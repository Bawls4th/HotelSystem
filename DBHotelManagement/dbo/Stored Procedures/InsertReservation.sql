CREATE PROCEDURE [dbo].[InsertReservation]
    @RoomID INT,
    @GuestID INT,
    @ServiceID INT,
    @CheckIn DATETIME,
    @CheckOut DATETIME,
    @DateIssued DATETIME
AS
BEGIN
    INSERT INTO tblReservation (RoomID, GuestID, ServiceID, CheckIn, CheckOut, DateIssued)
    VALUES (@RoomID, @GuestID, @ServiceID, @CheckIn, @CheckOut, @DateIssued);
    
    SELECT 
        SCOPE_IDENTITY() AS ReservationID,
        @RoomID AS RoomID,
        @GuestID AS GuestID,
        @ServiceID AS ServiceID,
        @CheckIn AS CheckIn,
        @CheckOut AS CheckOut,
        @DateIssued AS DateIssued;
END;
