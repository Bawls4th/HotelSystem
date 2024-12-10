CREATE PROCEDURE [dbo].[SearchRooms]
    @SearchTerm VARCHAR(50),
    @SearchType VARCHAR(50)
AS
BEGIN
    IF @SearchType = 'RoomID'
    BEGIN
        SELECT * FROM tblRooms 
        WHERE RoomID = @SearchTerm
    END

    ELSE IF @SearchType = 'RoomNo'
    BEGIN
		SELECT * FROM tblRooms
        WHERE RoomNo  LIKE '%' + @SearchTerm + '%'
    END

    ELSE IF @SearchType = 'RoomType'
    BEGIN
		SELECT * FROM tblRooms 
        WHERE RoomType LIKE '%' + @SearchTerm + '%'
    END

	ELSE IF @SearchType = 'Status'
    BEGIN
	 SELECT * FROM tblRooms
        WHERE Status LIKE '%' + @SearchTerm + '%'
    END
END
