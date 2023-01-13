create database NewDreamron;
Use NewDreamron;



--Employee--

create table Employee 
(EmpID varchar(10) primary key constraint Eid CHECK (EmpID like 'EMP%'),EType varchar(10)not null,EFName varchar (20) not null,ELName varchar (20) not null,
ESName varchar (30) not null,EIniName varchar(25) not null,
ENIC varchar(13)not null,EGender varchar(8)not null,EDOB Date not null,AddressNo varchar(15)not null,Street varchar(30)not null,City varchar(30)not null,
EMobile int not null,Email varchar(35) not null,EPassword varchar(15)not null,ERegDate Date not null,GradeID varchar(5) References Grade(GradeID) );

-- Lecturer--
create table Lecturer(LID varchar(10)primary key constraint Lid CHECK (LID like 'LEC%'),LFName varchar (20) not null,LLName varchar (20) not null,LSName varchar (30) not null,
LIniName varchar(25) not null,LNIC varchar(13)not null,LGender varchar(8)not null,LDOB Date not null,AddressNo varchar(15)not null,Street varchar(30)not null,City varchar(30)not null,
LMobile int not null,LEmail varchar(35) not null,LRegDate Date not null,GradeID varchar(5) References Grade(GradeID) );

--Student--

create table Student(SID varchar(10)primary key constraint Sid CHECK (SID like 'STU%'),SFName varchar (20) not null,SLName varchar (20) not null,SSName varchar (30) not null,
SIniName varchar(25) not null,SNIC varchar(13)not null,SGender varchar(8)not null,SDOB Date not null,AddressNo varchar(15)not null,Street varchar(30)not null,City varchar(30)not null,SMobile int not null,SEmail varchar(35) not null);

--Course--

create table Course(CID varchar(10) primary key , CName varchar(50) not null,CDuratin int not null,CFee decimal(9,2)not null);

--Batch--

create table Batch(BatchID varchar(10)primary key,StartDate Date not null,EndDate Date not null,Seats int not null,CourseID varchar(10)References Course(CID));



--Grade--

create table Grade(GradeID varchar(5)primary key,GradeName varchar(15) not null,
BasicSalary decimal(9,2)not null,EPF decimal(5,2)not null,ETF decimal(5,2)not null,LeavesPerMonth int not null,Allowance decimal (9,2)not null,SalaryPerDay decimal(9,2)not null);


--Payment--

create table Payment(RefNo varchar(10)primary key,Amount decimal(9,2)not null,
PayDate Date not null,PaymentMethods varchar(20)not null,
StdID varchar(10)References Student(SID),CourseID varchar(10)References Course(CID));

--Salary--

create table Salary(RefNo varchar(10)primary key,NetSal decimal(9,2),
Date_of_cal Date not null,Epf_amount decimal(9,2)not null,Etf_amount decimal(9,2)not null,EmpID varchar(10)References Employee(EmpID),
LecID varchar(10)References Lecturer(LID));

--Attendance--

create table Attendance(AttendanceID INT IDENTITY PRIMARY KEY,RoleType varchar(10)not null,AStatus varchar(10)not null,ADate Date not null,ATimeIn varchar(10)not null,ATimeOut varchar(10)not null,
LecID varchar(10)References Lecturer(LID),
StdID varchar(10)References Student(SID),EmpID varchar(10)References Employee(EmpID));


--Leaves--

create table Leave(LeaveID INT IDENTITY PRIMARY KEY,LType varchar(10)not null,LDate Date not null,
LStatus varchar(10)not null,Reason varchar(255)not null,Checks varchar(1),Approved_Employee_Id varchar(10)References Employee(EmpID),
EmpID varchar(10)References Employee(EmpID),LecID varchar(10)References Lecturer(LID));

--Lecturer_Course--

create table Lecturer_Course(LecID varchar(10)References Lecturer(LID),CourseID varchar(10)References Course(CID),primary key(LecId,CourseID));

--Student_Course--

create table Student_Course( StdID varchar(10)References Student(SID),CourseID varchar(10)References Course(CID),RegDate Date not null,primary key(StdID,CourseID));


--Student_Batch--

create table Student_Batch(StdID varchar(10)References Student(SID),BatchID varchar(10) References Batch(BatchID),primary key(StdID,BatchID));
