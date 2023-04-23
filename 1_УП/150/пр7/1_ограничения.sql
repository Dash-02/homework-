USE РиэлтерскоеАгентство;

ALTER TABLE Объект
	ADD CONSTRAINT Check_1 CHECK
		(Стоимость > 0)

	ALTER TABLE Сделка ADD CONSTRAINT
	Unique_1 UNIQUE (КодОбъекта)

	ALTER TABLE Объект ADD Default_1
	INT NOT NULL DEFAULT 0;