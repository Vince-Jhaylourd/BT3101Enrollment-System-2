USE EnrollmentSystem;
GO

CREATE PROCEDURE dbo.spLogin
	@Username NVARCHAR(50),
	@Password NVARCHAR(255)
	AS
BEGIN
	SET NOCOUNT ON;

	SELECT 
		UserId,
		Username
	FROM [dbo].[User]
	WHERE
		Username = @Username 
		AND Password = @Password;
END;
GO