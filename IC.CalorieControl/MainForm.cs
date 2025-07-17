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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IC.CalorieControl
{
	public partial class MainForm : Form
	{
		private string _userName;
		private readonly UserService _userService = new UserService(new UserDal());
		private MainForm _mainForm;
		private UserProfileControl _userProfileControl;
		private MealInputControl _mealInputControl;
		private MealListControl _mealListControl;
		private DailySummaryControl _dailySummaryControl;

		public MainForm(string userName)
		{
			InitializeComponent();
			pnMainpanel.Visible = true;

			_userName = userName;
			lblWelcome.Text = $"您好，{_userName}";

			_userProfileControl = new UserProfileControl(_userService, _userName);
			_userProfileControl.Dock = DockStyle.Fill;

			_mealInputControl = new MealInputControl();
			_mealInputControl.Dock = DockStyle.Fill;
			_mealInputControl.OnAddToLogCompleted += () => LoadMealListControl();
			_mealInputControl.OnViewTodayLogsRequested += () => LoadMealListControl();

			_mealListControl = new MealListControl();
			_mealListControl.Dock = DockStyle.Fill;

			_dailySummaryControl = new DailySummaryControl();
			_dailySummaryControl.Dock = DockStyle.Fill;
			_dailySummaryControl.OnViewTodayLogsRequested += () => LoadMealListControl();

			LoadMainForm();
		}

		private void btnUserProfile_MouseEnter(object sender, EventArgs e)
		{
			btnUserProfile.BackColor = Color.LightSkyBlue; // 鼠標移入時改變背景顏色
		}
		private void btnUserProfile_MouseLeave(object sender, EventArgs e)
		{
			btnUserProfile.BackColor = Color.DeepSkyBlue; // 鼠標移出時恢復背景顏色
		}
		private void btnMealLog_MouseEnter(object sender, EventArgs e)
		{
			btnMealLog.BackColor = Color.LightSkyBlue; // 鼠標移入時改變背景顏色
		}
		private void btnMealLog_MouseLeave(object sender, EventArgs e)
		{
			btnMealLog.BackColor = Color.DeepSkyBlue; // 鼠標移出時恢復背景顏色
		}
		private void btnNutrient_MouseEnter(object sender, EventArgs e)
		{
			btnDailyLog.BackColor = Color.LightSkyBlue; // 鼠標移入時改變背景顏色
		}
		private void btnNutrient_MouseLeave(object sender, EventArgs e)
		{
			btnDailyLog.BackColor = Color.DeepSkyBlue; // 鼠標移出時恢復背景顏色
		}
		private void btnActivity_MouseEnter(object sender, EventArgs e)
		{
			btnActivity.BackColor = Color.LightSkyBlue; // 鼠標移入時改變背景顏色
		}
		private void btnActivity_MouseLeave(object sender, EventArgs e)
		{
			btnActivity.BackColor = Color.DeepSkyBlue; // 鼠標移出時恢復背景顏色
		}
		private void btnLogout_MouseEnter(object sender, EventArgs e)
		{
			btnLogout.BackColor = Color.LightSkyBlue; // 鼠標移入時改變背景顏色
		}
		private void btnLogout_MouseLeave(object sender, EventArgs e)
		{
			btnLogout.BackColor = Color.DeepSkyBlue; // 鼠標移出時恢復背景顏色
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			// 手動點擊返回登入
			// 清空 SessionManager
			SessionManager.CurrentUserId = 0;
			SessionManager.CurrentUserName = null;
			this.Hide();
			LoginForm login = new LoginForm();
			login.FormClosed += (s, args) => this.Close();
			login.Show();
		}

		private void LoadMainForm()
		{
			pnMainpanel.Controls.Clear(); // 清除舊的內容
			pnMainpanel.Controls.Add(_mainForm);
		}

		private void LoadUserProfileControl()
		{
			pnMainpanel.Controls.Clear(); // 清除舊的內容
			pnMainpanel.Controls.Add(_userProfileControl);
		}

		private void LoadMealInputControl()
		{
			pnMainpanel.Controls.Clear();
			pnMainpanel.Controls.Add(_mealInputControl);
		}

		private void LoadMealListControl()
		{
			pnMainpanel.Controls.Clear();
			pnMainpanel.Controls.Add(_mealListControl);
		}

		private void LoadDailySummaryControl()
		{
			pnMainpanel.Controls.Clear();
			pnMainpanel.Controls.Add(_dailySummaryControl);
			_dailySummaryControl.LoadSummaryForDate(date: DateTime.Today);
		}
		// 在主畫面選單 ListItem 中設定事件：
		private void btnUserProfile_Click(object sender, EventArgs e)
		{
			LoadUserProfileControl();
		}
		private void btnMealLog_Click(object sender, EventArgs e)
		{
			LoadMealInputControl();
		}

		private void btnDailyLog_Click(object sender, EventArgs e)
		{
			LoadDailySummaryControl();
		}

		//private int GetCurrentUserId()
		//{
		//	return SessionManager.CurrentUserId;
		//}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			pnMainpanel.Controls.Clear();
			pnMainpanel.Visible = true;
			pnMainpanel.BringToFront();  // 確保 panel 在最上層
		}
	}

}
