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
	public partial class DailySummaryControl : UserControl
	{
		public event Action OnViewTodayLogsRequested; // 用於檢視當日紀錄事件
		private readonly MealService _mealService;
		public DailySummaryControl()
		{
			InitializeComponent();
			_mealService = new MealService(
			new FoodRepository("Data Source=DESKTOP-PAKSETB\\SQLEXPRESS;Initial Catalog=CalorieControlSystem;Integrated Security=True"),
			new MealLogRepository("Data Source=DESKTOP-PAKSETB\\SQLEXPRESS;Initial Catalog=CalorieControlSystem;Integrated Security=True")
			);
			// 設定日期選擇器
			dtpSummaryDate.Format = DateTimePickerFormat.Custom;
			dtpSummaryDate.CustomFormat = "yyyy-MM-dd";
			// 預設選擇今天並載入統計
			dtpSummaryDate.Value = DateTime.Today;
			LoadSummaryForDate(DateTime.Today);
		}

		private void dtpSummaryDate_ValueChanged(object sender, EventArgs e)
		{
			LoadSummaryForDate(dtpSummaryDate.Value.Date);
		}
		public void LoadSummaryForDate(DateTime date)
		{
			// 加入 Debug 方便排查
			int uid = SessionManager.CurrentUserId;
			//MessageBox.Show($"[Debug] 讀取統計 → UserId={uid}, Date={date:yyyy-MM-dd}");

			var summary = _mealService.GetDailySummary(uid, date);
			lblTotalCalories.Text = summary.TotalCalories.ToString("F2");
			lblTotalCarbs.Text = summary.TotalCarbohydrates.ToString("F2");
			lblTotalProtein.Text = summary.TotalProtein.ToString("F2");
			lblTotalFat.Text = summary.TotalFat.ToString("F2");

			// 再加一個 Debug 確認值
			//Debug.WriteLine($"Summary: Cal={summary.TotalCalories}, Carb={summary.TotalCarbohydrates}, Protein={summary.TotalProtein}, Fat={summary.TotalFat}");
		}

		private void btnViewLogs_Click(object sender, EventArgs e)
		{
			// 通知 MainForm 顯示當日紀錄列表
			OnViewTodayLogsRequested?.Invoke();
		}
	}
}
