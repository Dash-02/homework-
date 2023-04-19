USE TouristAgency;

SELECT Фамилия, Имя, Отчество
FROM Клиенты
WHERE Фамилия BETWEEN 'А' AND 'Р'
ORDER BY Фамилия;