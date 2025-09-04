- 系統設計理念

- 三層式架構流程圖（以文字描述）

- 詳細安裝/建置步驟

- 使用範例（流程操作）

- 開發規範與程式結構

- 貢獻與授權

# 🍱 Calorie Control System (WinForms 三層式架構)

### Calorie Control System 是一個以 C# WinForms 搭配 SQL Server 開發的桌面應用程式，幫助使用者進行 飲食紀錄、熱量追蹤與活動消耗管理。系統採用 三層式架構 (UI / BLL / DAL)，強調 程式邏輯分層、資料安全 (密碼雜湊)、擴充性。

## 🎯 設計理念

### 易用性：提供直覺化 UI，讓使用者能快速輸入餐點與活動。

### 模組化：功能以 UserControl 模組化，可在主介面 Panel 中自由切換。

### 擴充性：支援 RESTful API / Docker，方便後續與行動裝置或 Web 前端整合。

### 資料安全：使用者密碼以 SHA256 雜湊儲存，並具備登入 Session 管理。

## 🏗️ 系統架構

- UI層 (WinForms)   LoginForm, RegisterForm, ResetPasswordForm, MainForm, UserProfileControl, MealInputControl, MealListControl, DailySummaryControl, ActivityLogControl
 
- BLL層 (Business Logic Layer)   UserService, MealService, ActivityService

- DAL層 (Data Access Layer)    UserRepository, FoodRepository, MealLogRepository, ActivityRepository

- SQL Server Database   UserProfile, FoodItem, MealLog, ActivityLog, ActivityLevel, LoginSession

## ⚙️ 技術棧
- 程式語言：C# (.NET Framework 4.8)

- 前端介面：Windows Forms (WinForms)

- 資料存取：ADO.NET + Entity Framework (LINQ)

- 資料庫：SQL Server

- 版本控制：GitHub

- 其他工具：ChartControl

## 📌 功能模組
## 🔑 使用者管理

- 註冊 / 登入 / 登出

- 忘記密碼（重設密碼表單）

- Session 管理

- 個人檔案管理（年齡、性別、身高、體重、活動程度）

- 密碼以 SHA256 雜湊儲存

## 🍴 餐點管理

- MealInputControl

  手動輸入食物（名稱、熱量、碳水、蛋白質、脂肪）

  儲存為「常用食物」或僅單次紀錄

  可選擇日期新增紀錄

- MealListControl

  以 DataGridView 顯示當日餐點

  可刪除紀錄

- DailySummaryControl

  彙總每日攝取熱量、碳水、蛋白質、脂肪

  同時計算「常用食物」與「手動輸入」

## 🏃 活動管理

- ActivityLogControl

  - 記錄每日運動（時數 + 強度）

  - 自動計算活動消耗熱量

  - 計算基礎代謝率 (BMR)：

    - 男性：(10 × 體重) + (6.25 × 身高) - (5 × 年齡) + 5

    - 女性：(10 × 體重) + (6.25 × 身高) - (5 × 年齡) - 161

  - 當日總消耗 = BMR + 活動消耗

  - 折線圖顯示一週總消耗趨勢

  ## 🗄️ 資料表設計

  ### UserProfile
  
| 欄位           | 型別           | 描述     |
| ------------- | ------------- | --------- |
| UserId        | int (PK)      | 使用者ID  |
| UserName      | nvarchar(16)  | 帳號      |
| Email         | nvarchar(200) | 電子郵件  |
| PasswordHash  | nvarchar(64)  | 雜湊密碼  |
| Age           | int           | 年齡      |
| Gender        | nvarchar(6)   | 性別      |
| HeightCm      | decimal(5,2)  | 身高      |
| WeightKg      | decimal(5,2)  | 體重      |
| ActivityLevel | smallint      | 活動強度  |
| CreatedAt     | datetime      | 建立時間  |
| UpdatedAt     | datetime      | 更新時間  |

  ### FoodItem

| 欄位           | 型別           | 描述     |
| ------------- | -------------- | --------- |
| FoodId        | int (PK)       | 食物ID    |
| Name          | nvarchar(100)  | 食物名稱  |
| Calories      | decimal(10, 2) | 卡路里    |
| WeightGrams   | decimal(10, 2) | 重量      |
| Carbohydrates | decimal(10, 2) | 碳水化合物 |
| Protein       | decimal(10, 2) | 蛋白質    |
| Fat           | decimal(10,2)  | 脂肪      |
| UserId        | int            | 使用者ID  |
| CreatedAt     | datetime       | 建立時間  |
| UpdatedAt     | datetime       | 更新時間  |

  ### MealLog

