CREATE PROCEDURE spLogin
	@Username NVARCHAR(50),
	@PasswordHash NVARCHAR(255)
	AS 
BEGIN
	SELECT 
		UserId,
		Username
	FROM [User]
	WHERE Username = @Username
	AND Password = @Password
END;