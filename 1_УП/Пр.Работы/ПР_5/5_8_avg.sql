SELECT *
FROM Маршруты
WHERE Стоимость > (SELECT AVG(Стоимость)
					FROM Маршруты);