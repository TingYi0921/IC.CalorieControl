using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.CalorieControl.Classes
{
	public class MealLog
	{
		public int LogId { get; set; }
		public int UserId { get; set; }
		public DateTime LogTime { get; set; }
		public int FoodId { get; set; }
		public decimal Quantity { get; set; } // 幾克
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
	}
}
