CREATE PROCEDURE usp_GetReservations
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        r.ReservationID,
        r.ReservationNumber,
        g.FirstName + ' ' + g.LastName AS GuestName,
        rm.RoomNumber,
        rt.RoomTypeName,
        r.CheckInDate,
        r.CheckOutDate,
        r.NumberOfGuests,
        r.TotalNights,
        r.TotalPrice,
        r.Status
    FROM Reservations r
    INNER JOIN Guests g ON r.GuestID = g.GuestID
    INNER JOIN Rooms rm ON r.RoomID = rm.RoomID
    INNER JOIN RoomTypes rt ON rm.RoomTypeID = rt.RoomTypeID
    ORDER BY r.CreatedDate DESC;
END