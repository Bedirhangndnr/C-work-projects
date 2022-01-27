/*19:10*/
/*1. Müşteri Unvanı “Owner” olan müşterilerin Şirket Adı bilgisini A-Z’den sıralı olarak listele*/
/*
SELECT CompanyName 
FROM Customers 
WHERE ContactTitle='Owner'
ORDER BY CompanyName asc
*/


/*2. Fax veya Telefon Bilgisi Olmayan müşterileri listeleyiniz.*/
/*
SELECT * 
FROM Customers 
WHERE Customers.Phone IS NULL or Customers.Fax IS NULL
*/




/*3. 50 yaşından büyük personellerin Ad,Soyad ve Unvan bilgileri ile listeleyiniz. */
/* 
SELECT FirstName, LastName, Title 
FROM Employees 
WHERE DATEPART(year, getdate())-DATEPART(year, Employees.BirthDate)>50
*/




/*4. Personellerin Ad Soyad ve Bölge bilgisine göre listeleyiniz. ?                     -------------------------------Group By mı istiyor? Bunda tam oalrak emin olamadım yağtığımdan*/
/* 
SELECT FirstName, LastName, Region 
FROM Employees 
GROUP BY Employees.FirstName,Employees.LastName,Employees.Region
*/


/* 5. Personellerin Ad ve Soyadlarını listeleyiniz sıralama firmada çalışma tarihine göre en eskiden en yeniye doğru olsun.*/
/* 
SELECT FirstName, LastName
FROM Employees
ORDER BY Employees.HireDate asc
*/


/* 6. Hangi ülkede kaç tane tedarikçimiz olduğunu listeleyim. */
/*
SELECT Country, COUNT(*) 
FROM Suppliers
GROUP BY Suppliers.Country
*/


/*7. Hangi tedarikçiden kaç çeşit ürün tedarik ettiğimizin listesini oluşturalım. */
/* 
SELECT Suppliers.SupplierID,count(DISTINCT(ProductID)) as 'count of productID'
FROM Products
LEFT JOIN Suppliers on  Products.SupplierID=Suppliers.SupplierID
GROUP BY Suppliers.SupplierID
*/



/*8. Hangi kategoride kaç çeşit ürün olduğunu yazalım. */
/*
SELECT Categories.CategoryID, COUNT(*) as 'count of products per Category' 
FROM Products 
LEFT JOIN Categories on Categories.CategoryID=Products.CategoryID
GROUP BY Categories.CategoryID
*/




/*9. Ürünlerimizin ortalama fiyatını bulalım. */
/*
SELECT Products.ProductID, AVG(Products.UnitPrice)  as 'AVG Price'
FROM Products
GROUP BY Products.ProductID
*/


/*10. Her kategorinin içindeki ürünlerin fiyat ortalamasını kategori bazlı yazalım.*/
/* 
SELECT Products.CategoryID,COUNT(Products.UnitPrice)  as 'AVG Price'
FROM Products
GROUP BY Products.CategoryID
*/

/*70 dk*/



/*11. Yıl bazında yaptığımız satış tutarlarını her yıl için bir satır oluşacak şekilde listeleyelim. */
/* 
SELECT DATEPART(year, Orders.OrderDate), SUM([Order Details].UnitPrice)
FROM [Orders]
LEFT JOIN [Order Details] 
ON Orders.OrderID= [Order Details].OrderID
GROUP BY DATEPART(year, Orders.OrderDate)
*/





 



/*12. En çok satılan ürün ve en az satılan ürünü kategorisi ile birlikte yazalım. ------------------------------------------------------------ Bu SORUDA 2 farklı sorgu yazdım, emin değilim. Tek sorguda mı yapılmalıydı */
/*

Select TOP 1 Products.CategoryID, Products.ProductID,COUNT(*)
From [Order Details]  
LEFT JOIN Products
on Products.ProductID=[Order Details].ProductID
GROUP BY Products.ProductID, Products.CategoryID
ORDER BY COUNT(Products.ProductID) desc

/*   *****************************************************************************   */


Select TOP 1 Products.CategoryID, Products.ProductID,COUNT(*)
From [Order Details]  
LEFT JOIN Products
on Products.ProductID=[Order Details].ProductID
GROUP BY Products.ProductID, Products.CategoryID
ORDER BY COUNT(Products.ProductID) asc


*/







/*13. Her kategoriden toplam yapılan satışı kategori bazlı yazalım.  YAPAMADIMMMMMMMMMMMMMMMMMMMMMMMMMM TEKRAR BAKACAĞIM*/
/*
SELECT Categories.categoryID,count(*) as 'count' FROM Categories
LEFT JOIN Products 
on Categories.categoryID=Products.categoryID
LEFT JOIN [Order Details] 
on [Order Details].ProductID=Products.ProductID
GROUP BY Categories.CategoryID
*/





/*14. En çok satış yaptığımız 10 müşteriyi listeleyelim.*/
/* 
SELECT * FROM Customers
WHERE CustomerID IN(
SELECT TOP 5 c.CustomerID
FROM Customers c 
LEFT JOIN Orders o 
on c.CustomerID = o.CustomerID
GROUP BY c.CustomerID 
ORDER BY COUNT(*) desc
)
*/






