IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'InventoryDB3')
BEGIN
    CREATE DATABASE InventoryDB3;
END
GO

USE InventoryDB3;
GO

-- Categories Table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Categories')
BEGIN
    CREATE TABLE Categories (
        CategoryID NVARCHAR(10) PRIMARY KEY,
        CategoryName NVARCHAR(100) NOT NULL,
        Description NVARCHAR(255) NULL
    );
END
GO

-- Products Table
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

-- Sample Categories
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

-- Sample Products (matching the image data)
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

PRINT 'InventoryDB3 setup completed successfully.';
GO
