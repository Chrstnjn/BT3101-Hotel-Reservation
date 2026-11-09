CREATE TABLE DPayments
(
    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
    ReservationID INT NOT NULL,
    PaymentType VARCHAR(30) NOT NULL DEFAULT 'Downpayment',
    PaymentMethod VARCHAR(30) NOT NULL,
    Amount DECIMAL(18,2) NOT NULL,
    PaymentDate DATETIME NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_Payments_Reservations FOREIGN KEY (ReservationID) REFERENCES Reservations(ReservationID),
    CONSTRAINT CK_Payments_Type CHECK (PaymentType IN ('Downpayment', 'Full Payment'))
);