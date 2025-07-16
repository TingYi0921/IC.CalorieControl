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

			// 日期變更後重新載入
			dtpLogDate.Format = DateTimePickerFormat.Custom;
			dtpLogDate.CustomFormat = "yyyy-MM-dd";
			dtpLogDate.ValueChanged += (s, e) => LoadMealLogs(dtpLogDate.Value.Date);

			// 控制項載入時立即讀取今天的紀錄
			this.Load += MealListControl_Load;
		}
		private void MealListControl_Load(object sender, EventArgs e)
		{
			// 預設為今天
			dtpLogDate.Value = DateTime.Today;
			LoadMealLogs(DateTime.Today);
		}
		private void LoadMealLogs(DateTime date)
		{
			// 1. 先讀出所有符合條件的日誌
			var logs = _mealService.GetLogsByDate(SessionManager.CurrentUserId, date.Date);

			// 偵錯：印出筆數到輸出視窗
			Debug.WriteLine($"[MealListControl] LoadMealLogs -> userId={_currentUserId}, date={date:yyyy-MM-dd}, count={logs.Count}");

			// 2. 依照 foodId 計算營養並建匿名物件清單
			var data = logs.Select(log =>
			{
				var food = _mealService.GetFoodItemById(log.FoodId);
				decimal cal = 0, carb = 0, prot = 0, fat = 0;
				string name = "手動輸入";

				if (food != null && food.WeightGrams > 0)
				{
					name = food.Name;
					cal = food.Calories * log.Quantity / food.WeightGrams;
					carb = food.Carbohydrates * log.Quantity / food.WeightGrams;
					prot = food.Protein * log.Quantity / food.WeightGrams;
					fat = food.Fat * log.Quantity / food.WeightGrams;
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

			// 偵錯：看看匿名清單第一筆長什麼樣子
			if (data.Any())
				Debug.WriteLine($"[MealListControl] First item: {string.Join(", ", data.First().GetType().GetProperties().Select(p => p.Name + "=" + p.GetValue(data.First())))}");
			else
				Debug.WriteLine("[MealListControl] No data to bind");

			// 3. 清除任何既有綁定，並整列清除欄位（如果你之前手動加過欄位）
			dgvMealLog.DataSource = null;
			dgvMealLog.Columns.Clear();

			// 4. 交給 DataGridView 依匿名物件自動產生欄位
			dgvMealLog.AutoGenerateColumns = true;
			dgvMealLog.DataSource = data;

			// 5. 隱藏內部識別用的 LogId
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