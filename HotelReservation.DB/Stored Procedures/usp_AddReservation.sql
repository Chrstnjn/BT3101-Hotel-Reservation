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

    -- The room is only checked here. Its status does not change until the downpayment.
    IF NOT EXISTS (SELECT 1 FROM Rooms WHERE RoomID = @RoomID AND Status = 'Available')
        THROW 50001, 'This room is no longer available.', 1;

    INSERT INTO Reservations
        (GuestID, RoomID, CheckInDate, CheckOutDate, NumberOfGuests,
         TotalNights, RatePerNight, TotalPrice, Status)
    VALUES
        (@GuestID, @RoomID, @CheckInDate, @CheckOutDate, @NumberOfGuests,
         @TotalNights, @RatePerNight, @TotalPrice, 'Pending Downpayment');

    -- Send the number back to the app
    SELECT ReservationNumber
    FROM Reservations
    WHERE ReservationID = SCOPE_IDENTITY();
END