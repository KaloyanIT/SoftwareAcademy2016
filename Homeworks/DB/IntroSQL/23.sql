--left outer join
SELECT ISNULL(e.FirstName + ' ' + e.LastName, 'not responsible enought') AS Employee,
m.FirstName + ' ' + m.LastName AS Manager
FROM Employees e
RIGHT JOIN Employees m
ON e.ManagerID = m.EmployeeID

--right outer join
SELECT e.FirstName + ' ' + e.LastName AS Employee,
ISNULL(m.FirstName + ' ' + m.LastName, 'Unmanageable') AS Manager
FROM Employees e
LEFT JOIN Employees m
ON e.ManagerID = m.EmployeeID