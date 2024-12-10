CREATE PROCEDURE [dbo].[ReceptionistLogIn]
    @UserName NVARCHAR(30),
    @PassWord NVARCHAR(30)
AS
BEGIN 
    SELECT * 
    FROM dbo.tblReceptionist 
    WHERE RPUserName COLLATE SQL_Latin1_General_CP1_CS_AS = @UserName 
      AND RPPassword COLLATE SQL_Latin1_General_CP1_CS_AS = @PassWord
END