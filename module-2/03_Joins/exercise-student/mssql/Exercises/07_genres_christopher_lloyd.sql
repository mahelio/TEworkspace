-- 7. The genres of movies that Christopher Lloyd has appeared in (8 rows)
-- Hint: DISTINCT will prevent duplicate values in your query results.

SELECT DISTINCT(genre_name)
FROM genre
JOIN movie_genre on movie_genre.genre_id = genre.genre_id
JOIN movie_actor on movie_actor.movie_id = movie_genre.movie_id
JOIN person on person.person_id = movie_actor.actor_id
WHERE person.person_name = 'Christopher Lloyd'
;