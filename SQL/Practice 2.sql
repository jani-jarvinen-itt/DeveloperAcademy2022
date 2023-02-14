-- Practice 2.a
SELECT COUNT(CustomerID)
FROM Customers

-- Practice 2.b
SELECT SUM(UnitPrice * UnitsInStock)
FROM Products


-- Practice 2.c
SELECT *
FROM Products
WHERE ProductName = 'Tofu'

SELECT SUM(UnitPrice * Quantity) AS SalesAmount
FROM [Order Details]
WHERE ProductID = 14

-- Practice 2.c, combined
SELECT SUM(UnitPrice * Quantity) AS SalesAmount
FROM [Order Details]
WHERE ProductID = (SELECT ProductID
				   FROM Products
				   WHERE ProductName = 'Tofu')



-- Practice 2.c, combined with discount
SELECT SUM(UnitPrice * Quantity * (1 - Discount)) AS SalesAmount
FROM [Order Details]
WHERE ProductID = (SELECT ProductID
				   FROM Products
				   WHERE ProductName = 'Tofu')

SELECT *
FROM Products
WHERE ProductName = 'Tofu' OR ProductName = 'Longlife Tofu'

SELECT ProductID
FROM Products
WHERE ProductName LIKE '%Tofu%'

-- Practice 2.c, both tofus, combined query with discount
SELECT SUM(UnitPrice * Quantity * (1 - Discount)) AS SalesAmount
FROM [Order Details]
WHERE ProductID = 14 OR ProductID = 74

SELECT SUM(UnitPrice * Quantity * (1 - Discount)) AS SalesAmount
FROM [Order Details]
WHERE ProductID IN (14, 74)

SELECT SUM(UnitPrice * Quantity * (1 - Discount)) AS SalesAmount
FROM [Order Details]
WHERE ProductID IN (SELECT ProductID
                    FROM Products
				    WHERE ProductName LIKE '%Tofu%')
