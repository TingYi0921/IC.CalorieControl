namespace IC.CalorieControl
{
	partial class UserControl1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnUserProfile = new System.Windows.Forms.Button();
			this.btnMealLog = new System.Windows.Forms.Button();
			this.btnNutrient = new System.Windows.Forms.Button();
			this.btnActivity = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogout.ForeColor = System.Drawing.SystemColors.Window;
			this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
			this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLogout.Location = new System.Drawing.Point(0, 345);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(191, 40);
			this.btnLogout.TabIndex = 12;
			this.btnLogout.Text = "Log Out";
			this.btnLogout.UseVisualStyleBackColor = false;
			// 
			// btnUserProfile
			// 
			this.btnUserProfile.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnUserProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUserProfile.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUserProfile.ForeColor = System.Drawing.SystemColors.Window;
			this.btnUserProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnUserProfile.Image")));
			this.btnUserProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUserProfile.Location = new System.Drawing.Point(0, 21);
			this.btnUserProfile.Name = "btnUserProfile";
			this.btnUserProfile.Size = new System.Drawing.Size(191, 40);
			this.btnUserProfile.TabIndex = 13;
			this.btnUserProfile.Text = "User Profile";
			this.btnUserProfile.UseVisualStyleBackColor = false;
			// 
			// btnMealLog
			// 
			this.btnMealLog.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnMealLog.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMealLog.ForeColor = System.Drawing.SystemColors.Window;
			this.btnMealLog.Image = ((System.Drawing.Image)(resources.GetObject("btnMealLog.Image")));
			this.btnMealLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMealLog.Location = new System.Drawing.Point(0, 102);
			this.btnMealLog.Name = "btnMealLog";
			this.btnMealLog.Size = new System.Drawing.Size(191, 40);
			this.btnMealLog.TabIndex = 14;
			this.btnMealLog.Text = "Meal Log";
			this.btnMealLog.UseVisualStyleBackColor = false;
			// 
			// btnNutrient
			// 
			this.btnNutrient.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnNutrient.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNutrient.ForeColor = System.Drawing.SystemColors.Window;
			this.btnNutrient.Image = ((System.Drawing.Image)(resources.GetObject("btnNutrient.Image")));
			this.btnNutrient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNutrient.Location = new System.Drawing.Point(0, 183);
			this.btnNutrient.Name = "btnNutrient";
			this.btnNutrient.Size = new System.Drawing.Size(191, 40);
			this.btnNutrient.TabIndex = 15;
			this.btnNutrient.Text = "Nutrient";
			this.btnNutrient.UseVisualStyleBackColor = false;
			// 
			// btnActivity
			// 
			this.btnActivity.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnActivity.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActivity.ForeColor = System.Drawing.SystemColors.Window;
			this.btnActivity.Image = ((System.Drawing.Image)(resources.GetObject("btnActivity.Image")));
			this.btnActivity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnActivity.Location = new System.Drawing.Point(0, 264);
			this.btnActivity.Name = "btnActivity";
			this.btnActivity.Size = new System.Drawing.Size(191, 40);
			this.btnActivity.TabIndex = 16;
			this.btnActivity.Text = "Activity Log";
			this.btnActivity.UseVisualStyleBackColor = false;
			// 
			// UserControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnActivity);
			this.Controls.Add(this.btnNutrient);
			this.Controls.Add(this.btnMealLog);
			this.Controls.Add(this.btnUserProfile);
			this.Controls.Add(this.btnLogout);
			this.Name = "UserControl1";
			this.Size = new System.Drawing.Size(191, 410);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Button btnUserProfile;
		private System.Windows.Forms.Button btnMealLog;
		private System.Windows.Forms.Button btnNutrient;
		private System.Windows.Forms.Button btnActivity;
	}
}
