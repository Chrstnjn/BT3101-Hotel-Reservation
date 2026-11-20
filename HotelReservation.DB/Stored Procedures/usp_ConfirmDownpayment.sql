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

    DECLARE @RoomID INT, @TotalPrice DECIMAL(18,2);

    SELECT @RoomID = RoomID, @TotalPrice = TotalPrice
    FROM Reservations
    WHERE ReservationID = @ReservationID AND Status = 'Pending Downpayment';

    IF @RoomID IS NULL
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50002, 'This reservation is not waiting for a downpayment.', 1;
    END

    -- The downpayment is 50% of the total price
    IF @Amount < ROUND(@TotalPrice * 0.5, 2)
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50012, 'The downpayment must be at least 50% of the total price.', 1;
    END

    -- The room is taken only now, and only if nobody else paid for it first
    UPDATE Rooms
    SET Status = 'Reserved'
    WHERE RoomID = @RoomID AND Status = 'Available';

    IF @@ROWCOUNT = 0
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50003, 'This room was already taken by another guest.', 1;
    END

    INSERT INTO DPayments (ReservationID, PaymentType, PaymentMethod, Amount)
    VALUES (@ReservationID, 'Downpayment', @PaymentMethod, @Amount);

    UPDATE Reservations
    SET Status = 'Reserved'
    WHERE ReservationID = @ReservationID;

    COMMIT TRANSACTION;
END