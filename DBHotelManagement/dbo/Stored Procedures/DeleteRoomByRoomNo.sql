CREATE PROCEDURE [dbo].[DeleteRoomByRoomNo]
    @RoomNo INT
AS
BEGIN

    DELETE FROM tblRooms
    WHERE RoomNo = @RoomNo;
END;