-- 17. The titles and taglines of movies that are in the "Family" genre and 
--Samuel L. Jackson has acted in (4 rows)

SELECT title, tagline
FROM movie
JOIN movie_genre on movie_genre.movie_id = movie.movie_id
JOIN genre on genre.genre_id = movie_genre.genre_id
JOIN movie_actor on movie_actor.movie_id = movie.movie_id
JOIN person on person.person_id = movie_actor.actor_id
WHERE genre.genre_name = 'Family' AND person.person_name = 'Samuel L. Jackson'
;
