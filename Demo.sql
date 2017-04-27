
--事务回滚案例 Demo
Select * from A
Select * from B

insert into A values(13,'芜湖')

Select * from B
insert into B values('20100001','张三',1,GETDATE())
insert into B values('20100002','李四',2)

--不使用事务执行
insert into B values('20100002','李四',2) 
insert into A values(2,'大连') 

Select * from B
Select * from A

--使用事务执行
BEGIN TRANSACTION
	DECLARE @errorSun INT 
SET @errorSun=0 
	insert into B values('20100002','李四',2) 
	SET @errorSun=@errorSun+@@ERROR 
	insert into A values(2,'大连') SET @errorSun=@errorSun+@@ERROR
IF @errorSun<>0 
BEGIN 
	ROLLBACK TRANSACTION --回滚事务
End 
Else
BEGIN
	COMMIT TRANSACTION	--提交事务
END

Select * from B
Select * from A


select  GETDATE()