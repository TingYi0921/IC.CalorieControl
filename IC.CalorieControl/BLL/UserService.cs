using IC.CalorieControl.Classes;
using IC.CalorieControl.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IC.CalorieControl.BLL
{
	public class UserService
	{
		private UserDal userDal = new UserDal();
		public bool Register(UserProfile user, out string message)
		{
			if (!Regex.IsMatch(user.UserName, "^[a-zA-Z0-9]+$"))
			{
				message = "帳號只能包含英文字母與數字!";
				return false;
			}

			if (userDal.IsUserExists(user.UserName))
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

			if (user.Age < 0 || user.Age > 160 || user.Age %1 != 0)
			{
				message = "年齡須為正整數，請重新輸入!";
				return false;
			}

			if (user.HeightCm < 0.1m || user.HeightCm > 300 || user.HeightCm % 0.1m != 0)
			{
				message = "身高須為正數，請重新輸入!";
				return false;
			}

			if (user.WeightKg < 0.1m || user.WeightKg > 400 || user.WeightKg % 0.1m != 0)
			{
				message = "體重須為正數，請重新輸入!";
				return false;
			}

			userDal.RegisterUser(user);
			message = "註冊成功！";
			return true;
		}
		public UserProfile Login(string userName, string password)
        {
            if (!IsValidInput(userName) || !IsValidInput(password))
                return null;

            return userDal.GetUserByNameAndPassword(userName, password);
        }

        private bool IsValidInput(string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z0-9]+$");
        }

		public void RecordLogin(int userId, string ip)
		{
			userDal.LogLoginSession(userId, ip);
		}
	}
}
