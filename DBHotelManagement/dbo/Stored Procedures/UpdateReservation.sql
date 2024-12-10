CREATE PROCEDURE [dbo].[UpdateReservation]
    @ReservationID INT,
    @RoomID INT,
    @GuestID INT,
    @ServiceID INT,
    @CheckIn DATETIME,
    @CheckOut DATETIME,
    @DateIssued DATETIME
AS
BEGIN
    UPDATE tblReservation
    SET
        RoomID = @RoomID,
        GuestID = @GuestID,
        ServiceID = @ServiceID,
        CheckIn = @CheckIn,
        CheckOut = @CheckOut,
        DateIssued = @DateIssued
    WHERE ReservationID = @ReservationID;
END;