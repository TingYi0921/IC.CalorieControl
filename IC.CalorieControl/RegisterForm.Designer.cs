namespace IC.CalorieControl
{
	partial class RegisterForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblUserName = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblAge = new System.Windows.Forms.Label();
			this.lblGender = new System.Windows.Forms.Label();
			this.lblHeight = new System.Windows.Forms.Label();
			this.lblWeight = new System.Windows.Forms.Label();
			this.lblActivityLevel = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtAge = new System.Windows.Forms.TextBox();
			this.txtHeight = new System.Windows.Forms.TextBox();
			this.txtWeight = new System.Windows.Forms.TextBox();
			this.cmbGender = new System.Windows.Forms.ComboBox();
			this.cmbActivityLevel = new System.Windows.Forms.ComboBox();
			this.btnBackToLogin = new System.Windows.Forms.Button();
			this.btnRegister = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.BackColor = System.Drawing.Color.Yellow;
			this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblTitle.ForeColor = System.Drawing.SystemColors.Desktop;
			this.lblTitle.Location = new System.Drawing.Point(12, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(124, 24);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "會員基本資料";
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.BackColor = System.Drawing.Color.Transparent;
			this.lblUserName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblUserName.Location = new System.Drawing.Point(40, 59);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(90, 21);
			this.lblUserName.TabIndex = 1;
			this.lblUserName.Text = "使用者名稱";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.BackColor = System.Drawing.Color.Transparent;
			this.lblEmail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblEmail.Location = new System.Drawing.Point(40, 101);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(74, 21);
			this.lblEmail.TabIndex = 2;
			this.lblEmail.Text = "電子郵件";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.BackColor = System.Drawing.Color.Transparent;
			this.lblPassword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblPassword.Location = new System.Drawing.Point(40, 143);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(42, 21);
			this.lblPassword.TabIndex = 3;
			this.lblPassword.Text = "密碼";
			// 
			// lblAge
			// 
			this.lblAge.AutoSize = true;
			this.lblAge.BackColor = System.Drawing.Color.Transparent;
			this.lblAge.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblAge.Location = new System.Drawing.Point(40, 185);
			this.lblAge.Name = "lblAge";
			this.lblAge.Size = new System.Drawing.Size(42, 21);
			this.lblAge.TabIndex = 4;
			this.lblAge.Text = "年齡";
			// 
			// lblGender
			// 
			this.lblGender.AutoSize = true;
			this.lblGender.BackColor = System.Drawing.Color.Transparent;
			this.lblGender.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblGender.Location = new System.Drawing.Point(40, 227);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(42, 21);
			this.lblGender.TabIndex = 5;
			this.lblGender.Text = "性別";
			// 
			// lblHeight
			// 
			this.lblHeight.AutoSize = true;
			this.lblHeight.BackColor = System.Drawing.Color.Transparent;
			this.lblHeight.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblHeight.Location = new System.Drawing.Point(40, 269);
			this.lblHeight.Name = "lblHeight";
			this.lblHeight.Size = new System.Drawing.Size(97, 21);
			this.lblHeight.TabIndex = 6;
			this.lblHeight.Text = "身高（cm）";
			// 
			// lblWeight
			// 
			this.lblWeight.AutoSize = true;
			this.lblWeight.BackColor = System.Drawing.Color.Transparent;
			this.lblWeight.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblWeight.Location = new System.Drawing.Point(40, 311);
			this.lblWeight.Name = "lblWeight";
			this.lblWeight.Size = new System.Drawing.Size(93, 21);
			this.lblWeight.TabIndex = 7;
			this.lblWeight.Text = "體重（kg）";
			// 
			// lblActivityLevel
			// 
			this.lblActivityLevel.AutoSize = true;
			this.lblActivityLevel.BackColor = System.Drawing.Color.Transparent;
			this.lblActivityLevel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblActivityLevel.Location = new System.Drawing.Point(40, 353);
			this.lblActivityLevel.Name = "lblActivityLevel";
			this.lblActivityLevel.Size = new System.Drawing.Size(74, 21);
			this.lblActivityLevel.TabIndex = 8;
			this.lblActivityLevel.Text = "活動等級";
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtUserName.Location = new System.Drawing.Point(133, 53);
			this.txtUserName.MaxLength = 12;
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(182, 27);
			this.txtUserName.TabIndex = 9;
			this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
			this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtEmail.Location = new System.Drawing.Point(133, 95);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(182, 27);
			this.txtEmail.TabIndex = 10;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtPassword.Location = new System.Drawing.Point(133, 137);
			this.txtPassword.MaxLength = 16;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(182, 27);
			this.txtPassword.TabIndex = 11;
			this.txtPassword.Tag = "長度請低於16個字元";
			this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
			this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
			// 
			// txtAge
			// 
			this.txtAge.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtAge.Location = new System.Drawing.Point(133, 179);
			this.txtAge.Name = "txtAge";
			this.txtAge.Size = new System.Drawing.Size(182, 27);
			this.txtAge.TabIndex = 12;
			// 
			// txtHeight
			// 
			this.txtHeight.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtHeight.Location = new System.Drawing.Point(133, 263);
			this.txtHeight.Name = "txtHeight";
			this.txtHeight.Size = new System.Drawing.Size(182, 27);
			this.txtHeight.TabIndex = 14;
			// 
			// txtWeight
			// 
			this.txtWeight.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtWeight.Location = new System.Drawing.Point(133, 305);
			this.txtWeight.Name = "txtWeight";
			this.txtWeight.Size = new System.Drawing.Size(182, 27);
			this.txtWeight.TabIndex = 15;
			// 
			// cmbGender
			// 
			this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGender.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.cmbGender.FormattingEnabled = true;
			this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.cmbGender.Location = new System.Drawing.Point(133, 221);
			this.cmbGender.Name = "cmbGender";
			this.cmbGender.Size = new System.Drawing.Size(182, 27);
			this.cmbGender.TabIndex = 17;
			// 
			// cmbActivityLevel
			// 
			this.cmbActivityLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbActivityLevel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.cmbActivityLevel.FormattingEnabled = true;
			this.cmbActivityLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
			this.cmbActivityLevel.Location = new System.Drawing.Point(133, 347);
			this.cmbActivityLevel.Name = "cmbActivityLevel";
			this.cmbActivityLevel.Size = new System.Drawing.Size(182, 27);
			this.cmbActivityLevel.TabIndex = 18;
			// 
			// btnBackToLogin
			// 
			this.btnBackToLogin.BackColor = System.Drawing.Color.Red;
			this.btnBackToLogin.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnBackToLogin.Location = new System.Drawing.Point(44, 390);
			this.btnBackToLogin.Name = "btnBackToLogin";
			this.btnBackToLogin.Size = new System.Drawing.Size(100, 40);
			this.btnBackToLogin.TabIndex = 19;
			this.btnBackToLogin.Text = "返回登入";
			this.btnBackToLogin.UseVisualStyleBackColor = false;
			this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
			// 
			// btnRegister
			// 
			this.btnRegister.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnRegister.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnRegister.Location = new System.Drawing.Point(215, 390);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(100, 40);
			this.btnRegister.TabIndex = 20;
			this.btnRegister.Text = "確認註冊";
			this.btnRegister.UseVisualStyleBackColor = false;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(380, 457);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.btnBackToLogin);
			this.Controls.Add(this.cmbActivityLevel);
			this.Controls.Add(this.cmbGender);
			this.Controls.Add(this.txtWeight);
			this.Controls.Add(this.txtHeight);
			this.Controls.Add(this.txtAge);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.lblActivityLevel);
			this.Controls.Add(this.lblWeight);
			this.Controls.Add(this.lblHeight);
			this.Controls.Add(this.lblGender);
			this.Controls.Add(this.lblAge);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.lblTitle);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RegisterForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Register";
			this.Load += new System.EventHandler(this.RegisterForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblAge;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.Label lblHeight;
		private System.Windows.Forms.Label lblWeight;
		private System.Windows.Forms.Label lblActivityLevel;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtAge;
		private System.Windows.Forms.TextBox txtHeight;
		private System.Windows.Forms.TextBox txtWeight;
		private System.Windows.Forms.ComboBox cmbGender;
		private System.Windows.Forms.ComboBox cmbActivityLevel;
		private System.Windows.Forms.Button btnBackToLogin;
		private System.Windows.Forms.Button btnRegister;
	}
}