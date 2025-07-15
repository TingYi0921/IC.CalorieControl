using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.CalorieControl.Classes
{
	public class FoodItem
	{
		public int FoodId { get; set; }
		public string Name { get; set; }
		public decimal Calories { get; set; }
		public decimal WeightGrams { get; set; }
		public decimal Carbohydrates { get; set; }
		public decimal Protein { get; set; }
		public decimal Fat { get; set; }
		public int? UserId { get; set; } // null 表示為全域預設食物，否則為個人自訂
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
	}
}
