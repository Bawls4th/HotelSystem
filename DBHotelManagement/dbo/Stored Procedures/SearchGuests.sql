CREATE PROCEDURE [dbo].[SearchGuests]
    @SearchTerm NVARCHAR(50),
    @SearchType NVARCHAR(50)
AS
BEGIN
    IF @SearchType = 'Name'
    BEGIN
        SELECT * FROM tblGuest 
        WHERE GFirstName LIKE '%' + @SearchTerm + '%' OR GLastName LIKE '%' + @SearchTerm + '%' OR GMiddleName LIKE '%'+@SearchTerm + '%'
    END
    ELSE IF @SearchType = 'Email'
    BEGIN
        SELECT * FROM tblGuest 
        WHERE GEmailAddress LIKE '%' + @SearchTerm + '%'
    END
    ELSE IF @SearchType = 'ID'
    BEGIN
        SELECT * FROM tblGuest 
        WHERE GuestID = @SearchTerm
    END
END