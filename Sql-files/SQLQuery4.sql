use Camp;

/*
---create a table with employees
---add a new column with gender
--add all as male
--then update female staff from male to female

create table EmployeeDetail(id int,employeename varchar(200))
select * from EmployeeDetail
insert into EmployeeDetail values(1,'Vikash 1');
insert into EmployeeDetail values(2,'Vikash 2');
insert into EmployeeDetail values(3,'Vikash 3');
insert into EmployeeDetail values(4,'Vikash 4');
alter table EmployeeDetail add gender varchar(30)

update EmployeeDetail set gender='Male' 
update EmployeeDetail set gender='Female' where ID in (2,4)

--order by clasues

select * from EmployeeDetail order by employeename desc

*/

---create a table with student
---add a new column with gender
--add all as male
--then update female student to male

create table StudentDetail(id int,studentename varchar(200))
select * from StudentDetail
insert into StudentDetail values(1,'Vikash 1');
insert into StudentDetail values(2,'Vikash 2');
insert into StudentDetail values(3,'Vikash 3');
insert into StudentDetail values(4,'Vikash 4');
alter table StudentDetail add gender varchar(30)

update StudentDetail set gender='Male' 
update StudentDetail set gender='Female' where ID in (2,4)

--order by clasues

select * from StudentDetail order by studentename desc