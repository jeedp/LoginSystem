USE StudentDB;
GO

DROP TABLE dbo.Students;
DROP TABLE dbo.Courses;


CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Age INT,
    Course VARCHAR(50)
);
GO


INSERT INTO Students (StudentID, FirstName, LastName, Age, Course) VALUES
(23902, 'Jamie', 'Torres', 21, 'BS Computer Science'),
(23901, 'Jed', 'Padro', 20, 'BS Computer Engineering'),
(23904, 'Erica', 'Mendoza', 23, 'BS Computer Science'),
(23903, 'Alyssa', 'Navarro', 22, 'BS Information Technology'),
(23905, 'Nathaniel', 'Reyes', 27, 'BS Software Engineering'),
(23906, 'Marcus', 'Dela Cruz', 25, 'BS Information Technology');
GO


CREATE TABLE Courses (
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(100),
    Instructor VARCHAR(100)
);
GO


INSERT INTO Courses (CourseID, CourseName, Instructor) VALUES
(222, 'Software Desigm', 'Engr. Palima'),
(223, 'Operating Systems', 'Engr. Casilli'),
(224, 'Assembly Language', 'Engr. Palima');
GO


SELECT *
FROM Students;
GO