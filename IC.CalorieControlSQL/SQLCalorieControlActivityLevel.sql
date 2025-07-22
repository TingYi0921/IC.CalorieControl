-- 紀錄各強度每小時消耗
CREATE TABLE dbo.ActivityLevel (
    ActivityLevelId   INT    IDENTITY(1,1) PRIMARY KEY,
    LevelName         NVARCHAR(50) NOT NULL,    -- 低強度／正常強度…
    CaloriesPerHour   INT    NOT NULL,           -- 220／300／…
    CreatedAt         DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    UpdatedAt         DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME()
);

-- 使用者活動日誌
CREATE TABLE dbo.ActivityLog (
    ActivityLogId     INT    IDENTITY(1,1) PRIMARY KEY,
    UserId            INT    NOT NULL,           -- FK → UserProfile(UserId)
    ActivityLevelId   INT    NOT NULL,           -- FK → ActivityLevel
    DurationHours     DECIMAL(5,2) NOT NULL,     -- 小時數，可小數
    CaloriesBurned    INT    NOT NULL,           -- 系統計算：CaloriesPerHour * DurationHours
    ActivityDate      DATE   NOT NULL,           -- 活動發生日期
    CreatedAt         DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    UpdatedAt         DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    CONSTRAINT FK_ActivityLog_User FOREIGN KEY (UserId)          REFERENCES dbo.UserProfile(UserId),
    CONSTRAINT FK_ActivityLog_Level FOREIGN KEY (ActivityLevelId) REFERENCES dbo.ActivityLevel(ActivityLevelId)
);
