using IC.CalorieControl.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.CalorieControl.Interfaces
{
	public interface IMealLogRepository
	{
		void AddMealLog(MealLog log);
		List<MealLog> GetMealLogs(int userId, DateTime date);
		DailyNutritionSummary GetDailySummary(int userId, DateTime date);
		void DeleteMealLog(int logId);
	}
}
