create table Department
(Dept_no int primary key,Dept_name varchar(20) not null,Location varchar(15))

insert into Department values
(10,'Accounting','New York'),(20,'Research','Dallas'),
(30,'Sales','Chicago'),(40,'Operations','Boston')
select * from department

create table Employee
(Emp_no int, Emp_name varchar(40),
Job varchar(20), manager_ID int,
Hire_date DATE, Salary bigint, Comm int,
Dept_no int foreign key references Department(dept_no))

insert into Employee values
(7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30),
(7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30)
select * from employee

--names starts with 'A'
select * from Employee where Emp_name like 'A%'

--don't have manager
select * from Employee where manager_ID is null

--salary range is 1200 to 1400
select emp_no,emp_name,salary from Employee where Salary between 1200 and 1400

--10% rise for research dept
select emp_name,salary as 'Before rise',(salary+salary/10) as 'After rise' from Employee 
where Dept_no=(select dept_no from Department where dept_name like 'Research')

--no of clerks employed
select count(job) as 'No. of Clerks employed' from employee where job like 'Clerk'

--avg salary of each job type & no of ppl employed in each job
select job,avg(salary) 'Average salary',count(job) 'No.of people' from employee group by job

--employees with lowest & highest salary
select emp_no,emp_name,salary from employee where salary=(select min(salary) 'Lowest salary' from employee)
select emp_no,emp_name,salary from employee where salary=(select max(salary) 'Highest salary' from employee)

--departments that don't have employees
select * from Department where dept_no!=all(select distinct(dept_no) from employee)

--analysts earning>1200 in dept 20 in asc order of name
select emp_name,salary from Employee where job like 'analyst' and Dept_no=20 and salary>1200
order by Emp_name

--total salary in each dept
select d.dept_no,d.Dept_name, sum(e.salary) as 'Total Salary' from Department d, Employee e
where d.Dept_no = e.Dept_no group by d.dept_no,d.Dept_name

--salary of miller and smith
select emp_no,emp_name,salary from employee where emp_name in('smith','miller')

--name begin with a or m
select emp_no,emp_name from employee where Emp_name like '[am]%'

--yearly salary of smith
select emp_no,emp_name,salary,salary*12 'Yearly salary' from employee where emp_name like 'smith'

--salary not in range of 1500 and 2850
select emp_name,salary from employee where salary not between 1500 and 2850

--managers having more than 2 emps reporting
select manager_id, count(emp_no)'No of employees' from employee
group by manager_id
having count(emp_no)>2

with mycte(emp_no,emp_name,manager_id,emp_level)
as(select Emp_no,emp_name,manager_id, 1 emp_level
from employee where manager_id is null     -- initial query
union all
select e.emp_no,e.emp_name,e.manager_id, mct.emp_level + 1  -- recursive query
from employee e inner join mycte mct on e.manager_id=mct.emp_no
where e.manager_id is not null)
select * from mycte order by emp_level