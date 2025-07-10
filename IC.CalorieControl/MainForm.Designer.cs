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
			this.lblMainTitle = new System.Windows.Forms.Label();
			this.btnLogout = new System.Windows.Forms.Button();
			this.lblWelcome = new System.Windows.Forms.Label();
			this.lblUserProfile = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblMealLog = new System.Windows.Forms.Label();
			this.lblFoodItem = new System.Windows.Forms.Label();
			this.lblActivityAndBMI = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblMainTitle
			// 
			this.lblMainTitle.AutoSize = true;
			this.lblMainTitle.Font = new System.Drawing.Font("微軟正黑體", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblMainTitle.ForeColor = System.Drawing.Color.Blue;
			this.lblMainTitle.Location = new System.Drawing.Point(12, 9);
			this.lblMainTitle.Name = "lblMainTitle";
			this.lblMainTitle.Size = new System.Drawing.Size(379, 35);
			this.lblMainTitle.TabIndex = 0;
			this.lblMainTitle.Text = "Welcome to, Calorie Control";
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.Color.DarkGray;
			this.btnLogout.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnLogout.Location = new System.Drawing.Point(668, 14);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(100, 30);
			this.btnLogout.TabIndex = 1;
			this.btnLogout.Text = "登出";
			this.btnLogout.UseVisualStyleBackColor = false;
			// 
			// lblWelcome
			// 
			this.lblWelcome.AutoSize = true;
			this.lblWelcome.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblWelcome.Location = new System.Drawing.Point(539, 17);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(65, 24);
			this.lblWelcome.TabIndex = 2;
			this.lblWelcome.Text = "label1";
			// 
			// lblUserProfile
			// 
			this.lblUserProfile.AutoSize = true;
			this.lblUserProfile.BackColor = System.Drawing.Color.Gold;
			this.lblUserProfile.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblUserProfile.Location = new System.Drawing.Point(65, 77);
			this.lblUserProfile.Name = "lblUserProfile";
			this.lblUserProfile.Size = new System.Drawing.Size(96, 26);
			this.lblUserProfile.TabIndex = 3;
			this.lblUserProfile.Text = "基本資料";
			this.lblUserProfile.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(435, 275);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(347, 183);
			this.panel1.TabIndex = 4;
			// 
			// lblMealLog
			// 
			this.lblMealLog.AutoSize = true;
			this.lblMealLog.BackColor = System.Drawing.Color.OrangeRed;
			this.lblMealLog.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblMealLog.Location = new System.Drawing.Point(202, 77);
			this.lblMealLog.Name = "lblMealLog";
			this.lblMealLog.Size = new System.Drawing.Size(159, 26);
			this.lblMealLog.TabIndex = 5;
			this.lblMealLog.Text = "餐點及食物日誌";
			// 
			// lblFoodItem
			// 
			this.lblFoodItem.AutoSize = true;
			this.lblFoodItem.BackColor = System.Drawing.Color.Yellow;
			this.lblFoodItem.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblFoodItem.Location = new System.Drawing.Point(402, 77);
			this.lblFoodItem.Name = "lblFoodItem";
			this.lblFoodItem.Size = new System.Drawing.Size(138, 26);
			this.lblFoodItem.TabIndex = 6;
			this.lblFoodItem.Text = "營養成分分析";
			// 
			// lblActivityAndBMI
			// 
			this.lblActivityAndBMI.AutoSize = true;
			this.lblActivityAndBMI.BackColor = System.Drawing.Color.DodgerBlue;
			this.lblActivityAndBMI.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblActivityAndBMI.Location = new System.Drawing.Point(581, 77);
			this.lblActivityAndBMI.Name = "lblActivityAndBMI";
			this.lblActivityAndBMI.Size = new System.Drawing.Size(159, 26);
			this.lblActivityAndBMI.TabIndex = 7;
			this.lblActivityAndBMI.Text = "身體及活動紀錄";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(780, 457);
			this.Controls.Add(this.lblActivityAndBMI);
			this.Controls.Add(this.lblFoodItem);
			this.Controls.Add(this.lblMealLog);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblUserProfile);
			this.Controls.Add(this.lblWelcome);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.lblMainTitle);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Calorie Control";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblMainTitle;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Label lblWelcome;
		private System.Windows.Forms.Label lblUserProfile;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblMealLog;
		private System.Windows.Forms.Label lblFoodItem;
		private System.Windows.Forms.Label lblActivityAndBMI;
	}
}