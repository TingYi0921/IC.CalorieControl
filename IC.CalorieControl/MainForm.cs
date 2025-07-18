﻿using IC.CalorieControl.BLL;
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
		private UserProfile _currentUser;
		private readonly UserService _userService = new UserService(new UserRepository());
		private readonly ActivityService _activityService;
		private MainForm _mainForm;
		private UserProfileControl _userProfileControl;
		private MealInputControl _mealInputControl;
		private MealListControl _mealListControl;
		private DailySummaryControl _dailySummaryControl;
		private MainPanelControl _mainPanelControl;
		//private ActivityLogControl _activityLogControl;

		public MainForm(string userName)
		{
			InitializeComponent();
			pnMainpanel.Visible = true;

			System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
			timer.Interval = 1000; // 1秒
			timer.Tick += Timer_Tick;
			timer.Start();

			_userName = userName;
			lblWelcome.Text = $"您好，{_userName}";

			_currentUser = _userService.GetUserByUserName(userName);

			_activityService = new ActivityService(
		new ActivityRepository("Data Source=DESKTOP-PAKSETB\\SQLEXPRESS;Initial Catalog=CalorieControlSystem;Integrated Security=True")
			   );

			_mainPanelControl = new MainPanelControl();
			_mainPanelControl.Dock = DockStyle.Fill;

			_userProfileControl = new UserProfileControl(_userService, _userName);
			_userProfileControl.Dock = DockStyle.Fill;

			_mealInputControl = new MealInputControl();
			_mealInputControl.Dock = DockStyle.Fill;
			_mealInputControl.OnAddToLogCompleted += date => LoadMealListControl(date);
			_mealInputControl.OnViewTodayLogsRequested += date => LoadMealListControl(date);

			_mealListControl = new MealListControl();
			_mealListControl.Dock = DockStyle.Fill;

			_dailySummaryControl = new DailySummaryControl();
			_dailySummaryControl.Dock = DockStyle.Fill;
			_dailySummaryControl.OnViewTodayLogsRequested += date => LoadMealListControl(date);

			//_activityLogControl = new ActivityLogControl();
			//_activityLogControl.Dock = DockStyle.Fill;

			btnMealLog.Click += (s, e) => ShowControl(_mealInputControl);
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

		private void LoadMainPanelControl()
		{
			pnMainpanel.Controls.Clear(); // 清除舊的內容
			pnMainpanel.Controls.Add(_mainPanelControl);
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

		private void LoadMealListControl(DateTime date)
		{
			pnMainpanel.Controls.Clear();
			pnMainpanel.Controls.Add(_mealListControl);
			_mealListControl.LoadMealLogs(date);
		}

		private void LoadDailySummaryControl(DateTime date)
		{
			pnMainpanel.Controls.Clear();
			pnMainpanel.Controls.Add(_dailySummaryControl);
			_dailySummaryControl.LoadSummaryForDate(date);
		}
		private void LoadActivityLogControl()
		{
			pnMainpanel.Controls.Clear();
			// 建立並傳入 ActivityService 與目前使用者資料
			var activityCtrl = new ActivityLogControl(_activityService, _currentUser)
			{
				Dock = DockStyle.Fill
			};

			pnMainpanel.Controls.Add(activityCtrl);
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
			LoadDailySummaryControl(DateTime.Today);
		}
		private void btnActivity_Click(object sender, EventArgs e)
		{
			LoadActivityLogControl();
		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			LoadMainPanelControl();
		}

		private void ShowControl(UserControl ctrl)
		{
			pnMainpanel.Controls.Clear();
			ctrl.Dock = DockStyle.Fill;
			pnMainpanel.Controls.Add(ctrl);
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			// 格式化日期和時間，例如: "yyyy-MM-dd HH:mm:ss"
			lblTimer.Text = now.ToString("yyyy-MM-dd HH:mm:ss");
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			LoadMainPanelControl();
		}


	}

}
