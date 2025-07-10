using IC.CalorieControl.BLL;
using IC.CalorieControl.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IC.CalorieControl
{
	public partial class LoginForm : Form
	{
		private readonly UserService userService = new UserService(new UserDal());
		public LoginForm()
		{
			InitializeComponent();
		}
		private void LoginForm_Load(object sender, EventArgs e)
		{
			txtUserName.Text = "請輸入帳號(最長12字元)";
			txtPassword.Text = "請輸入密碼(最長16字元)";
			txtPassword.UseSystemPasswordChar = false;
		}

		private void txtUserName_Enter(object sender, EventArgs e)
		{
			// 這裡可以添加用戶名輸入的相關邏輯
			if (txtUserName.Text.Trim() == "請輸入帳號(最長12字元)")
			{
				txtUserName.Text = "";
			}
		}
		private void txtUserName_Leave(object sender, EventArgs e)
		{
			// 這裡可以添加用戶名輸入的相關邏輯
			if (string.IsNullOrWhiteSpace(txtUserName.Text))
			{
				txtUserName.Text = "請輸入帳號(最長12字元)";
			}
		}
		private void txtPassword_Enter(object sender, EventArgs e)
		{
			// 這裡可以添加密碼輸入的相關邏輯
			if (txtPassword.Text.Trim() == "請輸入密碼(最長16字元)")
			{
				txtPassword.Text = "";
				txtPassword.PasswordChar = '*'; // 使用密碼字符
			}
		}
		private void txtPassword_Leave(object sender, EventArgs e)
		{
			// 這裡可以添加密碼輸入的相關邏輯
			if (string.IsNullOrWhiteSpace(txtPassword.Text))
			{
				txtPassword.Text = "請輸入密碼(最長16字元)";
				txtPassword.PasswordChar = '\0'; // 不使用密碼字符
			}
		}
		private void btnLogin_Click(object sender, EventArgs e)
		{
			try
			{
				string userName = txtUserName.Text.Trim();
				string password = txtPassword.Text.Trim();

				var user = userService.Login(userName, password);

				if (user != null)
				{
					// 登入成功後紀錄登入紀錄
					string ip = GetLocalIPAddress();
					userService.RecordLogin(user.UserId, ip);

					// 跳轉到主畫面
					this.Hide();
					MainForm main = new MainForm(user.UserName);
					main.FormClosed += (s, args) => this.Close();
					main.Show();
				}
				else
				{
					MessageBox.Show("帳號或密碼錯誤，或格式不正確。\n請僅使用英文字母與數字。", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"發生錯誤：{ex.Message}", "登入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private string GetLocalIPAddress()
		{
			string localIP = "127.0.0.1";
			try
			{
				var host = Dns.GetHostEntry(Dns.GetHostName());
				foreach (var ip in host.AddressList)
				{
					if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
					{
						localIP = ip.ToString();
						break;
					}
				}
			}
			catch { }
			return localIP;
		}

		private void btnNewuser_Click(object sender, EventArgs e)
		{
			// 手動點擊開始註冊
			this.Hide();
			RegisterForm Register = new RegisterForm();
			Register.FormClosed += (s, args) => this.Close();
			Register.Show();
		}
	}
}