/*15. En az satış yaptığımız 10 ülkeyi listeleyelim. */
/* 
SELECT * FROM Customers
WHERE CustomerID IN(
SELECT TOP 5 c.CustomerID
FROM Customers c 
LEFT JOIN Orders o 
on c.CustomerID = o.CustomerID
GROUP BY c.CustomerID 
ORDER BY COUNT(*) asc
)
*/






/*16. Personellerimizden satış adedi en fazla olan 3 kişi ile satış tutarı en fazla olan 3 kişiyi listeleyelim.*/
/*

SELECT * FROM Employees e
WHERE e.EmployeeID IN(
SELECT TOP 3 e.EmployeeID
FROM Employees e 
LEFT JOIN Orders o 
on e.EmployeeID = o.EmployeeID
GROUP BY e.EmployeeID 
ORDER BY COUNT(*) desc
)

SELECT * FROM Employees e
WHERE e.EmployeeID IN(
SELECT TOP 3 e.EmployeeID
FROM Employees e 
LEFT JOIN Orders o 
on e.EmployeeID = o.EmployeeID
LEFT JOIN [Order Details] od 
on o.OrderID = od.OrderID
GROUP BY e.EmployeeID 
ORDER BY SUM(UnitPrice) desc
)
*/






/*
17. Hiç satış yapmamış personelleri listeleyelim.
*/
/* 
SELECT * 
FROM Employees e
WHERE e.EmployeeID NOT IN(
	SELECT DISTINCT o.EmployeeID FROM Orders o
)
*/

/*
18. Hiç satın alma yapmayan müşterileri listeleyelim.
*/
/*
SELECT * FROM Customers
WHERE Customers.CustomerID NOT IN (
	SELECT c.CustomerID FROM Customers c
	INNER JOIN Orders o
	on o.CustomerID=c.CustomerID
)
*/


/*19. Her müşterinin yaptığı satın almaların ortalama Fiyatını yazalım.*/
/*
SELECT c.CustomerID, AVG (UnitPrice) FROM Customers c
INNER JOIN Orders o
on c.CustomerID=o.CustomerID
INNER JOIN [Order Details] od
on o.OrderID=od.OrderID
GROUP BY c.CustomerID
*/

/*20. Tedarikçilerimizden ürünleri en çok satılan ilk 5 tane tedarikçiyi listeleyelim.*/

/*

*/



/*21. Siparişlerin ortalama nakliye maliyetini hesaplayalım.*/
/*
SELECT AVG(Freight) FROM Orders
*/

/*22. En çok mal sevk edilen 5 şehri listeleyelim.*/
/*
SELECT TOP 5 c.city, Count(*) FROM Customers c
INNER JOIN Orders o 
on o.CustomerID = c.CustomerID
GROUP BY c.City
ORDER BY COUNT(*) desc
*/

/*23. Sevk tarihi belli olan satışların ortalama sevk süresini gün olarak yazalım.*/
/*
SELECT 
DATEPART(MONTH, o.ShippedDate)- DATEPART(MONTH,o.OrderDate) 'month',
DATEPART(DAY, o.ShippedDate)- DATEPART(DAY,o.OrderDate)'day' 
FROM Orders o
WHERE o.ShippedDate IS NOT NULL 
*/

/*24. Kategori bazlı satılan ürün adetlerini yazalım.*/
/*
SELECT p.CategoryID, COUNT(*) 'number of products sold' FROM [Order Details] od
INNER JOIN Products p
on od.ProductID=p.ProductID
GROUP BY p.CategoryID
*/

/*25. Satışlarda yaptığımız ortalama indirimi hesaplayalım.*/
/*
SELECT AVG(od.Discount) FROM [Order Details] od
*/

/*26. Tüm satışlarda yaptığımız toplam indirimi hesaplayalım.*/

/*
SELECT SUM(od.Discount) FROM [Order Details] od

*/

/*27. İndirim yapılmadan satılan ürünleri listeleyelim.*/	
/*
SELECT * FROM [Order Details] od
WHERE od.Discount =0 OR od.Discount IS NULL
*/

/*28. Müşterileri bazında yapılan toplam indirimleri listeleyelim.*/

/*
SELECT o.CustomerID,SUM(UnitPrice) 'sum of dicounts' FROM Orders o
INNER JOIN [Order Details] od
on od.OrderID= o.OrderID
GROUP BY o.CustomerID
*/



/*29. Hiç satın alınmayan ürünlerin fiyat ortalamasını hesaplayalım.                ----------------------------------------------YOL MANTIKLI MIDIR HOCAM*/
/*
SELECT * FROM Products p
WHERE p.ProductID NOT IN(
	SELECT DISTINCT od.ProductID FROM [Order Details] od 
)
*/





/*30. En az satılan 3 ürünümüzü satın alan müşterilerimizi listeleyelim.*/

/*
SELECT od.ProductID,COUNT(*) 'sum of sold' FROM [Order Details] od
GROUP BY od.ProductID
HAVING COUNT(*)>3
*/
