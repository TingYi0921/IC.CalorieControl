ALTER TABLE dbo.MealLog
ADD 
    FoodName       NVARCHAR(100) NULL,
    FoodCalories   DECIMAL(18,2) NULL,
    FoodCarbs      DECIMAL(18,2) NULL,
    FoodProtein    DECIMAL(18,2) NULL,
    FoodFat        DECIMAL(18,2) NULL;