CREATE PROCEDURE [dbo].[CheckIFReceptionistExist]
	@FirstName VARCHAR(50),
    @LastName VARCHAR(50)

AS
BEGIN
    SET NOCOUNT ON;

    SELECT COUNT(*) 
    FROM tblReceptionist 
    WHERE RPFirstName = @FirstName 
	  AND RPLastName = @LastName
END