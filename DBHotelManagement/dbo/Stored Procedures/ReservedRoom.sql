CREATE PROCEDURE [dbo].[ReservedRoom]
	 @RoomID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT COUNT(*) 
    FROM dbo.tblReservation
    WHERE RoomID = @RoomID
    AND  CheckOut > GETDATE();
END;