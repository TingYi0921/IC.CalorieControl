using IC.CalorieControl.Classes;
using IC.CalorieControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.CalorieControl.DAL
{
	public class ActivityRepository : IActivityRepository
	{
		private readonly string connStr;
		public ActivityRepository(string connectionString) => connStr = connectionString;

		public List<ActivityLevel> GetActivityLevels()
		{
			var list = new List<ActivityLevel>();
			string sql = "SELECT ActivityLevelId, LevelName, CaloriesPerHour FROM ActivityLevel";
			using (var conn = new SqlConnection(connStr))
			using (var cmd = new SqlCommand(sql, conn))
			{
				conn.Open();
				using (var rd = cmd.ExecuteReader())
				{
					while (rd.Read())
						list.Add(new ActivityLevel
						{
							ActivityLevelId = rd.GetInt32(0),
							LevelName = rd.GetString(1),
							CaloriesPerHour = rd.GetInt32(2)
						});
				}
			}
			return list;
		}

		public void AddActivityLog(ActivityLog log)
		{
			string sql = @"
            INSERT INTO ActivityLog
              (UserId, ActivityLevelId, DurationHours, CaloriesBurned, ActivityDate, CreatedAt, UpdatedAt)
            VALUES
              (@UserId, @LevelId, @Duration, @Burned, @Date, SYSUTCDATETIME(), SYSUTCDATETIME())";
			using (var conn = new SqlConnection(connStr))
			using (var cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@UserId", log.UserId);
				cmd.Parameters.AddWithValue("@LevelId", log.ActivityLevelId);
				cmd.Parameters.AddWithValue("@Duration", log.DurationHours);
				cmd.Parameters.AddWithValue("@Burned", log.CaloriesBurned);
				cmd.Parameters.AddWithValue("@Date", log.ActivityDate);
				conn.Open();
				cmd.ExecuteNonQuery();
			}
		}

		public List<ActivityLog> GetActivityLogsByDate(int userId, DateTime date)
		{
			var list = new List<ActivityLog>();
			string sql = @"
            SELECT al.ActivityLogId, al.UserId, al.ActivityLevelId, al.DurationHours, al.CaloriesBurned, al.ActivityDate
            FROM ActivityLog al
            WHERE al.UserId = @UserId AND al.ActivityDate = @Date
            ORDER BY al.ActivityLogId";
			using (var conn = new SqlConnection(connStr))
			using (var cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@UserId", userId);
				cmd.Parameters.AddWithValue("@Date", date.Date);
				conn.Open();
				using (var rd = cmd.ExecuteReader())
				{
					while (rd.Read())
						list.Add(new ActivityLog
						{
							ActivityLogId = rd.GetInt32(0),
							UserId = rd.GetInt32(1),
							ActivityLevelId = rd.GetInt32(2),
							DurationHours = rd.GetDecimal(3),
							CaloriesBurned = rd.GetInt32(4),
							ActivityDate = rd.GetDateTime(5)
						});
				}
			}
			return list;
		}

		public int GetDailyActivityCalories(int userId, DateTime date)
		{
			string sql = @"
            SELECT ISNULL(SUM(CaloriesBurned),0) FROM ActivityLog
            WHERE UserId = @UserId AND ActivityDate = @Date";
			using (var conn = new SqlConnection(connStr))
			using (var cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@UserId", userId);
				cmd.Parameters.AddWithValue("@Date", date.Date);
				conn.Open();
				return (int)cmd.ExecuteScalar();
			}
		}
	}
}
