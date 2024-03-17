//#include <iostream>
//#include <cstdlib>
//#include <ctime>
//
//using namespace std;
//
//int main() {
//    setlocale(LC_ALL, "ru");
//    const int size = 10;
//    float arr1[size];
//    float arr2[size];
//    float arrSum[size];
//
//    srand(time(NULL));
//
//    for (int i = 0; i < size; ++i) {
//        arr1[i] = 10.0 + static_cast <float> (rand()) /( static_cast <float> (RAND_MAX/(30.0-10.0)));
//        arr2[i] = 10.0 + static_cast <float> (rand()) /( static_cast <float> (RAND_MAX/(30.0-10.0)));
//    }
//
//    for (int i = 0; i < size; ++i) {
//        arrSum[i] = (arr1[i] + arr2[i]) / 2.0;
//    }
//    cout << endl;
//
//    cout << "Первый массив:" << endl;
//    for (int i = 0; i < size; ++i) {
//        cout << arr1[i] << " ";
//    }
//    cout << endl;
//
//    cout << "Второй массив:" << endl;
//    for (int i = 0; i < size; ++i) {
//        cout << arr2[i] << " ";
//    }
//    cout << endl;
//
//    cout << "Третий массив (полусумма):" << endl;
//    for (int i = 0; i < size; ++i) {
//        cout << arrSum[i] << " ";
//    }
//    cout << endl;
//
//    return 0;
//}

//#include <iostream>
//#include <cstdlib>
//#include <ctime>
//
//using namespace std;
//
//const int maxSize = 100;
//
//void swapFunc(int matrix[maxSize][maxSize], int n, int index) {
//    if (index < 0 || index >= n) {
//        cout << "Некорректный индекс!" << endl;
//        return;
//    }
//
//    for (int i = 0; i < n; ++i) {
//        int temp = matrix[i][index];
//        matrix[i][index] = matrix[index][i];
//        matrix[index][i] = temp;
//    }
//}
//
//int main() {
//    int n;
//    cout << "Введите размерность двумерного массива (n*n): ";
//    cin >> n;
//
//    if (n <= 0 || n > maxSize) {
//        cout << "Некорректная размерность!" << endl;
//        return 1;
//    }
//
//    int matrix[maxSize][maxSize];
//
//    srand(time(NULL));
//
//    cout << "Двумерный массив " << n << "x" << n << endl;
//    for (int i = 0; i < n; ++i) {
//        for (int j = 0; j < n; ++j) {
//            matrix[i][j] = rand() % 50;
//            cout << matrix[i][j] << "\t";
//        }
//        cout << endl;
//    }
//
//    int index;
//    cout << "Введите число (меньше чем " << n << "): ";
//    cin >> index;
//
//    swapFunc(matrix, n, index);
//
//    cout << "Двумерный массив после замены:" << endl;
//    for (int i = 0; i < n; ++i) {
//        for (int j = 0; j < n; ++j) {
//            cout << matrix[i][j] << "\t";
//        }
//        cout << endl;
//    }
//    return 0;
//}

#include <iostream>

using namespace std;

const int maxSize = 50;

void fillArr(int array[maxSize][maxSize], int n) {
    for (int i = 0; i < n; ++i) {
        for (int j = 0; j < n; ++j) {
            if (i == j)
                array[i][j] = 0;
            else if (i < j)
                array[i][j] = 1 + j - i;
            else
                array[i][j] = 1 + i - j;
        }
    }
}

void printArr(int array[maxSize][maxSize], int n) {
    for (int i = 0; i < n; ++i) {
        for (int j = 0; j < n; ++j) {
            cout << array[i][j] << "  ";
        }
        cout << endl;
    }
}

int main() {
    int n;
    cout << "Введите размерность массива (n*n), не превышающую 50: ";
    cin >> n;

    if (n <= 0 || n > maxSize) {
        cout << "Некорректная размерность!" << endl;
        return 1;
    }

    int array[maxSize][maxSize];
    fillArr(array, n);
    printArr(array, n);

    return 0;
}
