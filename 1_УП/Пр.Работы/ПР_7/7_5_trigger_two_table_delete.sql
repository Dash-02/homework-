SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER Удаление_Клиенты 
   ON  Путевки
   AFTER DELETE
AS 
BEGIN

	SET NOCOUNT ON;
	DELETE Клиенты FROM deleted
	WHERE deleted.[КодКлиента]=Клиенты.[КодКлиента] DELETE Маршруты
	FROM deleted
	WHERE deleted.[КодМаршрута]=Маршруты.[КодМаршрута]

END
GO
