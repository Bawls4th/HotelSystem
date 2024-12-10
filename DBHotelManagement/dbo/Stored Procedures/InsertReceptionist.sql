CREATE PROCEDURE [dbo].[InsertReceptionist]
@FirstName VARCHAR(50),
@LastName VARCHAR(50),
@EmailAddress NVARCHAR(50),
@ContactNo VARCHAR(50),
@UserName NVARCHAR(50),
@Password NVARCHAR(50)

AS
BEGIN
INSERT INTO tblReceptionist(RPFirstName, RPLastName, RPEmailAddress, RPContactNo, RPUserName, RPPassword)
VALUES(@FirstName, @LastName, @EmailAddress, @ContactNo, @UserName, @Password);
SELECT SCOPE_IDENTITY() AS RPID,
@FirstName AS RPFirstName,
@LastName AS RPLastName,
@EmailAddress AS RPEmailAddress,
@ContactNo AS RPContactNo,
@UserName AS RPUserName,
@Password AS RPPassword
END