CREATE TABLE Guests
(
    GuestID INT IDENTITY(1,1) PRIMARY KEY,

    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,

    DateOfBirth DATE NOT NULL,
    Gender VARCHAR(10) NOT NULL,

    PhoneNumber VARCHAR(20) NOT NULL,

    StreetAddress VARCHAR(150),
    City VARCHAR(50),
    Province VARCHAR(50),

    EmergencyContactName VARCHAR(100),
    EmergencyContactNumber VARCHAR(20),

    CreatedDate DATETIME DEFAULT GETDATE()
);