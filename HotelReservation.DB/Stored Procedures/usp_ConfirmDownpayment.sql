GO
CREATE PROCEDURE usp_ConfirmDownpayment
(
    @ReservationID INT,
    @Amount DECIMAL(18,2),
    @PaymentMethod VARCHAR(30)
)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    BEGIN TRANSACTION;

    DECLARE @RoomID INT, @TotalPrice DECIMAL(18,2),
            @CheckIn DATETIME, @CheckOut DATETIME;

    SELECT @RoomID = RoomID, @TotalPrice = TotalPrice,
           @CheckIn = CheckInDate, @CheckOut = CheckOutDate
    FROM Reservations
    WHERE ReservationID = @ReservationID AND Status = 'Pending Downpayment';

    IF @RoomID IS NULL
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50002, 'This reservation is not waiting for a downpayment.', 1;
    END

    IF @Amount < ROUND(@TotalPrice * 0.5, 2)
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50012, 'The downpayment must be at least 50% of the total price.', 1;
    END

    -- Nobody else paid for the same room and dates first
    IF EXISTS (SELECT 1 FROM Reservations x
               WHERE x.RoomID = @RoomID
                 AND x.ReservationID <> @ReservationID
                 AND x.Status IN ('Reserved', 'Checked-In')
                 AND @CheckIn < x.CheckOutDate
                 AND @CheckOut > x.CheckInDate)
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50003, 'This room was already taken by another guest for those dates.', 1;
    END

    -- Mark the room Reserved only if it is free right now
    -- (if a guest is inside, the room keeps its Checked-In status)
    UPDATE Rooms
    SET Status = 'Reserved'
    WHERE RoomID = @RoomID AND Status = 'Available';

    INSERT INTO DPayments (ReservationID, PaymentType, PaymentMethod, Amount)
    VALUES (@ReservationID, 'Downpayment', @PaymentMethod, @Amount);

    UPDATE Reservations
    SET Status = 'Reserved'
    WHERE ReservationID = @ReservationID;

    COMMIT TRANSACTION;
END
GO