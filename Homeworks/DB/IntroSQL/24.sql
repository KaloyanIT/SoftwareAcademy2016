SELECT e.FirstName + ' ' + e.LastName AS Employee, e.HireDate,
d.Name
FROM Employees e, Departments d
WHERE e.DepartmentID = d.DepartmentID AND d.Name IN ('Sales', 'Finance')
AND e.HireDate BETWEEN '1995-01-01 00:00:00' AND '2005-12-31 00:00:00'