GO
CREATE PROCEDURE usp_ApplyLateCharges
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @FeePerHour DECIMAL(18,2) = 500;   -- change the fee per hour here
    DECLARE @CheckOutHour INT = 12;            -- check-out time: 12 = 12:00 PM
    DECLARE @GraceMinutes INT = 0;             -- free minutes before charging starts
    DECLARE @Now DATETIME = GETDATE();

    DECLARE @Overdue TABLE
    (
        ReservationID INT PRIMARY KEY,
        DueTime DATETIME,
        HoursLate INT,
        TotalPrice DECIMAL(18,2),
        Paid DECIMAL(18,2)
    );

    -- Checked-in guests who are past check-out time. Every started hour counts.
    INSERT INTO @Overdue
    SELECT x.ReservationID, x.DueTime,
           CEILING((DATEDIFF(MINUTE, x.DueTime, @Now) - @GraceMinutes) / 60.0),
           x.TotalPrice, x.Paid
    FROM
    (
        SELECT r.ReservationID, r.TotalPrice,
               DATEADD(HOUR, @CheckOutHour, CAST(CAST(r.CheckOutDate AS DATE) AS DATETIME)) AS DueTime,
               ISNULL((SELECT SUM(Amount) FROM DPayments
                       WHERE ReservationID = r.ReservationID), 0) AS Paid
        FROM Reservations r
        WHERE r.Status = 'Checked-In'
    ) x
    WHERE DATEDIFF(MINUTE, x.DueTime, @Now) > @GraceMinutes;

    -- 1) Update the charge that already exists (the hours keep growing).
    --    It stops growing once the guest has paid everything.
    UPDATE c
    SET c.Amount = o.HoursLate * @FeePerHour,
        c.Description = 'Overdue ' + CAST(o.HoursLate AS VARCHAR(10)) + ' hour(s) since '
                        + FORMAT(o.DueTime, 'MMM dd, yyyy hh:mm tt'),
        c.ChargedDate = @Now
    FROM Charge c
    INNER JOIN @Overdue o ON o.ReservationID = c.ReservationID
    WHERE c.ChargeType = 'Overdue'
      AND o.Paid < o.TotalPrice + c.Amount;

    -- 2) Add the first charge for guests who have an unpaid balance
    INSERT INTO Charge (ReservationID, ChargeType, Description, Amount)
    SELECT o.ReservationID, 'Overdue',
           'Overdue ' + CAST(o.HoursLate AS VARCHAR(10)) + ' hour(s) since '
               + FORMAT(o.DueTime, 'MMM dd, yyyy hh:mm tt'),
           o.HoursLate * @FeePerHour
    FROM @Overdue o
    WHERE o.Paid < o.TotalPrice
      AND NOT EXISTS (SELECT 1 FROM Charge c
                      WHERE c.ReservationID = o.ReservationID
                        AND c.ChargeType = 'Overdue');
END