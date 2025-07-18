using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.CalorieControl.Classes
{
	public class ActivityLevel
	{
		public int ActivityLevelId { get; set; }
		public string LevelName { get; set; }
		public int CaloriesPerHour { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
	}
}
