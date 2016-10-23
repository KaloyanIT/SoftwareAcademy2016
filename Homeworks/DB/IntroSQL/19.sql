SELECT e.FirstName + ' ' + e.LastName AS FullName, a.AddressText
FROM Employees e, Addresses a
WHERE e.AddressID = a.AddressID