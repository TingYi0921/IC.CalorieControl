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
		private readonly ActivityService _service;
		private readonly int _userId = SessionManager.CurrentUserId;
		private UserProfile _user;
		private readonly List<ActivityLevel> _levels;

		public ActivityLogControl(ActivityService service, UserProfile user)
		{
			InitializeComponent();
			if (service == null) throw new ArgumentNullException(nameof(service));
			if (user == null) throw new ArgumentNullException(nameof(user));

			_service = service;
			_user = user;

			_levels = _service.GetActivityLevels();

			// 設定日期與下拉
			dtpActivityDate.Format = DateTimePickerFormat.Custom;
			dtpActivityDate.CustomFormat = "yyyy-MM-dd";
			dtpActivityDate.Value = DateTime.Today;
			dtpActivityDate.ValueChanged += (s, e) => LoadActivityLogs(dtpActivityDate.Value.Date);

			cbActivityLevel.DataSource = _levels;
			cbActivityLevel.DisplayMember = "LevelName";
			cbActivityLevel.ValueMember = "ActivityLevelId";

			// 初始化圖表
			chartDailyBurn.Series.Clear();
			var series = new Series("Calories")
			{
				ChartType = SeriesChartType.Line,   // 折線圖
				XValueType = ChartValueType.String
			};
			chartDailyBurn.Series.Add(series);

			LoadActivityLogs(DateTime.Today);
		}

		private void btnAddActivity_Click(object sender, EventArgs e)
		{
			// 確認所有關鍵物件都不為 null
			if (_service == null) throw new InvalidOperationException("_activityService is null");
			if (cbActivityLevel == null) throw new InvalidOperationException("cbActivityLevel is null");
			if (nudDuration == null) throw new InvalidOperationException("nudDuration is null");
			if (dtpActivityDate == null) throw new InvalidOperationException("dtpActivityDate is null");

			// 確認 ValueMember / SelectedValue
			Debug.WriteLine($"[Debug] SelectedLevel = {cbActivityLevel.SelectedValue}");

			var log = new ActivityLog
			{
				UserId = _userId,
				ActivityLevelId = (int)cbActivityLevel.SelectedValue,
				DurationHours = nudDuration.Value,
				ActivityDate = dtpActivityDate.Value.Date,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			};
			if (_service.AddActivityLog(log, out string msg))
				MessageBox.Show(msg, "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show(msg, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			LoadActivityLogs(dtpActivityDate.Value.Date);
		}
		private void LoadActivityLogs(DateTime date)
		{
			// 1. 讀取該日活動明細到 DataGridView
			var logs = _service.GetActivityLogs(_user.UserId, date);
			dgvActivityLogs.DataSource = logs
				.Select(l => new
				{
					l.ActivityLogId,
					Level = levelsLookup(l.ActivityLevelId),
					Duration = l.DurationHours,
					Burned = l.CaloriesBurned
				}).ToList();

			// 2. 同步更新日期選擇器
			dtpActivityDate.ValueChanged -= DtpActivityDate_ValueChanged;
			dtpActivityDate.Value = date.Date;
			dtpActivityDate.ValueChanged += DtpActivityDate_ValueChanged;

			// 3. 一週資料：當天往前推 6 天到當天，共 7 天
			var series = chartDailyBurn.Series["Calories"];
			series.Points.Clear();
			DateTime start = date.Date.AddDays(-6);
			for (int i = 0; i < 7; i++)
			{
				var d = start.AddDays(i);
				double dailyBurn = _service.GetDailyTotalCaloriesBurned(_user, d);
				// X 軸顯示「月-日」，Y 軸顯示當日總消耗
				series.Points.AddXY(d.ToString("MM-dd"), dailyBurn);
			}
		}
		// 輔助：根據 ID 找 LevelName（可改成直接 join 顯示）
		private string levelsLookup(int id)
		{
			var level = _levels.FirstOrDefault(l => l.ActivityLevelId == id);
			return level?.LevelName ?? "未知";
		}

		// 為 LoadActivityLogs 的事件訂閱執行點
		private void DtpActivityDate_ValueChanged(object sender, EventArgs e)
		{
			LoadActivityLogs(dtpActivityDate.Value.Date);
		}
	}
}
