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
			this.dtpLogDate = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.calorieControlSystemDataSet1 = new IC.CalorieControl.CalorieControlSystemDataSet1();
			this.foodItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.foodItemTableAdapter = new IC.CalorieControl.CalorieControlSystemDataSet1TableAdapters.FoodItemTableAdapter();
			this.tableAdapterManager = new IC.CalorieControl.CalorieControlSystemDataSet1TableAdapters.TableAdapterManager();
			this.dgvMealLog = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnDeleteLog = new System.Windows.Forms.Button();
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
			this.dtpLogDate.ValueChanged += new System.EventHandler(this.dtpLogDate_ValueChanged_1);
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
			// dgvMealLog
			// 
			this.dgvMealLog.AutoGenerateColumns = false;
			this.dgvMealLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMealLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
			this.dgvMealLog.DataSource = this.foodItemBindingSource;
			this.dgvMealLog.Location = new System.Drawing.Point(0, 122);
			this.dgvMealLog.Name = "dgvMealLog";
			this.dgvMealLog.RowTemplate.Height = 24;
			this.dgvMealLog.Size = new System.Drawing.Size(589, 302);
			this.dgvMealLog.TabIndex = 42;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "FoodId";
			this.dataGridViewTextBoxColumn1.HeaderText = "FoodId";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn2.HeaderText = "Name";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Calories";
			this.dataGridViewTextBoxColumn3.HeaderText = "Calories";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "WeightGrams";
			this.dataGridViewTextBoxColumn4.HeaderText = "WeightGrams";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Carbohydrates";
			this.dataGridViewTextBoxColumn5.HeaderText = "Carbohydrates";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Protein";
			this.dataGridViewTextBoxColumn6.HeaderText = "Protein";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "Fat";
			this.dataGridViewTextBoxColumn7.HeaderText = "Fat";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "UserId";
			this.dataGridViewTextBoxColumn8.HeaderText = "UserId";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "CreatedAt";
			this.dataGridViewTextBoxColumn9.HeaderText = "CreatedAt";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "UpdatedAt";
			this.dataGridViewTextBoxColumn10.HeaderText = "UpdatedAt";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
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
			this.btnDeleteLog.Click += new System.EventHandler(this.btnDeleteLog_Click_1);
			// 
			// MealListControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.Controls.Add(this.btnDeleteLog);
			this.Controls.Add(this.dgvMealLog);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpLogDate);
			this.Name = "MealListControl";
			this.Size = new System.Drawing.Size(589, 424);
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
		private System.Windows.Forms.DataGridView dgvMealLog;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.Button btnDeleteLog;
	}
}
