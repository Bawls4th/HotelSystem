CREATE Procedure [dbo].[InsertServicor]
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
    INSERT INTO tblCustomerServicor(FirstName, MiddleName, LastName, Gender , Description, Price, Available, DateService)
    VALUES (@FirstName, @MiddleName, @LastName, @Gender, @Description, @Price, @Available, @DateService);
	SELECT SCOPE_IDENTITY() AS ServiceID, @FirstName AS FirstName, 
	@MiddleName AS MiddleName, 
	@LastName AS LastName,
	@Gender AS Gender,
	@Description AS Description,
	@Price AS Price,
	@Available AS Available,
	@DateService AS DateService
END;
