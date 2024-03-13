#include <iostream>
#include <algorithm>
#include <cmath>
using namespace std;

int main() {
    setlocale(LC_ALL, "Ru");

    int n;
    cout << "Введите длину массива: ";
    cin >> n;

    const int maxSize = 100;
    float arr[maxSize];

    for (int i = 0; i < n; i++)
    {
        cout << "Элемент " << i + 1 << ": ";
        cin >> arr[i];
    }

    cout << "Введенный массив: ";
    for (int i = 0; i < n; i++)
    {
        cout << arr[i] << " ";
    }
    cout << endl;

    float sum = 0;
    int lastNegI = -1;

    for (int i = 0; i < n; i++) {
        if (arr[i] < 0)
        {
            lastNegI = i;
        }
    }

    for (int i = lastNegI + 1; i < n; i++)
    {
        sum += floor(arr[i]);
    }
    cout << "Сумма целых частей элементов после последнего отрицательного элемента: " << sum << endl;

    float C;
    cout << "Введите значение C: ";
    cin >> C;

    int count = 0;
    for (int i = 0; i < n; i++)
    {
        if (arr[i] < C)
        {
            count++;
        }
    }
    cout << "Количество элементов массива, меньших " << C << ": " << count << endl;

    float maxElement = *max_element(arr, arr + n);
    int i = 0;
    int j = n - 1;
    while (i < j)
    {
        if (arr[i] >= maxElement * 0.8)
        {
            i++;
        }
        else if (arr[j] < maxElement * 0.8)
        {
            j--;
        }
        else
        {
            swap(arr[i], arr[j]);
            i++;
            j--;
        }
    }

    cout << "Преобразованный массив: ";
    for (int i = 0; i < n; i++) {
        cout << arr[i] << " ";
    }
    cout << endl;

    return 0;
}