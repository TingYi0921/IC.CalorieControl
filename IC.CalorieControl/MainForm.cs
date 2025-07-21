using IC.CalorieControl.BLL;
using IC.CalorieControl.Classes;
using IC.CalorieControl.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace IC.CalorieControl
{
	public partial class MainForm : Form
	{
		private string _userName;
		private UserProfile _currentUser;
		private readonly UserService _userService = new UserService(new UserRepository());
		private readonly ActivityService _activityService;
		private readonly MealService _mealService;
		private MainForm _mainForm;
		private UserProfileControl _userProfileControl;
		private MealInputControl _mealInputControl;
		private MealListControl _mealListControl;
		private DailySummaryControl _dailySummaryControl;
		private MainPanelControl _mainPanelControl;
		private ActivityLogControl _activityLogControl;

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
			_mealService = new MealService(
				new FoodRepository("Data Source=DESKTOP-PAKSETB\\SQLEXPRESS;Initial Catalog=CalorieControlSystem;Integrated Security=True"),
				new MealLogRepository("Data Source=DESKTOP-PAKSETB\\SQLEXPRESS;Initial Catalog=CalorieControlSystem;Integrated Security=True")
			);

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

			_activityLogControl = new ActivityLogControl(_activityService, _currentUser);
			_activityLogControl.Dock = DockStyle.Fill;

			btnMealLog.Click += (s, e) => ShowControl(_mealInputControl);

			_mainPanelControl.OnDateChanged += date => UpdateNetCalories(date);
			_userProfileControl.OnDateChanged += date => UpdateNetCalories(date);
			_mealInputControl.OnDateChanged += date => UpdateNetCalories(date);
			_mealListControl.OnDateChanged += date => UpdateNetCalories(date);
			_dailySummaryControl.OnDateChanged += date => UpdateNetCalories(date);
			_activityLogControl.OnDateChanged += date => UpdateNetCalories(date);

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

		private void LoadMainPanelControl(DateTime date)
		{
			pnMainpanel.Controls.Clear(); // 清除舊的內容
			pnMainpanel.Controls.Add(_mainPanelControl);
			UpdateNetCalories(date);
		}

		private void LoadUserProfileControl(DateTime date)
		{
			pnMainpanel.Controls.Clear(); // 清除舊的內容
			_userProfileControl.OnProfileUpdated += updatedUser =>
			{
				_currentUser = updatedUser;
				// 如果 ActivityLogControl 正在顯示，就告訴它更新 UserProfile
				_activityLogControl?.UpdateUserProfile(updatedUser);
			};

			pnMainpanel.Controls.Add(_userProfileControl);
			UpdateNetCalories(date);
		}

		private void LoadMealInputControl(DateTime date)
		{
			pnMainpanel.Controls.Clear();
			pnMainpanel.Controls.Add(_mealInputControl);
			UpdateNetCalories(date);
		}

		private void LoadMealListControl(DateTime date)
		{
			pnMainpanel.Controls.Clear();
			pnMainpanel.Controls.Add(_mealListControl);
			_mealListControl.LoadMealLogs(date);
			UpdateNetCalories(date);
		}

		private void LoadDailySummaryControl(DateTime date)
		{
			pnMainpanel.Controls.Clear();
			pnMainpanel.Controls.Add(_dailySummaryControl);
			_dailySummaryControl.LoadSummaryForDate(date);
			UpdateNetCalories(date);
		}
		private void LoadActivityLogControl(DateTime date)
		{
			pnMainpanel.Controls.Clear();
			// 建立並傳入 ActivityService 與目前使用者資料
			//var activityCtrl = new ActivityLogControl(_activityService, _currentUser)
			//{
			//	Dock = DockStyle.Fill
			//};
			//pnMainpanel.Controls.Add(activityCtrl);
			pnMainpanel.Controls.Add(_activityLogControl);
			UpdateNetCalories(date);
		}

		// 在主畫面選單 ListItem 中設定事件：
		private void btnUserProfile_Click(object sender, EventArgs e)
		{
			LoadUserProfileControl(DateTime.Today);
		}
		private void btnMealLog_Click(object sender, EventArgs e)
		{
			LoadMealInputControl(DateTime.Today);
		}

		private void btnDailyLog_Click(object sender, EventArgs e)
		{
			LoadDailySummaryControl(DateTime.Today);
		}
		private void btnActivity_Click(object sender, EventArgs e)
		{
			LoadActivityLogControl(DateTime.Today);
		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			LoadMainPanelControl(DateTime.Today);
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
			LoadMainPanelControl(DateTime.Today);
			DateTime today = DateTime.Today;
			UpdateNetCalories(today);

			toolTip1.SetToolTip(lblNetCalories, @"淨熱量 = 今日總消耗 - 今日總攝取" + Environment.NewLine +
				"今日總消耗 = 基礎代謝率 (BMR) + 活動消耗" + Environment.NewLine +
				"今日總攝取 = 今日所有餐點的熱量總和");
		}
		private void UpdateNetCalories(DateTime date)
		{
			// 1. 取得當日總攝取熱量
			var summary = _mealService.GetDailySummary(_currentUser.UserId, date);
			double consumed = (double)summary.TotalCalories;

			// 2. 取得當日總消耗熱量 (BMR + 活動)
			double burned = _activityService.GetDailyTotalCaloriesBurned(_currentUser, date);

			// 3. 計算淨熱量並顯示
			double net = burned - consumed;
			lblNetCalories.Text = $"今日淨熱量：{net:F2} Kcal";
		}

	}

}
