-- 18. The count of the number of cities (name column 'num_cities') and the state abbreviation for each state and territory (exclude state abbreviation DC).
-- Order the results by state abbreviation.
-- (55 rows)

SELECT count(city_name) as [num_cities], state_abbreviation
FROM city
WHERE state_abbreviation <> 'DC'
GROUP BY state_abbreviation
ORDER BY state_abbreviation
;

/*select count(district), district from city where countrycode = 'USA'
group by district order by district */