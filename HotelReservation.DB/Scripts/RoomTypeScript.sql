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

SET IDENTITY_INSERT RoomTypes ON;

MERGE INTO RoomTypes AS target
USING (VALUES
    (1, 'Single',    1, 1, 1000.00),
    (2, 'Single V2', 2, 2, 1350.00),
    (3, 'Double',    1, 2, 1560.00),
    (4, 'Double V2', 2, 4, 3120.00)
) AS source (RoomTypeID, RoomTypeName, NumberOfBeds, NumberOfPersons, PricePerNight)
ON target.RoomTypeID = source.RoomTypeID
WHEN NOT MATCHED BY TARGET THEN
    INSERT (RoomTypeID, RoomTypeName, NumberOfBeds, NumberOfPersons, PricePerNight)
    VALUES (source.RoomTypeID, source.RoomTypeName, source.NumberOfBeds, source.NumberOfPersons, source.PricePerNight);

SET IDENTITY_INSERT RoomTypes OFF;