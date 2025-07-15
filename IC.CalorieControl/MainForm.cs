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

		public MainForm(string userName)
		{
			InitializeComponent();
			_userName = userName;
			lblWelcome.Text = $"您好，{_userName}";
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
			btnNutrient.BackColor = Color.LightSkyBlue; // 鼠標移入時改變背景顏色
		}
		private void btnNutrient_MouseLeave(object sender, EventArgs e)
		{
			btnNutrient.BackColor = Color.DeepSkyBlue; // 鼠標移出時恢復背景顏色
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

		private void LoadUserProfileControl()
		{
			pnMainpanel.Controls.Clear(); // 清除舊的內容

			var profileControl = new UserProfileControl(userService, _userName);
			profileControl.Dock = DockStyle.Fill;

			pnMainpanel.Controls.Add(profileControl);
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			// 手動點擊返回登入
			this.Hide();
			LoginForm login = new LoginForm();
			login.FormClosed += (s, args) => this.Close();
			login.Show();
		}

		private void btnUserProfile_Click(object sender, EventArgs e)
		{
			LoadUserProfileControl();
		}
	}
	
}
