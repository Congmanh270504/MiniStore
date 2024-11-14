CREATE DATABASE miniMKT;
GO
----------------------------------------------------------------------------------------------------------------------------------------
USE miniMKT;
GO
----------------------------------------------------------------------------------------------------------------------------------------
-- Bảng Categories
CREATE TABLE Categories 
(
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(100) NOT NULL
);
GO
----------------------------------------------------------------------------------------------------------------------------------------
SET IDENTITY_INSERT Categories ON 
INSERT Categories (CategoryID, CategoryName) VALUES (1, N'Đồ uống')
INSERT Categories (CategoryID, CategoryName) VALUES (2, N'Bánh kẹo')
INSERT Categories (CategoryID, CategoryName) VALUES (3, N'Hàng gia dụng')
INSERT Categories (CategoryID, CategoryName) VALUES (4, N'Sản phẩm từ sữa')
INSERT Categories (CategoryID, CategoryName) VALUES (5, N'Trái cây & Rau củ')
SET IDENTITY_INSERT Categories OFF
GO
----------------------------------------------------------------------------------------------------------------------------------------
-- Bảng Customers
CREATE TABLE Customers 
(
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    CustomerName NVARCHAR(100) NOT NULL,
    Phone VARCHAR(15) NULL,
    Email VARCHAR(100) NULL,
    CustomerRank NVARCHAR(15) NULL,
    CustomerSuppAddress NVARCHAR(255) NULL
);
GO
----------------------------------------------------------------------------------------------------------------------------------------
SET IDENTITY_INSERT Customers ON 
INSERT Customers (CustomerID, CustomerName, Phone, Email, CustomerRank, CustomerSuppAddress) VALUES (1, N'Nguyễn Văn Hoàng', N'0909876543', N'hoangnguyen@gmail.com', N'Bạc', N'12 Nguyễn Trãi, Hà Nội')
INSERT Customers (CustomerID, CustomerName, Phone, Email, CustomerRank, CustomerSuppAddress) VALUES (2, N'Trần Thị Lan Anh', N'0932123456', N'lananhtran@gmail.com', N'Vàng', N'45 Hai Bà Trưng, TP Hồ Chí Minh')
INSERT Customers (CustomerID, CustomerName, Phone, Email, CustomerRank, CustomerSuppAddress) VALUES (3, N'Lê Văn Nam', N'0987123456', N'namle@gmail.com', N'Bạch kim', N'78 Phạm Văn Đồng, Ðà Nẵng')
INSERT Customers (CustomerID, CustomerName, Phone, Email, CustomerRank, CustomerSuppAddress) VALUES (4, N'Đỗ Thị Thu Hà', N'0918765432', N'hathu@gmail.com', N'Bạc', N'89 Lý Thuờng Kiệt, Hà Nội')
INSERT Customers (CustomerID, CustomerName, Phone, Email, CustomerRank, CustomerSuppAddress) VALUES (5, N'Nguyễn Thị Hoa', N'0923456789', N'hoanguyen@gmail.com', N'Vàng', N'101 Phan Chu Trinh, TP Hồ Chí Minh')
INSERT Customers (CustomerID, CustomerName, Phone, Email, CustomerRank, CustomerSuppAddress) VALUES (6, N'Phạm Văn Tài', N'0909988776', N'taipham@gmail.com', N'Bạch kim', N'12 Võ Văn Kiệt, Ðà Nẵng')
INSERT Customers (CustomerID, CustomerName, Phone, Email, CustomerRank, CustomerSuppAddress) VALUES (7, N'Võ Thị Hồng', N'0912233445', N'hongvo@gmail.com', N'Bạc', N'45 Lê Thánh Tôn, Hà Nội')
INSERT Customers (CustomerID, CustomerName, Phone, Email, CustomerRank, CustomerSuppAddress) VALUES (8, N'Trần Quốc Bảo', N'0921234567', N'baotran@gmail.com', N'Vàng', N'23 Nguyễn Hữu Cảnh, TP Hồ Chí Minh')
INSERT Customers (CustomerID, CustomerName, Phone, Email, CustomerRank, CustomerSuppAddress) VALUES (9, N'Nguyễn Thị Lan', N'0908776655', N'lannguyen@gmail.com', N'Bạch kim', N'67 Bùi Viện, TP Hồ Chí Minh')
INSERT Customers (CustomerID, CustomerName, Phone, Email, CustomerRank, CustomerSuppAddress) VALUES (10, N'Phan Văn Tú', N'0933221100', N'tuphan@gmail.com', N'Vàng', N'78 Trần Hưng Ðạo, Ðà Nẵng')
INSERT Customers (CustomerID, CustomerName, Phone, Email, CustomerRank, CustomerSuppAddress) VALUES (11, N'Phan Tấn Trung', N'0935544100', N'brbkol1989@gmail.com', N'Bạc', N'19 Trường Chinh, TP Hồ Chí Minh')
INSERT Customers (CustomerID, CustomerName, Phone, Email, CustomerRank, CustomerSuppAddress) VALUES (12, N'Trương Tuấn Tú', N'0846221100', N'senahihi@gmail.com', N'Bạch kim', N'20 Lâm Đồng, Đà Lạt')
INSERT Customers (CustomerID, CustomerName, Phone, Email, CustomerRank, CustomerSuppAddress) VALUES (13, N'Vĩ Phạm', N'0733221100', N'kitz@gmail.com', N'Bạch kim', N'15 Lưu Chí Hiển, Vũng Tàu')
INSERT Customers (CustomerID, CustomerName, Phone, Email, CustomerRank, CustomerSuppAddress) VALUES (14, N'Trương Anh Tuấn', N'0933227534', N'atuann@gmail.com', N'Vàng', N'88 Trường Chinh, Tây Ninh')
INSERT Customers (CustomerID, CustomerName, Phone, Email, CustomerRank, CustomerSuppAddress) VALUES (15, N'Phạm Minh Lộc', N'0753221100', N'mlocunban@gmail.com', N'Bạc', N'75 Lê Bảo Lộc, Đà Nẵng')
INSERT Customers (CustomerID, CustomerName, Phone, Email, CustomerRank, CustomerSuppAddress) VALUES (16, N'Lê Minh Huy', N'0933221129', N'mhuy@gmail.com', N'Đồng', N'20 Nguyễn Huệ, TP Hồ Chí Minh')
INSERT Customers (CustomerID, CustomerName, Phone, Email, CustomerRank, CustomerSuppAddress) VALUES (17, N'Kim Chung Cúc', N'0933254600', N'jkook@gmail.com', N'Bạch kim', N'10 Kim Đồng, Hà Nội')
INSERT Customers (CustomerID, CustomerName, Phone, Email, CustomerRank, CustomerSuppAddress) VALUES (18, N'Đào Tuấn Duy', N'0908221100', N'duydao@gmail.com', N'Vàng', N'44 Lê Lợi, Hà Nội')
INSERT Customers (CustomerID, CustomerName, Phone, Email, CustomerRank, CustomerSuppAddress) VALUES (19, N'Phạm Kim Yến', N'0533221107', N'kyen11@gmail.com', N'Đồng', N'25 Nguyễn Ảnh Thủ, TP Hồ Chí Minh')
INSERT Customers (CustomerID, CustomerName, Phone, Email, CustomerRank, CustomerSuppAddress) VALUES (20, N'Dương Tấn Quý', N'0955221100', N'quyzz@gmail.com', N'Vàng', N'12 Nguyễn Đồng, Hà Nội')
SET IDENTITY_INSERT Customers OFF
GO
----------------------------------------------------------------------------------------------------------------------------------------
-- Bảng Suppliers
CREATE TABLE Suppliers 
(
    SupplierID INT PRIMARY KEY IDENTITY(1,1),
    SupplierName NVARCHAR(100) NOT NULL,
    ContactName NVARCHAR(100) NULL,
    Phone VARCHAR(15) NULL,
    Email VARCHAR(100) NULL,
    SuppAddress NVARCHAR(255) NULL
);
----------------------------------------------------------------------------------------------------------------------------------------
SET IDENTITY_INSERT Suppliers ON 
INSERT Suppliers (SupplierID, SupplierName, ContactName, Phone, Email, SuppAddress) VALUES (1, N'Công ty TNHH Ngọc Minh', N'Lê Thị Minh', N'0912345678', N'leminh@ngocminh.com', N'123 Lê Duẩn, Hà Nội')
INSERT Suppliers (SupplierID, SupplierName, ContactName, Phone, Email, SuppAddress) VALUES (2, N'Công ty Phương Nam', N'Trần Quốc Phương', N'0938765432', N'phuongnam@phuongnam.com', N'456 Võ Thị Sáu, TP Hồ Chí Minh')
INSERT Suppliers (SupplierID, SupplierName, ContactName, Phone, Email, SuppAddress) VALUES (3, N'VietFresh Foods', N'Nguyễn Thị Lan', N'0987654321', N'lannguyen@vietfresh.com', N'789 Trần Phú, Ðà Nẵng')
INSERT Suppliers (SupplierID, SupplierName, ContactName, Phone, Email, SuppAddress) VALUES (4, N'Công ty Sữa Việt Nam', N'Phạm Văn Hoàng', N'0909988776', N'hoangpham@vinamilk.com', N'321 Hoàng Văn Thụ, TP Hồ Chí Minh')
INSERT Suppliers (SupplierID, SupplierName, ContactName, Phone, Email, SuppAddress) VALUES (5, N'Công ty TNHH Ngôi Sao', N'Dương Trịnh Đào', N'0902988756', N'daotrinh@star.com', N'12 Phố Bắc, Hà Nội')
INSERT Suppliers (SupplierID, SupplierName, ContactName, Phone, Email, SuppAddress) VALUES (6, N'Công ty TNHH Clean Food', N'Nguyễn Văn Thọ', N'0911988776', N'thognn@cleanf.com', N'10 Nguyễn Ảnh Thủ, TP Hồ Chí Minh')
INSERT Suppliers (SupplierID, SupplierName, ContactName, Phone, Email, SuppAddress) VALUES (7, N'Công ty Sữa Bò Sạch', N'Võ Thị Thu', N'0709988776', N'vtthu@bosach.com', N'18 Nguyễn Huệ, Huế')
INSERT Suppliers (SupplierID, SupplierName, ContactName, Phone, Email, SuppAddress) VALUES (8, N'Công ty TNHH Đồ Ăn Tươi', N'Nguyễn Thị Bế', N'0456988776', N'ngthibe@freshfood.com', N'15A Trường Chinh, Tiền Giang')

