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

namespace IC.CalorieControl
{
	public partial class MealListControl : UserControl
	{
		public DateTime SelectedDate => dtpLogDate.Value.Date;
		public event Action<DateTime> OnDateChanged; // 用於日期變更事件
		private readonly MealService _mealService;
		private readonly int _currentUserId;
		public MealListControl()
		{
			InitializeComponent();

			_currentUserId = SessionManager.CurrentUserId;
			_mealService = new MealService(
			new FoodRepository("Data Source=DESKTOP-PAKSETB\\SQLEXPRESS;Initial Catalog=CalorieControlSystem;Integrated Security=True"),
			new MealLogRepository("Data Source=DESKTOP-PAKSETB\\SQLEXPRESS;Initial Catalog=CalorieControlSystem;Integrated Security=True")
			);

			// 控制項載入時立即讀取今天的紀錄
			this.Load += MealListControl_Load;

			// 日期變更後重新載入
			dtpLogDate.Format = DateTimePickerFormat.Custom;
			dtpLogDate.CustomFormat = "yyyy-MM-dd";
			dtpLogDate.ValueChanged += (s, e) => LoadMealLogs(dtpLogDate.Value.Date);
			//dgvMealLog.DataSource = FoodRepository.GetUserFoodItems(_currentUserId);
		}
		private void MealListControl_Load(object sender, EventArgs e)
		{
			// 預設為今天
			dtpLogDate.Value = DateTime.Today;
			LoadMealLogs(DateTime.Today);
		}
		public void LoadMealLogs(DateTime date)
		{
			// 先解除 ValueChanged 事件，避免下面設定 Value 觸發重入
			dtpLogDate.ValueChanged -= dtpLogDate_ValueChanged;

			// 1. 同步更新日期選擇器
			dtpLogDate.Value = date.Date;

			// 重新綁回事件
			dtpLogDate.ValueChanged += dtpLogDate_ValueChanged;

			// 1. 先讀出所有符合條件的日誌
			var logs = _mealService.GetLogsByDate(SessionManager.CurrentUserId, date.Date);

			// 偵錯：印出筆數到輸出視窗
			Debug.WriteLine($"[MealListControl] LoadMealLogs -> userId={_currentUserId}, date={date:yyyy-MM-dd}, count={logs.Count}");

			// 2. 依照 foodId 計算營養並建匿名物件清單
			var data = logs.Select(log =>
			{
				decimal cal, carb, prot, fat;
				string name;

				if (log.FoodId > 0)
				{
					// 常用食物，依比例計算
					var food = _mealService.GetFoodItemById(log.FoodId);
					if (food != null && food.WeightGrams > 0)
					{
						name = food.Name;
						cal = food.Calories * log.Quantity / food.WeightGrams;
						carb = food.Carbohydrates * log.Quantity / food.WeightGrams;
						prot = food.Protein * log.Quantity / food.WeightGrams;
						fat = food.Fat * log.Quantity / food.WeightGrams;
					}
					else
					{
						// 萬一撈不到 FoodItem
						name = "未知食物";
						cal = carb = prot = fat = 0m;
					}
				}
				else
				{
					// 手動輸入，直接讀 MealLog 裡的欄位
					name = log.FoodName ?? "--手動輸入--";
					cal = log.FoodCalories ?? 0m;
					carb = log.FoodCarbs ?? 0m;
					prot = log.FoodProtein ?? 0m;
					fat = log.FoodFat ?? 0m;
				}

				return new
				{
					log.LogId,
					Name = name,
					Calories = cal.ToString("F2"),
					Quantity = log.Quantity,
					Carbohydrates = carb.ToString("F2"),
					Protein = prot.ToString("F2"),
					Fat = fat.ToString("F2"),
					Time = log.LogTime.ToString("HH:mm")
				};
			}).ToList();

			// 綁定 DataGridView
			dgvMealLog.DataSource = null;
			dgvMealLog.Columns.Clear();
			dgvMealLog.AutoGenerateColumns = true;
			dgvMealLog.DataSource = data;
			if (dgvMealLog.Columns.Contains("LogId"))
				dgvMealLog.Columns["LogId"].Visible = false;
		}

		private void dtpLogDate_ValueChanged(object sender, EventArgs e)
		{
			LoadMealLogs(dtpLogDate.Value.Date);
		}
		private void btnDeleteLog_Click(object sender, EventArgs e)
		{
			if (dgvMealLog.CurrentRow == null) return;
			int rowIndex = dgvMealLog.CurrentRow.Index;
			int logId = Convert.ToInt32(dgvMealLog.Rows[rowIndex].Cells[0].Value); // 第一欄為 LogId
			if (_mealService.DeleteMealLog(logId, out string msg))
				MessageBox.Show(msg, "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show(msg, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
			LoadMealLogs(dtpLogDate.Value.Date);
		}
	}
}