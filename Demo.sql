
--����ع����� Demo
Select * from A
Select * from B

insert into A values(13,'�ߺ�')

Select * from B
insert into B values('20100001','����',1,GETDATE())
insert into B values('20100002','����',2)

--��ʹ������ִ��
insert into B values('20100002','����',2) 
insert into A values(2,'����') 

Select * from B
Select * from A

--ʹ������ִ��
BEGIN TRANSACTION
	DECLARE @errorSun INT 
SET @errorSun=0 
	insert into B values('20100002','����',2) 
	SET @errorSun=@errorSun+@@ERROR 
	insert into A values(2,'����') SET @errorSun=@errorSun+@@ERROR
IF @errorSun<>0 
BEGIN 
	ROLLBACK TRANSACTION --�ع�����
End 
Else
BEGIN
	COMMIT TRANSACTION	--�ύ����
END

Select * from B
Select * from A


select  GETDATE()