
CREATE PROCEDURE [dbo].[CheckIFServicorExist]
    @FirstName VARCHAR(30),
	@MiddleName VARCHAR(30),
    @LastName VARCHAR(30),
	@Gender VARCHAR(30),
    @Description VARCHAR(MAX)
    
AS
BEGIN
    SET NOCOUNT ON;

    SELECT COUNT(*) 
    FROM tblCustomerServicor 
    WHERE FirstName = @FirstName 
	  AND MiddleName = @MiddleName
      AND Gender = @Gender 
      AND Description = @Description;
END
