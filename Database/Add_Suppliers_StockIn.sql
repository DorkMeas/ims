USE InventoryDB3;
GO

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
        Notes NVARCHAR(255) NULL
    );
END
GO

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
    ('1', 50, DATEADD(DAY, -10, GETDATE()), '1', 12.00, 600.00, 'Initial stock'),
    ('2', 30, DATEADD(DAY, -8, GETDATE()), '1', 14.00, 420.00, ''),
    ('3', 20, DATEADD(DAY, -5, GETDATE()), '2', 7.50, 150.00, 'Promo pack'),
    ('6', 40, DATEADD(DAY, -3, GETDATE()), '3', 18.00, 720.00, ''),
    ('10', 25, DATEADD(DAY, -1, GETDATE()), '4', 22.00, 550.00, 'Fresh shipment');
END
GO

PRINT 'Suppliers and StockIn tables created successfully.';
GO
