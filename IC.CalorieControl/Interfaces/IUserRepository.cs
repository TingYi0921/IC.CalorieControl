using IC.CalorieControl.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.CalorieControl.Interfaces
{
	public interface IUserRepository
	{
		bool IsUserExists(string userName);
		void RegisterUser(UserProfile user);
		UserProfile GetUserByNameAndPassword(string userName, string password);
		UserProfile GetUserByUserName(string userName);
		UserProfile CloneUser(UserProfile user);
		void UpdateUserProfile(UserProfile user);
		void LogLoginSession(int userId, string ipAddress);
	}
}
