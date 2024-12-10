CREATE PROCEDURE [dbo].[ManagerLogin]
    @UserName NVARCHAR(30),
    @PassWord NVARCHAR(30)
AS
BEGIN 
    SELECT * 
    FROM dbo.tblManager 
    WHERE MGUserName COLLATE SQL_Latin1_General_CP1_CS_AS = @UserName 
      AND MGPassword COLLATE SQL_Latin1_General_CP1_CS_AS = @PassWord
END