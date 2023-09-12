// sem_lab2.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");
    float r;
    float r1;
    cout << "Введите первое сопротивление: ";
    cin >> r1;

    float r2;
    cout << "Введите второе сопротивление: ";
    cin >> r2;

    int type;
    cout << "Выберите тип соединения: 1 - последовательное, 2 - параллельное ";
    cin >> type;

    if (type == 1) 
    {
        r = r1 + r2;
        cout << r;
    }
    else {
        r = 1 / r1 + 1 / r2;
        cout << r;
    }

    return 0;

    /*int a;
    cout << "Введите ребра a: ";
    cin >> a;
    
    int b;
    cout << "Введите b: ";
    cin >> b;

    int c;
    cout << "Введите c: ";
    cin >> c;

    int x;
    cout << "Введите стороны x: ";
    cin >> x;

    int y;
    cout << "Введите y: ";
    cin >> y;

    if (a <= x && b <= y)
    {
        cout << "Кирпич пройдет";
    }
    else
    {
        cout << "Кирпич не пройдет";
    }

    return 0;*/
}