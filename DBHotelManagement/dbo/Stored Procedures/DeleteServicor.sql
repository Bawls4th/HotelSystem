CREATE PROCEDURE [dbo].[DeleteServicor] 
	@ID INT

AS
BEGIN
  DELETE FROM tblCustomerServicor
    WHERE ServiceID = @ID
END;