SET IDENTITY_INSERT Suppliers OFF
GO
----------------------------------------------------------------------------------------------------------------------------------------
-- Bảng Products
CREATE TABLE Products 
(
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(100) NOT NULL,
    CategoryID INT NOT NULL,
    SupplierID INT NOT NULL,
    Price DECIMAL(10, 3) NOT NULL,
    StockQuantity INT NOT NULL,
    Unit NVARCHAR(50) NULL,
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID),
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID)
);
GO
----------------------------------------------------------------------------------------------------------------------------------------
SET IDENTITY_INSERT Products ON 
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (1, N'Nước ngọt Coca-Cola 1.5L', 1, 1, CAST(12.500 AS DECIMAL(10, 3)), 100, N'Chai')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (2, N'Bánh Snack Lays Classic', 2, 1, CAST(20.000 AS DECIMAL(10, 3)), 150, N'Gói')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (3, N'Bột giặt OMO 3kg', 3, 2, CAST(85.000 AS DECIMAL(10, 3)), 75, N'Túi')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (4, N'Sữa tươi Vinamilk 1L', 4, 3, CAST(30.000 AS DECIMAL(10, 3)), 200, N'Chai')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (5, N'Chuối', 5, 3, CAST(10.000 AS DECIMAL(10, 3)), 250, N'Kg')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (6, N'Nước cam Twister 1L', 1, 1, CAST(15.000 AS DECIMAL(10, 3)), 80, N'Chai')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (7, N'Kem đánh răng P/S 200g', 3, 2, CAST(25.000 AS DECIMAL(10, 3)), 120, N'Tuýp')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (8, N'Táo Mỹ', 5, 3, CAST(45.000 AS DECIMAL(10, 3)), 180, N'Kg')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (9, N'Sữa chua Vinamilk', 4, 4, CAST(8.000 AS DECIMAL(10, 3)), 300, N'Hộp')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (10, N'Bánh quy Oreo', 2, 1, CAST(22.000 AS DECIMAL(10, 3)), 130, N'Gói')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (11, N'Xà Lách Tươi', 5, 3,CAST(82.000 AS DECIMAL(10, 3)), 15, N'Kg')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (12, N'Pepsi Không Calo', 1, 5,CAST(40.000 AS DECIMAL(10, 3)), 50, N'Chai')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (13, N'Bơ Sữa Long Thành', 4, 7,CAST(75.000 AS DECIMAL(10, 3)), 100, N'Hộp')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (14, N'Ghế Lười', 3, 2,CAST(299.000 AS DECIMAL(10, 3)), 5, N'Cái')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (15, N'Táo Tươi Úc', 5, 8,CAST(125.000 AS DECIMAL(10, 3)), 150, N'Gói')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (16, N'Kẹo Nho Khô', 2, 6,CAST(22.000 AS DECIMAL(10, 3)), 15, N'Gói')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (17, N'Muỗng Nhựa Inox', 3, 2,CAST(52.000 AS DECIMAL(10, 3)), 8, N'Cái')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (18, N'Rau Mồng Tơi', 5, 6,CAST(12.000 AS DECIMAL(10, 3)), 150, N'Kg')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (19, N'Nước 7 UP', 1, 5,CAST(8.000 AS DECIMAL(10, 3)), 275, N'Chai')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (20, N'Thao Sứ Thanh Hoa',3 , 2,CAST(245.000 AS DECIMAL(10, 3)), 125, N'Cái')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (21, N'Kẹo dẻo dâu', 2, 8,CAST(15.000 AS DECIMAL(10, 3)), 88, N'Gói')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (22, N'Nước Khoáng Lavie', 1, 3,CAST(15.000 AS DECIMAL(10, 3)), 100, N'Chai')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (23, N'Dâu tươi Đà Lạt', 5, 6,CAST(275.000 AS DECIMAL(10, 3)), 25, N'Kg')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (24, N'Mận Hà Nội', 5, 6,CAST(125.000 AS DECIMAL(10, 3)), 50, N'Kg')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (25, N'Bàn gỗ', 3, 1,CAST(500.000 AS DECIMAL(10, 3)), 10, N'Cái')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (26, N'Nước Hoa', 3, 2,CAST(234.000 AS DECIMAL(10, 3)), 80, N'Hộp')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (27, N'Nước nhỏ mắt', 3, 2,CAST(50.000 AS DECIMAL(10, 3)), 155, N'Chai')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (28, N'Bánh quy Oreo', 2, 8,CAST(25.000 AS DECIMAL(10, 3)), 60, N'Gói')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (29, N'Nước cam Mirinda', 1, 3,CAST(15.000 AS DECIMAL(10, 3)), 100, N'Chai')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (30, N'Nước ngọt Fanta', 1, 3,CAST(15.000 AS DECIMAL(10, 3)), 20, N'Chai')
SET IDENTITY_INSERT Products OFF
GO
----------------------------------------------------------------------------------------------------------------------------------------
-- Bảng Discounts
CREATE TABLE Discounts 
(
    DiscountID INT PRIMARY KEY IDENTITY(1,1),
    ProductID INT NOT NULL,
    DiscountPercentage DECIMAL(5, 2) NOT NULL,
    StartDate DATETIME NOT NULL,
    EndDate DATETIME NOT NULL,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);
