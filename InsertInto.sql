--Opprett en SQL Server database med navn ContactDb.
--Opprett tabellen Contact med kolonnene ID (løpenummer), SSN ("Social Security Number" –
--personnummer), FirstName og LastName. Sørg for at hvert element i SSN feltet er unikt. 
--Ingen felt skal tillate nullverdier. Alt unntatt ID (løpenummer) skal være varchar.
--Lagre SQL for dette i et CreateTable.sql script!
Create database ContactDb;
CREATE TABLE Contact(
Id INT IDENTITY(1,1),
Ssn VARCHAR(128) UNIQUE NOT NULL,
FirstName VARCHAR(128) NOT NULL,
LastName VARCHAR(128) NOT NULL,
PRIMARY KEY(Id)
);

--Legg inn minst tre rader i tabellen.

INSERT INTO Contact(Ssn,FirstName,LastName)
VALUES(28120123123,'Arne','Bretting'),(9876512345,'Ole Tobias','Badstue'),(2225558834,'Arman','Armani'),(435685336,'Rene','Pathfinder')

--Lagre SQL for dette i et InsertInto.sql script!




