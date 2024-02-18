#include <iostream>
using namespace std;

//task 1-23
//int main() {
//    setlocale(LC_ALL, "Ru");
//
//    int sm;
//    cout << "Введите количество сантиметров: ";
//    cin >> sm;
//
//    // Количество вершков в сантиметре
//    float vershok = 4.4445;
//    // Количество футов в сантиметре
//    float fut = 30.48;
//    // Количество дюймов в сантиметре
//    float dum = 2.54;
//
//    // Перевод сантиметров в вершки
//    float SMvershok = sm / vershok;
//    // Перевод сантиметров в футы
//    float SMfut = sm / fut;
//    // Перевод сантиметров в дюймы
//    float SMdum = sm / dum;
//
//    // Вывод результатов
//    cout << "Вершки: " << SMvershok << endl;
//    cout << "Футы: " << SMfut << endl;
//    cout << "Дюймы: " << SMdum << endl;
//
//    return 0;
//}

//task 1-17
int main() {
    setlocale(LC_ALL, "Ru");
    float r1, r2, r;
    int t;

    cout << "вычисление сопротивления электрической цепи" << endl;
    cout << "величина первого сопротивления: ";
    cin >> r1;
    cout << "величина второго сопротивления: ";
    cin >> r2;
    cout << "тип соединения: последовательное " << endl;
    r = (r1 * r2) / (r1 + r2);

    cout << "сопротивление равно " << r << " Ом" << endl;

    return 0;
}
