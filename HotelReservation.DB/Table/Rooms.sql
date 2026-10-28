CREATE TABLE Rooms
(
    RoomID INT IDENTITY(1,1) PRIMARY KEY,

    RoomNumber VARCHAR(20) NOT NULL,

    RoomTypeID INT NOT NULL,

    Status VARCHAR(50) NOT NULL,

    CONSTRAINT UQ_RoomNumber UNIQUE (RoomNumber),

    FOREIGN KEY (RoomTypeID)
    REFERENCES RoomTypes(RoomTypeID)
);