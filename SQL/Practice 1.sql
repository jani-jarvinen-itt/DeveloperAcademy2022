-- Practice 1.a
SELECT *
FROM Customers
WHERE Country = 'Finland'

-- Practice 1.b (using subquery)
SELECT *
FROM Orders
WHERE CustomerID = (SELECT CustomerId
				    FROM Customers
                    WHERE CompanyName = 'Que Delícia')

-- Practice 1.c
SELECT *
FROM Employees
WHERE City = 'London'
