-- 13. The directors of the movies in the "Harry Potter Collection" (4 rows)

SELECT DISTINCT(person_name)
FROM person
JOIN movie on movie.director_id = person.person_id
JOIN collection on collection.collection_id = movie.collection_id
WHERE collection.collection_name = 'Harry Potter Collection'
;