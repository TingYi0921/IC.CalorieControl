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
			const string sql = @"
INSERT INTO MealLog
    (UserId, FoodId, LogTime, Quantity, CreatedAt, UpdatedAt,
     FoodName, FoodCalories, FoodCarbs, FoodProtein, FoodFat)
VALUES
    (@UserId, @FoodId, @LogTime, @Qty, @CreatedAt, @UpdatedAt,
     @FoodName, @FoodCalories, @FoodCarbs, @FoodProtein, @FoodFat)";
			using (var conn = new SqlConnection(connectionString))
			using (var cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@UserId", log.UserId);
				cmd.Parameters.AddWithValue("@FoodId", log.FoodId);
				cmd.Parameters.AddWithValue("@LogTime", log.LogTime);
				cmd.Parameters.AddWithValue("@Qty", log.Quantity);
				cmd.Parameters.AddWithValue("@CreatedAt", log.CreatedAt);
				cmd.Parameters.AddWithValue("@UpdatedAt", log.UpdatedAt);

				// 只有手動輸入時才傳入這些值，否則都給 DBNull
				cmd.Parameters.AddWithValue("@FoodName", (object)log.FoodName ?? DBNull.Value);
				cmd.Parameters.AddWithValue("@FoodCalories", (object)log.FoodCalories ?? DBNull.Value);
				cmd.Parameters.AddWithValue("@FoodCarbs", (object)log.FoodCarbs ?? DBNull.Value);
				cmd.Parameters.AddWithValue("@FoodProtein", (object)log.FoodProtein ?? DBNull.Value);
				cmd.Parameters.AddWithValue("@FoodFat", (object)log.FoodFat ?? DBNull.Value);

				conn.Open();
				cmd.ExecuteNonQuery();
			}
		}
		public List<MealLog> GetMealLogs(int userId, DateTime date)
		{
			var list = new List<MealLog>();

			// 明確列出所有欄位，包括手動輸入新加的五個欄位
			string sql = @"SELECT LogId, UserId, FoodId, Quantity, LogTime, CreatedAt, UpdatedAt, FoodName,
						FoodCalories, FoodCarbs, FoodProtein, FoodFat
						FROM MealLog
						WHERE UserId = @UserId AND CAST(LogTime AS DATE) = @Date
						ORDER BY LogTime";

			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@UserId", userId);
				cmd.Parameters.AddWithValue("@Date", date.Date);
				conn.Open();

				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						list.Add(new MealLog
						{
							LogId = reader.GetInt32(reader.GetOrdinal("LogId")),
							UserId = reader.GetInt32(reader.GetOrdinal("UserId")),
							FoodId = reader.GetInt32(reader.GetOrdinal("FoodId")),
							Quantity = reader.GetDecimal(reader.GetOrdinal("Quantity")),
							LogTime = reader.GetDateTime(reader.GetOrdinal("LogTime")),
							CreatedAt = reader.GetDateTime(reader.GetOrdinal("CreatedAt")),
							UpdatedAt = reader.GetDateTime(reader.GetOrdinal("UpdatedAt")),

							// 下面這五個屬性，要跟你 MealLog class 裡對應的 Nullable 屬性名稱一致
							FoodName = reader.IsDBNull(reader.GetOrdinal("FoodName"))
											 ? null
											 : reader.GetString(reader.GetOrdinal("FoodName")),
							FoodCalories = reader.IsDBNull(reader.GetOrdinal("FoodCalories"))
								? (decimal?)null
								: reader.GetDecimal(reader.GetOrdinal("FoodCalories")),
							FoodCarbs = reader.IsDBNull(reader.GetOrdinal("FoodCarbs"))
								? (decimal?)null
								: reader.GetDecimal(reader.GetOrdinal("FoodCarbs")),
							FoodProtein = reader.IsDBNull(reader.GetOrdinal("FoodProtein"))
								? (decimal?)null
								: reader.GetDecimal(reader.GetOrdinal("FoodProtein")),
							FoodFat = reader.IsDBNull(reader.GetOrdinal("FoodFat"))
								? (decimal?)null
								: reader.GetDecimal(reader.GetOrdinal("FoodFat")),
						});
					}
				}
			}
			return list;
		}
		public DailyNutritionSummary GetDailySummary(int userId, DateTime date)
		{
			var summary = new DailyNutritionSummary();

			const string sql = @"
								SELECT 
								  ISNULL(SUM(
									CASE 
									  WHEN ml.FoodId > 0 
									  THEN ml.Quantity * fi.Calories / fi.WeightGrams 
									  ELSE ml.FoodCalories 
									END
								  ), 0) AS TotalCalories,
								  ISNULL(SUM(
									CASE 
									  WHEN ml.FoodId > 0 
									  THEN ml.Quantity * fi.Carbohydrates / fi.WeightGrams 
									  ELSE ml.FoodCarbs 
									END
								  ), 0) AS TotalCarbohydrates,
								  ISNULL(SUM(
									CASE 
									  WHEN ml.FoodId > 0 
									  THEN ml.Quantity * fi.Protein / fi.WeightGrams 
									  ELSE ml.FoodProtein 
									END
								  ), 0) AS TotalProtein,
								  ISNULL(SUM(
									CASE 
									  WHEN ml.FoodId > 0 
									  THEN ml.Quantity * fi.Fat / fi.WeightGrams 
									  ELSE ml.FoodFat 
									END
								  ), 0) AS TotalFat
								FROM dbo.MealLog ml
								LEFT JOIN dbo.FoodItem fi ON ml.FoodId = fi.FoodId
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
					return summary;
				}
			}
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
