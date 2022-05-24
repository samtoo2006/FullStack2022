use Northwind 
go

/* 1
create view view_product_order_Sun AS
select p.ProductName, sum(od.Quantity) as ToTalOrderQuantity
from Products as p join [Order Details] as od on od.ProductID = p.ProductID
group by p.ProductName

select *
from view_product_order_Sun

drop view view_product_order_Sun
*/

/* 2
create procedure sp_product_order_quantity_Sun
@id int,
@quantity int out
as 
begin
select @quantity = sum(od.Quantity)
from Products as p join [Order Details] as od on od.ProductID = p.ProductID
where p.ProductID = @id
end
*/

/* 3
create procedure sp_product_order_quantity_Sun
@name nvarchar(100)
as
begin
with cte as (
	select p.ProductName,c.City, sum(od.Quantity) as Quantity
	from Products as p join [Order Details] as od on od.ProductID = p.ProductID join Orders as o on o.OrderID = od.OrderID join Customers as c on c.CustomerID = o.CustomerID
	group by c.City, p.ProductName)
select top 5 City, Quantity
from cte
where ProductName = @name
order by Quantity desc
end
*/
/* 4 ??
create Table People_Sun(id int, City nvarchar(10))
BEGIN TRAN
INSERT into People_Sun values(1,'Seattle')
insert into People_Sun vaules(2,'Green Bay')
insert into People_Sun vaules(1,'Aaron Rodgers',1)
insert into People_Sun vaules(2,'Russell Wilson',1)
insert into People_Sun vaules(3,' Jody Nelson',2)
if exists(select id from People_sun where City = (select id from City_sun where City = 'Seattle'))
Begin insert into City_Sun values(3,'Madison') update People_SUn set city = 'Madison' where city ='Seattle'))
end delete from City_Sun where City = 'Seattle'
CREATE VIEW Packers_Sun AS
SELECT namer from People_Sun WHERE city = 'Green Bay'
Select * from Packers_Sun commit 
drop Table People_Sun 
Drop Table City_Sun
drop view Packers_Sun
*/

/* 5
Create proc sp_birthday_employees_Sun AS BEGIN
SELECT *
INTO #EmployeeTemp 
FROM  employees 
WHERE DATEPART(MM, BirthDate) = 02

SELECT *
FROM #EmployeeTemp 
END
*/ 
/* 6
we can use EXCEPT
SELECT *
FROM Customers EXCEPT 
SELECT *
FROM Customers
*/