CREATE DATABASE Student

CREATE TABLE StudentDetails (
    StudentId int primary key,
    StudentName varchar(255),
    Gender varchar(255),
    Age int
);





insert into StudentDetails(StudentId,StudentName,Gender,Age)values(0,'Ashutosh','Male',24)
insert into StudentDetails(StudentId,StudentName,Gender,Age)values(1,'biswal','Male',36)

select * from StudentDetails