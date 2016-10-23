SELECT e1.FirstName + ' ' + e1.LastName AS Employee, 
e2.FirstName + ' ' + e2.LastName AS Manager
FROM Employees e1, Employees e2
WHERE e1.ManagerID = e2.EmployeeID