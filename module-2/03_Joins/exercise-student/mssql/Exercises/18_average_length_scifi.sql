-- 18. The average length of movies in the "Science Fiction" genre. 
--Name the column 'average_length'.
-- (1 row, expected result around 110-120)

SELECT AVG(length_minutes) average_length
FROM movie
JOIN movie_genre on movie_genre.movie_id = movie.movie_id
JOIN genre on genre.genre_id = movie_genre.genre_id
WHERE genre.genre_name = 'Science Fiction'
;