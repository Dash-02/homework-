-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Клиент_Указанный_Маршрут
	-- Add the parameters for the stored procedure here
	@Marchrute int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT Фамилия, Имя, Отчество, ДатаОтправления, Страна, Климат, Отель
	FROM Путевки JOIN Клиенты  ON Клиенты.КодКлиента = Путевки.КодКлиента  
	JOIN Маршруты ON Маршруты.КодМаршрута = Путевки.КодМаршрута
	WHERE Путевки.КодМаршрута = @Marchrute;
END
GO
