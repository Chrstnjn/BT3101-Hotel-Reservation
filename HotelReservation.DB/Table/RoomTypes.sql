CREATE TABLE RoomTypes
(
    RoomTypeID INT IDENTITY(1,1) PRIMARY KEY,
    RoomTypeName VARCHAR(100) NOT NULL,
    NumberOfBeds INT NOT NULL,
    NumberOfPersons INT NOT NULL,
    PricePerNight DECIMAL(18,2) NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE()
);