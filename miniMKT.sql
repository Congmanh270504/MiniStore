USE [master]
GO
/****** Object:  Database [miniMKT]    Script Date: 15/12/2024 8:23:18 PM ******/
CREATE DATABASE [miniMKT]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'miniMKT', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\miniMKT.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'miniMKT_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\miniMKT_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [miniMKT] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [miniMKT].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [miniMKT] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [miniMKT] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [miniMKT] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [miniMKT] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [miniMKT] SET ARITHABORT OFF 
GO
ALTER DATABASE [miniMKT] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [miniMKT] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [miniMKT] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [miniMKT] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [miniMKT] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [miniMKT] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [miniMKT] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [miniMKT] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [miniMKT] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [miniMKT] SET  ENABLE_BROKER 
GO
ALTER DATABASE [miniMKT] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [miniMKT] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [miniMKT] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [miniMKT] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [miniMKT] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [miniMKT] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [miniMKT] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [miniMKT] SET RECOVERY FULL 
GO
ALTER DATABASE [miniMKT] SET  MULTI_USER 
GO
ALTER DATABASE [miniMKT] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [miniMKT] SET DB_CHAINING OFF 
GO
ALTER DATABASE [miniMKT] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [miniMKT] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [miniMKT] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [miniMKT] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'miniMKT', N'ON'
GO
ALTER DATABASE [miniMKT] SET QUERY_STORE = ON
GO
ALTER DATABASE [miniMKT] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [miniMKT]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 15/12/2024 8:23:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[OrderDate] [datetime] NULL,
	[TotalAmount] [int] NOT NULL,
	[PaymentMethod] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[OrderDates]    Script Date: 15/12/2024 8:23:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[OrderDates] AS
SELECT DISTINCT
    MONTH(OrderDate) AS OrderMonth,      -- Tháng
    YEAR(OrderDate) AS OrderYear 
	
FROM Orders;
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 15/12/2024 8:23:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderDetailID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[MonthlyOrderSummary]    Script Date: 15/12/2024 8:23:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE VIEW [dbo].[MonthlyOrderSummary] AS
SELECT  
    MONTH(O.OrderDate) AS OrderMonth, 
    YEAR(O.OrderDate) AS OrderYear, 
    SUM(OD.Quantity) AS TotalQuantity -- Tổng số lượng sản phẩm
FROM  
    Orders O
JOIN  
    OrderDetails OD ON O.OrderID = OD.OrderID
GROUP BY  
    YEAR(O.OrderDate), MONTH(O.OrderDate);
