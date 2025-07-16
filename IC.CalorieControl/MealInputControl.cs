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
	public partial class MealInputControl : UserControl
	{
		public event Action OnAddToLogCompleted;
		private readonly MealService _mealService;
		private readonly int _currentUserId = SessionManager.CurrentUserId;
		public MealInputControl()
		{
			InitializeComponent();
			_mealService = new MealService
				(new FoodRepository("Data Source=DESKTOP-PAKSETB\\SQLEXPRESS;Initial Catalog=CalorieControlSystem;Integrated Security=True"), 
				new MealLogRepository("Data Source=DESKTOP-PAKSETB\\SQLEXPRESS;Initial Catalog=CalorieControlSystem;Integrated Security=True"));
		}

		private void btnAddToLog_Click(object sender, EventArgs e)
		{
			string name = txtFoodName.Text.Trim();
			if (!decimal.TryParse(txtCalories.Text, out var cal) ||
				!decimal.TryParse(txtWeight.Text, out var weight) ||
				!decimal.TryParse(txtCarbs.Text, out var carbs) ||
				!decimal.TryParse(txtProtein.Text, out var protein) ||
				!decimal.TryParse(txtFat.Text, out var fat))
			{
				MessageBox.Show("請確認所有數值輸入正確。");
				return;
			}

			// 建立 FoodItem 並新增（如有勾選儲存）
			var food = new FoodItem
			{
				Name = name,
				Calories = cal,
				WeightGrams = weight,
				Carbohydrates = carbs,
				Protein = protein,
				Fat = fat,
				UserId = chkSaveAsFavorite.Checked ? (int?)_currentUserId : null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			};

			if (chkSaveAsFavorite.Checked)
			{
				if (_mealService.AddFoodItem(food, out string msg))
					MessageBox.Show(msg, "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
				else
					MessageBox.Show(msg, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				// 若非儲存食物，自行先加入暫存使用
				food.FoodId = -1; // 假設值
			}

			// 建立 MealLog 紀錄
			var log = new MealLog
			{
				UserId = _currentUserId,
				FoodId = food.FoodId,
				LogTime = DateTime.Now,
				Quantity = food.WeightGrams,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			};

			if (_mealService.AddMealLog(log, out string logMsg))
				MessageBox.Show(logMsg, "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show(logMsg, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
			OnAddToLogCompleted?.Invoke(); // 通知MainForm切換畫面
		}
	}
}
