CREATE PROCEDURE usp_GetRecentActivity
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TOP 20
        r.ReservationID,
        g.FirstName + ' ' + g.LastName AS GuestName,
        rm.RoomNumber,
        rt.RoomTypeName,
        r.Status,
        CASE r.Status
            WHEN 'Checked-Out' THEN ISNULL(r.CheckedOutAt, r.CheckOutDate)
            WHEN 'Checked-In'  THEN ISNULL(r.CheckedInAt, r.CheckInDate)
            ELSE ISNULL
                 (
                     (SELECT MAX(p.PaymentDate) FROM DPayments p WHERE p.ReservationID = r.ReservationID),
                     r.CreatedDate
                 )
        END AS ActivityDate
    FROM Reservations r
    INNER JOIN Guests g ON r.GuestID = g.GuestID
    INNER JOIN Rooms rm ON r.RoomID = rm.RoomID
    INNER JOIN RoomTypes rt ON rm.RoomTypeID = rt.RoomTypeID
    WHERE r.Status IN ('Reserved', 'Checked-In', 'Checked-Out')
    ORDER BY ActivityDate DESC;
END