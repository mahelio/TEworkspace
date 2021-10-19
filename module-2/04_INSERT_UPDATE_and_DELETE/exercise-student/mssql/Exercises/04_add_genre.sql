-- 4. Add a "Sports" genre to the genre table. Add the movie "Coach Carter" to the newly created genre. (1 row each)

/*INSERT INTO genre (genre_name)
VALUES ('Sports')
INSERT INTO movie_genre ( movie_id, genre_id)
VALUES (7214, 11771)*/;

--SELECT m.title, g.genre_name
--FROM MOVIE M
--JOIN MOVIE_GENRE MG ON MG.movie_id = m.movie_id
--JOIN genre g on g.genre_id = mg.genre_id
--WHERE g.genre_name = 'Sports';

--Select * From movie;

BEGIN TRANSACTION;

INSERT INTO genre (genre_name)
VALUES ('Sports');

INSERT INTO movie_genre (movie_id, genre_id)
VALUES ( (SELECT movie_id FROM movie WHERE title = 'Coach Carter') , (SELECT genre_id FROM genre WHERE genre_name = 'Sports'));

COMMIT;

--TEST

SELECT title 
FROM movie
JOIN movie_genre mg ON mg.movie_id = movie.movie_id
JOIN genre g ON g.genre_id = mg.genre_id
WHERE g.genre_name = 'Sports';