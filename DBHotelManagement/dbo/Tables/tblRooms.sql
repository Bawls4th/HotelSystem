CREATE TABLE [dbo].[tblRooms] (
    [RoomID]      INT             IDENTITY (1, 1) NOT NULL,
    [RoomNo]      INT             NOT NULL,
    [RoomType]    VARCHAR (50)    NOT NULL,
    [Floor]       VARCHAR (50)    NOT NULL,
    [Name]        VARCHAR (50)    NOT NULL,
    [Capacity]    VARCHAR (50)    NOT NULL,
    [Price]       DECIMAL (18, 2) NOT NULL,
    [Status]      VARCHAR (50)    NOT NULL,
    [IsAvailable] BIT             NOT NULL,
    [Image]       VARCHAR (255)   NOT NULL,
    PRIMARY KEY CLUSTERED ([RoomID] ASC)
);

