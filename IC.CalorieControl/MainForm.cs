using IC.CalorieControl.BLL;
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
		private readonly UserService userService = new UserService(new UserDal());
		private MealInputControl mealInputControl;
		private MealListControl mealListControl;
		private DailySummaryControl dailySummaryControl;

		public MainForm(string userName)
		{
			InitializeComponent();
			_userName = userName;
			lblWelcome.Text = $"您好，{_userName}";
			mealInputControl = new MealInputControl();
			mealInputControl.Dock = DockStyle.Fill;
			mealInputControl.OnAddToLogCompleted += () => LoadMealListControl();

			mealListControl = new MealListControl();
			mealListControl.Dock = DockStyle.Fill;

			dailySummaryControl = new DailySummaryControl();
			dailySummaryControl.Dock = DockStyle.Fill;

			LoadMealInputControl();
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
			this.Hide();
			LoginForm login = new LoginForm();
			login.FormClosed += (s, args) => this.Close();
			login.Show();
		}
		private void LoadUserProfileControl()
		{
			pnMainpanel.Controls.Clear(); // 清除舊的內容

			var profileControl = new UserProfileControl(userService, _userName);
			profileControl.Dock = DockStyle.Fill;

			pnMainpanel.Controls.Add(profileControl);
		}

		private void LoadMealInputControl()
		{
			pnMainpanel.Controls.Clear();
			pnMainpanel.Controls.Add(mealInputControl);
		}

		private void LoadMealListControl()
		{
			pnMainpanel.Controls.Clear();
			pnMainpanel.Controls.Add(mealListControl);
		}

		private void LoadDailySummaryControl()
		{
			pnMainpanel.Controls.Clear();
			pnMainpanel.Controls.Add(dailySummaryControl);
			dailySummaryControl.LoadSummary(userId: GetCurrentUserId(), date: DateTime.Today);
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

		private int GetCurrentUserId()
		{
			// TODO: 實作取得目前登入的使用者 ID
			return 1;
		}
	}

}
