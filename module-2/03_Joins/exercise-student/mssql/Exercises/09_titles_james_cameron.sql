-- 9. The titles of movies directed by James Cameron (6 rows)
SELECT title
FROM movie
JOIN person on person.person_id = movie.director_id
WHERE person.person_name = 'James Cameron'
;
