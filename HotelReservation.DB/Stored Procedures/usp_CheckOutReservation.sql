GO
CREATE PROCEDURE usp_CheckOutReservation
(
    @ReservationID INT
)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    BEGIN TRANSACTION;

    DECLARE @RoomID INT, @TotalPrice DECIMAL(18,2),
            @Charges DECIMAL(18,2), @Paid DECIMAL(18,2);

    SELECT @RoomID = RoomID, @TotalPrice = TotalPrice
    FROM Reservations
    WHERE ReservationID = @ReservationID AND Status = 'Checked-In';

    IF @RoomID IS NULL
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50007, 'Only a Checked-In reservation can be checked out.', 1;
    END

    SELECT @Charges = ISNULL(SUM(Amount), 0)
    FROM Charge WHERE ReservationID = @ReservationID;

    SELECT @Paid = ISNULL(SUM(Amount), 0)
    FROM DPayments WHERE ReservationID = @ReservationID;

    IF @TotalPrice + @Charges - @Paid > 0
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50008, 'This reservation still has a balance. Please process the billing first.', 1;
    END

    UPDATE Reservations
    SET Status = 'Checked-Out',
        CheckedOutAt = GETDATE()
    WHERE ReservationID = @ReservationID;

    -- If the next guest already paid, the room stays Reserved. If not, it is Available.
    UPDATE Rooms
    SET Status = CASE WHEN EXISTS (SELECT 1 FROM Reservations
                                   WHERE RoomID = @RoomID AND Status = 'Reserved')
                      THEN 'Reserved' ELSE 'Available' END
    WHERE RoomID = @RoomID;

    COMMIT TRANSACTION;
END
GO