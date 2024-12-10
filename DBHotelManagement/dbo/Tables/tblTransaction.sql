CREATE TABLE [dbo].[tblTransaction]
(
	[TransactionID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [ReservationID] INT NOT NULL, 
    [RoomCharge] DECIMAL NOT NULL,
    [Balance] DECIMAL(18, 2) NOT NULL, 
    [AmountPaid] DECIMAL(18, 2) NOT NULL, 
    [PaymentMethod] VARCHAR(50) NOT NULL,
    CONSTRAINT FK_Reservation FOREIGN KEY (ReservationID) REFERENCES [dbo].[tblReservation](ReservationID)
)
