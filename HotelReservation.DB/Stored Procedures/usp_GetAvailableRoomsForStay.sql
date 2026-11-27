CREATE PROCEDURE usp_GetAvailableRoomsForStay
(
    @CheckIn DATETIME,
    @CheckOut DATETIME
)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        rm.RoomID,
        rm.RoomNumber,
        rt.RoomTypeName,
        rt.NumberOfBeds,
        rt.NumberOfPersons,
        rt.PricePerNight,
        'Available' AS Status
    FROM Rooms rm
    INNER JOIN RoomTypes rt
        ON rm.RoomTypeID = rt.RoomTypeID
    WHERE
        rm.IsActive = 1
        AND rt.IsActive = 1
        AND rm.Status NOT LIKE '%Maintenance%'
        AND NOT EXISTS
        (
            SELECT 1
            FROM Reservations r
            WHERE r.RoomID = rm.RoomID
            AND r.Status IN ('Reserved', 'Checked-In')
            AND r.CheckInDate < @CheckOut
            AND CASE
                    WHEN r.Status = 'Checked-In'
                         AND r.CheckOutDate < GETDATE()
                    THEN DATEADD(DAY, 1, CAST(GETDATE() AS DATE))
                    ELSE r.CheckOutDate
                END > @CheckIn
        )
    ORDER BY CAST(rm.RoomNumber AS INT);
END