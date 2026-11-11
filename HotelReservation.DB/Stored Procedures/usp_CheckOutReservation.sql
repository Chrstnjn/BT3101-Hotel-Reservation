CREATE PROCEDURE usp_CheckOutReservation
(
    @ReservationID INT
)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    BEGIN TRANSACTION;

    DECLARE @RoomID INT, @TotalPrice DECIMAL(18,2), @Paid DECIMAL(18,2);

    SELECT @RoomID = RoomID, @TotalPrice = TotalPrice
    FROM Reservations
    WHERE ReservationID = @ReservationID AND Status = 'Checked-In';

    IF @RoomID IS NULL
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50007, 'Only a Checked-In reservation can be checked out.', 1;
    END

    SELECT @Paid = ISNULL(SUM(Amount), 0)
    FROM DPayments
    WHERE ReservationID = @ReservationID;

    IF @TotalPrice - @Paid > 0
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50008, 'This reservation still has a balance. Please process the billing first.', 1;
    END

    UPDATE Rooms
    SET Status = 'Checked-Out'
    WHERE RoomID = @RoomID;

    UPDATE Reservations
    SET Status = 'Checked-Out'
    WHERE ReservationID = @ReservationID;

    COMMIT TRANSACTION;
END