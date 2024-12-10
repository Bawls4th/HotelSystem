CREATE PROCEDURE [dbo].[CheckForRoomExist]
    @RoomNo INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT COUNT(*)
    FROM tblRooms
    WHERE RoomNo = @RoomNo 
END