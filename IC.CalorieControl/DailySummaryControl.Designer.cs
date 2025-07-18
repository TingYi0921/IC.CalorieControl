namespace IC.CalorieControl
{
	partial class DailySummaryControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailySummaryControl));
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblTotalCalories = new System.Windows.Forms.Label();
			this.lblTotalCarbs = new System.Windows.Forms.Label();
			this.lblTotalProtein = new System.Windows.Forms.Label();
			this.lblTotalFat = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.dtpSummaryDate = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.btnViewLogs = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.RoyalBlue;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(407, 45);
			this.label2.TabIndex = 42;
			this.label2.Text = "Calorie Control Daily Log";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(30, 143);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(228, 31);
			this.label1.TabIndex = 43;
			this.label1.Text = "當日總卡路里(Kcal):";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(30, 205);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(172, 31);
			this.label3.TabIndex = 44;
			this.label3.Text = "當日總碳水(g):";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(30, 267);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(196, 31);
			this.label4.TabIndex = 45;
			this.label4.Text = "當日總蛋白質(g):";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(30, 329);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(172, 31);
			this.label5.TabIndex = 46;
			this.label5.Text = "當日總脂肪(g):";
			// 
			// lblTotalCalories
			// 
			this.lblTotalCalories.AutoSize = true;
			this.lblTotalCalories.BackColor = System.Drawing.Color.Transparent;
			this.lblTotalCalories.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblTotalCalories.Location = new System.Drawing.Point(267, 143);
			this.lblTotalCalories.Name = "lblTotalCalories";
			this.lblTotalCalories.Size = new System.Drawing.Size(85, 31);
			this.lblTotalCalories.TabIndex = 47;
			this.lblTotalCalories.Text = "label6";
			// 
			// lblTotalCarbs
			// 
			this.lblTotalCarbs.AutoSize = true;
			this.lblTotalCarbs.BackColor = System.Drawing.Color.Transparent;
			this.lblTotalCarbs.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblTotalCarbs.Location = new System.Drawing.Point(267, 205);
			this.lblTotalCarbs.Name = "lblTotalCarbs";
			this.lblTotalCarbs.Size = new System.Drawing.Size(85, 31);
			this.lblTotalCarbs.TabIndex = 48;
			this.lblTotalCarbs.Text = "label7";
			// 
			// lblTotalProtein
			// 
			this.lblTotalProtein.AutoSize = true;
			this.lblTotalProtein.BackColor = System.Drawing.Color.Transparent;
			this.lblTotalProtein.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblTotalProtein.Location = new System.Drawing.Point(267, 267);
			this.lblTotalProtein.Name = "lblTotalProtein";
			this.lblTotalProtein.Size = new System.Drawing.Size(85, 31);
			this.lblTotalProtein.TabIndex = 49;
			this.lblTotalProtein.Text = "label8";
			// 
			// lblTotalFat
			// 
			this.lblTotalFat.AutoSize = true;
			this.lblTotalFat.BackColor = System.Drawing.Color.Transparent;
			this.lblTotalFat.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblTotalFat.Location = new System.Drawing.Point(267, 329);
			this.lblTotalFat.Name = "lblTotalFat";
			this.lblTotalFat.Size = new System.Drawing.Size(85, 31);
			this.lblTotalFat.TabIndex = 50;
			this.lblTotalFat.Text = "label9";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(330, 204);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(298, 305);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 51;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(433, 69);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(156, 105);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 52;
			this.pictureBox2.TabStop = false;
			// 
			// dtpSummaryDate
			// 
			this.dtpSummaryDate.CalendarFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dtpSummaryDate.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dtpSummaryDate.Location = new System.Drawing.Point(152, 84);
			this.dtpSummaryDate.Name = "dtpSummaryDate";
			this.dtpSummaryDate.Size = new System.Drawing.Size(200, 25);
			this.dtpSummaryDate.TabIndex = 53;
			this.dtpSummaryDate.ValueChanged += new System.EventHandler(this.dtpSummaryDate_ValueChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(30, 81);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(116, 31);
			this.label6.TabIndex = 54;
			this.label6.Text = "選擇日期:";
			// 
			// btnViewLogs
			// 
			this.btnViewLogs.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnViewLogs.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnViewLogs.ForeColor = System.Drawing.Color.White;
			this.btnViewLogs.Location = new System.Drawing.Point(459, 13);
			this.btnViewLogs.Name = "btnViewLogs";
			this.btnViewLogs.Size = new System.Drawing.Size(127, 33);
			this.btnViewLogs.TabIndex = 55;
			this.btnViewLogs.Text = "檢視餐點紀錄";
			this.btnViewLogs.UseVisualStyleBackColor = false;
			this.btnViewLogs.Click += new System.EventHandler(this.btnViewLogs_Click);
			// 
			// DailySummaryControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.Controls.Add(this.btnViewLogs);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dtpSummaryDate);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.lblTotalFat);
			this.Controls.Add(this.lblTotalProtein);
			this.Controls.Add(this.lblTotalCarbs);
			this.Controls.Add(this.lblTotalCalories);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Name = "DailySummaryControl";
			this.Size = new System.Drawing.Size(589, 410);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblTotalCalories;
		private System.Windows.Forms.Label lblTotalCarbs;
		private System.Windows.Forms.Label lblTotalProtein;
		private System.Windows.Forms.Label lblTotalFat;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.DateTimePicker dtpSummaryDate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnViewLogs;
	}
}
