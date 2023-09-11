// ametseidlaiev1.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//
#define _USE_MATH_DEFINES
#include <iostream>
#include <math.h>


using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");

    int R;
    cout << "Введите радиус основания: ";
    cin >> R;

    int h;
    cout << "Введите высоту цилиндра: ";
    cin >> h;

    float v = M_PI * R*R*h;
    cout << "Объем цилиндра: " << v << endl;
    
    return 0;
}

