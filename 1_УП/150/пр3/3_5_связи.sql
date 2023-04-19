USE РиэлтерскоеАгентство;

ALTER TABLE Сделка
ADD CONSTRAINT Связь_Объект_Сделки FOREIGN KEY (КодОбъекта)
REFERENCES Объект(КодОбъекта);

ALTER TABLE Сделка
ADD CONSTRAINT Связь_Агент_Сделки FOREIGN KEY (КодАгента)
REFERENCES Агент(КодАгента);