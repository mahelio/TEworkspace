-- 23. The name and date established of parks opened in the 1960s (6 rows)
SELECT park_name, date_established
FROM park
WHERE DATEPART(YYYY, date_established) BETWEEN 1960 AND 1969
--WHERE DATEPART(YYYY,date_established) >= 1960 AND DATEPART(YYYY,date_established) <= 1969 (NOTE: can use either or but between is cleaner)
;

