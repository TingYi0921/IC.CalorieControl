namespace IC.CalorieControl
{
	partial class UserProfileControl
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

		#region 元件設計工具產生的程式碼

		/// <summary> 
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileControl));
			this.cmbActivityLevel = new System.Windows.Forms.ComboBox();
			this.cmbGender = new System.Windows.Forms.ComboBox();
			this.txtWeight = new System.Windows.Forms.TextBox();
			this.txtHeight = new System.Windows.Forms.TextBox();
			this.txtAge = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.lblActivityLevel = new System.Windows.Forms.Label();
			this.lblWeight = new System.Windows.Forms.Label();
			this.lblHeight = new System.Windows.Forms.Label();
			this.lblGender = new System.Windows.Forms.Label();
			this.lblAge = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblUserName = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
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
			this.cmbActivityLevel.Location = new System.Drawing.Point(394, 257);
			this.cmbActivityLevel.Name = "cmbActivityLevel";
			this.cmbActivityLevel.Size = new System.Drawing.Size(182, 27);
			this.cmbActivityLevel.TabIndex = 34;
			// 
			// cmbGender
			// 
			this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGender.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.cmbGender.FormattingEnabled = true;
			this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.cmbGender.Location = new System.Drawing.Point(394, 131);
			this.cmbGender.Name = "cmbGender";
			this.cmbGender.Size = new System.Drawing.Size(182, 27);
			this.cmbGender.TabIndex = 33;
			// 
			// txtWeight
			// 
			this.txtWeight.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtWeight.Location = new System.Drawing.Point(394, 215);
			this.txtWeight.Name = "txtWeight";
			this.txtWeight.Size = new System.Drawing.Size(182, 27);
			this.txtWeight.TabIndex = 32;
			// 
			// txtHeight
			// 
			this.txtHeight.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtHeight.Location = new System.Drawing.Point(394, 173);
			this.txtHeight.Name = "txtHeight";
			this.txtHeight.Size = new System.Drawing.Size(182, 27);
			this.txtHeight.TabIndex = 31;
			// 
			// txtAge
			// 
			this.txtAge.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtAge.Location = new System.Drawing.Point(110, 257);
			this.txtAge.Name = "txtAge";
			this.txtAge.Size = new System.Drawing.Size(182, 27);
			this.txtAge.TabIndex = 30;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtPassword.Location = new System.Drawing.Point(110, 215);
			this.txtPassword.MaxLength = 16;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.ReadOnly = true;
			this.txtPassword.Size = new System.Drawing.Size(182, 27);
			this.txtPassword.TabIndex = 29;
			this.txtPassword.Tag = "長度請低於16個字元";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtEmail.Location = new System.Drawing.Point(110, 173);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(182, 27);
			this.txtEmail.TabIndex = 28;
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtUserName.Location = new System.Drawing.Point(110, 131);
			this.txtUserName.MaxLength = 12;
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(182, 27);
			this.txtUserName.TabIndex = 27;
			// 
			// lblActivityLevel
			// 
			this.lblActivityLevel.AutoSize = true;
			this.lblActivityLevel.BackColor = System.Drawing.Color.Transparent;
			this.lblActivityLevel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblActivityLevel.Location = new System.Drawing.Point(301, 263);
			this.lblActivityLevel.Name = "lblActivityLevel";
			this.lblActivityLevel.Size = new System.Drawing.Size(74, 21);
			this.lblActivityLevel.TabIndex = 26;
			this.lblActivityLevel.Text = "活動等級";
			// 
			// lblWeight
			// 
			this.lblWeight.AutoSize = true;
			this.lblWeight.BackColor = System.Drawing.Color.Transparent;
			this.lblWeight.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblWeight.Location = new System.Drawing.Point(301, 221);
			this.lblWeight.Name = "lblWeight";
			this.lblWeight.Size = new System.Drawing.Size(93, 21);
			this.lblWeight.TabIndex = 25;
			this.lblWeight.Text = "體重（kg）";
			// 
			// lblHeight
			// 
			this.lblHeight.AutoSize = true;
			this.lblHeight.BackColor = System.Drawing.Color.Transparent;
			this.lblHeight.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblHeight.Location = new System.Drawing.Point(301, 179);
			this.lblHeight.Name = "lblHeight";
			this.lblHeight.Size = new System.Drawing.Size(97, 21);
			this.lblHeight.TabIndex = 24;
			this.lblHeight.Text = "身高（cm）";
			// 
			// lblGender
			// 
			this.lblGender.AutoSize = true;
			this.lblGender.BackColor = System.Drawing.Color.Transparent;
			this.lblGender.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblGender.Location = new System.Drawing.Point(301, 137);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(42, 21);
			this.lblGender.TabIndex = 23;
			this.lblGender.Text = "性別";
			// 
			// lblAge
			// 
			this.lblAge.AutoSize = true;
			this.lblAge.BackColor = System.Drawing.Color.Transparent;
			this.lblAge.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblAge.Location = new System.Drawing.Point(17, 263);
			this.lblAge.Name = "lblAge";
			this.lblAge.Size = new System.Drawing.Size(42, 21);
			this.lblAge.TabIndex = 22;
			this.lblAge.Text = "年齡";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.BackColor = System.Drawing.Color.Transparent;
			this.lblPassword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblPassword.Location = new System.Drawing.Point(17, 221);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(42, 21);
			this.lblPassword.TabIndex = 21;
			this.lblPassword.Text = "密碼";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.BackColor = System.Drawing.Color.Transparent;
			this.lblEmail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblEmail.Location = new System.Drawing.Point(17, 179);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(74, 21);
			this.lblEmail.TabIndex = 20;
			this.lblEmail.Text = "電子郵件";
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.BackColor = System.Drawing.Color.Transparent;
			this.lblUserName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblUserName.Location = new System.Drawing.Point(17, 137);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(90, 21);
			this.lblUserName.TabIndex = 19;
			this.lblUserName.Text = "使用者名稱";
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.Red;
			this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(348, 328);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(100, 40);
			this.btnCancel.TabIndex = 35;
			this.btnCancel.Text = "取消";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(476, 328);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 40);
			this.btnSave.TabIndex = 36;
			this.btnSave.Text = "儲存";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnEdit.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnEdit.ForeColor = System.Drawing.Color.White;
			this.btnEdit.Location = new System.Drawing.Point(476, 33);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(100, 40);
			this.btnEdit.TabIndex = 37;
			this.btnEdit.Text = "修改資料";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(0, 309);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(342, 101);
			this.pictureBox1.TabIndex = 38;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.MidnightBlue;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(1, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(452, 45);
			this.label1.TabIndex = 39;
			this.label1.Text = "Calorie Control User Profile";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(416, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 16);
			this.label2.TabIndex = 40;
			this.label2.Text = "註 : 性別及密碼無法進行修改";
			// 
			// UserProfileControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCancel);
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
			this.Name = "UserProfileControl";
			this.Size = new System.Drawing.Size(589, 410);
			this.Load += new System.EventHandler(this.UserProfileControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbActivityLevel;
		private System.Windows.Forms.ComboBox cmbGender;
		private System.Windows.Forms.TextBox txtWeight;
		private System.Windows.Forms.TextBox txtHeight;
		private System.Windows.Forms.TextBox txtAge;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label lblActivityLevel;
		private System.Windows.Forms.Label lblWeight;
		private System.Windows.Forms.Label lblHeight;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.Label lblAge;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}
