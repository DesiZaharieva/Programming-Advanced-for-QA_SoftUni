USE taskboard;

SELECT *FROM aspnetusers;


SELECT *FROM tasks;


SELECT *FROM boards;


INSERT INTO tasks ( Title, `Description`, BoardId, CreatedOn, OwnerId)
VALUES ('First Exercise Task with SQL', 'My taskcreated with SQL', '1', NOW(), 'cd9d6c0f-6ddb-4dc2-9365-a21135e542cb');


SELECT *FROM boards;

INSERT INTO boards (`name`) VALUES ('On Hold');

INSERT INTO tasks ( Title, `Description`, BoardId, CreatedOn, OwnerId)
VALUES ('First Exercise Task with SQL1', 'My taskcreated with SQL', '5', NOW(), 'cd9d6c0f-6ddb-4dc2-9365-a21135e542cb'),
	   ('First Exercise Task with SQL2', 'My taskcreated with SQL', '5', NOW(), 'cd9d6c0f-6ddb-4dc2-9365-a21135e542cb'),
	   ('First Exercise Task with SQL3', 'My taskcreated with SQL', '5', NOW(), 'cd9d6c0f-6ddb-4dc2-9365-a21135e542cb');
       
SELECT *FROM tasks
WHERE id = 20;

SELECT *FROM tasks
WHERE title = "Delete task";

DELETE FROM tasks
WHERE Id = 23;

UPDATE tasks
SET title = "Updated title"
WHERE Id = 24

SELECT *FROM tasks;

SELECT *FROM tasks
WHERE Title = "Task for Homework";

UPDATE tasks
SET Title = "Updated title", Description = "Lalala"
WHERE Id = 25;

SELECT *FROM tasks

SELECT *FROM tasks
WHERE Id IN (5, 24, 21, 22, 25);


