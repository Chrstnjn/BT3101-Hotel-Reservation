/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
/* ============================================================
   Ryan Diaz Reservation

   GuestID: 1016
   RoomID : 2015 (Room 2101)

   Check-In : 2026-11-26 01:00 PM
   Check-Out: 2026-11-27 12:00 PM

   Guests: 1
   Nights: 1

   Room Rate  : ₱2,300.00
   Downpayment: ₱1,150.00
   Balance    : ₱1,150.00
============================================================ */

SET IDENTITY_INSERT Reservations ON;

INSERT INTO Reservations
(
    ReservationID,
    GuestID,
    RoomID,
    CheckInDate,
    CheckOutDate,
    NumberOfGuests,
    TotalNights,
    RatePerNight,
    TotalPrice,
    Status
)
VALUES
(
    3018,
    1016,
    2015,
    '2026-11-26 13:00:00',
    '2026-11-27 12:00:00',
    1,
    1,
    2300.00,
    2300.00,
    'Pending Downpayment'
);

SET IDENTITY_INSERT Reservations OFF;

/*next*/

SET IDENTITY_INSERT DPayments ON;

INSERT INTO DPayments
(
    PaymentID,
    ReservationID,
    PaymentType,
    PaymentMethod,
    Amount,
    PaymentDate
)
VALUES
(
    4027,
    3018,
    'Downpayment',
    'Cash',
    1150.00,
    GETDATE()
);

SET IDENTITY_INSERT DPayments OFF;

/*next*/

/* ============================================================
   Remaining balance paid at check-in, then guest is Checked-In
============================================================ */

SET IDENTITY_INSERT DPayments ON;

INSERT INTO DPayments
(
    PaymentID,
    ReservationID,
    PaymentType,
    PaymentMethod,
    Amount,
    PaymentDate
)
VALUES
(
    4028,
    3018,
    'Balance',
    'Cash',
    1150.00,
    '2026-11-26 13:00:00'
);

SET IDENTITY_INSERT DPayments OFF;

UPDATE Reservations
SET Status = 'Checked-In'
WHERE ReservationID = 3018;

/*next*/

/* ============================================================
   Overdue Charge for Reservation 3018 (Room 2101)

   Rule: charge only if the check-out time has passed AND
         there is no next Reserved booking for the same room.
   Late fee: PHP 230.00 per hour, any part of an hour
         counts as a full hour.
============================================================ */

INSERT INTO Charge
(
    ReservationID,
    ChargeType,
    Description,
    Amount,
    ChargedDate
)
SELECT
    r.ReservationID,
    'Overdue',
    'Overdue ' + CAST(CEILING(DATEDIFF(MINUTE, r.CheckOutDate, GETDATE()) / 60.0) AS VARCHAR(10)) + ' hour(s)',
    CEILING(DATEDIFF(MINUTE, r.CheckOutDate, GETDATE()) / 60.0) * 230.00,
    GETDATE()
FROM Reservations r
WHERE r.ReservationID = 3018
  AND GETDATE() > r.CheckOutDate
  AND NOT EXISTS
      (
          SELECT 1
          FROM Reservations n
          WHERE n.RoomID = r.RoomID
            AND n.ReservationID <> r.ReservationID
            AND n.Status = 'Reserved'
            AND n.CheckInDate >= r.CheckOutDate
      )
  AND NOT EXISTS
      (
          SELECT 1
          FROM Charge c
          WHERE c.ReservationID = r.ReservationID
            AND c.ChargeType = 'Overdue'
      );