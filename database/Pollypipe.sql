SELECT CustomerID,SUM(Total_Pay) AS [Total Payment] FROM Payment GROUP BY CustomerID HAVING MAX(Total_Pay)>50000




SELECT * FROM Customer WHERE CustomerID IN (SELECT CustomerID FROM Customer WHERE C_Gender='Male')

select * from Customer
select * from Orders
select * from Payment
SELECT * FROM Payment WHERE Advance BETWEEN 1000 AND 5000



insert into Payment values ('P04','OR002',10000,5000,'2022-06-13','2022-07-18')



DELETE FROM Payment WHERE PaymentID='P04'



SELECT InstallationID,C_Name AS [Customer Name],C_Mail AS [E-Mail],Total_Pay AS [Full Amount],Advance FROM Installation I
JOIN Customer C ON C.CustomerID = I.CustomerID
JOIN Installation_Type IT ON IT.InstallTyID = I.InstallTyID
JOIN Payment P ON P.CustomerID = C.CustomerID





