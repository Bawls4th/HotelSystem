CREATE PROCEDURE [dbo].[DeleteReservation]
	@ReservationID INT

AS
BEGIN
	DELETE FROM tblReservation
		WHERE ReservationID = @ReservationID
END
