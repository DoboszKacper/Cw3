Insert into Student(IndexNumber,FirstName,LastName,BirthDate,IdEnrollment)
Values('s18903','Kacper','Dobosz','1998-12-12',1);
Insert into Student(IndexNumber,FirstName,LastName,BirthDate,IdEnrollment)
Values('s18932','Mikołaj','Janusz','2000-01-17',2);
Insert into Student(IndexNumber,FirstName,LastName,BirthDate,IdEnrollment)
Values('s18123','Patryk','Miernowski','2001-12-19',3);
Insert into Student(IndexNumber,FirstName,LastName,BirthDate,IdEnrollment)
Values('s13203','Michał','Mierzejewski','2000-02-11',4);
Insert into Student(IndexNumber,FirstName,LastName,BirthDate,IdEnrollment)
Values('s11233','Karol','Obrębski','2001-11-15',5);
Insert into Student(IndexNumber,FirstName,LastName,BirthDate,IdEnrollment)
Values('s16423','Dawid','Grigorian','1998-05-08',6);


Insert into Enrollment(IdEnrollment,Semester,IdStudy,StartDate)
Values(1,1,3,'2015-12-17');
Insert into Enrollment(IdEnrollment,Semester,IdStudy,StartDate)
Values(2,2,1,'2013-11-11');
Insert into Enrollment(IdEnrollment,Semester,IdStudy,StartDate)
Values(3,2,1,'2018-10-27');
Insert into Enrollment(IdEnrollment,Semester,IdStudy,StartDate)
Values(4,5,2,'2016-10-28');
Insert into Enrollment(IdEnrollment,Semester,IdStudy,StartDate)
Values(5,1,2,'2015-04-05');
Insert into Enrollment(IdEnrollment,Semester,IdStudy,StartDate)
Values(6,3,1,'2017-06-13');

Insert into Studies(IdStudy,Name)
Values(1,'IT');
Insert into Studies(IdStudy,Name)
Values(2,'Art');
Insert into Studies(IdStudy,Name)
Values(3,'Law');