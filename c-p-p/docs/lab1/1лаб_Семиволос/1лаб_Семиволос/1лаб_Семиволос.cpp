#include <iostream>
using namespace std;

//task1-24
int main() {
    setlocale(LC_ALL, "Ru");

    float kg;
    cout << "Введите количество килограммов: ";
    cin >> kg;

    float pudy = kg / 16.3807;
    float funty = kg / 0.4095;
    float loty = kg / 0.01638;
    float zolotniki = kg / 0.002066;

    cout << "Пуды: " << pudy << endl;
    cout << "Фунты: " << funty << endl;
    cout << "Лоты: " << loty << endl;
    cout << "Золотники: " << zolotniki << endl;

    return 0;
}
