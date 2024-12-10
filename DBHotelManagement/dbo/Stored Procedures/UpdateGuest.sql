CREATE Procedure [dbo].[UpdateGuest]
    @ID INT,
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
     UPDATE tblGuest
        SET 
            GFirstName = @FirstName,
			GMiddleName = @MiddleName,
            GLastName = @LastName,
			BirthDate = @BirthDate,
			Age = @Age,
			Gender = @Gender,
			Ethnicity = @Ethnicity,
            GEmailAddress = @EmailAddress,
            GContactNo = @ContactNo,
			Registered = @TimeRegistered
        WHERE 
            GuestID = @ID;
END;