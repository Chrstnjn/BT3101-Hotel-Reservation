CREATE PROCEDURE usp_UpdateReservation
(
    @ReservationID INT,
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

    IF NOT EXISTS (SELECT 1 FROM Reservations
                   WHERE ReservationID = @ReservationID AND Status = 'Pending Downpayment')
        THROW 50004, 'Only a reservation that is waiting for a downpayment can be edited.', 1;

    IF NOT EXISTS (SELECT 1 FROM Rooms WHERE RoomID = @RoomID AND Status = 'Available')
        THROW 50001, 'This room is no longer available.', 1;

    UPDATE Reservations
    SET RoomID = @RoomID,
        CheckInDate = @CheckInDate,
        CheckOutDate = @CheckOutDate,
        NumberOfGuests = @NumberOfGuests,
        TotalNights = @TotalNights,
        RatePerNight = @RatePerNight,
        TotalPrice = @TotalPrice
    WHERE ReservationID = @ReservationID;
END