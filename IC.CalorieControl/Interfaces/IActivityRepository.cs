using IC.CalorieControl.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.CalorieControl.Interfaces
{
	public interface IActivityRepository
	{
		List<ActivityLevel> GetActivityLevels();
		void AddActivityLog(ActivityLog log);
		List<ActivityLog> GetActivityLogsByDate(int userId, DateTime date);
		int GetDailyActivityCalories(int userId, DateTime date);
	}
}
