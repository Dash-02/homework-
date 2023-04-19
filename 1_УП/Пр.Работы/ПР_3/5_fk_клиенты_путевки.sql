USE TouristAgency;

ALTER TABLE Путевки
ADD CONSTRAINT FK_Клиенты_Путевки FOREIGN KEY (КодКлиента)
REFERENCES Клиенты(КодКлиента);

ALTER TABLE Путевки
ADD CONSTRAINT FK_Маршруты_Путевки FOREIGN KEY (КодМаршрута)
REFERENCES Маршруты(КодМаршрута);