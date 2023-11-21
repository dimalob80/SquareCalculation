SELECT c.Name, p.Name
FROM Products p
LEFT JOIN Categories c
ON p.CategoryId = c.Id