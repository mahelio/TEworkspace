USE assessment;
GO

-- Select all columns from posts that are published
	Select *
	FROM posts
	WHERE published IS NOT NULL;
-- Select posted_by and body from comments that have a body and were created after Oct. 15, 2019
	SELECT posted_by, body
	FROM comments
	WHERE body IS NOT NULL AND created > CONVERT(datetime, '2019-10-15');
-- Select the name and published states from posts ordered by when they were created, earliest first
	SELECT name, published
	FROM posts
	ORDER BY created ASC;
-- Select the created date and the count of all the comments created on that date
	SELECT created, COUNT(created) AS created_count
	FROM  comments
	GROUP BY created
	
-- Select the post name, comment posted_by and comment body for all posts created after Oct. 1st, 2019
SELECT p.name, c.posted_by, c.body
FROM comments c
JOIN posts p ON c.post_id = c.id
WHERE p.name > '2019-10-01';