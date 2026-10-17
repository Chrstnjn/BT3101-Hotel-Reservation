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
USE HighlandsDB;
GO

INSERT INTO Guests
(
    FirstName,
    LastName,
    DateOfBirth,
    Gender,
    PhoneNumber,
    StreetAddress,
    City,
    Province,
    EmergencyContactName,
    EmergencyContactNumber
)
VALUES
('John','Santos','1995-03-15','Male','9171234501','Poblacion','Balayan','Batangas','Maria Santos','9181234501'),
('Maria','Reyes','1998-06-10','Female','9171234502','Brgy Uno','Nasugbu','Batangas','Juan Reyes','9181234502'),
('James','Cruz','1993-09-22','Male','9171234503','Main Road','Lipa','Batangas','Ana Cruz','9181234503'),
('Anna','Garcia','1997-01-18','Female','9171234504','Rizal St','Balayan','Batangas','Pedro Garcia','9181234504'),
('Mark','Lopez','1994-04-01','Male','9171234505','Bonifacio St','Tagaytay','Cavite','Liza Lopez','9181234505'),
('Liza','Fernandez','1999-02-11','Female','9171234506','Market Area','Lian','Batangas','Jose Fernandez','9181234506'),
('Paul','Torres','1992-07-09','Male','9171234507','Mabini St','Batangas City','Batangas','Grace Torres','9181234507'),
('Grace','Flores','1996-12-05','Female','9171234508','Del Pilar','Nasugbu','Batangas','John Flores','9181234508'),
('Michael','Rivera','1991-08-19','Male','9171234509','Purok 2','Lipa','Batangas','Sarah Rivera','9181234509'),
('Sarah','Mendoza','1998-03-20','Female','9171234510','Town Proper','Balayan','Batangas','Mark Mendoza','9181234510'),

('Daniel','Castillo','1994-06-13','Male','9171234511','Brgy 1','Lian','Batangas','Ella Castillo','9181234511'),
('Ella','Ramos','2000-09-15','Female','9171234512','Brgy 2','Nasugbu','Batangas','Daniel Ramos','9181234512'),
('Kevin','Aquino','1993-05-27','Male','9171234513','Poblacion','Tagaytay','Cavite','Rose Aquino','9181234513'),
('Rose','Morales','1997-10-08','Female','9171234514','Mabini Rd','Balayan','Batangas','Kevin Morales','9181234514'),
('Ryan','Diaz','1996-11-14','Male','9171234515','Rizal Ave','Batangas City','Batangas','Mia Diaz','9181234515'),
('Mia','Villanueva','1999-07-03','Female','9171234516','Brgy Bucal','Lipa','Batangas','Ryan Villanueva','9181234516'),
('Chris','Domingo','1995-04-25','Male','9171234517','Alangilan','Batangas City','Batangas','Kate Domingo','9181234517'),
('Kate','Navarro','1998-12-16','Female','9171234518','Bagong Pook','Lipa','Batangas','Chris Navarro','9181234518'),
('Joshua','Salazar','1992-01-09','Male','9171234519','Kaylaway','Nasugbu','Batangas','Anne Salazar','9181234519'),
('Anne','Pascual','1999-08-29','Female','9171234520','Poblacion','Balayan','Batangas','Joshua Pascual','9181234520'),

