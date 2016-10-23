SELECT e.FirstName + ' ' + e.LastName AS FullName, a.AddressText
FROM Employees e 
INNER JOIN Addresses a
ON e.AddressID = a.AddressID