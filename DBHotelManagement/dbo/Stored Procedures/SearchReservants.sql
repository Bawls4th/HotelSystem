CREATE PROCEDURE [dbo].[SearchReservants]
    @SearchTerm VARCHAR(50),
    @SearchType VARCHAR(50)
AS
BEGIN
    IF @SearchType = 'ReservationID'
    BEGIN
        SELECT 
            r.ReservationID,
            CONCAT(g.GFirstName, ' ', g.GMiddleName, ' ', g.GLastName) AS Guest,
            ro.RoomNo,
            CONCAT(cs.FirstName, ' ', cs.MiddleName, ' ', cs.LastName) AS Servicor,
            (ro.Price + cs.Price) AS Price,
            r.CheckIn,
            r.CheckOut,
            r.DateIssued
        FROM 
            dbo.tblReservation r
        JOIN dbo.tblGuest g ON r.GuestID = g.GuestID
        JOIN dbo.tblRooms ro ON r.RoomID = ro.RoomID
        JOIN dbo.tblCustomerServicor cs ON r.ServiceID = cs.ServiceID
        WHERE r.ReservationID = @SearchTerm;
    END
    ELSE IF @SearchType = 'Name'
    BEGIN
        SELECT 
            r.ReservationID,
            CONCAT(g.GFirstName, ' ', g.GMiddleName, ' ', g.GLastName) AS Guest,
            ro.RoomNo,
            CONCAT(cs.FirstName, ' ', cs.MiddleName, ' ', cs.LastName) AS Servicor,
            (ro.Price + cs.Price) AS Price,
            r.CheckIn,
            r.CheckOut,
            r.DateIssued
        FROM 
            dbo.tblReservation r
        JOIN dbo.tblGuest g ON r.GuestID = g.GuestID
        JOIN dbo.tblRooms ro ON r.RoomID = ro.RoomID
        JOIN dbo.tblCustomerServicor cs ON r.ServiceID = cs.ServiceID
        WHERE 
            (g.GFirstName LIKE '%' + @SearchTerm + '%')
            OR (g.GMiddleName LIKE '%' + @SearchTerm + '%')
            OR (g.GLastName LIKE '%' + @SearchTerm + '%')
            OR (g.GFirstName + ' ' + g.GLastName LIKE '%' + @SearchTerm + '%')
            OR (g.GFirstName + ' ' + g.GMiddleName LIKE '%' + @SearchTerm + '%')
            OR (g.GMiddleName + ' ' + g.GLastName LIKE '%' + @SearchTerm + '%')
			OR (g.GFirstName + ' ' + g.GMiddleName + ' ' + g.GLastName LIKE '%' + @SearchTerm + '%');
    END
    ELSE IF @SearchType = 'RoomNo'
    BEGIN
        SELECT 
            r.ReservationID,
            CONCAT(g.GFirstName, ' ', g.GMiddleName, ' ', g.GLastName) AS Guest,
            ro.RoomNo,
            CONCAT(cs.FirstName, ' ', cs.MiddleName, ' ', cs.LastName) AS Servicor,
            (ro.Price + cs.Price) AS Price,
            r.CheckIn,
            r.CheckOut,
            r.DateIssued
        FROM 
            dbo.tblReservation r
        JOIN dbo.tblGuest g ON r.GuestID = g.GuestID
        JOIN dbo.tblRooms ro ON r.RoomID = ro.RoomID
        JOIN dbo.tblCustomerServicor cs ON r.ServiceID = cs.ServiceID
        WHERE ro.RoomNo LIKE '%' + @SearchTerm + '%'
           OR ro.Name LIKE '%' + @SearchTerm + '%';
    END
    ELSE IF @SearchType = 'Servicor'
    BEGIN
        SELECT 
            r.ReservationID,
            CONCAT(g.GFirstName, ' ', g.GMiddleName, ' ', g.GLastName) AS Guest,
            ro.RoomNo,
            CONCAT(cs.FirstName, ' ', cs.MiddleName, ' ', cs.LastName) AS Servicor,
            (ro.Price + cs.Price) AS Price,
            r.CheckIn,
            r.CheckOut,
            r.DateIssued
        FROM 
            dbo.tblReservation r
        JOIN dbo.tblGuest g ON r.GuestID = g.GuestID
        JOIN dbo.tblRooms ro ON r.RoomID = ro.RoomID
        JOIN dbo.tblCustomerServicor cs ON r.ServiceID = cs.ServiceID
        WHERE 
            (cs.FirstName LIKE '%' + @SearchTerm + '%')
            OR (cs.MiddleName LIKE '%' + @SearchTerm + '%')
            OR (cs.LastName LIKE '%' + @SearchTerm + '%')
            OR (cs.FirstName + ' ' + cs.LastName LIKE '%' + @SearchTerm + '%')
            OR (cs.FirstName + ' ' + cs.MiddleName LIKE '%' + @SearchTerm + '%')
            OR (cs.MiddleName + ' ' + cs.LastName LIKE '%' + @SearchTerm + '%')
			OR (cs.FirstName + ' ' + cs.MiddleName + ' ' + cs.LastName LIKE '%' + @SearchTerm + '%');
    END
END