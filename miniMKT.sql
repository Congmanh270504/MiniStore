create database miniMKT
use miniMKT
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
    Price INT NOT NULL,
    StockQuantity INT NOT NULL,
    Unit NVARCHAR(50) NULL,
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID),
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID)
);
GO
----------------------------------------------------------------------------------------------------------------------------------------
SET IDENTITY_INSERT Products ON 
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (1, N'Nước ngọt Coca-Cola 1.5L', 1, 1, 12500 , 100, N'Chai')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (2, N'Bánh Snack Lays Classic', 2, 1, 20000 , 150, N'Gói')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (3, N'Bột giặt OMO 3kg', 3, 2, 85000 , 75, N'Túi')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (4, N'Sữa tươi Vinamilk 1L', 4, 3, 30000 , 200, N'Chai')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (5, N'Chuối', 5, 3, 10000 , 250, N'Kg')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (6, N'Nước cam Twister 1L', 1, 1, 15000 , 80, N'Chai')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (7, N'Kem đánh răng P/S 200g', 3, 2, 25000 , 120, N'Tuýp')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (8, N'Táo Mỹ', 5, 3, 45000 , 180, N'Kg')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (9, N'Sữa chua Vinamilk', 4, 4, 8000 , 300, N'Hộp')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (10, N'Bánh quy Oreo', 2, 1, 22000 , 130, N'Gói')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (11, N'Xà Lách Tươi', 5, 3,82000 , 15, N'Kg')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (12, N'Pepsi Không Calo', 1, 5,40000 , 50, N'Chai')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (13, N'Bơ Sữa Long Thành', 4, 7,75000 , 100, N'Hộp')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (14, N'Ghế Lười', 3, 2,299000 , 5, N'Cái')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (15, N'Táo Tươi Úc', 5, 8,125000 , 150, N'Gói')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (16, N'Kẹo Nho Khô', 2, 6,22000 , 15, N'Gói')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (17, N'Muỗng Nhựa Inox', 3, 2,52000 , 8, N'Cái')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (18, N'Rau Mồng Tơi', 5, 6,12000 , 150, N'Kg')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (19, N'Nước 7 UP', 1, 5,8000 , 275, N'Chai')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (20, N'Thao Sứ Thanh Hoa',3 , 2,245000 , 125, N'Cái')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (21, N'Kẹo dẻo dâu', 2, 8,15000 , 88, N'Gói')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (22, N'Nước Khoáng Lavie', 1, 3,15000 , 100, N'Chai')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (23, N'Dâu tươi Đà Lạt', 5, 6,275000 , 25, N'Kg')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (24, N'Mận Hà Nội', 5, 6,125000 , 50, N'Kg')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (25, N'Bàn gỗ', 3, 1,500000 , 10, N'Cái')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (26, N'Nước Hoa', 3, 2,234000 , 80, N'Hộp')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (27, N'Nước nhỏ mắt', 3, 2,50000 , 155, N'Chai')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (28, N'Bánh quy Oreo', 2, 8,25000 , 60, N'Gói')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (29, N'Nước cam Mirinda', 1, 3,15000 , 100, N'Chai')
INSERT Products (ProductID, ProductName, CategoryID, SupplierID, Price, StockQuantity, Unit) VALUES (30, N'Nước ngọt Fanta', 1, 3,15000 , 20, N'Chai')
SET IDENTITY_INSERT Products OFF
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
INSERT Employees (EmployeeID, EmployeeName, Position, Phone, Email, EmployPassword) VALUES (1, N'Trần Công Mạnh', N'Quản lý cửa hàng', N'0901234567', N'congmanh@gmail.com', N'12345')
INSERT Employees (EmployeeID, EmployeeName, Position, Phone, Email, EmployPassword) VALUES (2, N'Phạm Thị Hằng', N'Thu ngân', N'0912345678', N'hangpham@gmail.com', N'password456')
INSERT Employees (EmployeeID, EmployeeName, Position, Phone, Email, EmployPassword) VALUES (3, N'Lê Văn Minh', N'Nhân viên kho', N'0938765432', N'minhle@gmail.com', N'password789')
INSERT Employees (EmployeeID, EmployeeName, Position, Phone, Email, EmployPassword) VALUES (4, N'Nguyễn Thị Mai', N'Nhân viên bán hàng', N'0945432123', N'mainguyen@gmail.com', N'password321')
INSERT Employees (EmployeeID, EmployeeName, Position, Phone, Email, EmployPassword) VALUES (5, N'Hoàng Văn An', N'Nhân viên bán hàng', N'0976543210', N'hoangan@gmail.com', N'password654');
INSERT Employees (EmployeeID, EmployeeName, Position, Phone, Email, EmployPassword) VALUES (6, N'Ngô Thị Hương', N'Nhân viên bán hàng', N'0967894321', N'huongngo@gmail.com', N'password987');
INSERT Employees (EmployeeID, EmployeeName, Position, Phone, Email, EmployPassword) VALUES (7, N'Phan Minh Tâm', N'Nhân viên kho', N'0954321789', N'tamphan@gmail.com', N'password123');
INSERT Employees (EmployeeID, EmployeeName, Position, Phone, Email, EmployPassword) VALUES (8, N'Trần Thị Lan', N'Nhân viên bán hàng', N'0987654321', N'lantran@gmail.com', N'password456');

SET IDENTITY_INSERT Employees OFF
GO
----------------------------------------------------------------------------------------------------------------------------------------
-- Bảng Orders
CREATE TABLE Orders 
(
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT NOT NULL,
    EmployeeID INT NOT NULL,
    OrderDate DATETIME NULL,
    TotalAmount INT NOT NULL,
    PaymentMethod NVARCHAR(50) NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);
