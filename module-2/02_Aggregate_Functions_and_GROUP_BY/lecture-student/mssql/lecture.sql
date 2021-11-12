-- ORDERING RESULTS

-- Populations of all states from largest to smallest.
SELECT state_name, population
FROM state
ORDER BY population DESC;


-- States sorted alphabetically (A-Z) within their census region. The census regions are sorted in reverse alphabetical (Z-A) order.
SELECT state_name, census_region
FROM state
ORDER BY census_region DESC, state_name ASC;

-- The biggest park by area
SELECT park_name, area
FROM park
ORDER BY area DESC;

-- LIMITING RESULTS

-- The 10 largest cities by populations
SELECT TOP 10 city_name, population
FROM city
ORDER BY population DESC;
-- The 20 oldest parks from oldest to youngest in years, sorted alphabetically by name.
--so we need today's date, and subtract from the year established to find park age
--SELECT YEAR(GETDATE());

SELECT  *,YEAR(GETDATE())- YEAR(date_established) AS age
FROM park
ORDER BY date_established ASC, park_name ASC;

-- CONCATENATING OUTPUTS

-- All city names and their state abbreviation.

SELECT city_name + ', ' + state_abbreviation AS concatenate
FROM city;

-- All park names and area
SELECT park_name + ', ' + CAST (area AS varchar) AS park_area
FROM park;


-- The census region and state name of all states in the West & Midwest sorted in ascending order.
SELECT census_region + ': ' + state_name AS region_as_state
FROM state
WHERE census_region IN ('West', 'Midwest')
ORDER BY census_region, state_name;

-- AGGREGATE FUNCTIONS

-- Average population across all the states. Note the use of alias, common with aggregated values.
SELECT AVG(population) AS average_population
FROM state


-- Total population in the West and South census regions
SELECT SUM(population) AS average_population
FROM state
WHERE census_region = 'West' OR census_region = 'South';



-- The number of cities with populations greater than 1 million
SELECT COUNT(population) AS city_bigpop
FROM city
WHERE population > 1000000;


-- The number of state nicknames.
SELECT COUNT(state_nickname) AS number_state_nickname
FROM state

SELECT COUNT(*) AS number_state_nicknames
FROM state

SELECT state_nickname FROM state


-- The area of the smallest and largest parks.

SELECT MIN(area) AS smallest_park_area, MAX(area) AS largest_park_area
FROM park

-- GROUP BY

-- Count the number of cities in each state, ordered from most cities to least.
SELECT COUNT(city_name) AS number_of_cities, state_abbreviation
FROM city
GROUP BY state_abbreviation


-- Determine the average park area depending upon whether parks allow camping or not.
SELECT AVG(area) AS avg_area_of_parks, has_camping
FROM park
GROUP BY has_camping

-- Sum of the population of cities in each state ordered by state abbreviation.
SELECT SUM(population) AS pop_sum, state_abbreviation
FROM city
GROUP BY state_abbreviation
ORDER BY state_abbreviation;


-- The smallest city population in each state ordered by city population.

SELECT MIN(population) AS minimum_population, state_abbreviation
FROM city
GROUP BY state_abbreviation
ORDER BY minimum_population DESC;
-- Miscelleneous

-- While you can use TOP to limit the number of results returned by a query,
-- it's recommended to use OFFSET and FETCH if you want to get
-- "pages" of results.
-- For instance, to get the first 10 rows in the city table
-- ordered by the name, you could use the following query.
-- (Skip 0 rows, and return only the first 10 rows from the sorted result set.)
SELECT * 
FROM city
ORDER BY city_name
OFFSET 30 ROWS FETCH NEXT 10 ROWS ONLY;
--offset means skip


-- SUBQUERIES (optional)
--the subquery is in parantheses
-- Include state name rather than the state abbreviation while counting the number of cities in each state,
SELECT * ,
	(SELECT state_name FROM state WHERE state_abbreviation = city.state_abbreviation) AS state_name
FROM city;

-- Include the names of the smallest and largest parks
SELECT *
FROM park
WHERE area = 
	(SELECT MIN(area) FROM park)
	OR area =
	(SELECT MAX(area) FROM park);
--another approach
SELECT *
FROM park
WHERE area IN (
	(SELECT MAX(area) FROM park),
	(SELECT MIN(area) FROM park)
	)

-- List the capital cities for the states in the Northeast census region.
SELECT *,
	(SELECT capital FROM state WHERE state_abbreviation = city.state_abbreviation) AS state_name
FROM city
WHERE city_id in (
	SELECT capital FROM state
	);