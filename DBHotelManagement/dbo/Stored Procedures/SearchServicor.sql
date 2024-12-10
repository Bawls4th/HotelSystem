CREATE PROCEDURE [dbo].[SearchServicor]
    @SearchTerm VARCHAR(50),
    @SearchType VARCHAR(50)
AS
BEGIN
    IF @SearchType = 'Name'
    BEGIN
       SELECT * FROM tblCustomerServicor
        WHERE FirstName LIKE '%' + @SearchTerm + '%' OR LastName LIKE '%' + @SearchTerm + '%' OR MiddleName LIKE '%'+@SearchTerm + '%'
    END

    ELSE IF @SearchType = 'ID'
    BEGIN
		SELECT * FROM tblCustomerServicor
        WHERE ServiceID  = @SearchType
    END

    ELSE IF @SearchType = 'Availability'
    BEGIN
		SELECT * FROM tblCustomerServicor 
        WHERE Available LIKE '%' + @SearchTerm + '%'
    END
END
