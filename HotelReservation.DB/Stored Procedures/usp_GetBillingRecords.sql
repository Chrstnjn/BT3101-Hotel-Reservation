CREATE PROCEDURE usp_GetBillingRecords
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        r.ReservationID,
        r.ReservationNumber,
        g.FirstName + ' ' + g.LastName AS GuestName,
        g.PhoneNumber,
        rm.RoomNumber,
        rt.RoomTypeName,
        r.CheckInDate,
        r.CheckOutDate,
        ISNULL(r.CheckedInAt, r.CheckInDate) AS CheckedInAt,
        ISNULL(r.CheckedOutAt, r.CheckOutDate) AS CheckedOutAt,
        r.TotalNights,
        r.TotalPrice,
        ISNULL(p.TotalPaid, 0) AS Paid,
        r.TotalPrice - ISNULL(p.TotalPaid, 0) AS Balance,
        r.Status
    FROM Reservations r
    INNER JOIN Guests g ON r.GuestID = g.GuestID
    INNER JOIN Rooms rm ON r.RoomID = rm.RoomID
    INNER JOIN RoomTypes rt ON rm.RoomTypeID = rt.RoomTypeID
    LEFT JOIN
    (
        SELECT ReservationID, SUM(Amount) AS TotalPaid
        FROM DPayments
        GROUP BY ReservationID
    ) p ON p.ReservationID = r.ReservationID
    WHERE r.Status = 'Checked-Out'
    ORDER BY ISNULL(r.CheckedOutAt, r.CheckOutDate) DESC;
END