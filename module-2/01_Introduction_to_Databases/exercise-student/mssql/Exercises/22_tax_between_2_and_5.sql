-- 22. The name and sales tax for states and territories with sales tax greater than or equal to 2% and less than or equal to 5% (15 rows)
SELECT state_name, sales_tax
FROM state
WHERE sales_tax BETWEEN 2.000 AND 5.000 -->= 2.000 AND sales_tax <= 5.000 (note: both options will work)
;

