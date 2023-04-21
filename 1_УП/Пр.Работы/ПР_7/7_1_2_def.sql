USE TouristAgency;

ALTER TABLE Маршруты ADD Количество_по_Умолчанию 
INT NOT NULL DEFAULT 0;



/*CREATE DEFAULT df1 AS 0
sp_bindefault 'df1', 'Товар.Остаток';*/

/*ALTER TABLE Маршруты
ADD CONSTRAINT Количество_по_умолчанию 
DEFAULT (Количество = 0);*/

/*ALTER TABLE Маршруты*/
/*ADD CONSTRAINT def DEFAULT Количество 0*/