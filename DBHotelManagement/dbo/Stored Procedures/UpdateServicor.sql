CREATE Procedure [dbo].[UpdateServicor]
@ID INT,
@FirstName varchar(30),
@MiddleName varchar(30),
@LastName varchar(30),
@Gender varchar(30),
@Description VARCHAR(MAX),
@Price DECIMAL (18,2),
@Available BIT,
@DateService DATETIME
AS
BEGIN
   UPDATE tblCustomerServicor
        SET 
       FirstName = @FirstName,
	   MiddleName = @MiddleName,
       LastName = @LastName,
       Gender = @Gender,
	   Description = @Description,
	   Price = @Price,
	   Available = @Available,
       DateService = @DateService
        WHERE 
            ServiceID = @ID;
END;
