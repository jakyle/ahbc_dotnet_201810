-------------------------------------------------------------------------
-------------------------------------------------------------------------
-------------------------------------------------------------------------

-------------------------------------------------------------------------
----------------------  INSERT STATEMENT --------------------------------
-------------------------------------------------------------------------

-- INSERT INTO School.Course
INSERT School.Course
-- Column names can also be omitted but, it is good practice to have them
(
	CourseName
)
VALUES
(
	'Daytime Bootcamp'
)

---- You can also insert a bulk chunk of data with a select statement
--INSERT School.Course
--SELECT ...


-------------------------------------------------------------------------
---------------------- UPDATE STATEMENT --------------------------------
-------------------------------------------------------------------------
SELECT
  *
FROM School.Course

-- SELECT * FROM School.Course
-- A good way to test your statment, thanks Matt ^_^ 
UPDATE School.Course
SET CourseName = 'AHBC'
WHERE CourseID = 1


-------------------------------------------------------------------------
-------------------- DELETE STATEMENT -----------------------------------
-------------------------------------------------------------------------

SELECT
  *
FROM School.StudentCourse

SELECT 
  *
FROM School.Student


--SELECT * FROM School.StudentCourse
DELETE FROM School.StudentCourse
WHERE CourseID = 1 AND StudentID = 2

-- Adding back for and example
--INSERT School.StudentCourse (StudentID, CourseID)
--VALUES (2, 1)

-------------------------------------------------------------------------
----------------------- JOIN STUFF --------------------------------------
-------------------------------------------------------------------------

SELECT
  S.FirstName,
  S.LastName,
  C.CourseName,
  CL.Name AS ClassroomName
FROM School.Student AS S
INNER JOIN School.StudentCourse AS SC -- When just using JOIN, INNER is implied
  ON SC.StudentID = S.StudentID
JOIN School.Course AS C
  ON C.CourseID = SC.CourseID
LEFT OUTER JOIN School.Classroom AS CL
  ON CL.ClassroomID = C.ClassroomID
--WHERE S.StudentID = 2
--  AND CL.ClassroomID IS NULL;

-------------------------------------------------------------------------
------------------------- AGGREGATES ------------------------------------
-------------------------------------------------------------------------
/*

ALTER TABLE School.Course
ADD TotalHours INT NULL

SELECT 
  *
FROM SChool.Course

UPDATE School.Course
SET TotalHours = 200
WHERE CourseID = 1

UPDATE School.Course
SET TotalHours = 300
WHERE CourseID = 2

*/

SELECT
  S.FirstName,
  S.LastName,
  COUNT(*) AS CoursesTaken,
  MAX(C.TotalHours) AS LongestClass,
  MIN(C.TotalHours) AS ShortestClass,
  AVG(C.TotalHours) AS AverageClass
FROM School.Student AS S
INNER JOIN School.StudentCourse AS SC -- When just using JOIN, INNER is implied
  ON SC.StudentID = S.StudentID
JOIN School.Course AS C
  ON C.CourseID = SC.CourseID
LEFT OUTER JOIN School.Classroom AS CL
  ON CL.ClassroomID = C.ClassroomID
GROUP BY 
  S.FirstName,
  S.LastName

-------------------------------------------------------------------------
-------------------------------------------------------------------------
-------------------------------------------------------------------------