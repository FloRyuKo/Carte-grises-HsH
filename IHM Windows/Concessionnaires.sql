DROP TABLE IF EXISTS Concessionnaires;
CREATE TABLE IF NOT EXISTS Concessionnaires 
(
ID INT(2) AUTO_INCREMENT, 
Nom VARCHAR(15) NOT NULL, 
Prenom VARCHAR(15) NOT NULL, 
Adresse VARCHAR(50) NOT NULL,
CodePostal VARCHAR(5) NOT NULL,
Ville VARCHAR(20) NOT NULL,
CONSTRAINT pk_concess PRIMARY KEY(ID)
) ENGINE=INNODB;

INSERT INTO Concessionnaires (Nom,Prenom,Adresse,CodePostal,Ville) VALUES 
('Davolio', 'Rose', '5, rue de la Poste', '03700', 'VICHY'),
('Fuller', 'Andrew', 'Place de la Gare', '03700', 'VICHY'),
('Daverling', 'Janet', '1, Boulevard d''Italie', '03700', 'VICHY'),
('Peacock', 'Margaret', '23, Impasse des Fleurs', '03000', 'MOULINS'),
('Buchanan', 'Steven', '15, Place de l''Hotel de Ville', '03000', 'MOULINS'),
('Bucyama', 'Michael', '15, Rue des Pinsons', '03000', 'MOULINS'),
('King', 'Andrew', '57, Boulevard de la Gare', '03000', 'MOULINS'),
('Callahan', 'Laura', '23, Boulevard Central', '03100', 'MONTLUCON'),
('Bucsworth', 'Annette', '7, rue de la Paix', '03100', 'MONTLUCON');

SELECT * FROM Concessionnaires;


