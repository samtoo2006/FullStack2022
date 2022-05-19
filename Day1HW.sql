
/* 1
SELECT ProductID, Name, Color, ListPrice
FROM  Production.Product 
*/

/* 2
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product 
WHERE ListPrice != 0
*/

/* 3
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product 
WHERE Color IS NOT NULL
*/

/* 4
SELECT ProductID, Name, Color, ListPrice
FROM Production.Product 
WHERE Color IS NOT NULL AND ListPrice > 0
*/

/* 5
SELECT Name, Color 
FROM Production.Product 
WHERE Color IS NOT NULL
*/



/* 6
SELECT 'NAME: ' + NAME + '-- COLOR: ' + Color AS  Name
FROM Production.Product
WHERE Name IS NOT NULL AND Color IS NOT NULL
*/

/*7.
SELECT ProductID, Name
FROM Production.Product 
WHERE ProductID BETWEEN 400 AND 500
*/

/*8.
SELECT ProductID, Name, Color
FROM Production.Product 
WHERE Color = 'Black' OR Color = 'Blue'
*/

/* 9....
Write a query to get a result set on products that begins
with the letter S. 

SELECT *
FROM Production.Product 
WHERE Name LIKE 'S%'
*/

/*10. 
SELECT Name, ListPrice
FROM Production.Product 
WHERE Name LIKE '[AS]%'
Order by Name
*/


/* 11
SELECT *
FROM Production.Product 
WHERE Name LIKE 'SPO[^k]%'
Order by Name
*/

/*
12. 
SELECT DISTINCT ISNULL (ProductSubcategoryID, '') AS ProductSubcategoryID, ISNULL (Color, 'Not Specified') AS Color
FROM Production.Product 
Order by ProductSubcategoryID
*/
