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

SET IDENTITY_INSERT Rooms ON;

MERGE INTO Rooms AS target
USING (VALUES
    (1,  '1101', 1, 'Available'),
    (2,  '1102', 1, 'Available'),
    (3,  '1103', 1, 'Available'),
    (4,  '1104', 1, 'Available'),
    (5,  '1105', 1, 'Available'),
    (6,  '1201', 2, 'Available'),
    (7,  '1202', 2, 'Available'),
    (8,  '1203', 2, 'Available'),
    (9,  '1204', 2, 'Available'),
    (10, '1205', 2, 'Available'),
    (11, '2101', 3, 'Available'),
    (12, '2102', 3, 'Available'),
    (13, '2103', 3, 'Available'),
    (14, '2104', 3, 'Available'),
    (15, '2105', 3, 'Available'),
    (16, '2201', 4, 'Available'),
    (17, '2202', 4, 'Available'),
    (18, '2203', 4, 'Available'),
    (19, '2204', 4, 'Under Maintenance'),
    (20, '2205', 4, 'Available')

) AS source (RoomID, RoomNumber, RoomTypeID, Status)
ON target.RoomID = source.RoomID
WHEN NOT MATCHED BY TARGET THEN
    INSERT (RoomID, RoomNumber, RoomTypeID, Status)
    VALUES (source.RoomID, source.RoomNumber, source.RoomTypeID, source.Status);

SET IDENTITY_INSERT Rooms OFF;