USE TouristAgency;

ALTER TABLE Маршруты 
	ADD CONSTRAINT check1 CHECK
		(Стоимость > 10000)

ALTER TABLE Путевки ADD CONSTRAINT 
uni1 UNIQUE (КодМаршрута)

ALTER TABLE Маршруты ADD default1 
INT NOT NULL DEFAULT 0;