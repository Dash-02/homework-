USE TouristAgency;

CREATE TABLE Путевки (КодПутевки INT PRIMARY KEY,
                      КодМаршрута INT,
                      КодКлиента INT,
                      ДатаОтправления DATE,
                      Количество INT,
                      Скидка INT);