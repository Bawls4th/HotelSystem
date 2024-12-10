CREATE PROCEDURE [dbo].[ReservedServicor]
	  @ServiceID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT COUNT(*) 
    FROM dbo.tblReservation
    WHERE ServiceID = @ServiceID
    AND  CheckOut > GETDATE();
END;