using IC.CalorieControl.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.CalorieControl.Interfaces
{
	public interface IFoodRepository
	{
		void AddFoodItem(FoodItem item);
		List<FoodItem> GetUserFoodItems(int userId);
		FoodItem GetFoodItemById(int foodId);
	}
}
