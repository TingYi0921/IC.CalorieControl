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
	public class FoodRepository : IFoodRepository
	{
		private readonly string connectionString;

		public FoodRepository(string connectionString)
		{
			this.connectionString = connectionString;
		}
		public void AddFoodItem(FoodItem item)
		{
			string sql = @"INSERT INTO FoodItem (Name, Calories, WeightGrams, Carbohydrates, Protein, Fat, UserId, CreatedAt, UpdatedAt)
                       VALUES (@Name, @Calories, @WeightGrams, @Carbohydrates, @Protein, @Fat, @UserId, @CreatedAt, @UpdatedAt)";
			using (var conn = new SqlConnection(connectionString))
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Name", item.Name);
					cmd.Parameters.AddWithValue("@Calories", item.Calories);
					cmd.Parameters.AddWithValue("@WeightGrams", item.WeightGrams);
					cmd.Parameters.AddWithValue("@Carbohydrates", item.Carbohydrates);
					cmd.Parameters.AddWithValue("@Protein", item.Protein);
					cmd.Parameters.AddWithValue("@Fat", item.Fat);
					cmd.Parameters.AddWithValue("@UserId", item.UserId);
					cmd.Parameters.AddWithValue("@CreatedAt", item.CreatedAt);
					cmd.Parameters.AddWithValue("@UpdatedAt", item.UpdatedAt);
					cmd.ExecuteNonQuery();
				}
			}
		}
		public List<FoodItem> GetUserFoodItems(int userId)
		{
			var list = new List<FoodItem>();
			string sql = "SELECT * FROM FoodItem WHERE UserId IS NULL OR UserId = @UserId";
			using (var conn = new SqlConnection(connectionString))
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@UserId", userId);
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
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@FoodId", foodId);
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