GO
/****** Object:  View [dbo].[TotalRevenue]    Script Date: 15/12/2024 8:23:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[TotalRevenue] AS
SELECT  
    MONTH(O.OrderDate) AS OrderMonth, 
    YEAR(O.OrderDate) AS OrderYear, 
    SUM(O.TotalAmount) AS TotalRevenue
FROM  
    Orders O , OrderDetails OD
GROUP BY  
    YEAR(O.OrderDate), MONTH(O.OrderDate)
GO
/****** Object:  View [dbo].[TotalQuantity]    Script Date: 15/12/2024 8:23:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE VIEW [dbo].[TotalQuantity] AS
SELECT  
    MONTH(O.OrderDate) AS OrderMonth, 
    YEAR(O.OrderDate) AS OrderYear, 
    SUM(OD.Quantity) AS TotalQuantity -- Tổng số lượng sản phẩm
FROM  
    Orders O
JOIN  
    OrderDetails OD ON O.OrderID = OD.OrderID
GROUP BY  
    YEAR(O.OrderDate), MONTH(O.OrderDate);
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 15/12/2024 8:23:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 15/12/2024 8:23:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](100) NOT NULL,
	[Phone] [varchar](15) NULL,
	[Email] [varchar](100) NULL,
	[CustomerRank] [nvarchar](15) NULL,
	[CustomerSuppAddress] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 15/12/2024 8:23:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [nvarchar](100) NOT NULL,
	[Position] [nvarchar](50) NULL,
	[Phone] [varchar](15) NULL,
	[Email] [varchar](100) NULL,
	[EmployPassword] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 15/12/2024 8:23:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](100) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[SupplierID] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[StockQuantity] [int] NOT NULL,
	[Unit] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 15/12/2024 8:23:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierName] [nvarchar](100) NOT NULL,
	[ContactName] [nvarchar](100) NULL,
	[Phone] [varchar](15) NULL,
	[Email] [varchar](100) NULL,
	[SuppAddress] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (1, N'Đồ uống')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (2, N'Bánh kẹo')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (3, N'Hàng gia dụng')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (4, N'Sản phẩm từ sữa')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (5, N'Trái cây & Rau củ')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Phone], [Email], [CustomerRank], [CustomerSuppAddress]) VALUES (1, N'Nguyễn Văn Hoàng', N'0909876543', N'hoangnguyen@gmail.com', N'Bạc', N'12 Nguyễn Trãi, Hà Nội')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Phone], [Email], [CustomerRank], [CustomerSuppAddress]) VALUES (2, N'Trần Thị Lan Anh', N'0932123456', N'lananhtran@gmail.com', N'Vàng', N'45 Hai Bà Trưng, TP Hồ Chí Minh')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Phone], [Email], [CustomerRank], [CustomerSuppAddress]) VALUES (3, N'Lê Văn Nam', N'0987123456', N'namle@gmail.com', N'Bạch kim', N'78 Phạm Văn Đồng, Ðà Nẵng')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Phone], [Email], [CustomerRank], [CustomerSuppAddress]) VALUES (4, N'Đỗ Thị Thu Hà', N'0918765432', N'hathu@gmail.com', N'Bạc', N'89 Lý Thuờng Kiệt, Hà Nội')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Phone], [Email], [CustomerRank], [CustomerSuppAddress]) VALUES (5, N'Nguyễn Thị Hoa', N'0923456789', N'hoanguyen@gmail.com', N'Vàng', N'101 Phan Chu Trinh, TP Hồ Chí Minh')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Phone], [Email], [CustomerRank], [CustomerSuppAddress]) VALUES (6, N'Phạm Văn Tài', N'0909988776', N'taipham@gmail.com', N'Bạch kim', N'12 Võ Văn Kiệt, Ðà Nẵng')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Phone], [Email], [CustomerRank], [CustomerSuppAddress]) VALUES (7, N'Võ Thị Hồng', N'0912233445', N'hongvo@gmail.com', N'Bạc', N'45 Lê Thánh Tôn, Hà Nội')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Phone], [Email], [CustomerRank], [CustomerSuppAddress]) VALUES (8, N'Trần Quốc Bảo', N'0921234567', N'baotran@gmail.com', N'Vàng', N'23 Nguyễn Hữu Cảnh, TP Hồ Chí Minh')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Phone], [Email], [CustomerRank], [CustomerSuppAddress]) VALUES (9, N'Nguyễn Thị Lan', N'0908776655', N'lannguyen@gmail.com', N'Bạch kim', N'67 Bùi Viện, TP Hồ Chí Minh')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Phone], [Email], [CustomerRank], [CustomerSuppAddress]) VALUES (10, N'Phan Văn Tú', N'0933221100', N'tuphan@gmail.com', N'Vàng', N'78 Trần Hưng Ðạo, Ðà Nẵng')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Phone], [Email], [CustomerRank], [CustomerSuppAddress]) VALUES (11, N'Phan Tấn Trung', N'0935544100', N'brbkol1989@gmail.com', N'Bạc', N'19 Trường Chinh, TP Hồ Chí Minh')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Phone], [Email], [CustomerRank], [CustomerSuppAddress]) VALUES (12, N'Trương Tuấn Tú', N'0846221100', N'senahihi@gmail.com', N'Bạch kim', N'20 Lâm Đồng, Đà Lạt')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Phone], [Email], [CustomerRank], [CustomerSuppAddress]) VALUES (13, N'Vĩ Phạm', N'0733221100', N'kitz@gmail.com', N'Bạch kim', N'15 Lưu Chí Hiển, Vũng Tàu')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Phone], [Email], [CustomerRank], [CustomerSuppAddress]) VALUES (14, N'Trương Anh Tuấn', N'0933227534', N'atuann@gmail.com', N'Vàng', N'88 Trường Chinh, Tây Ninh')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Phone], [Email], [CustomerRank], [CustomerSuppAddress]) VALUES (15, N'Phạm Minh Lộc', N'0753221100', N'mlocunban@gmail.com', N'Bạc', N'75 Lê Bảo Lộc, Đà Nẵng')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Phone], [Email], [CustomerRank], [CustomerSuppAddress]) VALUES (16, N'Lê Minh Huy', N'0933221129', N'mhuy@gmail.com', N'Đồng', N'20 Nguyễn Huệ, TP Hồ Chí Minh')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Phone], [Email], [CustomerRank], [CustomerSuppAddress]) VALUES (17, N'Kim Chung Cúc', N'0933254600', N'jkook@gmail.com', N'Bạch kim', N'10 Kim Đồng, Hà Nội')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Phone], [Email], [CustomerRank], [CustomerSuppAddress]) VALUES (18, N'Đào Tuấn Duy', N'0908221100', N'duydao@gmail.com', N'Vàng', N'44 Lê Lợi, Hà Nội')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Phone], [Email], [CustomerRank], [CustomerSuppAddress]) VALUES (19, N'Phạm Kim Yến', N'0533221107', N'kyen11@gmail.com', N'Đồng', N'25 Nguyễn Ảnh Thủ, TP Hồ Chí Minh')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Phone], [Email], [CustomerRank], [CustomerSuppAddress]) VALUES (20, N'Dương Tấn Quý', N'0955221100', N'quyzz@gmail.com', N'Vàng', N'12 Nguyễn Đồng, Hà Nội')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Phone], [Email], [CustomerRank], [CustomerSuppAddress]) VALUES (21, N'aaaa', N'0912345678', N'aa@gmail.com', NULL, N'fdasfasdfdsa')
INSERT [dbo].[Customers] ([CustomerID], [CustomerName], [Phone], [Email], [CustomerRank], [CustomerSuppAddress]) VALUES (22, N'bbbb', N'0912345677', N'bb@gmail.com', NULL, N'dfasdfasdf')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([EmployeeID], [EmployeeName], [Position], [Phone], [Email], [EmployPassword]) VALUES (1, N'Trần Công Mạnh', N'Quản lý cửa hàng', N'0901234567', N'congmanh@gmail.com', N'12345')
INSERT [dbo].[Employees] ([EmployeeID], [EmployeeName], [Position], [Phone], [Email], [EmployPassword]) VALUES (2, N'Phạm Thị Hằng', N'Thu ngân', N'0912345678', N'hangpham@gmail.com', N'password456')
INSERT [dbo].[Employees] ([EmployeeID], [EmployeeName], [Position], [Phone], [Email], [EmployPassword]) VALUES (3, N'Lê Văn Minh', N'Nhân viên kho', N'0938765432', N'minhle@gmail.com', N'password789')
INSERT [dbo].[Employees] ([EmployeeID], [EmployeeName], [Position], [Phone], [Email], [EmployPassword]) VALUES (4, N'Nguyễn Thị Mai', N'Nhân viên bán hàng', N'0945432123', N'mainguyen@gmail.com', N'password321')
INSERT [dbo].[Employees] ([EmployeeID], [EmployeeName], [Position], [Phone], [Email], [EmployPassword]) VALUES (5, N'Hoàng Văn An', N'Nhân viên bán hàng', N'0976543210', N'hoangan@gmail.com', N'password654')
INSERT [dbo].[Employees] ([EmployeeID], [EmployeeName], [Position], [Phone], [Email], [EmployPassword]) VALUES (6, N'Ngô Thị Hương', N'Nhân viên bán hàng', N'0967894321', N'huongngo@gmail.com', N'password987')
INSERT [dbo].[Employees] ([EmployeeID], [EmployeeName], [Position], [Phone], [Email], [EmployPassword]) VALUES (7, N'Phan Minh Tâm', N'Nhân viên kho', N'0954321789', N'tamphan@gmail.com', N'password123')
INSERT [dbo].[Employees] ([EmployeeID], [EmployeeName], [Position], [Phone], [Email], [EmployPassword]) VALUES (8, N'Trần Thị Lan', N'Nhân viên bán hàng', N'0987654321', N'lantran@gmail.com', N'password456')
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetails] ON 

INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (1, 1, 1, 2, 1250)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (2, 1, 2, 1, 2000)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (3, 1, 3, 1, 8500)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (4, 2, 4, 3, 3000)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (5, 2, 5, 2, 1000)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (6, 3, 6, 1, 1500)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (7, 3, 7, 2, 2500)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (8, 4, 8, 5, 4500)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (9, 4, 9, 10, 800)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (10, 5, 10, 4, 2200)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (11, 5, 1, 3, 1250)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (12, 6, 2, 5, 2000)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (13, 6, 3, 1, 8500)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (14, 7, 4, 4, 3000)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (15, 7, 5, 6, 1000)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (16, 8, 6, 3, 1500)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (17, 8, 7, 2, 2500)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (18, 9, 8, 7, 4500)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (19, 9, 9, 12, 800)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (20, 10, 10, 5, 2200)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (21, 15, 30, 5, 2500)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (22, 28, 18, 6, 8000)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (23, 22, 17, 8, 15000)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (24, 14, 11, 15, 35500)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (25, 11, 25, 9, 47500)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (26, 29, 14, 11, 58900)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (27, 30, 25, 17, 66600)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (28, 17, 9, 8, 12400)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (29, 12, 7, 12, 74500)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity], [Price]) VALUES (30, 26, 8, 29, 22200)
SET IDENTITY_INSERT [dbo].[OrderDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (1, 1, 1, CAST(N'2024-10-25T20:46:46.753' AS DateTime), 12350, N'Tiền mặt')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (2, 2, 2, CAST(N'2023-12-18T20:46:46.753' AS DateTime), 10230, N'Thẻ')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (3, 3, 1, CAST(N'2023-07-14T20:46:46.753' AS DateTime), 5850, N'Tiền mặt')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (4, 4, 3, CAST(N'2024-11-22T20:46:46.753' AS DateTime), 28975, N'Chuyển khoản')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (5, 5, 4, CAST(N'2023-08-20T20:46:46.753' AS DateTime), 11671, N'Thẻ')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (6, 6, 2, CAST(N'2023-10-26T20:46:46.753' AS DateTime), 16650, N'Tiền mặt')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (7, 7, 1, CAST(N'2023-07-13T20:46:46.753' AS DateTime), 17100, N'Thẻ')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (8, 8, 3, CAST(N'2024-10-14T20:46:46.753' AS DateTime), 8835, N'Tiền mặt')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (9, 9, 4, CAST(N'2024-02-22T20:46:46.753' AS DateTime), 36990, N'Chuyển khoản')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (10, 10, 2, CAST(N'2023-11-14T20:46:46.753' AS DateTime), 10230, N'Tiền mặt')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (11, 11, 2, CAST(N'2024-08-25T20:46:46.753' AS DateTime), 406125, N'Thẻ')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (12, 12, 4, CAST(N'2024-04-22T20:46:46.753' AS DateTime), 804600, N'Chuyển khoản')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (13, 13, 3, CAST(N'2024-05-16T20:46:46.753' AS DateTime), 79000, N'Tiền mặt')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (14, 14, 1, CAST(N'2023-06-19T20:46:46.753' AS DateTime), 495225, N'Chuyển khoản')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (15, 15, 1, CAST(N'2023-11-25T20:46:46.753' AS DateTime), 11875, N'Tiền mặt')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (16, 16, 4, CAST(N'2024-07-22T20:46:46.753' AS DateTime), 22000, N'Chuyển khoản')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (17, 17, 2, CAST(N'2024-11-27T20:46:46.753' AS DateTime), 89280, N'Thẻ')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (18, 18, 3, CAST(N'2024-10-16T20:46:46.753' AS DateTime), 78000, N'Chuyển khoản')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (19, 19, 2, CAST(N'2023-09-25T20:46:46.753' AS DateTime), 99000, N'Tiền mặt')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (20, 20, 1, CAST(N'2023-01-13T20:46:46.753' AS DateTime), 146000, N'Thẻ')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (21, 20, 4, CAST(N'2024-07-25T20:46:46.753' AS DateTime), 89000, N'Tiền mặt')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (22, 15, 3, CAST(N'2024-11-17T20:46:46.753' AS DateTime), 114000, N'Chuyển khoản')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (23, 17, 1, CAST(N'2023-12-08T20:46:46.753' AS DateTime), 20000, N'Thẻ')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (24, 18, 2, CAST(N'2024-08-25T20:46:46.753' AS DateTime), 55000, N'Thẻ')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (25, 8, 3, CAST(N'2024-05-09T20:46:46.753' AS DateTime), 89000, N'Tiền mặt')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (26, 7, 4, CAST(N'2023-12-25T20:46:46.753' AS DateTime), 611610, N'Thẻ')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (27, 11, 1, CAST(N'2024-11-12T20:46:46.753' AS DateTime), 444000, N'Chuyển khoản')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (28, 12, 2, CAST(N'2024-10-25T20:46:46.753' AS DateTime), 43200, N'Thẻ')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (29, 7, 4, CAST(N'2024-06-17T20:46:46.753' AS DateTime), 615505, N'Tiền mặt')
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [EmployeeID], [OrderDate], [TotalAmount], [PaymentMethod]) VALUES (30, 15, 1, CAST(N'2023-07-19T20:46:46.753' AS DateTime), 1075590, N'Chuyển khoản')
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (1, N'Nước ngọt Coca-Cola 1.5L', 1, 1, 12500, 100, N'Chai')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (2, N'Bánh Snack Lays Classic', 2, 1, 20000, 150, N'Gói')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (3, N'Bột giặt OMO 3kg', 3, 2, 85000, 75, N'Túi')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (4, N'Sữa tươi Vinamilk 1L', 4, 3, 30000, 200, N'Chai')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (5, N'Chuối', 5, 3, 10000, 250, N'Kg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (6, N'Nước cam Twister 1L', 1, 1, 15000, 80, N'Chai')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (7, N'Kem đánh răng P/S 200g', 3, 2, 25000, 120, N'Tuýp')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (8, N'Táo Mỹ', 5, 3, 45000, 180, N'Kg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (9, N'Sữa chua Vinamilk', 4, 4, 8000, 300, N'Hộp')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (10, N'Bánh quy Oreo', 2, 1, 22000, 130, N'Gói')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (11, N'Xà Lách Tươi', 5, 3, 82000, 15, N'Kg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (12, N'Pepsi Không Calo', 1, 5, 40000, 50, N'Chai')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (13, N'Bơ Sữa Long Thành', 4, 7, 75000, 100, N'Hộp')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (14, N'Ghế Lười', 3, 2, 299000, 5, N'Cái')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (15, N'Táo Tươi Úc', 5, 8, 125000, 150, N'Gói')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (16, N'Kẹo Nho Khô', 2, 6, 22000, 15, N'Gói')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (17, N'Muỗng Nhựa Inox', 3, 2, 52000, 8, N'Cái')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (18, N'Rau Mồng Tơi', 5, 6, 12000, 150, N'Kg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (19, N'Nước 7 UP', 1, 5, 8000, 275, N'Chai')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (20, N'Thao Sứ Thanh Hoa', 3, 2, 245000, 125, N'Cái')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (21, N'Kẹo dẻo dâu', 2, 8, 15000, 88, N'Gói')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (22, N'Nước Khoáng Lavie', 1, 3, 15000, 100, N'Chai')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (23, N'Dâu tươi Đà Lạt', 5, 6, 275000, 25, N'Kg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (24, N'Mận Hà Nội', 5, 6, 125000, 50, N'Kg')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (25, N'Bàn gỗ', 3, 1, 500000, 10, N'Cái')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (26, N'Nước Hoa', 3, 2, 234000, 80, N'Hộp')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (27, N'Nước nhỏ mắt', 3, 2, 50000, 155, N'Chai')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (28, N'Bánh quy Oreo', 2, 8, 25000, 60, N'Gói')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (29, N'Nước cam Mirinda', 1, 3, 15000, 100, N'Chai')
INSERT [dbo].[Products] ([ProductID], [ProductName], [CategoryID], [SupplierID], [Price], [StockQuantity], [Unit]) VALUES (30, N'Nước ngọt Fanta', 1, 3, 15000, 20, N'Chai')
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Suppliers] ON 

INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [ContactName], [Phone], [Email], [SuppAddress]) VALUES (1, N'Công ty TNHH Ngọc Minh', N'Lê Thị Minh', N'0912345678', N'leminh@ngocminh.com', N'123 Lê Duẩn, Hà Nội')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [ContactName], [Phone], [Email], [SuppAddress]) VALUES (2, N'Công ty Phương Nam', N'Trần Quốc Phương', N'0938765432', N'phuongnam@phuongnam.com', N'456 Võ Thị Sáu, TP Hồ Chí Minh')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [ContactName], [Phone], [Email], [SuppAddress]) VALUES (3, N'VietFresh Foods', N'Nguyễn Thị Lan', N'0987654321', N'lannguyen@vietfresh.com', N'789 Trần Phú, Ðà Nẵng')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [ContactName], [Phone], [Email], [SuppAddress]) VALUES (4, N'Công ty Sữa Việt Nam', N'Phạm Văn Hoàng', N'0909988776', N'hoangpham@vinamilk.com', N'321 Hoàng Văn Thụ, TP Hồ Chí Minh')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [ContactName], [Phone], [Email], [SuppAddress]) VALUES (5, N'Công ty TNHH Ngôi Sao', N'Dương Trịnh Đào', N'0902988756', N'daotrinh@star.com', N'12 Phố Bắc, Hà Nội')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [ContactName], [Phone], [Email], [SuppAddress]) VALUES (6, N'Công ty TNHH Clean Food', N'Nguyễn Văn Thọ', N'0911988776', N'thognn@cleanf.com', N'10 Nguyễn Ảnh Thủ, TP Hồ Chí Minh')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [ContactName], [Phone], [Email], [SuppAddress]) VALUES (7, N'Công ty Sữa Bò Sạch', N'Võ Thị Thu', N'0709988776', N'vtthu@bosach.com', N'18 Nguyễn Huệ, Huế')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName], [ContactName], [Phone], [Email], [SuppAddress]) VALUES (8, N'Công ty TNHH Đồ Ăn Tươi', N'Nguyễn Thị Bế', N'0456988776', N'ngthibe@freshfood.com', N'15A Trường Chinh, Tiền Giang')
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
USE [master]
GO
ALTER DATABASE [miniMKT] SET  READ_WRITE 
GO