('David','Gutierrez','1994-02-12','Male','9171234521','Roxas St','Tagaytay','Cavite','Jenny Gutierrez','9181234521'),
('Jenny','Herrera','1997-05-18','Female','9171234522','Main Rd','Lian','Batangas','David Herrera','9181234522'),
('Nathan','Alvarez','1996-09-22','Male','9171234523','Brgy Santol','Batangas City','Batangas','Joy Alvarez','9181234523'),
('Joy','Bautista','1998-04-30','Female','9171234524','Poblacion','Nasugbu','Batangas','Nathan Bautista','9181234524'),
('Carlo','Serrano','1993-11-01','Male','9171234525','Rizal St','Balayan','Batangas','Mae Serrano','9181234525'),
('Mae','Valdez','1999-06-12','Female','9171234526','Brgy 5','Lipa','Batangas','Carlo Valdez','9181234526'),
('Adrian','Rosales','1991-03-08','Male','9171234527','Town Center','Lian','Batangas','Lyn Rosales','9181234527'),
('Lyn','Evangelista','1998-07-26','Female','9171234528','Brgy Uno','Tagaytay','Cavite','Adrian Evangelista','9181234528'),
('John Paul','Tan','1995-10-10','Male','9171234529','Mabini St','Nasugbu','Batangas','Angel Tan','9181234529'),
('Angel','Lim','1997-01-15','Female','9171234530','Brgy Dos','Batangas City','Batangas','John Lim','9181234530'),

('Brian','Ocampo','1994-12-27','Male','9171234531','Rizal Ave','Lipa','Batangas','Shane Ocampo','9181234531'),
('Shane','Gomez','1998-02-18','Female','9171234532','Main Highway','Balayan','Batangas','Brian Gomez','9181234532'),
('Eric','Delos Reyes','1992-08-17','Male','9171234533','Purok 1','Lian','Batangas','Faith Reyes','9181234533'),
('Faith','Soriano','1999-05-05','Female','9171234534','Poblacion','Tagaytay','Cavite','Eric Soriano','9181234534'),
('Patrick','Mercado','1993-06-23','Male','9171234535','Calo','Nasugbu','Batangas','Aira Mercado','9181234535'),
('Aira','Luna','1998-09-13','Female','9171234536','Sampaga','Balayan','Batangas','Patrick Luna','9181234536'),
('Richard','Padilla','1995-04-14','Male','9171234537','Town Proper','Batangas City','Batangas','Joy Padilla','9181234537'),
('Joy','David','1997-11-28','Female','9171234538','Brgy 3','Lipa','Batangas','Richard David','9181234538'),
('Jerome','Manalo','1991-01-20','Male','9171234539','Brgy 4','Lian','Batangas','Kim Manalo','9181234539'),
('Kim','Natividad','1999-07-09','Female','9171234540','Poblacion','Nasugbu','Batangas','Jerome Natividad','9181234540'),

('Vincent','Abad','1993-03-11','Male','9171234541','Rizal St','Balayan','Batangas','Leah Abad','9181234541'),
('Leah','Torio','1998-06-06','Female','9171234542','Mabini St','Tagaytay','Cavite','Vincent Torio','9181234542'),
('Ralph','Dela Cruz','1994-08-08','Male','9171234543','Brgy A','Batangas City','Batangas','Jane Dela Cruz','9181234543'),
('Jane','Martin','1997-10-20','Female','9171234544','Brgy B','Lipa','Batangas','Ralph Martin','9181234544'),
('Kenneth','Pineda','1992-05-17','Male','9171234545','Main Street','Lian','Batangas','Ella Pineda','9181234545'),
('Ella Mae','Santiago','1999-12-01','Female','9171234546','Poblacion','Balayan','Batangas','Kenneth Santiago','9181234546'),
('Marvin','Balanay','1995-09-04','Male','9171234547','Brgy C','Nasugbu','Batangas','Rose Balanay','9181234547'),
('Rosemarie','Peralta','1998-04-21','Female','9171234548','Brgy D','Batangas City','Batangas','Marvin Peralta','9181234548'),
('Albert','Agustin','1994-11-11','Male','9171234549','Town Proper','Tagaytay','Cavite','Jean Agustin','9181234549'),
('Jean','Bacani','1999-02-22','Female','9171234550','Brgy E','Lipa','Batangas','Albert Bacani','9181234550');

UPDATE dbo.Guests
SET PhoneNumber =
REPLACE(REPLACE(REPLACE(PhoneNumber,'(+63)',''),'-',''),' ','');

UPDATE dbo.Guests
SET EmergencyContactNumber =
REPLACE(REPLACE(REPLACE(PhoneNumber,'(+63)',''),'-',''),' ','');