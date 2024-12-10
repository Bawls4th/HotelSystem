CREATE PROCEDURE [dbo].[CheckIFReservantsExist]
	@GuestID INT,
    @RoomID INT,
    @ServiceID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT COUNT(*) AS ReservationExists
    FROM dbo.tblReservation
    WHERE GuestID = @GuestID
      AND RoomID = @RoomID
      AND ServiceID = @ServiceID;
END