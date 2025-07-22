CREATE TABLE dbo.UserProfile (
    UserId       INT IDENTITY(1,1) PRIMARY KEY,     -- 使用者ID，自動遞增
    UserName     NVARCHAR(100)   NOT NULL,          -- 使用者名稱
    Email        NVARCHAR(200)   NULL,              -- 電子郵件
    PasswordHash NVARCHAR(64)    NOT NULL,          -- 密碼雜湊（不可逆）
    Age          INT             NOT NULL,         -- 年齡
    Gender       VARCHAR(6)      NOT NULL,          -- 性別 'Male' 或 'Female'
    HeightCm     DECIMAL(5,2)    NOT NULL,          -- 身高 (公分)
    WeightKg     DECIMAL(5,2)    NOT NULL,          -- 體重 (公斤)
    ActivityLevel SMALLINT       NOT NULL,          -- 活動等級 (1~5)
    CreatedAt    DATETIME2       NOT NULL DEFAULT SYSUTCDATETIME(),
    UpdatedAt    DATETIME2       NOT NULL DEFAULT SYSUTCDATETIME()
);

CREATE TABLE LoginSession (
    SessionId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL,
    LoginTime DATETIME2 NOT NULL,
    IpAddress NVARCHAR(50) NULL
);
