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
		public MainForm(string userName)
		{
			InitializeComponent();
			_userName = userName;
			lblWelcome.Text = $"您好，{_userName}";
		}

		private void label1_Click(object sender, EventArgs e)
		{
			
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			// 手動點擊返回登入
			this.Hide();
			LoginForm login = new LoginForm();
			login.FormClosed += (s, args) => this.Close();
			login.Show();
		}
	}
}
