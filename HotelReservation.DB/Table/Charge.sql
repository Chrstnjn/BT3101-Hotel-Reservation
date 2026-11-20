CREATE TABLE Charge
(
    ChargeID INT IDENTITY(1,1) PRIMARY KEY,
    ReservationID INT NOT NULL,

    ChargeType VARCHAR(50) NOT NULL,                -- e.g. 'Late Payment'
    Description VARCHAR(200) NULL,
    Amount DECIMAL(18,2) NOT NULL,
    ChargedDate DATETIME NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_Charges_Reservations FOREIGN KEY (ReservationID) REFERENCES Reservations(ReservationID),
    CONSTRAINT CK_Charges_Amount CHECK (Amount > 0)
);