CREATE PROCEDURE dbo.spLogin
    @Username NVARCHAR(50),
    @Password NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT UserId, Username 
    FROM Users 
    WHERE Username = @Username AND Password = @Password;
END
GO