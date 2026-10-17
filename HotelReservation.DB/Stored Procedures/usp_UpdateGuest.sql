CREATE PROCEDURE usp_UpdateGuest
(
    @GuestID BIGINT,
    @FirstName VARCHAR(100),
    @LastName VARCHAR(100),
    @DateOfBirth DATE,
    @Gender VARCHAR(20),
    @PhoneNumber VARCHAR(20),
    @StreetAddress VARCHAR(255),
    @City VARCHAR(100),
    @Province VARCHAR(100),
    @EmergencyContactName VARCHAR(100),
    @EmergencyContactNumber VARCHAR(20)
)
AS
BEGIN
    UPDATE Guests
    SET
        FirstName = @FirstName,
        LastName = @LastName,
        DateOfBirth = @DateOfBirth,
        Gender = @Gender,
        PhoneNumber = @PhoneNumber,
        StreetAddress = @StreetAddress,
        City = @City,
        Province = @Province,
        EmergencyContactName = @EmergencyContactName,
        EmergencyContactNumber = @EmergencyContactNumber
    WHERE GuestID = @GuestID
END