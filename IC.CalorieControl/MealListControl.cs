using IC.CalorieControl.BLL;
using IC.CalorieControl.Classes;
using IC.CalorieControl.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
		private readonly int _currentUserId = SessionManager.CurrentUserId;
		public MealListControl()
		{
			InitializeComponent();
			_mealService = new MealService(
			new FoodRepository("Data Source=DESKTOP-PAKSETB\\SQLEXPRESS;Initial Catalog=CalorieControlSystem;Integrated Security=True"),
			new MealLogRepository("Data Source=DESKTOP-PAKSETB\\SQLEXPRESS;Initial Catalog=CalorieControlSystem;Integrated Security=True")
			);
			LoadMealLogs(DateTime.Today);
		}

		private void LoadMealLogs(DateTime date)
		{
			var logs = _mealService.GetLogsByDate(_currentUserId, date);
			var data = new List<object>();
			foreach (var log in logs)
			{
				var food = _mealService.GetFoodItemById(log.FoodId);
				data.Add(new
				{
					log.LogId,
					Name = food?.Name ?? "",
					Calories = food != null ? (food.Calories * log.Quantity / food.WeightGrams).ToString("F2") : "0",
					Quantity = log.Quantity,
					Carbohydrates = food != null ? (food.Carbohydrates * log.Quantity / food.WeightGrams).ToString("F2") : "0",
					Protein = food != null ? (food.Protein * log.Quantity / food.WeightGrams).ToString("F2") : "0",
					Fat = food != null ? (food.Fat * log.Quantity / food.WeightGrams).ToString("F2") : "0",
					Time = log.LogTime.ToString("HH:mm")
				});
			}
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
