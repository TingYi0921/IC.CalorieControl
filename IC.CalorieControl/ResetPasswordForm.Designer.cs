namespace IC.CalorieControl
{
	partial class ResetPasswordForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordForm));
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.lblUserName = new System.Windows.Forms.Label();
			this.lblNewPassword = new System.Windows.Forms.Label();
			this.txtNewPassword = new System.Windows.Forms.TextBox();
			this.lblConfirmPassword = new System.Windows.Forms.Label();
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtUserName.Location = new System.Drawing.Point(123, 50);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(164, 25);
			this.txtUserName.TabIndex = 0;
			this.txtUserName.MouseEnter += new System.EventHandler(this.txtUserName_Enter);
			this.txtUserName.MouseLeave += new System.EventHandler(this.txtUserName_Leave);
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.BackColor = System.Drawing.Color.Transparent;
			this.lblUserName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblUserName.Location = new System.Drawing.Point(27, 50);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(90, 21);
			this.lblUserName.TabIndex = 1;
			this.lblUserName.Text = "使用者名稱";
			// 
			// lblNewPassword
			// 
			this.lblNewPassword.AutoSize = true;
			this.lblNewPassword.BackColor = System.Drawing.Color.Transparent;
			this.lblNewPassword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblNewPassword.Location = new System.Drawing.Point(27, 102);
			this.lblNewPassword.Name = "lblNewPassword";
			this.lblNewPassword.Size = new System.Drawing.Size(58, 21);
			this.lblNewPassword.TabIndex = 3;
			this.lblNewPassword.Text = "新密碼";
			// 
			// txtNewPassword
			// 
			this.txtNewPassword.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtNewPassword.Location = new System.Drawing.Point(123, 102);
			this.txtNewPassword.Name = "txtNewPassword";
			this.txtNewPassword.Size = new System.Drawing.Size(164, 25);
			this.txtNewPassword.TabIndex = 2;
			this.txtNewPassword.MouseEnter += new System.EventHandler(this.txtNewPassword_Enter);
			this.txtNewPassword.MouseLeave += new System.EventHandler(this.txtNewPassword_Leave);
			// 
			// lblConfirmPassword
			// 
			this.lblConfirmPassword.AutoSize = true;
			this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
			this.lblConfirmPassword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblConfirmPassword.Location = new System.Drawing.Point(27, 154);
			this.lblConfirmPassword.Name = "lblConfirmPassword";
			this.lblConfirmPassword.Size = new System.Drawing.Size(90, 21);
			this.lblConfirmPassword.TabIndex = 5;
			this.lblConfirmPassword.Text = "確認新密碼";
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtConfirmPassword.Location = new System.Drawing.Point(123, 154);
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.Size = new System.Drawing.Size(164, 25);
			this.txtConfirmPassword.TabIndex = 4;
			this.txtConfirmPassword.MouseEnter += new System.EventHandler(this.txtConfirmPassword_Enter);
			this.txtConfirmPassword.MouseLeave += new System.EventHandler(this.txtConfirmPassword_Leave);
			// 
			// btnReset
			// 
			this.btnReset.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnReset.ForeColor = System.Drawing.Color.White;
			this.btnReset.Location = new System.Drawing.Point(187, 208);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(100, 40);
			this.btnReset.TabIndex = 6;
			this.btnReset.Text = "確認重設";
			this.btnReset.UseVisualStyleBackColor = false;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Red;
			this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(31, 208);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(100, 40);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "取消重設";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// ResetPasswordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(304, 281);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.lblConfirmPassword);
			this.Controls.Add(this.txtConfirmPassword);
			this.Controls.Add(this.lblNewPassword);
			this.Controls.Add(this.txtNewPassword);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.txtUserName);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ResetPasswordForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Reset Password";
			this.Load += new System.EventHandler(this.ResetPasswordForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Label lblNewPassword;
		private System.Windows.Forms.TextBox txtNewPassword;
		private System.Windows.Forms.Label lblConfirmPassword;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnCancel;
	}
}