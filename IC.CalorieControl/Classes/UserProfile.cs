using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.CalorieControl.Classes
{
	public class UserProfile
	{
		public int UserId { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public string PasswordHash { get; set; }
		public int Age { get; set; }
		public string Gender { get; set; }
		public decimal HeightCm { get; set; }
		public decimal WeightKg { get; set; }
		public short ActivityLevel { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
	}
	public class LoginSession
	{
		public int SessionId { get; set; }
		public int UserId { get; set; }
		public DateTime LoginTime { get; set; }
		public string IpAddress { get; set; }
	}
}
