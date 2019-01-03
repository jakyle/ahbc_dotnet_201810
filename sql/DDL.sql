USE AdventureWorks2017;
GO 

CREATE SCHEMA School;

CREATE TABLE School.Student
(
	StudentID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL
)


CREATE TABLE School.Course
(
	CourseID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	CourseName NVARCHAR(50) NOT NULL
)

CREATE TABLE School.Classroom
(
	ClassroomID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name NVARCHAR(50) NOT NULL
)

ALTER TABLE School.Course
ADD ClassroomID INT NULL

ALTER TABLE School.Course
ADD FOREIGN KEY (ClassroomID) REFERENCES School.Classroom(ClassroomID)

CREATE TABLE School.StudentCourse
(
	StudentID INT NOT NULL,
	CourseID INT NOT NULL,
	CONSTRAINT PK_StudentCourse PRIMARY KEY (StudentID, CourseID),
    FOREIGN KEY (CourseID) REFERENCES School.Course(CourseID),
    FOREIGN KEY (StudentID) REFERENCES School.Student(StudentID)
)

INSERT School.Course
(
	CourseName
)
VALUES
(
	'Daytime Bootcamp'
)

INSERT School.Classroom
(
	Name
)
VALUES
(
	'Yellow Room'
)

INSERT School.Student
(
	FirstName,
	LastName
)
VALUES
(
	'Zack',
	'Finn'
)

INSERT School.StudentCourse
(
	StudentID,
	CourseID
)
VALUES
(
	2,
	2
)

UPDATE School.Course
SET ClassroomID = 1
WHERE CourseName = 'Daytime Bootcamp'