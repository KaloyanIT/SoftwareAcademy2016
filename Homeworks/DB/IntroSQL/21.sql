SELECT e.FirstName + ' ' + e.LastName AS Employee, 
m.FirstName + ' ' + m.LastName AS Manager,
a.AddressText
FROM Employees e, Employees m, Addresses a
WHERE e.ManagerID = m.EmployeeID 
AND e.AddressID = a.AddressID