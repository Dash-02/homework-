SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER Каскадное_Удаление  
   ON  Сделка 
   AFTER DELETE
AS 
BEGIN

	SET NOCOUNT ON;
	DELETE Агент 
	FROM deleted
	WHERE deleted.КодАгента = Агент.КодАгента

	DELETE Объект 
	FROM deleted
	WHERE deleted.КодОбъекта = Объект.КодОбъекта
END
GO
