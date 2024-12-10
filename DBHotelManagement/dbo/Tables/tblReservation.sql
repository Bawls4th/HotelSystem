CREATE TABLE [dbo].[tblReservation]
(
    [ReservationID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [GuestID] INT NOT NULL,
    [RoomID] INT NOT NULL,
    [ServiceID] INT NOT NULL,
    [CheckIn] DATETIME NOT NULL,
    [CheckOut] DATETIME NOT NULL,
    [DateIssued] DATETIME NOT NULL,
    CONSTRAINT FK_Guest FOREIGN KEY (GuestID) REFERENCES [dbo].[tblGuest](GuestID),
    CONSTRAINT FK_Room FOREIGN KEY (RoomID) REFERENCES [dbo].[tblRooms](RoomID),
    CONSTRAINT FK_Service FOREIGN KEY (ServiceID) REFERENCES [dbo].[tblCustomerServicor](ServiceID)
);