| 欄位           | 型別            | 描述      |
| ------------- | --------------- | --------- |
| LogId         | int (PK)        | 紀錄ID    |
| UserId        | int             | 使用者ID  |
| FoodId        | int             | 食物ID    |
| Quantity      | decimal(10, 2)  | 數量      |
| LogTime       | datetime        | 紀錄時間  |
| FoodName      | nvarchar(100)   | 食物名稱  |
| FoodCalories  | decimal(18, 2)  | 食物卡路里|
| FoodCarbs     | decimal(18, 2)  | 食物碳水  |
| FoodProtein   | decimal(18, 2)  | 食物蛋白質|
| FoodFat       | decimal(18, 2)  | 食物脂肪  |
| CreatedAt     | datetime        | 建立時間  |
| UpdatedAt     | datetime        | 更新時間  |

  ### ActivityLevel

| 欄位            | 型別             | 描述      |
| --------------- | --------------- | --------- |
| ActivityLevelId | int (PK)        | 紀錄ID    |
| LevelName       | nvarchar(50)    | 使用者ID  |
| CaloriesPerHour | int             | 食物ID    |
| CreatedAt       | datetime        | 建立時間  |
| UpdatedAt       | datetime        | 更新時間  |

  ### ActivityLog

| 欄位             | 型別            | 描述      |
| --------------- | --------------- | --------- |
| LogId           | int (PK)        | 紀錄ID    |
| UserId          | int             | 使用者ID  |
| ActivityLevelId | int             | 食物ID    |
| DurationHours   | decimal(5, 2)   | 持續時間  |
| CaloriesBurned  | int             | 燃燒卡路里|
| ActivityDate    | date            | 活動日期  |
| CreatedAt       | datetime        | 建立時間  |
| UpdatedAt       | datetime        | 更新時間  |

  ### LoginSession

| 欄位         | 型別            | 描述      |
| ----------- | --------------- | --------- |
| SessionId   | int (PK)        | 識別ID    |
| UserId      | int             | 使用者ID  |
| LoginTime   | datetime2(7)    | 登入時間  |
| IPAddress   | nvarchar(50)    | IP位址    |

## 🚀 安裝與使用
### 1️⃣ 環境需求

- Visual Studio 2022

- .NET Framework 4.8

- SQL Server 2019+

### 2️⃣ 安裝步驟
#### 1. Clone 專案
git clone https://github.com/your-repo/calorie-control-system.git

#### 2. 開啟解決方案
cd calorie-control-system
CalorieControlSystem.sln

#### 3. 建立資料庫
使用 SQL Server Management Studio 執行 /scripts/schema.sql

#### 4. 更新連線字串
修改 App.config 裡的 connectionString

#### 5. 執行專案
F5 Run

### 3️⃣ 使用流程

1. 開啟應用程式 → 首次需「註冊」帳號

2. 登入後進入 MainForm，可在左側清單切換功能模組
   
  - User Profile → 更新個人資料

  - Meal Log → 新增餐點 / 瀏覽紀錄

  - Daily Log → 查看每日統計

  - Activity Log → 新增運動 / 查看一週消耗

## 📊 範例畫面

- 登入/註冊頁面：提供新帳號註冊與雜湊密碼登入

- 餐點輸入：TextBox + ComboBox 選擇常用食物

- 每日統計：Label 顯示總熱量與營養素

- 活動消耗：ChartControl 折線圖顯示一週趨勢

## 🧑‍💻 開發規範

- 採 三層式架構，UI 不包含商業邏輯

- 資料存取統一經由 Repository (DAL)

- 所有輸入需驗證（帳號/密碼/Email 格式、年齡/身高/體重範圍檢查）

- Commit 流程遵守 Git Flow：feature/、bugfix/、release/ 分支

## 🤝 貢獻

- 歡迎透過 Fork & PR 提交新功能或修正。

## 📄 授權

- 本專案採用 MIT License，可自由使用、修改與發佈。
