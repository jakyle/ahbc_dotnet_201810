SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE School.StudentsGet

AS
BEGIN
	SET NOCOUNT ON;

     SELECT
	  S.FirstName,
	  S.LastName,
	  C.CourseName,
	  CL.Name AS ClassroomName
	FROM School.Student AS S
	JOIN School.StudentCourse AS SC
	  ON SC.StudentID = S.StudentID
	JOIN School.Course AS C
	  ON C.CourseID = SC.CourseID
	LEFT OUTER JOIN School.Classroom AS CL
	  ON CL.ClassroomID = C.ClassroomID
END
GO
