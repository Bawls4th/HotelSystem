CREATE PROCEDURE [dbo].[TransactionProcess]
    @ReservationID INT,
    @RoomCharge DECIMAL(18, 2),
    @Balance DECIMAL(18, 2),
    @AmountPaid DECIMAL(18, 2),
    @PaymentMethod VARCHAR(50),
    @TransactionID INT OUTPUT
AS
BEGIN
    BEGIN TRANSACTION;

    DECLARE @ExistingAmountPaid DECIMAL(18, 2);
    DECLARE @ExistingBalance DECIMAL(18, 2);

    SELECT TOP 1 
        @ExistingAmountPaid = AmountPaid, 
        @ExistingBalance = Balance
    FROM [dbo].[tblTransaction]
    WHERE ReservationID = @ReservationID
    ORDER BY TransactionID DESC;

    IF (@RoomCharge IS NULL OR @Balance IS NULL OR @AmountPaid IS NULL)
    BEGIN
        PRINT 'Invalid input detected. Rolling back transaction.';
        ROLLBACK TRANSACTION;
        RETURN;
    END

    IF (@ExistingAmountPaid IS NULL)
    BEGIN
        SET @ExistingAmountPaid = 0;
        SET @ExistingBalance = @Balance;

        INSERT INTO [dbo].[tblTransaction]
            (ReservationID, RoomCharge, Balance, AmountPaid, PaymentMethod)
        VALUES
            (@ReservationID, @RoomCharge, @ExistingBalance, @AmountPaid, @PaymentMethod);

        SET @TransactionID = SCOPE_IDENTITY();
    END
    ELSE
    BEGIN
        SET @ExistingAmountPaid = @ExistingAmountPaid + @AmountPaid;

        SET @ExistingBalance = 
            CASE 
                WHEN @AmountPaid >= @ExistingBalance THEN 0
                ELSE @ExistingBalance - @AmountPaid 
            END;

        IF (@ExistingBalance < 0)
        BEGIN
            PRINT 'Invalid balance detected. Rolling back transaction.';
            ROLLBACK TRANSACTION;
            RETURN;
        END

        UPDATE [dbo].[tblTransaction]
        SET 
            Balance = @ExistingBalance,
            AmountPaid = @ExistingAmountPaid,
            PaymentMethod = @PaymentMethod
        WHERE ReservationID = @ReservationID
        AND TransactionID = (SELECT MAX(TransactionID) FROM [dbo].[tblTransaction] WHERE ReservationID = @ReservationID);

        SET @TransactionID = (SELECT MAX(TransactionID) FROM [dbo].[tblTransaction] WHERE ReservationID = @ReservationID);
    END
    COMMIT TRANSACTION;
END;
