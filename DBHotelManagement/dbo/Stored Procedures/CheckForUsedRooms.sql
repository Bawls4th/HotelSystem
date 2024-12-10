CREATE PROCEDURE [dbo].[CheckForUsedRooms]
 @RoomNo INT,
  @Status VARCHAR(50),
  @IsAvailable BIT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM dbo.tblReservation r
        JOIN dbo.tblRooms ro ON r.RoomID = ro.RoomID
        WHERE ro.RoomNo = @RoomNo
    )
    BEGIN
        IF @Status IN ('Available', 'Out of Order') OR @IsAvailable = 1
        BEGIN
            PRINT 'Room is currently reserved or in use, cannot be marked as available or out of order.';
            RETURN;
        END;
    END
    ELSE
    BEGIN
        PRINT 'Room is available for changes.';
    END;
END;