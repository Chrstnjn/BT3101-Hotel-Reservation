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

    DECLARE @RoomID INT;

    SELECT @RoomID = RoomID
    FROM Reservations
    WHERE ReservationID = @ReservationID AND Status = 'Pending Downpayment';

    IF @RoomID IS NULL
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50002, 'This reservation is not waiting for a downpayment.', 1;
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