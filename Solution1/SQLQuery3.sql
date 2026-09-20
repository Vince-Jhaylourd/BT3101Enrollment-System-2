USE EnrollmentSystem;
GO

EXEC dbo.spLogin 
	@Username = 'admin', 
	@Password = '12345';