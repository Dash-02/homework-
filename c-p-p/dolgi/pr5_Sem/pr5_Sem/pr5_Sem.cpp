#include <iostream>
#include <cmath>
#include <algorithm>
using namespace std;

int main() {
    setlocale(LC_ALL, "Ru");

    int n;
    float a, b;
    cout << "Введите длину массива: ";
    cin >> n;

    const int maxSize = 100;
    float arr[maxSize];
    float sumModule = 0;

    for (int i = 0; i < n; i++) {
        cout << "Элемент " << i + 1 << ": ";
        cin >> arr[i];
    }

    cout << "Введенный массив: ";
    for (int i = 0; i < n; i++) {
        cout << arr[i] << " ";
    }
    cout << endl;

    cout << "Введите интервал [a, b], a: ";
    cin >> a;
    cout << "b: ";
    cin >> b;

    float count = 0;
    for (int i = 0; i < n; i++) {
        if (arr[i] >= a && arr[i] <= b) {
            count++;
        }
    }
    cout << "Количество элементов в диапазоне от " << a << " до " << b << ": " << count << endl;

    float maxElement = arr[0];
    int maxIndex = 0;
    float sumModulus = 0;
    for (int i = 0; i < n; i++) {
        if (arr[i] > maxElement) {
            maxElement = arr[i];
            maxIndex = i;
        }
        else if (i > maxIndex) {
            sumModulus += fabs(arr[i]);
        }
    }
    cout << "Сумма модулей элементов после максимального элемента: " << sumModulus << endl;

    sort(arr, arr + n, [](float a, float b) {
        return fabs(a) > fabs(b);
        });

    cout << "Отсортированный массив: ";
    for (int i = 0; i < n; i++) {
        cout << arr[i] << " ";
    }

    return 0;
}
