using IC.CalorieControl.Classes;
using IC.CalorieControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IC.CalorieControl.DAL
{
	public class UserDal : IUserRepository
	{
		private readonly string connectionString = "Data Source=DESKTOP-PAKSETB\\SQLEXPRESS;Initial Catalog=CalorieControlSystem;Integrated Security=True";

		public bool IsUserExists(string userName)
		{
			string query = "SELECT COUNT(*) FROM UserProfile WHERE UserName = @UserName";
			using (var conn = new SqlConnection(connectionString))
			using (var cmd = new SqlCommand(query, conn))
			{
				cmd.Parameters.AddWithValue("@UserName", userName);
				conn.Open();
				return (int)cmd.ExecuteScalar() > 0;
			}
		}

		public void RegisterUser(UserProfile user)
		{
			string query = @"INSERT INTO UserProfile (UserName, Email, PasswordHash, Age, Gender, HeightCm, WeightKg, ActivityLevel, CreatedAt, UpdatedAt)
                             VALUES (@UserName, @Email, @PasswordHash, @Age, @Gender, @HeightCm, @WeightKg, @ActivityLevel, @CreatedAt, @UpdatedAt)";
			using (var conn = new SqlConnection(connectionString))
			using (var cmd = new SqlCommand(query, conn))
			{
				cmd.Parameters.AddWithValue("@UserName", user.UserName);
				cmd.Parameters.AddWithValue("@Email", user.Email);
				cmd.Parameters.AddWithValue("@PasswordHash", ComputeSha256Hash(user.PasswordHash));
				cmd.Parameters.AddWithValue("@Age", user.Age);
				cmd.Parameters.AddWithValue("@Gender", user.Gender);
				cmd.Parameters.AddWithValue("@HeightCm", user.HeightCm);
				cmd.Parameters.AddWithValue("@WeightKg", user.WeightKg);
				cmd.Parameters.AddWithValue("@ActivityLevel", user.ActivityLevel);
				cmd.Parameters.AddWithValue("@CreatedAt", user.CreatedAt);
				cmd.Parameters.AddWithValue("@UpdatedAt", user.UpdatedAt);
				conn.Open();
				cmd.ExecuteNonQuery();
			}
		}

		public UserProfile GetUserByNameAndPassword(string userName, string password)
		{
			string query = "SELECT UserId, UserName FROM UserProfile WHERE UserName = @UserName AND PasswordHash = @PasswordHash";
			using (var conn = new SqlConnection(connectionString))
			using (var cmd = new SqlCommand(query, conn))
			{
				cmd.Parameters.AddWithValue("@UserName", userName);
				cmd.Parameters.AddWithValue("@PasswordHash", ComputeSha256Hash(password));
				conn.Open();
				var reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					return new UserProfile
					{
						UserId = reader.GetInt32(0),
						UserName = reader.GetString(1)
					};
				}
				return null;
			}	
		}

		public void LogLoginSession(int userId, string ipAddress)
		{
			string query = @"INSERT INTO LoginSession (UserId, LoginTime, IpAddress) VALUES (@UserId, @LoginTime, @IpAddress)";
			using (var conn = new SqlConnection(connectionString))
			using (var cmd = new SqlCommand(query, conn))
			{
				cmd.Parameters.AddWithValue("@UserId", userId);
				cmd.Parameters.AddWithValue("@LoginTime", DateTime.UtcNow);
				cmd.Parameters.AddWithValue("@IpAddress", ipAddress);
				conn.Open();
				cmd.ExecuteNonQuery();
			}
		}

		private string ComputeSha256Hash(string rawData)
		{
			var sha256 = SHA256.Create();
			var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));
			return BitConverter.ToString(bytes).Replace("-", "").ToLower();
		}

		public UserProfile GetUserByUserName(string userName)
		{
			string query = "SELECT * FROM UserProfile WHERE UserName = @UserName";
			using (var conn = new SqlConnection(connectionString))
			using (var cmd = new SqlCommand(query, conn))
			{
				cmd.Parameters.AddWithValue("@UserName", userName);
				conn.Open();
				var reader = cmd.ExecuteReader();
				if (reader.Read())
				{
					return new UserProfile
					{
						UserId = Convert.ToInt32(reader["UserId"]),
						UserName = reader["UserName"].ToString(),
						Email = reader["Email"].ToString(),
						Age = Convert.ToInt32(reader["Age"]),
						Gender = reader["Gender"].ToString(),
						HeightCm = Convert.ToDecimal(reader["HeightCm"]),
						WeightKg = Convert.ToDecimal(reader["WeightKg"]),
						ActivityLevel = Convert.ToInt16(reader["ActivityLevel"]),
						CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
						UpdatedAt = Convert.ToDateTime(reader["UpdatedAt"])
					};
				}
				return null;
			}
		}

		public UserProfile CloneUser(UserProfile user)
		{
			return new UserProfile
			{
				UserId = user.UserId,
				UserName = user.UserName,
				Email = user.Email,
				PasswordHash = user.PasswordHash,
				Age = user.Age,
				Gender = user.Gender,
				HeightCm = user.HeightCm,
				WeightKg = user.WeightKg,
				ActivityLevel = user.ActivityLevel,
				CreatedAt = user.CreatedAt,
				UpdatedAt = user.UpdatedAt
			};
		}

		public void UpdateUserProfile(UserProfile user)
		{
			string query = @"UPDATE UserProfile SET UserName = @UserName, Email = @Email, Age = @Age, Gender = @Gender, HeightCm = @HeightCm, WeightKg = @WeightKg, ActivityLevel = @ActivityLevel, UpdatedAt = @UpdatedAt WHERE UserId = @UserId";
			using (var conn = new SqlConnection(connectionString))
			using (var cmd = new SqlCommand(query, conn))
			{
				cmd.Parameters.AddWithValue("@UserName", user.UserName);
				cmd.Parameters.AddWithValue("@Email", user.Email);
				//cmd.Parameters.AddWithValue("@PasswordHash", ComputeSha256Hash(user.PasswordHash));
				cmd.Parameters.AddWithValue("@Age", user.Age);
				cmd.Parameters.AddWithValue("@Gender", user.Gender);
				cmd.Parameters.AddWithValue("@HeightCm", user.HeightCm);
				cmd.Parameters.AddWithValue("@WeightKg", user.WeightKg);
				cmd.Parameters.AddWithValue("@ActivityLevel", user.ActivityLevel);
				cmd.Parameters.AddWithValue("@UpdatedAt", user.UpdatedAt);
				cmd.Parameters.AddWithValue("@UserId", user.UserId);
				conn.Open();
				int rowsAffected = cmd.ExecuteNonQuery();
				MessageBox.Show($"資料庫更新筆數：{rowsAffected}");
			}
		}
		public string GetCurrentUserPassword(string userName)
		{
			string query = @"
                SELECT PasswordHash
                FROM UserProfile
                WHERE UserName = @UserName";

			using (var conn = new SqlConnection(connectionString))
			using (var cmd = new SqlCommand(query, conn))
			{
				cmd.Parameters.AddWithValue("@UserName", userName);
				conn.Open();
				var result = cmd.ExecuteScalar();
				return result?.ToString();
			}
		}
	}
}
