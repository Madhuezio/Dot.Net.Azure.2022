
create table employeedepartmentmapping(id int identity(1,1),employeeID int,departmentId int);

select * from employeedepartmentmapping
insert into employeedepartmentmapping(employeeID,departmentId) values(1,1)
insert into employeedepartmentmapping(employeeID,departmentId) values(1,2)
insert into employeedepartmentmapping(employeeID,departmentId) values(2,1)
insert into employeedepartmentmapping(employeeID,departmentId) values(3,1)
insert into employeedepartmentmapping(employeeID,departmentId) values(4,2)
select * from [EmployeeDetail]
select * from Department
insert into Department(DepartmentID,DepartmentName) values(2,'Sales')

select employeeid from employeedepartmentmapping where departmentId=1

select dbo.EmployeeName(EmployeeID) as EmployeeName from Department

select dbo.EmployeeName(1)


select * from [EmployeeDetail] where id in (select employeeid from employeedepartmentmapping where departmentId=1)



/*
create table student(id int, name varchar(200));
select * from student

insert into student values(101,'Madhu') 
insert into student values(102,'Ezio') 
insert into student values(103,'Connor')
insert into student values(104,'Cell')

create table course(name varchar(200));

select * from course

insert into course values('Math') 
insert into course values('C++') 
insert into course values('C#')
insert into course values('JS')

*/