GO
----------------------------------------------------------------------------------------------------------------------------------------
SET IDENTITY_INSERT Orders ON 
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (1, 1, 1, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), 150000 , N'Tiền mặt')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (2, 2, 2, CAST(N'2023-12-18T20:46:46.753' AS DATETIME), 85000 , N'Thẻ')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (3, 3, 1, CAST(N'2023-07-14T20:46:46.753' AS DATETIME), 250000 , N'Tiền mặt')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (4, 4, 3, CAST(N'2024-11-22T20:46:46.753' AS DATETIME), 300000 , N'Chuyển khoản')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (5, 5, 4, CAST(N'2023-08-20T20:46:46.753' AS DATETIME), 120000 , N'Thẻ')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (6, 6, 2, CAST(N'2023-10-26T20:46:46.753' AS DATETIME), 190000 , N'Tiền mặt')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (7, 7, 1, CAST(N'2023-07-13T20:46:46.753' AS DATETIME), 230000 , N'Thẻ')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (8, 8, 3, CAST(N'2024-10-14T20:46:46.753' AS DATETIME), 90000 , N'Tiền mặt')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (9, 9, 4, CAST(N'2024-02-22T20:46:46.753' AS DATETIME), 170000 , N'Chuyển khoản')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (10, 10, 2, CAST(N'2023-11-14T20:46:46.753' AS DATETIME), 210000 , N'Tiền mặt')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (11, 11, 2, CAST(N'2024-08-25T20:46:46.753' AS DATETIME), 55000 , N'Thẻ')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (12, 12, 4, CAST(N'2024-04-22T20:46:46.753' AS DATETIME), 82000 , N'Chuyển khoản')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (13, 13, 3, CAST(N'2024-05-16T20:46:46.753' AS DATETIME), 79000 , N'Tiền mặt')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (14, 14, 1, CAST(N'2023-06-19T20:46:46.753' AS DATETIME), 125000 , N'Chuyển khoản')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (15, 15, 1, CAST(N'2023-11-25T20:46:46.753' AS DATETIME), 263000 , N'Tiền mặt')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (16, 16, 4, CAST(N'2024-07-22T20:46:46.753' AS DATETIME), 22000 , N'Chuyển khoản')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (17, 17, 2, CAST(N'2024-11-27T20:46:46.753' AS DATETIME), 34000 , N'Thẻ')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (18, 18, 3, CAST(N'2024-10-16T20:46:46.753' AS DATETIME), 78000 , N'Chuyển khoản')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (19, 19, 2, CAST(N'2023-09-25T20:46:46.753' AS DATETIME), 99000 , N'Tiền mặt')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (20, 20, 1, CAST(N'2023-01-13T20:46:46.753' AS DATETIME), 146000 , N'Thẻ')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (21, 20, 4, CAST(N'2024-07-25T20:46:46.753' AS DATETIME), 89000 , N'Tiền mặt')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (22, 15, 3, CAST(N'2024-11-17T20:46:46.753' AS DATETIME), 155000 , N'Chuyển khoản')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (23, 17, 1, CAST(N'2023-12-08T20:46:46.753' AS DATETIME), 20000 , N'Thẻ')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (24, 18, 2, CAST(N'2024-08-25T20:46:46.753' AS DATETIME), 55000 , N'Thẻ')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (25, 8, 3, CAST(N'2024-05-09T20:46:46.753' AS DATETIME), 89000 , N'Tiền mặt')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (26, 7, 4, CAST(N'2023-12-25T20:46:46.753' AS DATETIME), 76000 , N'Thẻ')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (27, 11, 1, CAST(N'2024-11-12T20:46:46.753' AS DATETIME), 444000 , N'Chuyển khoản')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (28, 12, 2, CAST(N'2024-10-25T20:46:46.753' AS DATETIME), 178000 , N'Thẻ')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (29, 7, 4, CAST(N'2024-06-17T20:46:46.753' AS DATETIME), 97000 , N'Tiền mặt')
INSERT Orders (OrderID, CustomerID, EmployeeID, OrderDate, TotalAmount, PaymentMethod) VALUES (30, 15, 1, CAST(N'2023-07-19T20:46:46.753' AS DATETIME), 23000 , N'Chuyển khoản')
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
    Price INT NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);
GO 
----------------------------------------------------------------------------------------------------------------------------------------
SET IDENTITY_INSERT OrderDetails ON 
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (1, 1, 1, 2, 1250 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (2, 1, 2, 1, 2000 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (3, 1, 3, 1, 8500 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (4, 2, 4, 3, 3000 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (5, 2, 5, 2, 1000 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (6, 3, 6, 1, 1500 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (7, 3, 7, 2, 2500 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (8, 4, 8, 5, 4500 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (9, 4, 9, 10, 800 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (10, 5, 10, 4, 2200 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (11, 5, 1, 3, 1250 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (12, 6, 2, 5, 2000 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (13, 6, 3, 1, 8500 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (14, 7, 4, 4, 3000 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (15, 7, 5, 6, 1000 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (16, 8, 6, 3, 1500 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (17, 8, 7, 2, 2500 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (18, 9, 8, 7, 4500 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (19, 9, 9, 12, 800 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (20, 10, 10, 5, 2200 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (21, 15, 30, 5, 2500 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (22, 28, 18, 6, 8000 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (23, 22, 17, 8, 15000 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (24, 14, 11, 15, 35500 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (25, 11, 25, 9, 47500 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (26, 29, 14, 11, 58900 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (27, 30, 25, 17, 66600 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (28, 17, 9, 8, 12400 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (29, 12, 7, 12, 74500 )
INSERT OrderDetails (OrderDetailID, OrderID, ProductID, Quantity, Price) VALUES (30, 26, 8, 29, 22200 )

