using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.CalorieControl.Classes
{
	public static class SessionManager
	{
		/// <summary>
		/// 登入時由 LoginForm 設定
		/// </summary>
		public static int CurrentUserId { get; set; }

		/// <summary>
		/// 登入時由 LoginForm 設定
		/// </summary>
		public static string CurrentUserName { get; set; }
	}
}
