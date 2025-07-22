CREATE TABLE FoodItem (
    FoodId INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Calories DECIMAL(10,2) NOT NULL,
    WeightGrams DECIMAL(10,2) NOT NULL,
    Carbohydrates DECIMAL(10,2) NOT NULL,
    Protein DECIMAL(10,2) NOT NULL,
    Fat DECIMAL(10,2) NOT NULL,
    UserId INT NULL,
    CreatedAt DATETIME NOT NULL,
    UpdatedAt DATETIME NOT NULL
);

CREATE TABLE MealLog (
    LogId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL,
    LogTime DATETIME NOT NULL,
    FoodId INT NOT NULL,
    Quantity DECIMAL(10,2) NOT NULL,
    CreatedAt DATETIME NOT NULL,
    UpdatedAt DATETIME NOT NULL
);