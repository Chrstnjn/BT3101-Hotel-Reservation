GO
CREATE PROCEDURE usp_AddReservation
(
    @GuestID INT,
    @RoomID INT,
    @CheckInDate DATETIME,
    @CheckOutDate DATETIME,
    @NumberOfGuests INT,
    @TotalNights INT,
    @RatePerNight DECIMAL(18,2),
    @TotalPrice DECIMAL(18,2)
)
AS
BEGIN
    SET NOCOUNT ON;

    -- The room must exist and not be under maintenance (change the word if yours is different)
    IF NOT EXISTS (SELECT 1 FROM Rooms WHERE RoomID = @RoomID AND Status <> 'Maintenance')
        THROW 50001, 'This room is not available.', 1;

    -- The dates must not overlap with a paid or checked-in reservation
    IF EXISTS (SELECT 1 FROM Reservations x
               WHERE x.RoomID = @RoomID
                 AND x.Status IN ('Reserved', 'Checked-In')
                 AND @CheckInDate < x.CheckOutDate
                 AND @CheckOutDate > x.CheckInDate)
        THROW 50001, 'This room is already booked for those dates.', 1;

    INSERT INTO Reservations
        (GuestID, RoomID, CheckInDate, CheckOutDate, NumberOfGuests,
         TotalNights, RatePerNight, TotalPrice, Status, PaymentDueDate)
    VALUES
        (@GuestID, @RoomID, @CheckInDate, @CheckOutDate, @NumberOfGuests,
         @TotalNights, @RatePerNight, @TotalPrice, 'Pending Downpayment',
         CAST(@CheckOutDate AS DATE));

    SELECT ReservationNumber
    FROM Reservations
    WHERE ReservationID = SCOPE_IDENTITY();
END
GO