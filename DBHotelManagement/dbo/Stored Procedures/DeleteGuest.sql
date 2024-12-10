CREATE PROCEDURE [dbo].[DeleteGuest] 
	@ID int

AS
BEGIN
  DELETE FROM tblGuest
    WHERE GuestID = @ID
END;