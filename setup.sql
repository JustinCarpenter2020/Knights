-- CREATE TABLE castle (
--   id INT NOT NULL AUTO_INCREMENT,
--   name VARCHAR(255),
--   PRIMARY KEY(id)
-- );




-- CREATE TABLE knights (
--   id INT NOT NULL AUTO_INCREMENT,
--   name VARCHAR(255),
--   dragonsSlayed INT DEFAULT 0,
--   hasSword TINYINT DEFAULT 0,
--   castleId INT,
--   PRIMARY KEY(id),
--   FOREIGN KEY(castleId)
--   REFERENCES castle(id)
-- );