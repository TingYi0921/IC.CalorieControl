using IC.CalorieControl.Classes;
using IC.CalorieControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.CalorieControl.BLL
{
	public class ActivityService
	{
		private readonly IActivityRepository repo;
		public ActivityService(IActivityRepository repository) => repo = repository;

		// 取得強度清單
		public List<ActivityLevel> GetActivityLevels() => repo.GetActivityLevels();

		// 新增一筆活動，並計算消耗
		public bool AddActivityLog(ActivityLog log, out string message)
		{
			if (log.DurationHours <= 0)
			{
				message = "請輸入大於 0 的活動時數。";
				return false;
			}
			// 先找對應強度的 kcal/hr
			var level = repo.GetActivityLevels()
							.FirstOrDefault(l => l.ActivityLevelId == log.ActivityLevelId);
			if (level == null)
			{
				message = "請選擇有效的活動強度。";
				return false;
			}
			// 計算消耗
			log.CaloriesBurned = (int)(level.CaloriesPerHour * log.DurationHours);
			repo.AddActivityLog(log);
			message = "活動已記錄。";
			return true;
		}

		// 讀該日所有活動
		public List<ActivityLog> GetActivityLogs(int userId, DateTime date) =>
			repo.GetActivityLogsByDate(userId, date);

		// 該日活動總消耗
		public int GetDailyActivityCalories(int userId, DateTime date) =>
			repo.GetDailyActivityCalories(userId, date);

		// 計算 BMR
		public double CalculateBMR(UserProfile user)
		{
			if (user.Gender == "Male")
				return 10 * (double)user.WeightKg
					 + 6.25 * (double)user.HeightCm
					 - 5 * user.Age
					 + 5;
			else
				return 10 * (double)user.WeightKg
					 + 6.25 * (double)user.HeightCm
					 - 5 * user.Age
					 - 161;
		}

		// 該日總消耗 = BMR + 活動消耗
		public double GetDailyTotalCaloriesBurned(UserProfile user, DateTime date)
		{
			double bmr = CalculateBMR(user);
			int act = GetDailyActivityCalories(user.UserId, date);
			return bmr + act;
		}
	}
}
