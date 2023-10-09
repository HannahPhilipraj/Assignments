create database Assignments
use Assignments;

--to create a Client table
create table tblClients(
Client_ID int primary key,
Client_Name varchar(40) not null,
Client_address varchar(30),
Email varchar(30) unique,
Phone bigint,
Business varchar(20) not null)

--to insert values to Client table
insert into tblClients values
(1001,'ACME Utilities','Noida','contact@acmeutil.com',9567880032,'Manufacturing'),
(1002,'Trackon Consultants','Mumbai','consult@trackon.com',8734210090,'Consultant')
select * from tblClients

--to create Departments table
create table Departments
(Dept_no int primary key,
Dept_name varchar(15) not null,
Location varchar(20))

insert into Departments values
(10,'Design','Pune'),(20,'Development','Pune'),
(30,'Testing','Mumbai'),(40,'Document','Mumbai')
select * from Departments

--to create Employees table
create table Employees(
Emp_no int primary key,
Emp_Name varchar(40) not null,
Job varchar(15),
Salary bigint check(salary>0),
Dept_no int foreign key references Departments(Dept_no))

insert into Employees values
(7011,'Anand','Project Manager',65000,10),
(7010,'Smita','Analyst',20000,10)
select * from Employees

create table Projects
(Project_ID int primary key,
Description varchar(30) not null,
Start_date DATE,
Planned_end_date DATE,
Actual_end_date DATE,
constraint check_date check(planned_end_date<actual_end_date),
Budget bigint check(budget>0),
Client_ID int foreign key references tblclients(Client_ID))

insert into Projects values
(404,'Contact Management','2011-11-01','2011-12-31',null,50000,1004),
(403,'Payroll','2011-10-01','2011-12-31',null,75000,1003)
select * from Projects

create table EmpProjectTasks
(Project_ID int foreign key references projects(project_id),
Emp_no int foreign key references employees(emp_no),
Start_date DATE,
End_date DATE,
Task varchar(25) not null,
Status varchar(15) not null,
primary key (project_ID,Emp_no))

insert into EmpProjectTasks values
(402,7002,'2011-08-22','2011-09-30','System Design','Completed'),
(402,7004,'2011-10-01',null,'Coding','In Progress')
select * from EmpProjectTasks
