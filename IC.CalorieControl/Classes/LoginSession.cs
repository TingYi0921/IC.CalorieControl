using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.CalorieControl.Classes
{
	public class LoginSession
	{
		public int SessionId { get; set; }
		public int UserId { get; set; }
		public DateTime LoginTime { get; set; }
		public string IpAddress { get; set; }
	}
}
