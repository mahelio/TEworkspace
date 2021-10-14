-- 21. For every person in the person table with the first name of "George", 
--list the number of movies they've been in--include all Georges, even those that have 
--not appeared in any movies. Display the names in alphabetical order. (59 rows)
-- Name the count column 'num_of_movies'

SELECT person_name, COUNT(ma.movie_id) num_of_movies
FROM person AS p
LEFT JOIN movie_actor AS ma ON ma.actor_id = p.person_id
WHERE p.person_name like 'George %'
GROUP BY p.person_name, p.person_id
ORDER BY p.person_name
;