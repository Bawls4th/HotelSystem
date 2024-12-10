CREATE PROCEDURE [dbo].[DeleteReceptionist]
	@ID int
AS
BEGIN
  DELETE FROM tblReceptionist
    WHERE RPID = @ID
END;