GO
CREATE PROCEDURE usp_ApplyLateCharges
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @FeePerHour DECIMAL(18,2) = 500;   -- fee per hour
    DECLARE @CheckOutHour INT = 12;            -- check-out time (12 = 12:00 PM)
    DECLARE @GraceMinutes INT = 0;             -- free minutes
    DECLARE @Now DATETIME = GETDATE();

    DECLARE @Overdue TABLE
    (
        ReservationID INT PRIMARY KEY,
        DueTime DATETIME,
        HoursLate INT,
        Amount DECIMAL(18,2),
        TotalPrice DECIMAL(18,2),
        Paid DECIMAL(18,2)
    );

    INSERT INTO @Overdue
    SELECT y.ReservationID, y.DueTime, y.HoursLate,
           -- full days cost the room rate. The last part of a day is hourly, but never more than the rate.
           (y.HoursLate / 24) * y.RatePerNight
             + CASE WHEN (y.HoursLate % 24) * @FeePerHour > y.RatePerNight
                    THEN y.RatePerNight
                    ELSE (y.HoursLate % 24) * @FeePerHour END,
           y.TotalPrice, y.Paid
    FROM
    (
        SELECT x.ReservationID, x.DueTime, x.RatePerNight, x.TotalPrice, x.Paid,
               CAST(CEILING((DATEDIFF(MINUTE, x.DueTime, @Now) - @GraceMinutes) / 60.0) AS INT) AS HoursLate
        FROM
        (
            SELECT r.ReservationID, r.RatePerNight, r.TotalPrice,
                   DATEADD(HOUR, @CheckOutHour, CAST(CAST(r.CheckOutDate AS DATE) AS DATETIME)) AS DueTime,
                   ISNULL((SELECT SUM(Amount) FROM DPayments
                           WHERE ReservationID = r.ReservationID), 0) AS Paid
            FROM Reservations r
            WHERE r.Status = 'Checked-In'
              -- no next booking for this room
              AND NOT EXISTS (SELECT 1 FROM Reservations n
                              WHERE n.RoomID = r.RoomID
                                AND n.ReservationID <> r.ReservationID
                                AND n.Status = 'Reserved'
                                AND CAST(n.CheckInDate AS DATE) >= CAST(r.CheckOutDate AS DATE))
        ) x
        WHERE DATEDIFF(MINUTE, x.DueTime, @Now) > @GraceMinutes
    ) y;

    -- Update the charge that already exists (it grows with the hours)
    UPDATE c
    SET c.Amount = o.Amount,
        c.Description = 'Overdue ' + CAST(o.HoursLate AS VARCHAR(10)) + ' hour(s) since '
                        + FORMAT(o.DueTime, 'MMM dd, yyyy hh:mm tt'),
        c.ChargedDate = @Now
    FROM Charge c
    INNER JOIN @Overdue o ON o.ReservationID = c.ReservationID
    WHERE c.ChargeType = 'Overdue'
      AND o.Paid < o.TotalPrice + c.Amount;

    -- Add the first charge
    INSERT INTO Charge (ReservationID, ChargeType, Description, Amount)
    SELECT o.ReservationID, 'Overdue',
           'Overdue ' + CAST(o.HoursLate AS VARCHAR(10)) + ' hour(s) since '
               + FORMAT(o.DueTime, 'MMM dd, yyyy hh:mm tt'),
           o.Amount
    FROM @Overdue o
    WHERE o.Paid < o.TotalPrice
      AND NOT EXISTS (SELECT 1 FROM Charge c
                      WHERE c.ReservationID = o.ReservationID
                        AND c.ChargeType = 'Overdue');
END
GO