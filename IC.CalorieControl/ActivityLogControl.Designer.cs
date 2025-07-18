namespace IC.CalorieControl
{
	partial class ActivityLogControl
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpActivityDate = new System.Windows.Forms.DateTimePicker();
			this.cbActivityLevel = new System.Windows.Forms.ComboBox();
			this.nudDuration = new System.Windows.Forms.NumericUpDown();
			this.btnAddActivity = new System.Windows.Forms.Button();
			this.chartDailyBurn = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dgvActivityLogs = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartDailyBurn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvActivityLogs)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.RoyalBlue;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(451, 45);
			this.label1.TabIndex = 41;
			this.label1.Text = "Calorie Control Activity Log";
			// 
			// dtpActivityDate
			// 
			this.dtpActivityDate.CalendarFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dtpActivityDate.CustomFormat = "\"yyyy-MM-dd\"";
			this.dtpActivityDate.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dtpActivityDate.Location = new System.Drawing.Point(105, 63);
			this.dtpActivityDate.Name = "dtpActivityDate";
			this.dtpActivityDate.Size = new System.Drawing.Size(200, 25);
			this.dtpActivityDate.TabIndex = 42;
			this.dtpActivityDate.ValueChanged += new System.EventHandler(this.DtpActivityDate_ValueChanged);
			// 
			// cbActivityLevel
			// 
			this.cbActivityLevel.FormattingEnabled = true;
			this.cbActivityLevel.Location = new System.Drawing.Point(105, 111);
			this.cbActivityLevel.Name = "cbActivityLevel";
			this.cbActivityLevel.Size = new System.Drawing.Size(121, 20);
			this.cbActivityLevel.TabIndex = 43;
			// 
			// nudDuration
			// 
			this.nudDuration.DecimalPlaces = 2;
			this.nudDuration.Location = new System.Drawing.Point(443, 109);
			this.nudDuration.Name = "nudDuration";
			this.nudDuration.Size = new System.Drawing.Size(120, 22);
			this.nudDuration.TabIndex = 44;
			// 
			// btnAddActivity
			// 
			this.btnAddActivity.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnAddActivity.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnAddActivity.ForeColor = System.Drawing.Color.White;
			this.btnAddActivity.Location = new System.Drawing.Point(453, 60);
			this.btnAddActivity.Name = "btnAddActivity";
			this.btnAddActivity.Size = new System.Drawing.Size(110, 33);
			this.btnAddActivity.TabIndex = 45;
			this.btnAddActivity.Text = "加入活動";
			this.btnAddActivity.UseVisualStyleBackColor = false;
			this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
			// 
			// chartDailyBurn
			// 
			this.chartDailyBurn.BackColor = System.Drawing.Color.PaleTurquoise;
			chartArea1.AxisX.Title = "Date";
			chartArea1.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			chartArea1.AxisY.Title = "Calorie";
			chartArea1.AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			chartArea1.BackColor = System.Drawing.Color.White;
			chartArea1.Name = "ChartArea1";
			this.chartDailyBurn.ChartAreas.Add(chartArea1);
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
			legend1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			legend1.IsTextAutoFit = false;
			legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
			legend1.Name = "Legend1";
			this.chartDailyBurn.Legends.Add(legend1);
			this.chartDailyBurn.Location = new System.Drawing.Point(0, 137);
			this.chartDailyBurn.Name = "chartDailyBurn";
			series1.BorderColor = System.Drawing.Color.Yellow;
			series1.BorderWidth = 3;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Color = System.Drawing.Color.Blue;
			series1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			series1.IsValueShownAsLabel = true;
			series1.LabelForeColor = System.Drawing.Color.DarkBlue;
			series1.Legend = "Legend1";
			series1.MarkerBorderColor = System.Drawing.Color.DarkBlue;
			series1.MarkerBorderWidth = 2;
			series1.MarkerColor = System.Drawing.Color.DarkBlue;
			series1.MarkerSize = 7;
			series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
			series1.Name = "Calories";
			this.chartDailyBurn.Series.Add(series1);
			this.chartDailyBurn.Size = new System.Drawing.Size(589, 187);
			this.chartDailyBurn.TabIndex = 47;
			this.chartDailyBurn.Text = "Daily Calorie";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(21, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 21);
			this.label2.TabIndex = 48;
			this.label2.Text = "選擇日期:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(21, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 21);
			this.label3.TabIndex = 49;
			this.label3.Text = "活動等級:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(326, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 21);
			this.label4.TabIndex = 50;
			this.label4.Text = "運動時間(hr):";
			// 
			// dgvActivityLogs
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvActivityLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvActivityLogs.BackgroundColor = System.Drawing.Color.PaleTurquoise;
			this.dgvActivityLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvActivityLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvActivityLogs.Location = new System.Drawing.Point(83, 323);
			this.dgvActivityLogs.Name = "dgvActivityLogs";
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvActivityLogs.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvActivityLogs.RowTemplate.Height = 24;
			this.dgvActivityLogs.Size = new System.Drawing.Size(443, 87);
			this.dgvActivityLogs.TabIndex = 51;
			// 
			// ActivityLogControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.Controls.Add(this.dgvActivityLogs);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.chartDailyBurn);
			this.Controls.Add(this.btnAddActivity);
			this.Controls.Add(this.nudDuration);
			this.Controls.Add(this.cbActivityLevel);
			this.Controls.Add(this.dtpActivityDate);
			this.Controls.Add(this.label1);
			this.Name = "ActivityLogControl";
			this.Size = new System.Drawing.Size(589, 410);
			((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartDailyBurn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvActivityLogs)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpActivityDate;
		private System.Windows.Forms.ComboBox cbActivityLevel;
		private System.Windows.Forms.NumericUpDown nudDuration;
		private System.Windows.Forms.Button btnAddActivity;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartDailyBurn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dgvActivityLogs;
	}
}
