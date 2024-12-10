CREATE PROCEDURE [dbo].[UpdateReceptionist]
@ID INT,
@FirstName VARCHAR(50),
@LastName VARCHAR(50),
@EmailAddress NVARCHAR(50),
@ContactNo VARCHAR(50),
@UserName NVARCHAR(50),
@Password NVARCHAR(50)

AS 
BEGIN
UPDATE
tblReceptionist

SET
RPFirstName = @FirstName,
RPLastName = @LastName,
RPEmailAddress = @EmailAddress,
RPContactNo = @ContactNo,
RPUserName = @UserName,
RPPassword = @Password
WHERE
RPID = @ID;
END