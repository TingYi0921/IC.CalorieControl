using IC.CalorieControl.Classes;
using IC.CalorieControl.DAL;
using IC.CalorieControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IC.CalorieControl.BLL
{
	public class UserService
	{
		private readonly IUserRepository userRepository;
		public UserService(IUserRepository userRepository)
		{
			this.userRepository = userRepository;
		}

		public bool Register(UserProfile user, out string message)
		{
			if (!Regex.IsMatch(user.UserName, "^[a-zA-Z0-9]+$"))
			{
				message = "帳號只能包含英文字母與數字!";
				return false;
			}

			if (userRepository.IsUserExists(user.UserName))
			{
				message = "該使用者名稱已存在!";
				return false;
			}

			if (!Regex.IsMatch(user.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
			{
				message = "電子郵件格式錯誤!";
				return false;
			}

			if (!Regex.IsMatch(user.PasswordHash, "^[a-zA-Z0-9]+$"))
			{
				message = "密碼只能包含英文字母與數字!";
				return false;
			}

			if (user.Age < 0 || user.Age > 150 || user.Age %1 != 0)
			{
				message = "年齡數值不合理，請重新輸入!";
				return false;
			}

			if (user.HeightCm < 10 || user.HeightCm > 300 || user.HeightCm % 0.1m != 0)
			{
				message = "身高數值不合理，請重新輸入!";
				return false;
			}

			if (user.WeightKg < 1 || user.WeightKg > 350 || user.WeightKg % 0.1m != 0)
			{
				message = "體重數值不合理，請重新輸入!";
				return false;
			}

			userRepository.RegisterUser(user);
			message = "註冊成功！";
			return true;
		}
		public UserProfile Login(string userName, string password)
        {
            if (!IsValidInput(userName) || !IsValidInput(password))
                return null;

            return userRepository.GetUserByNameAndPassword(userName, password);
        }

		public bool UpdateUserProfile(UserProfile user, out string message)
		{
			if (!Regex.IsMatch(user.UserName, "^[a-zA-Z0-9]+$"))
			{
				message = "帳號只能包含英文字母與數字!";
				return false;
			}

			if (!Regex.IsMatch(user.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
			{
				message = "電子郵件格式錯誤!";
				return false;
			}

			if (user.Age < 0 || user.Age > 160 || user.Age % 1 != 0)
			{
				message = "年齡數值不合理，請重新輸入!";
				return false;
			}

			if (user.HeightCm < 0.1m || user.HeightCm > 300 || user.HeightCm % 0.1m != 0)
			{
				message = "身高數值不合理，請重新輸入!";
				return false;
			}

			if (user.WeightKg < 0.1m || user.WeightKg > 400 || user.WeightKg % 0.1m != 0)
			{
				message = "體重數值不合理，請重新輸入!";
				return false;
			}

			userRepository.UpdateUserProfile(user);
			message = "使用者資料更新成功。";
			return true;
		}
		public UserProfile GetUserByUserName(string userName)
		{
			return userRepository.GetUserByUserName(userName);
		}
		public string GetCurrentUserPassword(string userName)
		{
			return userRepository.GetCurrentUserPassword(userName);
		}
		public UserProfile CloneUser(UserProfile user)
		{
			return userRepository.CloneUser(user);
		}

		private bool IsValidInput(string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z0-9]+$");
        }

		public void RecordLogin(int userId, string ip)
		{
			userRepository.LogLoginSession(userId, ip);
		}
	}
}
