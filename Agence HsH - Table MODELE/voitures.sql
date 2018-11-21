DROP TABLE IF EXISTS Modele;
CREATE TABLE Modele  
(
	id_modele INT(3),
	modele VARCHAR(30) NOT NULL,
	carburant ENUM('essence','diesel','gpl','electrique') default 'essence' NOT NULL,
	CONSTRAINT pk_modele PRIMARY KEY(id_modele)
) ENGINE=INNODB;

INSERT INTO Modele VALUES(1,'Volkswagen','essence');
INSERT INTO Modele VALUES(2,'Renault','essence');
INSERT INTO Modele VALUES(3,'Volkswagen','diesel');
INSERT INTO Modele VALUES(4,'Renault','diesel');
INSERT INTO Modele VALUES(5,'Peugeot','diesel');
INSERT INTO Modele VALUES(6,'Peugeot','gpl');
INSERT INTO Modele VALUES(7,'Ligier','electrique');
