-- 16. The names and birthdays of actors born in the 1950s who acted in movies that were 
--released in 1985 (20 rows)

SELECT DISTINCT(person_name), birthday
FROM person
JOIN movie_actor on movie_actor.actor_id = person.person_id
JOIN movie on movie.movie_id = movie_actor.movie_id
WHERE DATEPART(YYYY,person.birthday) BETWEEN 1950 and 1959 AND DATEPART(YYYY, movie.release_date) = 1985
;