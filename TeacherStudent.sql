Create database SchoolDemo
Go 


Use [SchoolDemo]
GO


Create Table Gender
(
   ID int NOT NULL Primary Key ,
   Gender nvarchar(15) NOT NULL,
)
GO

Create Table Teacher
(
 TeacherId int NOT NULL Primary Key identity,
 FirstName nvarchar(20) NOT NULL,
 LastName nvarchar(20) NOT NULL,
 GenderId int NOT NULL,
 Topic nvarchar(30) NOT NULL,
 constraint tbleTeacher_GenderID_FK
 Foreign Key (GenderId) references Gender(ID)
)
GO

Create Table Pupil
(
 PupilId int NOT NULL Primary Key identity ,
 FirstName nvarchar(20) NOT NULL,
 LastName nvarchar(20) NOT NULL,
 GenderId int NOT NULL,
 Grade nvarchar(30) NOT NULL ,
 constraint tblePupil_GenderId_FK
 Foreign Key (GenderId) references Gender(ID)
)
GO

Create Table Student_Pupil
(
 TeacherId int NOT NULL,
 StudentId int NOT NULL,
 constraint Student_Pupil_PK primary key (TeacherId,StudentId),
 constraint TeacherId_FK foreign key(TeacherId) references Teacher (TeacherId),
 constraint Student_FK foreign key(StudentId) references Pupil (PupilId),
)
GO

select tich.TeacherId ,tich.FirstName , tich.LastName , tich.Topic ,tich.GenderId
from Teacher as tich
inner join Student_Pupil as sttich on tich.TeacherId = sttich.TeacherId
inner join Pupil as st on sttich.StudentId= st.PupilId
where st.FirstName = 'გიორგი'

go
