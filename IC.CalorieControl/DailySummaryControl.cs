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
	public partial class DailySummaryControl : UserControl
	{
		private readonly MealService _mealService;
		private readonly int _currentUserId = SessionManager.CurrentUserId;
		public DailySummaryControl()
		{
			InitializeComponent();
			_mealService = new MealService(
			new FoodRepository("Data Source=DESKTOP-PAKSETB\\SQLEXPRESS;Initial Catalog=CalorieControlSystem;Integrated Security=True"),
			new MealLogRepository("Data Source=DESKTOP-PAKSETB\\SQLEXPRESS;Initial Catalog=CalorieControlSystem;Integrated Security=True")
			);
		}
		public void LoadSummary(int userId, DateTime date)
		{
			var summary = _mealService.GetDailySummary(userId, date);
			lblTotalCalories.Text = summary.TotalCalories.ToString("F2");
			lblTotalCarbs.Text = summary.TotalCarbohydrates.ToString("F2");
			lblTotalProtein.Text = summary.TotalProtein.ToString("F2");
			lblTotalFat.Text = summary.TotalFat.ToString("F2");
		}
	}
}
