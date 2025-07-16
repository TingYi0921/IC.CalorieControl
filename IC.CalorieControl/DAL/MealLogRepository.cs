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
			using (var conn = new SqlConnection(connectionString))
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
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
			using (var conn = new SqlConnection(connectionString))
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
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
			string sql = @"
            SELECT SUM(f.Calories * m.Quantity / f.WeightGrams) AS TotalCalories,
                   SUM(f.Carbohydrates * m.Quantity / f.WeightGrams) AS TotalCarbohydrates,
                   SUM(f.Protein * m.Quantity / f.WeightGrams) AS TotalProtein,
                   SUM(f.Fat * m.Quantity / f.WeightGrams) AS TotalFat
            FROM MealLog m
            JOIN FoodItem f ON m.FoodId = f.FoodId
            WHERE m.UserId = @UserId AND CAST(m.LogTime AS DATE) = @Date";
			using (var conn = new SqlConnection(connectionString))
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@UserId", userId);
					cmd.Parameters.AddWithValue("@Date", date);
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							return new DailyNutritionSummary
							{
								TotalCalories = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0),
								TotalCarbohydrates = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1),
								TotalProtein = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
								TotalFat = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3)
							};
						}
						return new DailyNutritionSummary();
					}
				}
			}
		}
		public void DeleteMealLog(int logId)
		{
			string sql = "DELETE FROM MealLog WHERE LogId = @LogId";
			using (var conn = new SqlConnection(connectionString))
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@LogId", logId);
					cmd.ExecuteNonQuery();
				}
			}
		}
	}
}