GO
----------------------------------------------------------------------------------------------------------------------------------------
SET IDENTITY_INSERT Discounts ON 
INSERT Discounts (DiscountID, ProductID, DiscountPercentage, StartDate, EndDate) VALUES (2, 1, CAST(10.00 AS DECIMAL(5, 2)), CAST(N'2024-09-01T00:00:00.000' AS DATETIME), CAST(N'2024-09-30T00:00:00.000' AS DATETIME))
INSERT Discounts (DiscountID, ProductID, DiscountPercentage, StartDate, EndDate) VALUES (3, 2, CAST(5.00 AS DECIMAL(5, 2)), CAST(N'2024-09-15T00:00:00.000' AS DATETIME), CAST(N'2024-10-15T00:00:00.000' AS DATETIME))
INSERT Discounts (DiscountID, ProductID, DiscountPercentage, StartDate, EndDate) VALUES (4, 4, CAST(15.00 AS DECIMAL(5, 2)), CAST(N'2024-10-01T00:00:00.000' AS DATETIME), CAST(N'2024-10-31T00:00:00.000' AS DATETIME))
INSERT Discounts (DiscountID, ProductID, DiscountPercentage, StartDate, EndDate) VALUES (5, 8, CAST(20.00 AS DECIMAL(5, 2)), CAST(N'2024-09-20T00:00:00.000' AS DATETIME), CAST(N'2024-10-20T00:00:00.000' AS DATETIME))
SET IDENTITY_INSERT Discounts OFF
GO
----------------------------------------------------------------------------------------------------------------------------------------
-- Bảng Employees
CREATE TABLE Employees 
(
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    EmployeeName NVARCHAR(100) NOT NULL,
    Position NVARCHAR(50) NULL,
    Phone VARCHAR(15) NULL,
    Email VARCHAR(100) NULL,
    EmployPassword VARCHAR(255) NULL
);
GO
----------------------------------------------------------------------------------------------------------------------------------------
SET IDENTITY_INSERT Employees ON 
INSERT Employees (EmployeeID, EmployeeName, Position, Phone, Email, EmployPassword) VALUES (1, N'Trần Công Mạnh', N'Thu ngân', N'0901234567', N'congmanh@gmail.com', N'12345')
INSERT Employees (EmployeeID, EmployeeName, Position, Phone, Email, EmployPassword) VALUES (2, N'Phạm Thị Hằng', N'Quản lý cửa hàng', N'0912345678', N'hangpham@gmail.com', N'password456')
INSERT Employees (EmployeeID, EmployeeName, Position, Phone, Email, EmployPassword) VALUES (3, N'Lê Văn Minh', N'Nhân viên kho', N'0938765432', N'minhle@gmail.com', N'password789')
INSERT Employees (EmployeeID, EmployeeName, Position, Phone, Email, EmployPassword) VALUES (4, N'Nguyễn Thị Mai', N'Nhân viên bán hàng', N'0945432123', N'mainguyen@gmail.com', N'password321')
SET IDENTITY_INSERT Employees OFF
GO
----------------------------------------------------------------------------------------------------------------------------------------
-- Bảng Inventory
CREATE TABLE Inventory 
(
    InventoryID INT PRIMARY KEY IDENTITY(1,1),
    ProductID INT NOT NULL,
    QuantityInStock INT NOT NULL,
    MinimumRequired INT NULL,
    LastUpdated DATETIME NULL,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);
