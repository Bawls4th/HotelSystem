CREATE PROCEDURE [dbo].[SearchReceptionist]
	@SearchTerm NVARCHAR(50),
    @SearchType NVARCHAR(50)
AS
BEGIN
    IF @SearchType = 'Name'
    BEGIN
        SELECT * FROM tblReceptionist 
        WHERE RPFirstName LIKE '%' + @SearchTerm + '%' OR RPLastName LIKE '%' 
    END
    ELSE IF @SearchType = 'UserName'
    BEGIN
        SELECT * FROM tblReceptionist 
        WHERE RPUserName LIKE '%' 
    END
    ELSE IF @SearchType = 'ID'
    BEGIN
        SELECT * FROM tblReceptionist 
        WHERE RPID = @SearchTerm
    END
END