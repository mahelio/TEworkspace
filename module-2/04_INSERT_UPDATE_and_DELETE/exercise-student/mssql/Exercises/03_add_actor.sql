-- 3. Did you know Eric Stoltz was originally cast as Marty McFly in "Back to the Future"? 
--Add Eric Stoltz to the list of actors for "Back to the Future" (1 row)

INSERT INTO movie_actor(movie_id, actor_id)
VALUES ( (SELECT movie_id FROM movie WHERE title = 'Back to the Future'), (SELECT person_id FROM person WHERE person_name = 'Eric Stoltz'));

--Check
/*SELECT title, p.person_name
FROM movie m
JOIN movie_actor ma ON ma.movie_id = m.movie_id
JOIN person p ON p.person_id = ma.actor_id
WHERE title = 'Back to the Future';*/



