CREATE PROCEDURE [dbo].[InsertRoom]
    @RoomNo INT,
    @RoomType VARCHAR(50),
    @Floor VARCHAR(50),
	@RoomName VARCHAR(50),
	@Capacity VARCHAR(50),
	@Price DECIMAL(6,2),
    @Status VARCHAR(50),
    @IsAvailable BIT,
	@RoomImage VARCHAR(255)
AS
BEGIN
    INSERT INTO tblRooms (RoomNo, RoomType, Floor,Name, Capacity, Price, Status, IsAvailable, Image)
    VALUES (@RoomNo, @RoomType, @Floor, @RoomName, @Capacity, @Price, @Status, @IsAvailable, @RoomImage);
	SELECT SCOPE_IDENTITY() AS RoomID, @RoomNo AS RoomNo,
	@RoomType AS RoomType,
	@Floor AS Floor,
	@RoomName AS RoomName,
	@Capacity AS Capacity,
	@Price AS Price,
	@Status AS Status,
	@IsAvailable AS IsAvailable,
	@RoomImage AS Image
END;