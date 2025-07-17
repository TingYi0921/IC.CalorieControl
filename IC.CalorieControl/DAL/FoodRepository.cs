using IC.CalorieControl.Classes;
using IC.CalorieControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.CalorieControl.DAL
{
	public class FoodRepository : IFoodRepository
	{
		private readonly string connectionString;

		public FoodRepository(string connectionString)
		{
			this.connectionString = connectionString;
		}
		public void AddFoodItem(FoodItem item)
		{
			string sql = @"
                INSERT INTO FoodItem 
                    (Name, Calories, WeightGrams, Carbohydrates, Protein, Fat, UserId, CreatedAt, UpdatedAt)
                VALUES 
                    (@Name, @Calories, @WeightGrams, @Carbohydrates, @Protein, @Fat, @UserId, @CreatedAt, @UpdatedAt);
                SELECT CAST(SCOPE_IDENTITY() AS int);";

			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@Name", item.Name);
				cmd.Parameters.AddWithValue("@Calories", item.Calories);
				cmd.Parameters.AddWithValue("@WeightGrams", item.WeightGrams);
				cmd.Parameters.AddWithValue("@Carbohydrates", item.Carbohydrates);
				cmd.Parameters.AddWithValue("@Protein", item.Protein);
				cmd.Parameters.AddWithValue("@Fat", item.Fat);
				cmd.Parameters.AddWithValue(
					"@UserId",
					item.UserId.HasValue ? (object)item.UserId.Value : DBNull.Value
				);
				cmd.Parameters.AddWithValue("@CreatedAt", item.CreatedAt);
				cmd.Parameters.AddWithValue("@UpdatedAt", item.UpdatedAt);

				conn.Open();
				object result = cmd.ExecuteScalar();
				if (result != null && int.TryParse(result.ToString(), out int newId))
				{
					item.FoodId = newId;
				}
				conn.Close();
			}
		}
		public List<FoodItem> GetUserFoodItems(int userId)
		{
			var list = new List<FoodItem>();
			string sql = "SELECT * FROM FoodItem WHERE UserId IS NULL OR UserId = @UserId";
			using (var conn = new SqlConnection(connectionString))
			{
				using (var cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@UserId", userId);
					conn.Open();
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							list.Add(new FoodItem
							{
								FoodId = Convert.ToInt32(reader["FoodId"]),
								Name = reader["Name"].ToString(),
								Calories = Convert.ToDecimal(reader["Calories"]),
								WeightGrams = Convert.ToDecimal(reader["WeightGrams"]),
								Carbohydrates = Convert.ToDecimal(reader["Carbohydrates"]),
								Protein = Convert.ToDecimal(reader["Protein"]),
								Fat = Convert.ToDecimal(reader["Fat"]),
								UserId = reader["UserId"] == DBNull.Value ? null : (int?)Convert.ToInt32(reader["UserId"]),
								CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
								UpdatedAt = Convert.ToDateTime(reader["UpdatedAt"])
							});
						}
						return list;
					}
				}
			}
		}
		public FoodItem GetFoodItemById(int foodId)
		{
			string sql = "SELECT * FROM FoodItem WHERE FoodId = @FoodId";
			using (var conn = new SqlConnection(connectionString))
			{
				using (var cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@FoodId", foodId);
					conn.Open();
					using (var reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							return new FoodItem
							{
								FoodId = Convert.ToInt32(reader["FoodId"]),
								Name = reader["Name"].ToString(),
								Calories = Convert.ToDecimal(reader["Calories"]),
								WeightGrams = Convert.ToDecimal(reader["WeightGrams"]),
								Carbohydrates = Convert.ToDecimal(reader["Carbohydrates"]),
								Protein = Convert.ToDecimal(reader["Protein"]),
								Fat = Convert.ToDecimal(reader["Fat"]),
								UserId = reader["UserId"] == DBNull.Value ? null : (int?)Convert.ToInt32(reader["UserId"]),
								CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
								UpdatedAt = Convert.ToDateTime(reader["UpdatedAt"])
							};
						}
						return null;
					}
				}
			}
		}
	}
}
