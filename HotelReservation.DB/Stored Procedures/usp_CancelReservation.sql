CREATE PROCEDURE usp_CancelReservation
(
    @ReservationID INT
)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    BEGIN TRANSACTION;

    DECLARE @RoomID INT, @Status VARCHAR(50);

    SELECT @RoomID = RoomID, @Status = Status
    FROM Reservations
    WHERE ReservationID = @ReservationID;

    IF @Status IS NULL OR @Status NOT IN ('Pending Downpayment', 'Reserved')
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50005, 'Only a pending or awaiting check-in reservation can be cancelled.', 1;
    END

    -- Only a paid reservation holds the room, so only then is the room freed
    IF @Status = 'Reserved'
    BEGIN
        UPDATE Rooms
        SET Status = 'Available'
        WHERE RoomID = @RoomID AND Status = 'Reserved';
    END

    UPDATE Reservations
    SET Status = 'Cancelled'
    WHERE ReservationID = @ReservationID;

    COMMIT TRANSACTION;
END