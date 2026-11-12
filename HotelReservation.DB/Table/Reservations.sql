CREATE TABLE Reservations
(
    ReservationID INT IDENTITY(1,1) PRIMARY KEY,

    -- Example: RES-2026-00001 (made automatically from the year and the ID)
    ReservationNumber AS
        ('RES-' + CAST(YEAR(CreatedDate) AS VARCHAR(4)) + '-'
         + RIGHT('00000' + CAST(ReservationID AS VARCHAR(10)), 5)) PERSISTED,

    GuestID INT NOT NULL,
    RoomID INT NOT NULL,

    CheckInDate DATETIME NOT NULL,
    CheckOutDate DATETIME NOT NULL,

    NumberOfGuests INT NOT NULL,
    TotalNights INT NOT NULL,
    RatePerNight DECIMAL(18,2) NOT NULL,
    TotalPrice DECIMAL(18,2) NOT NULL,

    Status VARCHAR(50) NOT NULL DEFAULT 'Pending Downpayment',
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
    CheckedInAt DATETIME NULL,
    CheckedOutAt DATETIME NULL,

    CONSTRAINT FK_Reservations_Guests FOREIGN KEY (GuestID) REFERENCES Guests(GuestID),
    CONSTRAINT FK_Reservations_Rooms FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID),

    CONSTRAINT CK_Reservations_Dates CHECK (CheckOutDate > CheckInDate),
    CONSTRAINT CK_Reservations_Status CHECK
        (Status IN ('Pending Downpayment', 'Reserved', 'Checked-In', 'Checked-Out', 'Cancelled'))
);
