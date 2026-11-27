GO
CREATE PROCEDURE usp_GetCheckOuts
AS
BEGIN
    SET NOCOUNT ON;

    EXEC usp_ApplyLateCharges;

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
        r.TotalNights,
        r.TotalPrice,
        ISNULL(c.TotalCharges, 0) AS Charges,
        ISNULL(p.TotalPaid, 0) AS Paid,
        r.TotalPrice + ISNULL(c.TotalCharges, 0) - ISNULL(p.TotalPaid, 0) AS Balance,
        r.PaymentDueDate,
        nx.NextCheckInDate,
        -- 1 = past check-out time AND another guest is waiting for this room
        CASE WHEN nx.NextCheckInDate IS NOT NULL
              AND GETDATE() >= DATEADD(HOUR, 12, CAST(CAST(r.CheckOutDate AS DATE) AS DATETIME))
             THEN 1 ELSE 0 END AS MustLeave,
        r.Status
    FROM Reservations r
    INNER JOIN Guests g ON r.GuestID = g.GuestID
    INNER JOIN Rooms rm ON r.RoomID = rm.RoomID
    INNER JOIN RoomTypes rt ON rm.RoomTypeID = rt.RoomTypeID
    LEFT JOIN
    (
        SELECT ReservationID, SUM(Amount) AS TotalPaid
        FROM DPayments GROUP BY ReservationID
    ) p ON p.ReservationID = r.ReservationID
    LEFT JOIN
    (
        SELECT ReservationID, SUM(Amount) AS TotalCharges
        FROM Charge GROUP BY ReservationID
    ) c ON c.ReservationID = r.ReservationID
    OUTER APPLY
    (
        SELECT TOP 1 n.CheckInDate AS NextCheckInDate
        FROM Reservations n
        WHERE n.RoomID = r.RoomID
          AND n.ReservationID <> r.ReservationID
          AND n.Status = 'Reserved'
          AND CAST(n.CheckInDate AS DATE) >= CAST(r.CheckOutDate AS DATE)
        ORDER BY n.CheckInDate
    ) nx
    WHERE r.Status = 'Checked-In'
    ORDER BY r.CheckOutDate ASC;
END
GO