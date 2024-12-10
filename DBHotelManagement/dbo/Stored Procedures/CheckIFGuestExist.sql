CREATE PROCEDURE [dbo].[CheckIFGuestExist]
    @FirstName VARCHAR(50),
	@MiddleName VARCHAR(50),
    @LastName VARCHAR(50),
    @EmailAddress NVARCHAR(50),
    @ContactNo VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT COUNT(*) 
    FROM tblGuest 
    WHERE GFirstName = @FirstName 
	  AND GMiddleName = @MiddleName
      AND GLastName = @LastName 
      AND GEmailAddress = @EmailAddress 
      AND GContactNo = @ContactNo;
END