Oppgave (B)
CREATE TABLE Language(
Id int identity(1,1) not null UNIQUE,
Name varchar(100) not null,
Year int NULL,
Creater varchar(100) default '',
Primary Key(Id)
);

CREATE TABLE Tool(
Id varchar(100) not null UNIQUE,
Name varchar(100) not null,
Developer varchar(100) null default '',
Primary key(Id)
);


ALTER TABLE Language
ADD FOREIGN KEY (ToolId) REFERENCES Tool(Id)

INSERT INTO Tool(Id,Name,Developer)
VALUES('VC', 'Visual Studio Code', 'Microsoft'),
('IJ', 'IntelliJ', 'JetBrains')
INSERT INTO Language(Name,year,Creater)
VALUES('C#', 2002,'Anders Hejlsberg'),
('JavaScript',1997, 'Brendan Eich'),
('Java', 1996, 'James Gosling'),
('Python', 1994, 'Guido van Rossum'),
('COBOL', 1959, 'CODASYL')

ALTER TABLE Language
ADD ToolId VARCHAR(100) null DEFAULT ''

UPDATE Language
SET ToolId = 'VC'
WHERE name = 'JavaScript'

UPDATE Language
SET ToolId = 'VC'
WHERE name = 'C#'

UPDATE Language
SET ToolId = 'IJ'
WHERE name = 'Java'

ALTER TABLE language
ADD FOREIGN KEY(ToolId) references Tool(Id)



Oppgave(C)
(1)
SELECT Developer,Name
FROM Tool
ORDER BY Developer DESC
(2)
SELECT COUNT(Id)
FROM Language
(3)
SELECT *
FROM Language
WHERE name like '%java%'


DEL 2
(A) 
(4)
SELECT *
FROM Language
LEFT JOIN Tool ON tOOL.iD = Language.ToolId
WHERE Language.ToolId != 'null'
(5)
SELECT *
FROM Language
LEFT JOIN Tool ON tOOL.iD = Language.ToolId ;
sto ikke spesifikt at du ikke ville ha null med eller ikke, men hvis ikke er det bare å fjerne LEFT ved JOIN.
(6)
SELECT *
FROM Language
JOIN Tool ON tOOL.iD = Language.ToolId


(B)/(C)
UPDATE Language
SET ToolId = 'IJ'
WHERE NAME = 'Python';

INSERT INTO Language(Name,Year,Creater,ToolId)
VALUES('JavaScript',1997,'Brendan Eich','IJ')

INSERT INTO Language(Name,Year,Creater,ToolId)
VALUES('Python',1994,'Guido van Rossum','VC')


(D)
Klarte ikke denne rakk ikke mye misforståelse med oppgaven
(4 DEL 2 versjon)
SELECT *
FROM Language
LEFT JOIN Tool ON tOOL.iD = Language.ToolId
WHERE Language.ToolId != 'null'
(5 del 2 versjon)
SELECT *
FROM Language
LEFT JOIN Tool ON tOOL.iD = Language.ToolId ;
WHERE Tool.Id = 'null'
(6 del 2 versjon)





