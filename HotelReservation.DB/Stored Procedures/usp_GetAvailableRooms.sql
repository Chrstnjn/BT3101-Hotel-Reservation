CREATE PROCEDURE usp_GetAvailableRooms
(
    @Date DATE
)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Today DATE = CAST(GETDATE() AS DATE);

    SELECT
        rm.RoomID,
        rm.RoomNumber,
        rt.RoomTypeName,
        rt.NumberOfBeds,
        rt.NumberOfPersons,
        rt.PricePerNight
    FROM Rooms rm
    INNER JOIN RoomTypes rt ON rm.RoomTypeID = rt.RoomTypeID
    WHERE rm.Status NOT LIKE '%Maintenance%'
      AND NOT EXISTS
      (
          SELECT 1
          FROM Reservations r
          WHERE r.RoomID = rm.RoomID
            AND r.Status IN ('Reserved', 'Checked-In')
            AND CAST(r.CheckInDate AS DATE) <= @Date
            AND CASE
                    -- The guest is still inside after the check-out time: the room is still taken today
                    WHEN r.Status = 'Checked-In' AND r.CheckOutDate < GETDATE()
                        THEN DATEADD(DAY, 1, @Today)
                    ELSE CAST(r.CheckOutDate AS DATE)
                END > @Date
      )
    ORDER BY rm.RoomNumber;
END