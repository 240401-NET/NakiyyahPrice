-- CREATE TABLE Grade
-- (
--     id      INT PRIMARY KEY IDENTITY,
--     grade   NVARCHAR(5)

-- );

-- CREATE TABLE Status
-- (
--     id      INT PRIMARY KEY IDENTITY,
--     status  NVARCHAR(10)

-- );

-- CREATE TABLE Models
-- (
--     id              INT PRIMARY KEY IDENTITY,
--     name            NVARCHAR(100) NOT NULL,
--     grade           INT FOREIGN KEY REFERENCES Grade(id),
--     type            NVARCHAR(25), 
--     status          INT FOREIGN KEY REFERENCES Status(id),
--     description     NVARCHAR(400)
-- );

-- drop table Models


-- INSERT INTO Grade (grade) VALUES ('HG'),('RG'),('MG'),('PG'),('None');

-- select * from grade

-- INSERT INTO Status (status) VALUES ('Unbuilt'),('Incomplete'),('Finished'),('Broken'),('None');

-- select * from [Status]

-- INSERT INTO Models (name,grade,type,status,description) VALUES ('Petit''G Guy Burning Red',1,'Petit''G Guy',1,'Red, Small, Bear');

-- select * from Models

-- select m.id, m.name, g.grade , m.type, s.status, m.description 
-- from models m
-- join grade g on m.grade = g.id
-- join status s on m.status = s.id

-- CREATE VIEW Gunpla AS
-- select m.id, m.name, g.grade , m.type, s.status, m.description 
-- from models m
-- join grade g on m.grade = g.id
-- join status s on m.status = s.id

