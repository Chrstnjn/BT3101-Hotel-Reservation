CREATE PROCEDURE usp_CheckInReservation
(
    @ReservationID INT
)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    BEGIN TRANSACTION;

    DECLARE @RoomID INT;

    SELECT @RoomID = RoomID
    FROM Reservations
    WHERE ReservationID = @ReservationID AND Status = 'Reserved';

    IF @RoomID IS NULL
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50006, 'Only an Reserved reservation can be checked in.', 1;
    END

    UPDATE Rooms
    SET Status = 'Checked-In'
    WHERE RoomID = @RoomID;

    UPDATE Reservations
    SET Status = 'Checked-In',
        CheckedInAt = GETDATE()
    WHERE ReservationID = @ReservationID;

    COMMIT TRANSACTION;
END