GO
----------------------------------------------------------------------------------------------------------------------------------------
SET IDENTITY_INSERT Inventory ON 
INSERT Inventory (InventoryID, ProductID, QuantityInStock, MinimumRequired, LastUpdated) VALUES (1, 1, 100, 50, CAST(N'2024-10-25T20:47:17.383' AS DATETIME))
INSERT Inventory (InventoryID, ProductID, QuantityInStock, MinimumRequired, LastUpdated) VALUES (2, 2, 150, 50, CAST(N'2024-10-25T20:47:17.383' AS DATETIME))
INSERT Inventory (InventoryID, ProductID, QuantityInStock, MinimumRequired, LastUpdated) VALUES (3, 3, 75, 20, CAST(N'2024-10-25T20:47:17.383' AS DATETIME))
INSERT Inventory (InventoryID, ProductID, QuantityInStock, MinimumRequired, LastUpdated) VALUES (4, 4, 200, 100, CAST(N'2024-10-25T20:47:17.383' AS DATETIME))
INSERT Inventory (InventoryID, ProductID, QuantityInStock, MinimumRequired, LastUpdated) VALUES (5, 5, 250, 80, CAST(N'2024-10-25T20:47:17.383' AS DATETIME))
INSERT Inventory (InventoryID, ProductID, QuantityInStock, MinimumRequired, LastUpdated) VALUES (6, 6, 80, 30, CAST(N'2024-10-25T20:47:17.383' AS DATETIME))
INSERT Inventory (InventoryID, ProductID, QuantityInStock, MinimumRequired, LastUpdated) VALUES (7, 7, 120, 50, CAST(N'2024-10-25T20:47:17.383' AS DATETIME))
INSERT Inventory (InventoryID, ProductID, QuantityInStock, MinimumRequired, LastUpdated) VALUES (8, 8, 180, 60, CAST(N'2024-10-25T20:47:17.383' AS DATETIME))
INSERT Inventory (InventoryID, ProductID, QuantityInStock, MinimumRequired, LastUpdated) VALUES (9, 9, 300, 150, CAST(N'2024-10-25T20:47:17.383' AS DATETIME))
INSERT Inventory (InventoryID, ProductID, QuantityInStock, MinimumRequired, LastUpdated) VALUES (10, 10, 130, 70, CAST(N'2024-10-25T20:47:17.383' AS DATETIME))
SET IDENTITY_INSERT Inventory OFF
GO
----------------------------------------------------------------------------------------------------------------------------------------
-- Bảng Orders
CREATE TABLE Orders 
(
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT NOT NULL,
    EmployeeID INT NOT NULL,
    OrderDate DATETIME NULL,
    TotalAmount DECIMAL(10, 3) NOT NULL,
    PaymentMethod NVARCHAR(50) NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);
