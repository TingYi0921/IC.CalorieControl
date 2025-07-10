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
	public partial class RegisterForm : Form
	{
		private readonly UserService userService = new UserService(new UserDal());
		public RegisterForm()
		{
			InitializeComponent();
		}

		private void RegisterForm_Load(object sender, EventArgs e)
		{
			// 指定顯示的活動等級選項為3
			cmbActivityLevel.Text = "3";
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
		private void btnRegister_Click(object sender, EventArgs e)
		{
			try
			{
				var user = new UserProfile
				{
					UserName = txtUserName.Text.Trim(),
					Email = txtEmail.Text.Trim(),
					PasswordHash = txtPassword.Text.Trim(),
					CreatedAt = DateTime.UtcNow,
					UpdatedAt = DateTime.UtcNow
				};

				// 僅將文字轉換為資料型別，不執行邏輯驗證
				int.TryParse(txtAge.Text, out int age);
				decimal.TryParse(txtHeight.Text, out decimal heightCm);
				decimal.TryParse(txtWeight.Text, out decimal weightKg);

				user.Age = age;
				user.HeightCm = heightCm;
				user.WeightKg = weightKg;
				user.Gender = cmbGender.Text;
				user.ActivityLevel = Convert.ToInt16(cmbActivityLevel.SelectedItem);

				if (userService.Register(user, out string msg))
				{
					MessageBox.Show(msg, "註冊成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Hide();
					LoginForm login = new LoginForm();
					login.FormClosed += (s, args) => this.Close();
					login.Show();
				}
				else
				{
					MessageBox.Show(msg, "註冊失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"發生錯誤：{ex.Message}", "註冊錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnBackToLogin_Click(object sender, EventArgs e)
		{
			// 手動點擊返回登入
			this.Hide();
			LoginForm login = new LoginForm();
			login.FormClosed += (s, args) => this.Close();
			login.Show();
		}
	}
}
