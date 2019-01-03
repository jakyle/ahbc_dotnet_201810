SELECT 
  *
FROM School.Course
WHERE CourseID >= 1 AND CourseName LIKE '%Bootcamp'

SELECT * FROM School.Classroom

SELECT
  *
FROM School.Student

SELECT
  *
FROM School.StudentCourse

SELECT
  C.CourseName,
  CR.Name
FROM School.Course AS C
JOIN School.Classroom AS CR
  ON CR.ClassroomID = C.ClassroomID

  
SELECT
  C.CourseName,
  CR.Name AS ClassroomName,
  S.FirstName,
  S.LastName
FROM School.Course AS C
JOIN School.Classroom AS CR
  ON CR.ClassroomID = C.ClassroomID
JOIN School.StudentCourse AS SC
  ON SC.CourseID = C.CourseID
JOIN School.Student AS S
  ON S.StudentID = SC.StudentID