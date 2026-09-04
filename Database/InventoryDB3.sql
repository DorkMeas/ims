IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'InventoryDB3')
BEGIN
    CREATE DATABASE InventoryDB3;
END
GO

USE InventoryDB3;
GO

<<<<<<< HEAD
-- Categories Table
=======
>>>>>>> 561f509 (feat: add stock)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Categories')
BEGIN
    CREATE TABLE Categories (
        CategoryID NVARCHAR(10) PRIMARY KEY,
        CategoryName NVARCHAR(100) NOT NULL,
        Description NVARCHAR(255) NULL
    );
END
GO

<<<<<<< HEAD
-- Products Table
=======
>>>>>>> 561f509 (feat: add stock)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Products')
BEGIN
    CREATE TABLE Products (
        ProductID NVARCHAR(20) PRIMARY KEY,
        ProductName NVARCHAR(100) NOT NULL,
        CategoryID NVARCHAR(10) NULL,
        UnitPrice DECIMAL(18,2) DEFAULT 0,
        QuantityInStock INT DEFAULT 0,
        Description NVARCHAR(255) NULL,
        Barcode NVARCHAR(50) NULL,
        ReOrderLevel INT DEFAULT 0,
        LastUpdated DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
    );
END
GO

<<<<<<< HEAD
-- Sample Categories
=======
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Suppliers')
BEGIN
    CREATE TABLE Suppliers (
        SupplierID INT IDENTITY(1,1) PRIMARY KEY,
        SupplierName NVARCHAR(100) NOT NULL,
        ContactPerson NVARCHAR(100) NULL,
        Phone NVARCHAR(30) NULL,
        Email NVARCHAR(100) NULL,
        Address NVARCHAR(255) NULL
    );
END
GO

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'StockIn')
BEGIN
    CREATE TABLE StockIn (
        StockInID INT IDENTITY(1,1) PRIMARY KEY,
        ProductID NVARCHAR(20) NOT NULL,
        Quantity INT NOT NULL,
        DateIn DATETIME NOT NULL DEFAULT GETDATE(),
        SupplierID NVARCHAR(20) NULL,
        UnitCost DECIMAL(18,2) DEFAULT 0,
        TotalCost DECIMAL(18,2) DEFAULT 0,
        Notes NVARCHAR(255) NULL,
        FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
    );
END
GO

>>>>>>> 561f509 (feat: add stock)
IF NOT EXISTS (SELECT 1 FROM Categories)
BEGIN
    INSERT INTO Categories (CategoryID, CategoryName, Description) VALUES
    ('1', 'Beverages', 'Soft drinks, coffees, teas, beers, and ales'),
    ('2', 'Condiments', 'Sweet and savory sauces, relishes, spreads, and seasonings'),
    ('6', 'Meat/Poultry', 'Prepared meats'),
    ('7', 'Produce', 'Dried fruit and bean curd'),
    ('8', 'Seafood', 'Seaweed and fish');
END
GO

<<<<<<< HEAD
-- Sample Products (matching the image data)
=======
>>>>>>> 561f509 (feat: add stock)
IF NOT EXISTS (SELECT 1 FROM Products)
BEGIN
    INSERT INTO Products (ProductID, ProductName, CategoryID, UnitPrice, QuantityInStock, Description, Barcode, ReOrderLevel, LastUpdated) VALUES
    ('1', 'Chai', '1', 18.00, 39, '', '', 10, '1900-01-01'),
    ('2', 'Chang', '1', 19.00, 17, '', '', 25, '1900-01-01'),
    ('3', 'Aniseed Syrup', '2', 10.00, 13, '', '', 25, '1900-01-01'),
    ('4', 'Chef Anton''s Cajun Seasoning', '2', 22.00, 53, '', '', 0, '1900-01-01'),
    ('5', 'Chef Anton''s Gumbo Mix', '2', 21.35, 0, '', '', 0, '1900-01-01'),
    ('6', 'Grandma''s Boysenberry Spread', '2', 25.00, 120, '', '', 25, '1900-01-01'),
    ('7', 'Uncle Bob''s Organic Dried Pears', '7', 30.00, 15, '', '', 10, '1900-01-01'),
    ('8', 'Northwoods Cranberry Sauce', '2', 40.00, 6, '', '', 0, '1900-01-01'),
    ('9', 'Mishi Kobe Niku', '6', 97.00, 29, '', '', 0, '1900-01-01'),
    ('10', 'Ikura', '8', 31.00, 31, '', '', 0, '1900-01-01');
END
GO

<<<<<<< HEAD
=======
IF NOT EXISTS (SELECT 1 FROM Suppliers)
BEGIN
    INSERT INTO Suppliers (SupplierName, ContactPerson, Phone, Email, Address) VALUES
    ('Exotic Liquids', 'Charlotte Cooper', '171-555-2222', 'charlotte@exotic.com', '49 Gilbert St. London'),
    ('New Orleans Cajun Delights', 'Shelley Burke', '100-555-4822', 'shelley@cajun.com', 'P.O. Box 78934 New Orleans'),
    ('Grandma Kelly''s Homestead', 'Regina Murphy', '313-555-5735', 'regina@grandma.com', '707 Oxford Rd. Ann Arbor'),
    ('Tokyo Traders', 'Yoshi Nagase', '03-3555-5011', 'yoshi@tokyo.com', '9-8 Sekimai Musashino-shi Tokyo'),
    ('Cooperativa de Quesos', 'Antonio del Valle', '98-598-7654', 'antonio@quesos.com', 'Calle del Rosal 4 Oviedo');
END
GO

IF NOT EXISTS (SELECT 1 FROM StockIn)
BEGIN
    INSERT INTO StockIn (ProductID, Quantity, DateIn, SupplierID, UnitCost, TotalCost, Notes) VALUES
    ('1', 50, GETDATE()-10, '1', 12.00, 600.00, 'Initial stock'),
    ('2', 30, GETDATE()-8, '1', 14.00, 420.00, ''),
    ('3', 20, GETDATE()-5, '2', 7.50, 150.00, 'Promo pack'),
    ('6', 40, GETDATE()-3, '3', 18.00, 720.00, ''),
    ('10', 25, GETDATE()-1, '4', 22.00, 550.00, 'Fresh shipment');
END
GO

>>>>>>> 561f509 (feat: add stock)
PRINT 'InventoryDB3 setup completed successfully.';
GO
