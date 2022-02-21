--userdetails database
use UserLog;

Create table userdetails (Id int identity(1,1),FirstName varchar(200),
LastName varchar(200),Gender varchar(200),IsDeleted int default 0,DOB date,
EmailId nvarchar(200),Primary key(Id)
);

Create table tbluser(Id int identity(1,1),UserName nvarchar(200),
Password nvarchar(200),UserID int,IsDeleted int default 0,Primary key(Id),FOREIGN KEY(UserID) References userdetails(ID)
);


--3.problem

create table tblrole(Id int identity(1,1), RoleName varchar(200), IsDeleted int default 0, Primary key(Id));

create table tblmenumaster(Id int identity(1,1), pagename varchar(200), Primary key(Id));


create table tblroleusermapping(Id int identity(1,1), Roleid int, Userid int, IsDeleted int default 0,Primary key(Id),
FOREIGN KEY(Roleid) References tblrole(ID),FOREIGN KEY(Userid) References tbluser(ID)
);

create table tblmenurolemapping(Id int identity(1,1), menuid int , roleid int, IsDeleted int default 0,Primary key(Id),
FOREIGN KEY(menuid) References tblmenumaster(ID),FOREIGN KEY(roleid) References tblrole(ID)
);

select * from tblrole
select * from tblmenumaster
select * from tblroleusermapping
select * from tblmenurolemapping

Create proc GetMenuByUser(@UserID int)
As Begin

select M.PageName from tbluser T inner join tblroleusermapping TUM on TUM.UserId=T.UserId 
inner join tblmenurolemapping MRM on MRM.RoleId=TUM.RoleId 
inner join tblmenumaster M on M.Id=MRM.MenuId where T.Id=@UserID;

End

exec GetMenuByUser 1








select * from tbluser;
select * from userdetails;

Create Proc Login(@username nvarchar(200),@password nvarchar(200)) as
begin


if((select count(*) from tbluser where username=@username and [password]=@password)>0) 
select 1 as ValidUserName;
else
select 0 as ValidUserName;



END

exec Login 'vikash@dummy.com1','123456'



Create Proc AddUserDetails(@firstname nvarchar(200),@lastname nvarchar(200),@gender varchar(20),@dob date,@email nvarchar(200)) as
begin


insert into userdetails(FirstName,LastName,Gender,DOB,EmailId) values(@firstname,@lastname,@gender,@dob,@email);
insert into tbluser(username,[password],UserID) values(@email,'123456',IDENT_CURRENT('userdetails'))

END

exec AddUserDetails 'Sumit','Kumar','Male','12/09/1978','Sumit.Kumar@dummy.com'