GO
----------------------------------------------------------------------------------------------------------------------------------------
SET IDENTITY_INSERT Orders ON 
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (1, 1, 1, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(150.000 AS DECIMAL(10, 3)), N'Tiền mặt')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (2, 2, 2, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(85.000 AS DECIMAL(10, 3)), N'Thẻ')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (3, 3, 1, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(250.000 AS DECIMAL(10, 3)), N'Tiền mặt')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (4, 4, 3, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(300.000 AS DECIMAL(10, 3)), N'Chuyển khoản')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (5, 5, 4, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(120.000 AS DECIMAL(10, 3)), N'Thẻ')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (6, 6, 2, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(190.000 AS DECIMAL(10, 3)), N'Tiền mặt')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (7, 7, 1, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(230.000 AS DECIMAL(10, 3)), N'Thẻ')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (8, 8, 3, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(90.000 AS DECIMAL(10, 3)), N'Tiền mặt')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (9, 9, 4, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(170.000 AS DECIMAL(10, 3)), N'Chuyển khoản')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (10, 10, 2, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(210.000 AS DECIMAL(10, 3)), N'Tiền mặt')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (11, 11, 2, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(55.000 AS DECIMAL(10, 3)), N'Thẻ')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (12, 12, 4, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(82.000 AS DECIMAL(10, 3)), N'Chuyển khoản')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (13, 13, 3, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(79.000 AS DECIMAL(10, 3)), N'Tiền mặt')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (14, 14, 1, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(125.000 AS DECIMAL(10, 3)), N'Chuyển khoản')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (15, 15, 1, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(263.000 AS DECIMAL(10, 3)), N'Tiền mặt')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (16, 16, 4, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(22.000 AS DECIMAL(10, 3)), N'Chuyển khoản')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (17, 17, 2, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(34.000 AS DECIMAL(10, 3)), N'Thẻ')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (18, 18, 3, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(78.000 AS DECIMAL(10, 3)), N'Chuyển khoản')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (19, 19, 2, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(99.000 AS DECIMAL(10, 3)), N'Tiền mặt')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (20, 20, 1, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(146.000 AS DECIMAL(10, 3)), N'Thẻ')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (21, 20, 4, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(89.000 AS DECIMAL(10, 3)), N'Tiền mặt')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (22, 15, 3, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(155.000 AS DECIMAL(10, 3)), N'Chuyển khoản')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (23, 17, 1, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(20.000 AS DECIMAL(10, 3)), N'Thẻ')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (24, 18, 2, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(55.000 AS DECIMAL(10, 3)), N'Thẻ')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (25, 8, 3, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(89.000 AS DECIMAL(10, 3)), N'Tiền mặt')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (26, 7, 4, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(76.000 AS DECIMAL(10, 3)), N'Thẻ')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (27, 11, 1, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(444.000 AS DECIMAL(10, 3)), N'Chuyển khoản')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (28, 12, 2, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(178.000 AS DECIMAL(10, 3)), N'Thẻ')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (29, 7, 4, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(97.000 AS DECIMAL(10, 3)), N'Tiền mặt')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (30, 15, 1, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), CAST(23.000 AS DECIMAL(10, 3)), N'Chuyển khoản')
SET IDENTITY_INSERT Orders OFF
GO
----------------------------------------------------------------------------------------------------------------------------------------
-- Bảng OrderDetails
CREATE TABLE OrderDetails
(
    OrderDetailID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);
