namespace IC.CalorieControl
{
	partial class LoginForm
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.lblUserName = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnNewuser = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.BackColor = System.Drawing.Color.Transparent;
			this.lblUserName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblUserName.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lblUserName.Location = new System.Drawing.Point(16, 115);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(90, 21);
			this.lblUserName.TabIndex = 1;
			this.lblUserName.Text = "使用者名稱";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.BackColor = System.Drawing.Color.Transparent;
			this.lblPassword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblPassword.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lblPassword.Location = new System.Drawing.Point(16, 155);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(42, 21);
			this.lblPassword.TabIndex = 2;
			this.lblPassword.Text = "密碼";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(113, 114);
			this.txtUserName.MaxLength = 12;
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(172, 22);
			this.txtUserName.TabIndex = 3;
			this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
			this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(113, 154);
			this.txtPassword.MaxLength = 16;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(172, 22);
			this.txtPassword.TabIndex = 4;
			this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
			this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnLogin.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnLogin.Location = new System.Drawing.Point(185, 207);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(100, 40);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "登入";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnNewuser
			// 
			this.btnNewuser.BackColor = System.Drawing.Color.Red;
			this.btnNewuser.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnNewuser.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnNewuser.Location = new System.Drawing.Point(20, 207);
			this.btnNewuser.Name = "btnNewuser";
			this.btnNewuser.Size = new System.Drawing.Size(100, 40);
			this.btnNewuser.TabIndex = 6;
			this.btnNewuser.Text = "註冊帳號";
			this.btnNewuser.UseVisualStyleBackColor = false;
			this.btnNewuser.Click += new System.EventHandler(this.btnNewuser_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblTitle.ForeColor = System.Drawing.Color.Blue;
			this.lblTitle.Location = new System.Drawing.Point(43, 9);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(209, 35);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Calorie Control";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(101, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 35);
			this.label1.TabIndex = 7;
			this.label1.Text = "Login";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(300, 277);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnNewuser);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUserName);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Calorie Control";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnNewuser;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label label1;
	}
}

