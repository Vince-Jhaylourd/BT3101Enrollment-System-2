USE EnrollmentSystem;

CREATE TABLE [dbo].[User]
(
	UserId INT IDENTITY(1,1) PRIMARY KEY,
	Username NVARCHAR(50) NOT NULL,
	Password NVARCHAR(255) NOT NULL,
	);

	INSERT INTO [dbo].[User] (Username, Password) VALUES
	('admin', '12345');
	