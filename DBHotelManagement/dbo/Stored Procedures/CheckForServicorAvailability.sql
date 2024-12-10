CREATE PROCEDURE [dbo].[CheckForServicorAvailability]
	@FirstName VARCHAR(50),
    @MiddleName VARCHAR(50),
    @LastName VARCHAR(50),
    @Available BIT
AS
BEGIN
    DECLARE @ServicorName VARCHAR(50);
    SET @ServicorName = LTRIM(RTRIM(@FirstName)) + ' ' + LTRIM(RTRIM(@MiddleName)) + ' ' + LTRIM(RTRIM(@LastName));

    IF EXISTS (
        SELECT 1
        FROM dbo.tblReservation r
        JOIN dbo.tblCustomerServicor cs ON r.ServiceID = cs.ServiceID
        WHERE cs.FirstName + ' ' + cs.MiddleName + ' ' + cs.LastName = @ServicorName
    )
    BEGIN
        IF @Available = 1
        BEGIN
            RETURN;
        END
    END
END;