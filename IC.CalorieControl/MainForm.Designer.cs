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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnListItems = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnActivity = new System.Windows.Forms.Button();
			this.btnNutrient = new System.Windows.Forms.Button();
			this.btnMealLog = new System.Windows.Forms.Button();
			this.btnUserProfile = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
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
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.panel1.Controls.Add(this.lblWelcome);
			this.panel1.Location = new System.Drawing.Point(189, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(591, 47);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(191, 47);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(589, 410);
			this.panel2.TabIndex = 2;
			// 
			// pnListItems
			// 
			this.pnListItems.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.pnListItems.Controls.Add(this.pictureBox1);
			this.pnListItems.Controls.Add(this.btnActivity);
			this.pnListItems.Controls.Add(this.btnNutrient);
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
			// 
			// btnNutrient
			// 
			this.btnNutrient.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnNutrient.FlatAppearance.BorderSize = 0;
			this.btnNutrient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNutrient.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNutrient.ForeColor = System.Drawing.SystemColors.Window;
			this.btnNutrient.Image = ((System.Drawing.Image)(resources.GetObject("btnNutrient.Image")));
			this.btnNutrient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNutrient.Location = new System.Drawing.Point(0, 287);
			this.btnNutrient.Name = "btnNutrient";
			this.btnNutrient.Size = new System.Drawing.Size(190, 40);
			this.btnNutrient.TabIndex = 38;
			this.btnNutrient.Text = "Nutrient";
			this.btnNutrient.UseVisualStyleBackColor = false;
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
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(780, 457);
			this.Controls.Add(this.pnListItems);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calorie Control";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.pnListItems.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblWelcome;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel pnListItems;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnActivity;
		private System.Windows.Forms.Button btnNutrient;
		private System.Windows.Forms.Button btnMealLog;
		private System.Windows.Forms.Button btnUserProfile;
		private System.Windows.Forms.Button btnLogout;
	}
}