using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.CalorieControl.Classes
{
	public class ActivityLog
	{
		public int ActivityLogId { get; set; }
		public int UserId { get; set; }
		public int ActivityLevelId { get; set; }
		public decimal DurationHours { get; set; }
		public int CaloriesBurned { get; set; }
		public DateTime ActivityDate { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
		public virtual ActivityLevel ActivityLevel { get; set; }
	}
}
