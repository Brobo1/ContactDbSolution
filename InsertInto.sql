--Opprett en SQL Server database med navn ContactDb.
--Opprett tabellen Contact med kolonnene ID (løpenummer), SSN ("Social Security Number" –
--personnummer), FirstName og LastName. Sørg for at hvert element i SSN feltet er unikt. 
--Ingen felt skal tillate nullverdier. Alt unntatt ID (løpenummer) skal være varchar.
--Lagre SQL for dette i et CreateTable.sql script!
--Create database ContactDb;

--CREATE TABLE Contact
--(
--    Id        INT IDENTITY (1,1),
--    Ssn       VARCHAR(128) UNIQUE NOT NULL,
--    FirstName VARCHAR(128)        NOT NULL,
--    LastName  VARCHAR(128)        NOT NULL,
--    PRIMARY KEY (Id)
--);
--
--CREATE TABLE ContactInformation
--(
--    Id               INT IDENTITY (1,1),
--    Info             VARCHAR(128) not null,
--    AddsReservation VARCHAR(128) not null,
--    ContactId        INT          null,
--    PRIMARY KEY (id),
--    FOREIGN KEY (ContactId) REFERENCES Contact (Id),
--)
--
--create table Address
--(
--    Id     INT IDENTITY (1,1),
--    Street VARCHAR(128) NOT NULL,
--    City   VARCHAR(128) NOT NULL,
--    Zip    VARCHAR(128) NOT NULL,
--    UNIQUE (Street, City, Zip),
--    PRIMARY KEY (Id)
--)
--

--CREATE TABLE ContactAddress(
--Id INT IDENTITY(1,1),
--ContactId INT NULL,
--AddressId INT NULL,
--PRIMARY KEY (Id),
--FOREIGN KEY (ContactId) REFERENCES Contact(Id),
--FOREIGN KEY (AddressId) REFERENCES Address(Id),
--);

----Legg inn minst tre rader i tabellen.
--
--INSERT INTO Contact(Ssn, FirstName, LastName)
--VALUES (28120123123, 'Arne', 'Bretting'),
--       (9876512345, 'Ole Tobias', 'Badstue'),
--       (2225558834, 'Arman', 'Armani'),
--       (435685336, 'Rene', 'Pathfinder')
--
----Lagre SQL for dette i et InsertInto.sql script!


--INSERT INTO ContactInformation(Info,AddsReservation,ContactId)
--VALUES('Badstue','0',1),('Ski','1',2),('Rider','0',3),('Terningkast','1',4)

--INSERT INTO Address (street, city, Zip)
--VALUES ('Pitbull straat','Bodø','3333'),('Tupac alley','Lillehammer','2233'),('Diddey Boulevard','Vennesla','1134'),('Beastyboys vei','Siljan','8645');



