////#include <iostream>
////#include <cmath>
////#include <algorithm>
////using namespace std;
////
////int main() {
////    setlocale(LC_ALL, "Ru");
////
////    int n;
////    float a, b;
////    cout << "Введите длину массива: ";
////    cin >> n;
////
////    const int maxSize = 100;
////    float arr[maxSize];
////    float sumModule = 0;
////
////    for (int i = 0; i < n; i++) {
////        cout << "Элемент " << i + 1 << ": ";
////        cin >> arr[i];
////    }
////
////    cout << "Введенный массив: ";
////    for (int i = 0; i < n; i++) {
////        cout << arr[i] << " ";
////    }
////    cout << endl;
////
////    cout << "Введите интервал [a, b], a: ";
////    cin >> a;
////    cout << "b: ";
////    cin >> b;
////
////    float count = 0;
////    for (int i = 0; i < n; i++) {
////        if (arr[i] >= a && arr[i] <= b) {
////            count++;
////        }
////    }
////    cout << "Количество элементов в диапазоне от " << a << " до " << b << ": " << count << endl;
////    
////    float maxElement = arr[0]; 
////    int maxIndex = 0; 
////    float sumModulus = 0; 
////    for (int i = 0; i < n; i++) {
////        if (arr[i] > maxElement) {
////            maxElement = arr[i];
////            maxIndex = i;
////        }
////        else if (i > maxIndex) { 
////            sumModulus += fabs(arr[i]);
////        }
////    }
////    cout << "Сумма модулей элементов после максимального элемента: " << sumModulus << endl;
////    
////    sort(arr, arr + n, [](float a, float b) {
////        return fabs(a) > fabs(b);
////        });
////
////    cout << "Отсортированный массив: ";
////    for (int i = 0; i < n; i++) {
////        cout << arr[i] << " ";
////    }
////    
////    return 0;
////}
//
//#include <iostream>
//#include <cmath>
//#include <algorithm>
//using namespace std;
//
//int main() {
//    setlocale(LC_ALL, "Ru");
//
//    int n;
//    cout << "Введите длину массива: "; 
//    cin >> n;
//    
//    const int maxSize = 100;
//    float arr[maxSize];
//    float sumModule = 0;
//    
//    for (int i = 0; i < n; i++) 
//    {
//        cout << "Элемент " << i + 1 << ": ";
//        cin >> arr[i];
//    }
//    
//    cout << "Введенный массив: ";
//    for (int i = 0; i < n; i++) 
//    {
//        cout << arr[i] << " ";
//    }
//    cout << endl;
//
//    float sum = 0;
//    int lastNeg = 0;
//    int lastNegI = 0;
//
//    for (int i = 0; i < n; i++) {
//        
//        if (lastNeg > arr[i])
//        {
//            lastNegI = i;
//        }
//    }
//    for (int i = lastNegI + 1; i < n; i++)
//    {
//        sum += arr[i];
//    }
//    cout << "Сумма целых частей элементов после последнего отрицательного элемента: " << sum << endl;
//
//    float C;
//    cout << "Введите значение C: ";
//    cin >> C;
//
//    float count = 0;
//    for (int i = 0; i < n; i++)
//    {
//        if (arr[i] < C)
//        {
//            count++;
//        }
//    }
//    cout << "Количество элементов массива, меньших " << C << ": " << count << endl;
//
//    float maxElement = *max_element(arr, arr + n);
//    int i = 0;
//    int j = n - 1;
//    while (i < j)
//    {
//        if (arr[i] >= maxElement * 0.8)
//        {
//            i++;
//        }
//        else if (arr[j] < maxElement * 0.8)
//        {
//            j--;
//        }
//        else
//        {
//            swap(arr[i], arr[j]);
//            i++;
//            j--;
//        }
//    }
//
//    cout << "Преобразованный массив: ";
//    for (int i = 0; i < n; i++) {
//        cout << arr[i] << " ";
//    }
//    cout << endl;
//
//    return 0;
//}
//
// task 5-24

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
    for (int i = 0; i < newArraySize; i++) {
        cout << arr[i] << " ";
    }
    cout << endl;

    delete[] arr;

    return 0;
}
