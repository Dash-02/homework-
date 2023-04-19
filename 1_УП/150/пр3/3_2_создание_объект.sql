USE РиэлтерскоеАгентство;

CREATE TABLE Объект (КодОбъекта INT PRIMARY KEY, 
					Район VARCHAR (25),
                    Адрес VARCHAR (50),
				    Этаж INT,
                    Комнаты INT,
					Площадь INT,
					Удобства VARCHAR (255),
					Стоимость INT,
					Примечание VARCHAR(50));