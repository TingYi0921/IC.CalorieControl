namespace IC.CalorieControl
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lblWelcome = new System.Windows.Forms.Label();
			this.pnTitle = new System.Windows.Forms.Panel();
			this.pnMainpanel = new System.Windows.Forms.Panel();
			this.pnListItems = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnActivity = new System.Windows.Forms.Button();
			this.btnDailyLog = new System.Windows.Forms.Button();
			this.btnMealLog = new System.Windows.Forms.Button();
			this.btnUserProfile = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.pnTitle.SuspendLayout();
			this.pnListItems.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblWelcome
			// 
			this.lblWelcome.AutoSize = true;
			this.lblWelcome.Font = new System.Drawing.Font("微軟正黑體", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblWelcome.ForeColor = System.Drawing.SystemColors.Window;
			this.lblWelcome.Location = new System.Drawing.Point(410, 9);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(96, 26);
			this.lblWelcome.TabIndex = 0;
			this.lblWelcome.Text = "歡迎標籤";
			// 
			// pnTitle
			// 
			this.pnTitle.BackColor = System.Drawing.Color.MidnightBlue;
			this.pnTitle.Controls.Add(this.lblWelcome);
			this.pnTitle.Location = new System.Drawing.Point(189, 0);
			this.pnTitle.Name = "pnTitle";
			this.pnTitle.Size = new System.Drawing.Size(591, 47);
			this.pnTitle.TabIndex = 1;
			// 
			// pnMainpanel
			// 
			this.pnMainpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMainpanel.BackgroundImage")));
			this.pnMainpanel.Location = new System.Drawing.Point(191, 47);
			this.pnMainpanel.Name = "pnMainpanel";
			this.pnMainpanel.Size = new System.Drawing.Size(589, 410);
			this.pnMainpanel.TabIndex = 2;
			// 
			// pnListItems
			// 
			this.pnListItems.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.pnListItems.Controls.Add(this.pictureBox1);
			this.pnListItems.Controls.Add(this.btnActivity);
			this.pnListItems.Controls.Add(this.btnDailyLog);
			this.pnListItems.Controls.Add(this.btnMealLog);
			this.pnListItems.Controls.Add(this.btnUserProfile);
			this.pnListItems.Controls.Add(this.btnLogout);
			this.pnListItems.Location = new System.Drawing.Point(0, 0);
			this.pnListItems.Name = "pnListItems";
			this.pnListItems.Size = new System.Drawing.Size(191, 457);
			this.pnListItems.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(22, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 150);
			this.pictureBox1.TabIndex = 40;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// btnActivity
			// 
			this.btnActivity.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnActivity.FlatAppearance.BorderSize = 0;
			this.btnActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnActivity.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActivity.ForeColor = System.Drawing.SystemColors.Window;
			this.btnActivity.Image = ((System.Drawing.Image)(resources.GetObject("btnActivity.Image")));
			this.btnActivity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnActivity.Location = new System.Drawing.Point(0, 351);
			this.btnActivity.Name = "btnActivity";
			this.btnActivity.Size = new System.Drawing.Size(190, 40);
			this.btnActivity.TabIndex = 39;
			this.btnActivity.Text = "Activity Log";
			this.btnActivity.UseVisualStyleBackColor = false;
			this.btnActivity.MouseEnter += new System.EventHandler(this.btnActivity_MouseEnter);
			this.btnActivity.MouseLeave += new System.EventHandler(this.btnActivity_MouseLeave);
			// 
			// btnDailyLog
			// 
			this.btnDailyLog.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnDailyLog.FlatAppearance.BorderSize = 0;
			this.btnDailyLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDailyLog.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDailyLog.ForeColor = System.Drawing.SystemColors.Window;
			this.btnDailyLog.Image = ((System.Drawing.Image)(resources.GetObject("btnDailyLog.Image")));
			this.btnDailyLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDailyLog.Location = new System.Drawing.Point(0, 287);
			this.btnDailyLog.Name = "btnDailyLog";
			this.btnDailyLog.Size = new System.Drawing.Size(190, 40);
			this.btnDailyLog.TabIndex = 38;
			this.btnDailyLog.Text = "Daily Log";
			this.btnDailyLog.UseVisualStyleBackColor = false;
			this.btnDailyLog.Click += new System.EventHandler(this.btnDailyLog_Click);
			this.btnDailyLog.MouseEnter += new System.EventHandler(this.btnNutrient_MouseEnter);
			this.btnDailyLog.MouseLeave += new System.EventHandler(this.btnNutrient_MouseLeave);
			// 
			// btnMealLog
			// 
			this.btnMealLog.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnMealLog.FlatAppearance.BorderSize = 0;
			this.btnMealLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMealLog.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMealLog.ForeColor = System.Drawing.SystemColors.Window;
			this.btnMealLog.Image = ((System.Drawing.Image)(resources.GetObject("btnMealLog.Image")));
			this.btnMealLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMealLog.Location = new System.Drawing.Point(0, 223);
			this.btnMealLog.Name = "btnMealLog";
			this.btnMealLog.Size = new System.Drawing.Size(190, 40);
			this.btnMealLog.TabIndex = 37;
			this.btnMealLog.Text = "Meal Log";
			this.btnMealLog.UseVisualStyleBackColor = false;
			this.btnMealLog.Click += new System.EventHandler(this.btnMealLog_Click);
			this.btnMealLog.MouseEnter += new System.EventHandler(this.btnMealLog_MouseEnter);
			this.btnMealLog.MouseLeave += new System.EventHandler(this.btnMealLog_MouseLeave);
			// 
			// btnUserProfile
			// 
			this.btnUserProfile.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnUserProfile.FlatAppearance.BorderSize = 0;
			this.btnUserProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUserProfile.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUserProfile.ForeColor = System.Drawing.SystemColors.Window;
			this.btnUserProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnUserProfile.Image")));
			this.btnUserProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUserProfile.Location = new System.Drawing.Point(0, 159);
			this.btnUserProfile.Name = "btnUserProfile";
			this.btnUserProfile.Size = new System.Drawing.Size(190, 40);
			this.btnUserProfile.TabIndex = 36;
			this.btnUserProfile.Text = "User Profile";
			this.btnUserProfile.UseVisualStyleBackColor = false;
			this.btnUserProfile.Click += new System.EventHandler(this.btnUserProfile_Click);
			this.btnUserProfile.MouseEnter += new System.EventHandler(this.btnUserProfile_MouseEnter);
			this.btnUserProfile.MouseLeave += new System.EventHandler(this.btnUserProfile_MouseLeave);
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnLogout.FlatAppearance.BorderSize = 0;
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogout.ForeColor = System.Drawing.SystemColors.Window;
			this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
			this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLogout.Location = new System.Drawing.Point(0, 415);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(190, 40);
			this.btnLogout.TabIndex = 35;
			this.btnLogout.Text = "Log Out";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
			this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(780, 457);
			this.Controls.Add(this.pnListItems);
			this.Controls.Add(this.pnMainpanel);
			this.Controls.Add(this.pnTitle);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calorie Control";
			this.pnTitle.ResumeLayout(false);
			this.pnTitle.PerformLayout();
			this.pnListItems.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblWelcome;
		private System.Windows.Forms.Panel pnTitle;
		private System.Windows.Forms.Panel pnMainpanel;
		private System.Windows.Forms.Panel pnListItems;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnActivity;
		private System.Windows.Forms.Button btnDailyLog;
		private System.Windows.Forms.Button btnMealLog;
		private System.Windows.Forms.Button btnUserProfile;
		private System.Windows.Forms.Button btnLogout;
	}
}