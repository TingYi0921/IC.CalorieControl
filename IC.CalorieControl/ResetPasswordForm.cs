using IC.CalorieControl.BLL;
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
	public partial class ResetPasswordForm : Form
	{
		private readonly UserService _userService;
		public ResetPasswordForm(UserService userService)
		{
			InitializeComponent();
			_userService = userService;
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			string userName = txtUserName.Text.Trim();
			string newPwd = txtNewPassword.Text;
			string confirm = txtConfirmPassword.Text;

			if (string.IsNullOrEmpty(userName) ||
				string.IsNullOrEmpty(newPwd) ||
				newPwd != confirm)
			{
				MessageBox.Show("請確認帳號已填、密碼與確認密碼相同。", "格式錯誤",
								MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!_userService.ResetPassword(userName, newPwd, out string msg))
			{
				MessageBox.Show(msg, "重設失敗",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			MessageBox.Show("密碼已重設，請用新密碼登入。", "完成",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("確定要取消重設密碼嗎？", "確認",
								MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Hide();
				LoginForm login = new LoginForm();
				login.FormClosed += (s, args) => this.Close();
				login.Show();
			}
		}
	}
}
