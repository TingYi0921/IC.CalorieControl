using IC.CalorieControl.BLL;
using IC.CalorieControl.Classes;
using IC.CalorieControl.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IC.CalorieControl
{
	public partial class ActivityLogControl : UserControl
	{
		public DateTime SelectedDate => dtpActivityDate.Value.Date;
		public event Action<DateTime> OnDateChanged; // 用於日期變更事件
		private readonly ActivityService _activityService;
		private readonly int _userId = SessionManager.CurrentUserId;
		private UserProfile _user;
		private readonly List<ActivityLevel> _levels;

		public ActivityLogControl(ActivityService service, UserProfile user)
		{
			InitializeComponent();
			if (service == null) throw new ArgumentNullException(nameof(service));
			if (user == null) throw new ArgumentNullException(nameof(user));

			_activityService = service;
			_user = user;

			_levels = _activityService.GetActivityLevels();

			// 設定日期與下拉
			dtpActivityDate.Format = DateTimePickerFormat.Custom;
			dtpActivityDate.CustomFormat = "yyyy-MM-dd";
			dtpActivityDate.Value = DateTime.Today;
			dtpActivityDate.ValueChanged += (s, e) => LoadActivityLogs(dtpActivityDate.Value.Date);

			cbActivityLevel.DataSource = _levels;
			cbActivityLevel.DisplayMember = "LevelName";
			cbActivityLevel.ValueMember = "ActivityLevelId";

			LoadActivityLogs(DateTime.Today);

			// 初始化圖表
			chartDailyBurn.Series.Clear();
			var series = new Series("Calories")
			{
				ChartType = SeriesChartType.Line,   // 折線圖
				XValueType = ChartValueType.String,
				Color = Color.Blue,  // 線條顏色
				BorderWidth = 3, // 線條寬度
				MarkerStyle = MarkerStyle.Circle,
				MarkerSize = 8,                 // 標記大小
				MarkerColor = Color.DarkBlue,       // 標記顏色
				IsValueShownAsLabel = true,                  // 顯示數值
				LabelForeColor = Color.Red,        // 數值文字顏色
				Font = new Font("Segoe UI", 9)
			};
			chartDailyBurn.Series.Add(series);

			//chartDailyBurn.Legends.Clear();
			//var legend = new Legend("Activity")
			//{
			//	Docking = Docking.Top,            // 放頂端
			//	Alignment = StringAlignment.Near,   // 靠左
			//	LegendStyle = LegendStyle.Row,
			//	BackColor = Color.Transparent,
			//	Font = new Font("Segoe UI", 9)
			//};
			//chartDailyBurn.Legends.Add(legend);
		}
		public void UpdateUserProfile(UserProfile updatedUser)
		{
			if (updatedUser == null) throw new ArgumentNullException(nameof(updatedUser));
			_user = updatedUser;                    // 更新內部的 UserProfile
													// 重新計算並刷新當前選擇日期的所有顯示
			LoadActivityLogs(dtpActivityDate.Value.Date);
		}

		private void btnAddActivity_Click(object sender, EventArgs e)
		{
			// 確認所有關鍵物件都不為 null
			if (_activityService == null) throw new InvalidOperationException("_activityService is null");
			if (cbActivityLevel == null) throw new InvalidOperationException("cbActivityLevel is null");
			if (nudDuration == null) throw new InvalidOperationException("nudDuration is null");
			if (dtpActivityDate == null) throw new InvalidOperationException("dtpActivityDate is null");

			// 確認 ValueMember / SelectedValue
			Debug.WriteLine($"[Debug] SelectedLevel = {cbActivityLevel.SelectedValue}");

			var log = new ActivityLog
			{
				UserId = SessionManager.CurrentUserId,
				ActivityLevelId = (int)cbActivityLevel.SelectedValue,
				DurationHours = nudDuration.Value,
				ActivityDate = dtpActivityDate.Value.Date,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			};
			if (_activityService.AddActivityLog(log, out string msg))
				MessageBox.Show(msg, "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show(msg, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			LoadActivityLogs(dtpActivityDate.Value.Date);
		}
		public void LoadActivityLogs(DateTime date)
		{
			// 1. 同步更新日期選擇器
			dtpActivityDate.ValueChanged -= DtpActivityDate_ValueChanged;
			dtpActivityDate.Value = date.Date;
			dtpActivityDate.ValueChanged += DtpActivityDate_ValueChanged;

			// 2. 讀取該日活動明細到 DataGridView
			var logs = _activityService.GetActivityLogs(_user.UserId, date);
			dgvActivityLogs.DataSource = logs
				.Select(l => new
				{
					運動等級 = levelsLookup(l.ActivityLevelId),
					運動時長 = l.DurationHours,
					消耗熱量 = l.CaloriesBurned,
					l.ActivityLogId
				}).ToList();

			// 3. 一週資料：當天往前推 6 天到當天，共 7 天
			var series = chartDailyBurn.Series["Calories"];
			series.Points.Clear();
			DateTime start = date.Date.AddDays(-6);
			for (int i = 0; i < 7; i++)
			{
				var d = start.AddDays(i);
				double dailyBurn = _activityService.GetDailyTotalCaloriesBurned(_user, d);
				// X 軸顯示「月-日」，Y 軸顯示當日總消耗
				series.Points.AddXY(d.ToString("MM-dd"), dailyBurn);
			}
			UpdateSummaryLabels(date);
		}
		// 輔助：根據 ID 找 LevelName（可改成直接 join 顯示）
		private string levelsLookup(int id)
		{
			var level = _levels.FirstOrDefault(l => l.ActivityLevelId == id);
			return level?.LevelName ?? "未知";
		}
		private void UpdateSummaryLabels(DateTime date)
		{
			lblBMR.Text = $"{_activityService.CalculateBMR(_user):F2} Kcal";
			lblCalorieBurn.Text = $"{_activityService.GetDailyTotalCaloriesBurned(_user, date):F2} Kcal";
		}

		// 為 LoadActivityLogs 的事件訂閱執行點
		private void DtpActivityDate_ValueChanged(object sender, EventArgs e)
		{
			LoadActivityLogs(dtpActivityDate.Value.Date);
		}

		private void ActivityLogControl_Load(object sender, EventArgs e)
		{
			toolTip1.SetToolTip(label3, @"運動消耗(hr/Kcal)：
低強度：220 Kcal
正常強度：300 Kcal
中強度：400 Kcal
高強度：500 Kcal
超高強度：600 Kcal");

			toolTip1.SetToolTip(cbActivityLevel, @"運動消耗(hr/Kcal)：
低強度：220 Kcal
正常強度：300 Kcal
中強度：400 Kcal
高強度：500 Kcal
超高強度：600 Kcal");

			toolTip1.SetToolTip(label6, @"基礎代謝率計算公式：
男性:(10*體重)+(6.25*身高)-(5*年齡)+5
女性:(10*體重)+(6.25*身高)-(5*年齡)-161");
			toolTip1.SetToolTip(label5, @"當日總消耗計算公式：基礎代謝率(BMR) + 活動消耗");
		}

		private void btnDeleteActivity_Click(object sender, EventArgs e)
		{
			if (dgvActivityLogs.SelectedRows.Count == 0)
			{
				MessageBox.Show("請先從列表中選擇要刪除的紀錄。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// 取得被選中的 ActivityLogId
			var row = dgvActivityLogs.SelectedRows[0];
			int logId = (int)row.Cells["ActivityLogId"].Value;

			// 呼叫 Service 刪除
			if (_activityService.DeleteActivityLog(logId, out string msg))
			{
				MessageBox.Show(msg, "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show(msg, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			// 刪除後重新載入該日期的列表、圖表與摘要
			LoadActivityLogs(dtpActivityDate.Value.Date);
		}
	}
}
