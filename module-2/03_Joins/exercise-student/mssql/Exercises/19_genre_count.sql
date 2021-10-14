-- 19. The genre name and the number of movies in each genre. 
--Name the count column 'num_of_movies'. 
-- (19 rows, expected result for Action is around 180).

SELECT genre.genre_name, COUNT(movie.title) num_of_movies 
FROM movie
JOIN movie_genre on movie_genre.movie_id = movie.movie_id
JOIN genre on genre.genre_id = movie_genre.genre_id
GROUP BY genre_name
;