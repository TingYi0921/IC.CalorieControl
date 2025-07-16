using IC.CalorieControl.Classes;
using IC.CalorieControl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.CalorieControl.BLL
{
	public class MealService
	{
		private readonly IFoodRepository _foodRepo;
		private readonly IMealLogRepository _logRepo;
		private readonly int _currentUserId = SessionManager.CurrentUserId;

		public MealService(IFoodRepository foodRepo, IMealLogRepository logRepo)
		{
			this._foodRepo = foodRepo;
			this._logRepo = logRepo;
		}

		/// <summary>
		/// 新增食物項目，供收藏常用食物
		/// </summary>
		public bool AddFoodItem(FoodItem item, out string message)
		{
			if (string.IsNullOrWhiteSpace(item.Name))
			{
				message = "食物名稱不可為空。";
				return false;
			}
			if (item.Calories <= 0 || item.WeightGrams <= 0)
			{
				message = "熱量與份量必須大於 0。";
				return false;
			}
			if (item.Carbohydrates < 0 || item.Protein < 0 || item.Fat < 0)
			{
				message = "營養素數值不可為負。";
				return false;
			}
			_foodRepo.AddFoodItem(item);
			message = "食物已加入收藏。";
			return true;
		}

		/// <summary>
		/// 取得指定使用者的所有食物項目（含系統預設）
		/// </summary>
		public List<FoodItem> GetUserFoodItems(int userId)
		{
			return _foodRepo.GetUserFoodItems(userId);
		}

		/// <summary>
		/// 依編號取得單一食物
		/// </summary>
		public FoodItem GetFoodItemById(int foodId)
		{
			return _foodRepo.GetFoodItemById(foodId);
		}

		/// <summary>
		/// 新增餐點日誌
		/// </summary>
		public bool AddMealLog(MealLog log, out string message)
		{
			if (log.Quantity <= 0)
			{
				message = "食用份量必須大於 0。";
				return false;
			}
			_logRepo.AddMealLog(log);
			message = "餐點已紀錄。";
			return true;
		}

		/// <summary>
		/// 依日期取得餐點日誌
		/// </summary>
		public List<MealLog> GetLogsByDate(int userId, DateTime date)
		{
			return _logRepo.GetMealLogs(userId, date);
		}

		/// <summary>
		/// 刪除指定日誌
		/// </summary>
		public bool DeleteMealLog(int logId, out string message)
		{
			if (logId <= 0)
			{
				message = "無效的紀錄編號。";
				return false;
			}
			_logRepo.DeleteMealLog(logId);
			message = "餐點紀錄已刪除。";
			return true;
		}

		/// <summary>
		/// 取得每日營養攝取總結
		/// </summary>
		public DailyNutritionSummary GetDailySummary(int userId, DateTime date)
		{
			return _logRepo.GetDailySummary(userId, date.Date);
		}
	}

}
