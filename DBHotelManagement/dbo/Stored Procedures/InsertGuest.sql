CREATE Procedure [dbo].[InsertGuest]
	@FirstName VARCHAR(50),
	@MiddleName VARCHAR(50),
	@LastName VARCHAR(50),
    @BirthDate date,
	@Age int,
	@Gender varchar(50),
	@Ethnicity varchar(50),
    @EmailAddress NVARCHAR(30),
    @ContactNo VARCHAR(50),
	@TimeRegistered datetime
AS
BEGIN
    INSERT INTO tblGuest (GFirstName, GMiddleName, GLastName, BirthDate, Age, Gender, Ethnicity, GEmailAddress, GContactNo, Registered)
    VALUES (@FirstName, @MiddleName, @LastName, @BirthDate, @Age, @Gender, @Ethnicity, @EmailAddress, @ContactNo, @TimeRegistered);
	SELECT SCOPE_IDENTITY() AS GuestID, @FirstName AS GFirstName, 
	@MiddleName AS GMiddleName, 
	@LastName AS GLastName,
	@BirthDate AS BirthDate,
	@Age AS Age,
	@Gender AS Gender,
	@Ethnicity AS Ethnicity,
	@EmailAddress AS GEmailAddress,
	@ContactNo AS GContactNo,
	@TimeRegistered AS Registered
END;