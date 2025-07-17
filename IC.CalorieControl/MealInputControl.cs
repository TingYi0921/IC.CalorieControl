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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IC.CalorieControl
{
	public partial class MealInputControl : UserControl
	{
		public event Action<DateTime> OnAddToLogCompleted;
		public event Action<DateTime> OnViewTodayLogsRequested; // 用於檢視當日紀錄事件

		private readonly MealService _mealService;
		private readonly int _currentUserId = SessionManager.CurrentUserId;

		public MealInputControl()
		{
			InitializeComponent();

			// 確保格式
			dtpInputLogDate.Format = DateTimePickerFormat.Custom;
			dtpInputLogDate.CustomFormat = "yyyy-MM-dd";
			dtpInputLogDate.Value = DateTime.Today;

			_mealService = new MealService
				(new FoodRepository("Data Source=DESKTOP-PAKSETB\\SQLEXPRESS;Initial Catalog=CalorieControlSystem;Integrated Security=True"), 
				new MealLogRepository("Data Source=DESKTOP-PAKSETB\\SQLEXPRESS;Initial Catalog=CalorieControlSystem;Integrated Security=True"));
			LoadFavoriteFoods();
		}

		private void LoadFavoriteFoods()
		{
			var allFoods = _mealService.GetUserFoodItems(_currentUserId);

			// 2. 依 Name 去重，只保留每個食物名稱的第一筆
			var uniqueFoods = allFoods
				.GroupBy(f => f.Name)
				.Select(g => g.First())
				.ToList();

			// 3. 加入一個「手動輸入」選項（Key = 0）
			var manual = new FoodItem { FoodId = 0, Name = "-- 手動輸入 --" };
			uniqueFoods.Insert(0, manual);

			// 4. 綁定 ComboBox
			cbFoodList.DataSource = null;
			cbFoodList.DisplayMember = "Name";
			cbFoodList.ValueMember = "FoodId";
			cbFoodList.DataSource = uniqueFoods;
		}
		private void cbFoodList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbFoodList.SelectedItem is FoodItem sel && sel.FoodId > 0)
			{
				// 選擇已儲存的食物，自動填入各欄位
				txtFoodName.Text = sel.Name;
				txtCalories.Text = sel.Calories.ToString("F2");
				txtWeight.Text = sel.WeightGrams.ToString("F2");
				txtCarbs.Text = sel.Carbohydrates.ToString("F2");
				txtProtein.Text = sel.Protein.ToString("F2");
				txtFat.Text = sel.Fat.ToString("F2");
				chkSaveAsFavorite.Checked = false;
			}
			else
			{
				// 手動輸入模式，清空欄位
				txtFoodName.Clear();
				txtCalories.Clear();
				txtWeight.Clear();
				txtCarbs.Clear();
				txtProtein.Clear();
				txtFat.Clear();
				chkSaveAsFavorite.Checked = true;
			}
		}

		private void btnAddToLog_Click(object sender, EventArgs e)
		{
			DateTime selectedDate = dtpInputLogDate.Value.Date;
			// 檢查必填
			if (string.IsNullOrWhiteSpace(txtFoodName.Text))
			{
				MessageBox.Show("請輸入食物名稱。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// 解析數值
			if (!decimal.TryParse(txtCalories.Text, out var cal) ||
				!decimal.TryParse(txtWeight.Text, out var weight) ||
				!decimal.TryParse(txtCarbs.Text, out var carbs) ||
				!decimal.TryParse(txtProtein.Text, out var protein) ||
				!decimal.TryParse(txtFat.Text, out var fat))
			{
				MessageBox.Show("請確認所有數值輸入正確。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// 建立 FoodItem
			var food = new FoodItem
			{
				Name = txtFoodName.Text.Trim(),
				Calories = cal,
				WeightGrams = weight,
				Carbohydrates = carbs,
				Protein = protein,
				Fat = fat,
				UserId = chkSaveAsFavorite.Checked ? (int?)_currentUserId : null,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			};

			// 儲存至 DB 並更新下拉清單
			if (_mealService.AddFoodItem(food, out string foodMsg))
			{
				if (chkSaveAsFavorite.Checked)
				{
					LoadFavoriteFoods(); // 重新載入
				}
				MessageBox.Show(foodMsg, "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show(foodMsg, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// 取得實際 FoodId
			var selectedItem = cbFoodList.SelectedItem as FoodItem;
			int foodId = selectedItem != null && selectedItem.FoodId > 0
				? selectedItem.FoodId
				: food.UserId == null ? food.FoodId : food.FoodId;

			// 建立並儲存餐點日誌
			var log = new MealLog
			{
				UserId = SessionManager.CurrentUserId,
				FoodId = food.FoodId,
				LogTime = selectedDate,
				Quantity = weight,
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now
			};
			//MessageBox.Show($"[Debug] 新增日誌時 UserId = {SessionManager.CurrentUserId}");

			if (_mealService.AddMealLog(log, out string logMsg))
				MessageBox.Show("餐點已加入 " + selectedDate.ToString("yyyy-MM-dd") + " 的日誌！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
				MessageBox.Show(logMsg, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);

			OnAddToLogCompleted?.Invoke(selectedDate);
		}
		private void btnViewLogs_Click(object sender, EventArgs e)
		{
			OnViewTodayLogsRequested?.Invoke(dtpInputLogDate.Value.Date);
		}
	}
}
