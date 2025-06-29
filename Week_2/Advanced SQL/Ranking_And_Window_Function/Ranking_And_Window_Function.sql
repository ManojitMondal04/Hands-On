IF OBJECT_ID('Products', 'U') IS NOT NULL
    DROP TABLE Products;

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName NVARCHAR(100),
    Category NVARCHAR(100),
    Price DECIMAL(10,2)
);

INSERT INTO Products (ProductID, ProductName, Category, Price) VALUES
(1, 'Shirt', 'Clothing', 50.00),
(2, 'Sweater', 'Clothing', 1100.00),  
(3, 'Jacket', 'Clothing', 120.00),

(4, 'Laptop A', 'Electronics', 1000.00),
(5, 'Laptop B', 'Electronics', 950.00),
(6, 'Headphones', 'Electronics', 150.00),

(7, 'Oven', 'Home Appliances', 400.00),
(8, 'Microwave', 'Home Appliances', 400.00),
(9, 'Toaster', 'Home Appliances', 150.00);

WITH MaxCategoryPrice AS (
    SELECT Category, MAX(Price) AS MaxPrice
    FROM Products
    GROUP BY Category
),
RankedProducts AS (
    SELECT 
        p.Category,
        p.ProductName,
        p.Price,
        ROW_NUMBER() OVER (PARTITION BY p.Category ORDER BY p.Price DESC) AS RowNum
    FROM Products p
)
SELECT rp.Category, rp.ProductName, rp.Price, rp.RowNum
FROM RankedProducts rp
JOIN MaxCategoryPrice mcp ON rp.Category = mcp.Category
WHERE rp.RowNum <= 3
ORDER BY mcp.MaxPrice DESC, rp.RowNum;
