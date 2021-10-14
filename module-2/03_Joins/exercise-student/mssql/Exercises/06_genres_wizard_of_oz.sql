-- 6. The genres of "The Wizard of Oz" (3 rows)
SELECT genre_name
FROM  genre
JOIN movie_genre on movie_genre.genre_id = genre.genre_id
JOIN movie on movie.movie_id = movie_genre.movie_id
WHERE movie.title like 'The Wizard of Oz%'
;

