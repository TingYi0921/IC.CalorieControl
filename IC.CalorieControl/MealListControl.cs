using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IC.CalorieControl
{
	public partial class MealListControl : UserControl
	{
		public MealListControl()
		{
			InitializeComponent();
			dtpLogDate.ValueChanged += dtpLogDate_ValueChanged_1;
			btnDeleteLog.Click += btnDeleteLog_Click_1;
		}

		private void dtpLogDate_ValueChanged_1(object sender, EventArgs e)
		{
			// TODO: 重新載入資料表內容
		}

		private void btnDeleteLog_Click_1(object sender, EventArgs e)
		{
			// TODO: 刪除選取紀錄並重新整理表格
		}
	}
}
