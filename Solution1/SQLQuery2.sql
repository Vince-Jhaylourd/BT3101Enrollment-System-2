CREATE TABLE Users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL
);
GO

-- Insert a test user record
INSERT INTO Users (Username, Password) 
VALUES ('ADMIN', '12345');
GO