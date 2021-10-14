-- 8. The genres of movies that Robert De Niro has appeared in that were released in 
--2010 or later (6 rows)

SELECT DISTINCT(genre_name)
FROM genre
JOIN movie_genre on movie_genre.genre_id = genre.genre_id
JOIN movie on movie.movie_id = movie_genre.movie_id
JOIN movie_actor on movie_actor.movie_id = movie_genre.movie_id
JOIN person on person.person_id = movie_actor.actor_id
WHERE person.person_name = 'Robert De Niro' AND DATEPART(YYYY,movie.release_date)>=2010 
;


