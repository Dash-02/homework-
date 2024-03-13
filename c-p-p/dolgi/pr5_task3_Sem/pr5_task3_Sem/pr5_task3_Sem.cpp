#include <iostream>
#include <cmath>
using namespace std;

int main() {
    setlocale(LC_ALL, "Ru");
    int N;
    cout << "Введите размер массива: ";
    cin >> N;

    double* arr = new double[N];
    cout << "Введите элементы массива: ";
    for (int i = 0; i < N; i++) {
        cin >> arr[i];
    }

    double sum = 0;
    double product = 1;
    int firstNegIndex = -1;
    int lastNegIndex = -1;

    for (int i = 0; i < N; i++) {
        if (i % 2 != 0) {
            sum += arr[i];
        }

        if (arr[i] < 0) {
            if (firstNegIndex == -1) {
                firstNegIndex = i;
            }
            lastNegIndex = i;
        }
    }

    if (firstNegIndex != -1 && lastNegIndex != -1 && firstNegIndex != lastNegIndex) {
        for (int i = firstNegIndex + 1; i < lastNegIndex; i++) {
            product *= arr[i];
        }
    }

    int newArraySize = 0;
    for (int i = 0; i < N; i++) {
        if (abs(arr[i]) > 1) {
            arr[newArraySize] = arr[i];
            newArraySize++;
        }
    }

    for (int i = newArraySize; i < N; i++) {
        arr[i] = 0;
    }

    cout << "Сумма элементов с нечетными номерами: " << sum << endl;
    cout << "Произведение элементов между первым и последним отрицательными элементами: " << product << endl;
    cout << "Сжатый массив: ";
    for (int i = 0; i < N; i++) {
        cout << arr[i] << " ";
    }
    cout << endl;

    delete[] arr;

    return 0;
}