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
	public class MealLogRepository : IMealLogRepository
	{
		private readonly string connectionString;

		public MealLogRepository(string connectionString)
		{
			this.connectionString = connectionString;
		}

		public void AddMealLog(MealLog log)
		{
			string sql = @"INSERT INTO MealLog (UserId, LogTime, FoodId, Quantity, CreatedAt, UpdatedAt)
                       VALUES (@UserId, @LogTime, @FoodId, @Quantity, @CreatedAt, @UpdatedAt)";
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@UserId", log.UserId);
					cmd.Parameters.AddWithValue("@LogTime", log.LogTime);
					cmd.Parameters.AddWithValue("@FoodId", log.FoodId);
					cmd.Parameters.AddWithValue("@Quantity", log.Quantity);
					cmd.Parameters.AddWithValue("@CreatedAt", log.CreatedAt);
					cmd.Parameters.AddWithValue("@UpdatedAt", log.UpdatedAt);
					cmd.ExecuteNonQuery();
				}
			}
		}
		public List<MealLog> GetMealLogs(int userId, DateTime date)
		{
			var list = new List<MealLog>();
			string sql = @"SELECT * FROM MealLog WHERE UserId = @UserId AND CAST(LogTime AS DATE) = @Date";
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@UserId", userId);
					cmd.Parameters.AddWithValue("@Date", date);
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							list.Add(new MealLog
							{
								LogId = Convert.ToInt32(reader["LogId"]),
								UserId = Convert.ToInt32(reader["UserId"]),
								LogTime = Convert.ToDateTime(reader["LogTime"]),
								FoodId = Convert.ToInt32(reader["FoodId"]),
								Quantity = Convert.ToDecimal(reader["Quantity"]),
								CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
								UpdatedAt = Convert.ToDateTime(reader["UpdatedAt"])
							});
						}
						return list;
					}
				}
			}
		}
		public DailyNutritionSummary GetDailySummary(int userId, DateTime date)
		{
			var summary = new DailyNutritionSummary();

			string sql = @"
        SELECT 
            ISNULL(SUM(ml.Quantity * fi.Calories / fi.WeightGrams), 0)    AS TotalCalories,
            ISNULL(SUM(ml.Quantity * fi.Carbohydrates / fi.WeightGrams), 0) AS TotalCarbohydrates,
            ISNULL(SUM(ml.Quantity * fi.Protein / fi.WeightGrams), 0)     AS TotalProtein,
            ISNULL(SUM(ml.Quantity * fi.Fat / fi.WeightGrams), 0)         AS TotalFat
        FROM MealLog ml
        LEFT JOIN FoodItem fi ON ml.FoodId = fi.FoodId
        WHERE ml.UserId = @UserId
          AND CAST(ml.LogTime AS DATE) = @LogDate;
    ";

			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@UserId", userId);
				cmd.Parameters.AddWithValue("@LogDate", date.Date);
				conn.Open();
				using (var reader = cmd.ExecuteReader())
				{
					if (reader.Read())
					{
						summary.TotalCalories = reader.GetDecimal(reader.GetOrdinal("TotalCalories"));
						summary.TotalCarbohydrates = reader.GetDecimal(reader.GetOrdinal("TotalCarbohydrates"));
						summary.TotalProtein = reader.GetDecimal(reader.GetOrdinal("TotalProtein"));
						summary.TotalFat = reader.GetDecimal(reader.GetOrdinal("TotalFat"));
					}
				}
			}
			return summary;
		}
		public void DeleteMealLog(int logId)
		{
			string sql = "DELETE FROM MealLog WHERE LogId = @LogId";
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@LogId", logId);
					cmd.ExecuteNonQuery();
				}
			}
		}
	}
}
