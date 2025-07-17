namespace IC.CalorieControl
{
	partial class MealListControl
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dtpLogDate = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.calorieControlSystemDataSet1 = new IC.CalorieControl.CalorieControlSystemDataSet1();
			this.foodItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.foodItemTableAdapter = new IC.CalorieControl.CalorieControlSystemDataSet1TableAdapters.FoodItemTableAdapter();
			this.tableAdapterManager = new IC.CalorieControl.CalorieControlSystemDataSet1TableAdapters.TableAdapterManager();
			this.btnDeleteLog = new System.Windows.Forms.Button();
			this.dgvMealLog = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.calorieControlSystemDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.foodItemBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvMealLog)).BeginInit();
			this.SuspendLayout();
			// 
			// dtpLogDate
			// 
			this.dtpLogDate.CalendarFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.dtpLogDate.Location = new System.Drawing.Point(102, 87);
			this.dtpLogDate.Name = "dtpLogDate";
			this.dtpLogDate.Size = new System.Drawing.Size(200, 22);
			this.dtpLogDate.TabIndex = 0;
			this.dtpLogDate.ValueChanged += new System.EventHandler(this.dtpLogDate_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(5, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "紀錄日期";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.MidnightBlue;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(1, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(403, 45);
			this.label2.TabIndex = 41;
			this.label2.Text = "Calorie Control Meal Log";
			// 
			// calorieControlSystemDataSet1
			// 
			this.calorieControlSystemDataSet1.DataSetName = "CalorieControlSystemDataSet1";
			this.calorieControlSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// foodItemBindingSource
			// 
			this.foodItemBindingSource.DataMember = "FoodItem";
			this.foodItemBindingSource.DataSource = this.calorieControlSystemDataSet1;
			// 
			// foodItemTableAdapter
			// 
			this.foodItemTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.FoodItemTableAdapter = this.foodItemTableAdapter;
			this.tableAdapterManager.LoginSessionTableAdapter = null;
			this.tableAdapterManager.MealLogTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = IC.CalorieControl.CalorieControlSystemDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.UserProfileTableAdapter = null;
			// 
			// btnDeleteLog
			// 
			this.btnDeleteLog.BackColor = System.Drawing.Color.Red;
			this.btnDeleteLog.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnDeleteLog.ForeColor = System.Drawing.Color.White;
			this.btnDeleteLog.Location = new System.Drawing.Point(451, 79);
			this.btnDeleteLog.Name = "btnDeleteLog";
			this.btnDeleteLog.Size = new System.Drawing.Size(126, 30);
			this.btnDeleteLog.TabIndex = 43;
			this.btnDeleteLog.Text = "刪除選取紀錄";
			this.btnDeleteLog.UseVisualStyleBackColor = false;
			this.btnDeleteLog.Click += new System.EventHandler(this.btnDeleteLog_Click);
			// 
			// dgvMealLog
			// 
			this.dgvMealLog.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvMealLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvMealLog.AutoGenerateColumns = false;
			this.dgvMealLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMealLog.DataSource = this.calorieControlSystemDataSet1;
			this.dgvMealLog.Location = new System.Drawing.Point(0, 124);
			this.dgvMealLog.Name = "dgvMealLog";
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.dgvMealLog.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvMealLog.RowTemplate.Height = 24;
			this.dgvMealLog.Size = new System.Drawing.Size(589, 300);
			this.dgvMealLog.TabIndex = 44;
			// 
			// MealListControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.Controls.Add(this.dgvMealLog);
			this.Controls.Add(this.btnDeleteLog);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpLogDate);
			this.Name = "MealListControl";
			this.Size = new System.Drawing.Size(589, 424);
			this.Load += new System.EventHandler(this.MealListControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.calorieControlSystemDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.foodItemBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvMealLog)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpLogDate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private CalorieControlSystemDataSet1 calorieControlSystemDataSet1;
		private System.Windows.Forms.BindingSource foodItemBindingSource;
		private CalorieControlSystemDataSet1TableAdapters.FoodItemTableAdapter foodItemTableAdapter;
		private CalorieControlSystemDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.Button btnDeleteLog;
		private System.Windows.Forms.DataGridView dgvMealLog;
	}
}
