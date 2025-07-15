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
	public partial class DailySummaryControl : UserControl
	{
		public DailySummaryControl()
		{
			InitializeComponent();
		}
		public void LoadSummary(int userId, DateTime date)
		{
			// TODO: 從 BLL 抓取統計資訊並顯示於 Label
		}
	}
}
