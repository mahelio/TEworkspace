-- 4. The titles and taglines of all the movies that are in the Fantasy genre. 
--Order the results by title (A-Z) (81 rows)

SELECT title, tagline
FROM movie
JOIN movie_genre on movie_genre.movie_id = movie.movie_id
JOIN genre on genre.genre_id = movie_genre.genre_id
WHERE genre.genre_name = 'Fantasy'
ORDER BY title
;
