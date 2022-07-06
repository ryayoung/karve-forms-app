USE Karve
GO

IF EXISTS (SELECT * FROM sys.views WHERE name=N'CustomerList')
	DROP VIEW CustomerList;

GO
IF EXISTS (SELECT * FROM sys.views WHERE name=N'RentalHistory')
	DROP VIEW RentalHistory;

GO
CREATE VIEW CustomerList (CustomerID, FullName)
AS
	SELECT CustomerID, (FirstName + ' ' + LastName)
	FROM Customer
WITH CHECK OPTION;
GO
CREATE VIEW RentalHistory ([Order Date], Customer, Ski, Width, [Length], [Order Status], [Days Kept], Damage, [Tune Time], [Days Left Untuned])
/* This view summarizes all ongoing and completed orders. It's essential that we
   never ship a product to a new customer without a fresh tune, so this view will
   show us which products have been returned from customers but have not yet received
   a tune. We can also compare ski damage to how long it took us to tune the ski afterwards.
   This view keeps all numeric data in its original format, and returns -1 or -2 in the CASE
   statements depending on the case.
*/ 
AS
	SELECT Rental.OrderDate,
	(Customer.FirstName + ' ' + Customer.LastName),
	(Brand.BrandName + ':  ' + SkiModel.Name),
	SkiModel.WaistWidth,
	Ski.Length,
	-- Order status: If a customer has the ski in their posession, the rental is ACTIVE
	CASE WHEN Rental.ReturnDate IS NULL THEN 'ACTIVE'
		ELSE 'COMPLETE' END,
	-- Days kept: IF the rental is COMPLETE, then count the days between order and return
	CASE WHEN Rental.ReturnDate IS NOT NULL THEN DATEDIFF(day, Rental.OrderDate, Rental.ReturnDate)
		ELSE DATEDIFF(day, Rental.OrderDate, GETDATE()) END,
	-- Damage: IF the rental is COMPLETE, display NONE if there is no damage, and display the description if there is damage
	CASE WHEN Rental.ReturnDate IS NULL THEN '-'
		WHEN Rental.Damage = 0 THEN '-'
		ELSE Rental.DamageDescription END,
	-- Tune Time: IF the rental is COMPLETE and has received a tune, sum the completion time of each job done. If no tune was received, return -2
	CASE WHEN Rental.ReturnDate IS NULL THEN -1
		WHEN SUM(TuneLine.CompletionTime) IS NULL THEN -2
		ELSE SUM(TuneLine.CompletionTime) END,
	-- Days Left Untuned: IF a product was returned but hasn't been tuned yet, count the days since it was returned.
	CASE WHEN Rental.ReturnDate IS NULL THEN -1
		WHEN SUM(TuneLine.CompletionTime) IS NULL THEN DATEDIFF(day, Rental.ReturnDate, GETDATE())
		ELSE -2 END
	FROM Rental
	INNER JOIN Customer
		ON Customer.CustomerID = Rental.CustomerID
	LEFT OUTER JOIN Tune
		ON Rental.RentalID = Tune.RentalID
	LEFT OUTER JOIN TuneLine
		ON Tune.TuneID = TuneLine.TuneID
	INNER JOIN SkiBinding
		ON SkiBinding.SkiBindingID = Rental.SkiBindingID
	INNER JOIN Ski
		ON Ski.SkiID = SkiBinding.SkiID
	INNER JOIN [Binding]
		ON [Binding].BindingID = SkiBinding.BindingID
	INNER JOIN SkiModel
		ON SkiModel.SkiModelID = Ski.SkiModelID
	INNER JOIN BindingModel
		ON BindingModel.BindingModelID = [Binding].BindingModelID
	INNER JOIN Brand
		ON Brand.BrandName = SkiModel.Brand
	GROUP BY Rental.OrderDate, Customer.FirstName, Customer.LastName, Brand.BrandName, SkiModel.Name, SkiModel.WaistWidth,
		Ski.Length, Rental.OrderDate, Rental.ReturnDate, Rental.Damage, Rental.DamageDescription

WITH CHECK OPTION;

GO
SELECT [Order Date], Customer, Ski, Width, Length, [Order Status], [Days Kept], [Tune Time], [Days Left Untuned]

FROM RentalHistory;