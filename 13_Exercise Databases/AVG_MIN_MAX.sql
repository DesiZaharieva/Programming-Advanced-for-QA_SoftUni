SELECT d.name AS department_name,
 COUNT(e.id) AS total_employees,
 AVG(e.salary) AS average_salary,
 MIN(e.salary) AS min_salary,
 MAX(e.salary) AS max_salary
FROM departments d
LEFT JOIN employees e ON d.id = e.department_id
GROUP BY d.name
HAVING total_employees >= 2
ORDER BY average_salary DESC;