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
    WHERE ReservationID = @ReservationID AND Status = 'Awaiting Check-In';

    IF @RoomID IS NULL
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50006, 'Only an Awaiting Check-In reservation can be checked in.', 1;
    END

    UPDATE Rooms
    SET Status = 'Checked-In'
    WHERE RoomID = @RoomID;

    UPDATE Reservations
    SET Status = 'Checked-In'
    WHERE ReservationID = @ReservationID;

    COMMIT TRANSACTION;
END