#include <iostream>
using namespace std;

int main()
{
    system("chcp 1251");

    struct date{ 
        int day;
        int month;
        int year; 
    } dateNow = {
        12, 3, 2024
    };

    int m = 0;
    cout << "Введите количество дней: ";
    cin >> m;
}