USE TouristAgency;

GRANT SELECT ON Клиенты TO UserFirst;
DENY UPDATE ON Маршруты TO UserSecond;
GRANT INSERT ON Путевки TO UserFirst;