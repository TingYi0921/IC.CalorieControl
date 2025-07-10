using IC.CalorieControl.Classes;
using IC.CalorieControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IC.CalorieControl.DAL
{
	public class UserDal : IUserRepository
	{
		private readonly string connectionString = "Data Source=DESKTOP-PAKSETB\\SQLEXPRESS;Initial Catalog=CalorieControlSystem;Integrated Security=True";

		public bool IsUserExists(string userName)
		{
			string query = "SELECT COUNT(*) FROM UserProfile WHERE UserName = @UserName";
			var conn = new SqlConnection(connectionString);
			var cmd = new SqlCommand(query, conn);
			cmd.Parameters.AddWithValue("@UserName", userName);
			conn.Open();
			return (int)cmd.ExecuteScalar() > 0;
		}

		public void RegisterUser(UserProfile user)
		{
			string query = @"INSERT INTO UserProfile (UserName, Email, PasswordHash, Age, Gender, HeightCm, WeightKg, ActivityLevel, CreatedAt, UpdatedAt)
                             VALUES (@UserName, @Email, @PasswordHash, @Age, @Gender, @HeightCm, @WeightKg, @ActivityLevel, @CreatedAt, @UpdatedAt)";
			var conn = new SqlConnection(connectionString);
			var cmd = new SqlCommand(query, conn);
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

		public UserProfile GetUserByNameAndPassword(string userName, string password)
		{
			string query = "SELECT UserId, UserName FROM UserProfile WHERE UserName = @UserName AND PasswordHash = @PasswordHash";
			var conn = new SqlConnection(connectionString);
			var cmd = new SqlCommand(query, conn);
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

		public void LogLoginSession(int userId, string ipAddress)
		{
			string query = @"INSERT INTO LoginSession (UserId, LoginTime, IpAddress) VALUES (@UserId, @LoginTime, @IpAddress)";
			var conn = new SqlConnection(connectionString);
			var cmd = new SqlCommand(query, conn);
			cmd.Parameters.AddWithValue("@UserId", userId);
			cmd.Parameters.AddWithValue("@LoginTime", DateTime.UtcNow);
			cmd.Parameters.AddWithValue("@IpAddress", ipAddress);
			conn.Open();
			cmd.ExecuteNonQuery();
		}

		private string ComputeSha256Hash(string rawData)
		{
			var sha256 = SHA256.Create();
			var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));
			return BitConverter.ToString(bytes).Replace("-", "").ToLower();
		}
	}
}
