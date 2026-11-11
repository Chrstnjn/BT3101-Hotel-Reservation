CREATE PROCEDURE usp_ProcessBilling
(
    @ReservationID INT,
    @AmountReceived DECIMAL(18,2),
    @PaymentMethod VARCHAR(30)
)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    BEGIN TRANSACTION;

    DECLARE @TotalPrice DECIMAL(18,2), @Paid DECIMAL(18,2), @Balance DECIMAL(18,2);

    SELECT @TotalPrice = TotalPrice
    FROM Reservations
    WHERE ReservationID = @ReservationID AND Status = 'Checked-In';

    IF @TotalPrice IS NULL
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50009, 'Only a Checked-In reservation can be billed.', 1;
    END

    SELECT @Paid = ISNULL(SUM(Amount), 0)
    FROM DPayments
    WHERE ReservationID = @ReservationID;

    SET @Balance = @TotalPrice - @Paid;

    IF @Balance <= 0
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50010, 'This reservation has no balance.', 1;
    END

    IF @AmountReceived < @Balance
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50011, 'The payment received is not enough to pay the balance.', 1;
    END

    -- Save the balance. The change is given back to the guest.
    INSERT INTO DPayments (ReservationID, PaymentType, PaymentMethod, Amount)
    VALUES (@ReservationID, 'Full Payment', @PaymentMethod, @Balance);

    COMMIT TRANSACTION;
END