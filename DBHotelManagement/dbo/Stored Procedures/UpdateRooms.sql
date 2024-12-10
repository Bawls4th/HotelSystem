CREATE PROCEDURE [dbo].[UpdateRooms]
	@RoomID INT,
    @RoomNo INT,
    @RoomType VARCHAR(50),
    @Floor VARCHAR(50),
	@RoomName VARCHAR(50),
	@Capacity VARCHAR(50),
	@Price DECIMAL(6,2),
    @Status VARCHAR(50),
    @IsAvailable BIT
AS
BEGIN
    UPDATE tblRooms
    SET
        RoomNo = @RoomNo,
        RoomType = @RoomType,
		Floor = @Floor,
		Name = @RoomName,
		Capacity = @Capacity,
		Price = @Price,
        Status = @Status,
        IsAvailable = @IsAvailable
    WHERE
        RoomID = @RoomID;
END;