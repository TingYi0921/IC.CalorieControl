using IC.CalorieControl.BLL;
using IC.CalorieControl.Classes;
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
	public partial class UserProfileControl : UserControl
	{
		private bool _isEditing = false;
		public UserProfileControl()
		{
			InitializeComponent();
			SetEditable(false);
		}
		private readonly UserService userService;
		private UserProfile currentUser;
		private UserProfile originalUser;
		private Dictionary<short, string> activityMap = new Dictionary<short, string>()
		{
			{ 1, "低強度" },
			{ 2, "正常強度" },
			{ 3, "中強度" },
			{ 4, "高強度" },
			{ 5, "超高強度" }
		};
		private void UserProfileControl_Load(object sender, EventArgs e)
		{
			string hashedPassword = userService.GetCurrentUserPassword(txtUserName.Text);

			txtPassword.Enabled = false;
			txtPassword.Text = hashedPassword;
			txtPassword.PasswordChar = '*'; // 使用密碼字符
		}
		private UserProfile CloneUser(UserProfile user)
		{
			return new UserProfile
			{
				UserId = user.UserId,
				UserName = user.UserName,
				PasswordHash = user.PasswordHash,
				Email = user.Email,
				Age = user.Age,
				Gender = user.Gender,
				HeightCm = user.HeightCm,
				WeightKg = user.WeightKg,
				ActivityLevel = user.ActivityLevel,
				CreatedAt = user.CreatedAt,
				UpdatedAt = user.UpdatedAt
			};
		}
		public UserProfileControl(UserService service, string userName)
		{
			InitializeComponent();
			userService = service;
			cmbActivityLevel.DataSource = new BindingSource(activityMap, null);
			cmbActivityLevel.DisplayMember = "Value";
			cmbActivityLevel.ValueMember = "Key";
			currentUser = userService.GetUserByUserName(userName);
			originalUser = userService.CloneUser(currentUser);
			LoadUserData();
			SetEditable(false);
		}

		private void LoadUserData()
		{
			if (currentUser == null) return;
			txtUserName.Text = currentUser.UserName;
			txtEmail.Text = currentUser.Email;
			txtPassword.Text = currentUser.PasswordHash;
			txtAge.Text = currentUser.Age.ToString();
			cmbGender.Text = currentUser.Gender;
			txtHeight.Text = currentUser.HeightCm.ToString();
			txtWeight.Text = currentUser.WeightKg.ToString();
			cmbActivityLevel.SelectedValue = currentUser.ActivityLevel;
		}

		private void SetEditable(bool editable)
		{
			txtUserName.Enabled = editable;
			txtEmail.Enabled = editable;
			txtPassword.Enabled = false;
			txtAge.Enabled = editable;
			txtHeight.Enabled = editable;
			txtWeight.Enabled = editable;
			cmbActivityLevel.Enabled = editable;
			// cmbGender 永遠停用
			cmbGender.Enabled = false;
			// 切換按鈕顯示狀態
			btnSave.Visible = editable;
			btnCancel.Visible = editable;
			btnEdit.Visible = !editable;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			_isEditing = true;
			SetEditable(true);

			// 你可以在這裡切換按鈕顯示／隱藏：
			btnEdit.Visible = false;
			btnSave.Visible = true;
			btnCancel.Visible = true;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			_isEditing = false;
			SetEditable(false);

			btnEdit.Visible = true;
			btnSave.Visible = false;
			btnCancel.Visible = false;
			currentUser.UserName = txtUserName.Text.Trim();
			//currentUser.PasswordHash = txtPassword.Text.Trim();
			currentUser.Email = txtEmail.Text.Trim();
			currentUser.Age = int.TryParse(txtAge.Text, out int age) ? age : 0;
			currentUser.Gender = cmbGender.Text.Trim();
			currentUser.HeightCm = decimal.TryParse(txtHeight.Text, out decimal h) ? h : 0;
			currentUser.WeightKg = decimal.TryParse(txtWeight.Text, out decimal w) ? w : 0;
			currentUser.ActivityLevel = short.TryParse(cmbActivityLevel.SelectedValue.ToString(), out short level) ? level : (short)0;
			currentUser.UpdatedAt = DateTime.UtcNow;

			if (userService.UpdateUserProfile(currentUser, out string msg))
			{
				MessageBox.Show(msg, "更新成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
				originalUser = CloneUser(currentUser); // 更新參考備份
				SetEditable(false); // 回復唯讀狀態
			}
			else
			{
				MessageBox.Show(msg, "更新失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			_isEditing = false;
			btnEdit.Visible = true;
			btnSave.Visible = false;
			btnCancel.Visible = false;

			currentUser = CloneUser(originalUser); // 還原備份資料
			LoadUserData(); // 將資料重新載入到表單
			SetEditable(false); // 回復唯讀狀態
		}
	}
}
