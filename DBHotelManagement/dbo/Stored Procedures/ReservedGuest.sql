CREATE PROCEDURE [dbo].[ReservedGuest]
   @GuestID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT COUNT(*) 
    FROM dbo.tblReservation
    WHERE GuestID = @GuestID
    AND  CheckOut > GETDATE();
END;