GO 
----------------------------------------------------------------------------------------------------------------------------------------
SET IDENTITY_INSERT OrderDetails ON 
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (1, 1, 1, 2, CAST(12.50 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (2, 1, 2, 1, CAST(20.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (3, 1, 3, 1, CAST(85.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (4, 2, 4, 3, CAST(30.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (5, 2, 5, 2, CAST(10.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (6, 3, 6, 1, CAST(15.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (7, 3, 7, 2, CAST(25.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (8, 4, 8, 5, CAST(45.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (9, 4, 9, 10, CAST(8.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (10, 5, 10, 4, CAST(22.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (11, 5, 1, 3, CAST(12.50 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (12, 6, 2, 5, CAST(20.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (13, 6, 3, 1, CAST(85.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (14, 7, 4, 4, CAST(30.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (15, 7, 5, 6, CAST(10.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (16, 8, 6, 3, CAST(15.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (17, 8, 7, 2, CAST(25.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (18, 9, 8, 7, CAST(45.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (19, 9, 9, 12, CAST(8.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (20, 10, 10, 5, CAST(22.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (21, 15, 30, 5, CAST(25.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (22, 28, 18, 6, CAST(80.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (23, 22, 17, 8, CAST(150.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (24, 14, 11, 15, CAST(355.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (25, 11, 25, 9, CAST(475.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (26, 29, 14, 11, CAST(589.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (27, 30, 25, 17, CAST(666.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (28, 17, 9, 8, CAST(124.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (29, 12, 7, 12, CAST(745.00 AS DECIMAL(10, 2)))
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (30, 26, 8, 29, CAST(222.00 AS DECIMAL(10, 2)))

SET IDENTITY_INSERT OrderDetails OFF
GO
----------------------------------------------------------------------------------------------------------------------------------------
ALTER TABLE Inventory ADD  DEFAULT ((0)) FOR MinimumRequired
GO
ALTER TABLE Inventory ADD  DEFAULT (getdate()) FOR LastUpdated
GO
ALTER TABLE Orders ADD  CONSTRAINT DF__Orders__OrderDat__4316F928  DEFAULT (getdate()) FOR OrderDate
GO
ALTER TABLE Discounts  WITH CHECK ADD  CONSTRAINT FK__Discounts__Produ__5070F446 FOREIGN KEY(ProductID)
REFERENCES Products (ProductID)
GO
ALTER TABLE Discounts CHECK CONSTRAINT FK__Discounts__Produ__5070F446
GO
ALTER TABLE Inventory  WITH CHECK ADD  CONSTRAINT FK__Inventory__Produ__4D94879B FOREIGN KEY(ProductID)
REFERENCES Products (ProductID)
GO
ALTER TABLE Inventory CHECK CONSTRAINT FK__Inventory__Produ__4D94879B
GO
ALTER TABLE OrderDetails  WITH CHECK ADD  CONSTRAINT FK__OrderDeta__Order__47DBAE45 FOREIGN KEY(OrderID)
REFERENCES Orders (OrderID)
GO
ALTER TABLE OrderDetails CHECK CONSTRAINT FK__OrderDeta__Order__47DBAE45
GO
ALTER TABLE OrderDetails  WITH CHECK ADD  CONSTRAINT FK__OrderDeta__Produ__48CFD27E FOREIGN KEY(ProductID)
REFERENCES Products (ProductID)
GO
ALTER TABLE OrderDetails CHECK CONSTRAINT FK__OrderDeta__Produ__48CFD27E
GO
ALTER TABLE Orders  WITH CHECK ADD  CONSTRAINT FK__Orders__Customer__440B1D61 FOREIGN KEY(CustomerID)
REFERENCES Customers (CustomerID)
GO
ALTER TABLE Orders CHECK CONSTRAINT FK__Orders__Customer__440B1D61
GO
ALTER TABLE Orders  WITH CHECK ADD  CONSTRAINT FK__Orders__Employee__44FF419A FOREIGN KEY(EmployeeID)
REFERENCES Employees (EmployeeID)
GO
ALTER TABLE Orders CHECK CONSTRAINT FK__Orders__Employee__44FF419A
GO
ALTER TABLE Products  WITH CHECK ADD  CONSTRAINT FK__Products__Catego__3B75D760 FOREIGN KEY(CategoryID)
REFERENCES Categories (CategoryID)
GO
ALTER TABLE Products CHECK CONSTRAINT FK__Products__Catego__3B75D760
GO
ALTER TABLE Products  WITH CHECK ADD  CONSTRAINT FK__Products__Suppli__3C69FB99 FOREIGN KEY(SupplierID)
REFERENCES Suppliers (SupplierID)
GO
ALTER TABLE Products CHECK CONSTRAINT FK__Products__Suppli__3C69FB99
GO
USE master
GO
ALTER DATABASE miniMKT SET  READ_WRITE 
GO
----------------------------------------------------------------------------------------------------------------------------------------
