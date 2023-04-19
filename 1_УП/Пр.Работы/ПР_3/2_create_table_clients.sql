USE TouristAgency;

CREATE TABLE Клиенты (КодКлиента INT PRIMARY KEY, 
					  Фамилия VARCHAR (25),
                      Имя VARCHAR (25),
                      Отчество VARCHAR (25),
                      Адрес VARCHAR (255),
                      Телефон VARCHAR (25));