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
		private readonly MealService mealService;
		private readonly int currentUserId = 1; // TODO: 從 Session 取得目前使用者 ID
		public MealInputControl()
		{
			InitializeComponent();
			mealService = new MealService(new FoodRepository("your-connection-string"), new MealLogRepository("your-connection-string"));
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
				UserId = chkSaveAsFavorite.Checked ? currentUserId : null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			};

			if (chkSaveAsFavorite.Checked)
			{
				mealService.AddFoodItem(food);
			}
			else
			{
				// 若非儲存食物，自行先加入暫存使用
				food.FoodId = -1; // 假設值
			}

			// 建立 MealLog 紀錄
			var log = new MealLog
			{
				UserId = currentUserId,
				FoodId = food.FoodId,
				LogTime = DateTime.Now,
				Quantity = food.WeightGrams,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			};

			mealService.AddMealLog(log);
			MessageBox.Show("紀錄成功！");
			OnAddToLogCompleted?.Invoke(); // 通知MainForm切換畫面
		}
	}
}
