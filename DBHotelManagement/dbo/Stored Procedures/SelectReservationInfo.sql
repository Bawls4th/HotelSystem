CREATE PROCEDURE [dbo].[SelectReservationInfo]
AS
BEGIN
     SELECT 
    r.ReservationID,
    r.GuestID,
    r.RoomID,
    r.ServiceID,
    CONCAT(COALESCE(g.GFirstName, ''), ' ', COALESCE(g.GMiddleName, ''), ' ', COALESCE(g.GLastName, '')) AS Guest,
    ro.RoomNo,
    CONCAT(COALESCE(cs.FirstName, ''), ' ', COALESCE(cs.MiddleName, ''), ' ', COALESCE(cs.LastName, '')) AS Servicor,
    (COALESCE(ro.Price, 0) + COALESCE(cs.Price, 0)) AS TotalPrice,
    ro.Price AS RoomPrice,
    cs.Price AS ServicorPrice,
    r.CheckIn,
    r.CheckOut,
    r.DateIssued
FROM 
    dbo.tblReservation r
JOIN 
    dbo.tblGuest g ON r.GuestID = g.GuestID
JOIN 
    dbo.tblRooms ro ON r.RoomID = ro.RoomID
JOIN 
    dbo.tblCustomerServicor cs ON r.ServiceID = cs.ServiceID;
END
