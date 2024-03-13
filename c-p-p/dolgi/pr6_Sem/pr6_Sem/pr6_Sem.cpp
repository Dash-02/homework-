//// TASK 1
#include <iostream>
#include <vector>
#include <cstdlib>
#include <ctime>
using namespace std;

int main() {
    setlocale(LC_ALL, "ru");
    int n = 3;

    vector<vector<int>> matrix(n, vector<int>(n));

    srand(time(nullptr));

    for (int i = 0; i < n; ++i) {
        for (int j = 0; j < n; ++j) {
            if (i != j) {
                int result = rand() % 3;

                if (result == 2) {
                    matrix[i][j] = 2;
                    matrix[j][i] = 0;
                }
                else if (result == 1) {
                    matrix[i][j] = 1;
                    matrix[j][i] = 1;
                }
                else {
                    matrix[i][j] = 0;
                    matrix[j][i] = 2;
                }
            }
        }
    }

    cout << "Матрица игр:\n";
    for (int i = 0; i < n; ++i) {
        for (int j = 0; j < n; ++j) {
            cout << matrix[i][j] << " ";
        }
        cout << endl;
    }

    vector<int> wins(n, 0);
    for (int i = 0; i < n; ++i) {
        for (int j = 0; j < n; ++j) {
            wins[i] += matrix[i][j];
        }
    }

    for (int i = 0; i < n; ++i) {
        if (wins[i] > n / 2) {
            cout << "Команда " << i << " выиграла более половины игр" << endl;
            return 0;
        }
    }

    cout << "Нет команды, выигравшей более половины игр" << endl;

    return 0;
}




// ----------------- TASK 2 --------------------
////
//#include <iostream>
//#include <vector>
//#include <climits>
//#include <ctime>
//
//using namespace std;
//int main() {
//    setlocale(LC_ALL, "RU");
//
//    const int rows = 6;
//    const int cols = 9;
//    double matrix[rows][cols];
//
//
//    srand(time(NULL));
//
//
//    for (int i = 0; i < rows; ++i) {
//        for (int j = 0; j < cols; ++j) {
//            matrix[i][j] = rand() % 10;
//        }
//    }
//
//    cout << "Исходная матрица:\n";
//    for (int i = 0; i < rows; ++i) {
//        for (int j = 0; j < cols; ++j) {
//            cout << matrix[i][j] << " ";
//        }
//        cout << endl;
//    }
//
//
//    int maxRowIndex = 0;
//    int minRowIndex = 0;
//    double maxValue = matrix[0][0];
//    double minValue = matrix[0][0];
//
//    for (int i = 0; i < rows; ++i) {
//        for (int j = 0; j < cols; ++j) {
//            if (matrix[i][j] > maxValue) {
//                maxValue = matrix[i][j];
//                maxRowIndex = i;
//            }
//            if (matrix[i][j] < minValue) {
//                minValue = matrix[i][j];
//                minRowIndex = i;
//            }
//        }
//    }
//
//
//    swap(matrix[maxRowIndex], matrix[minRowIndex]);
//
//
//    cout << "Матрица после замены строк:\n";
//    for (int i = 0; i < rows; ++i) {
//        for (int j = 0; j < cols; ++j) {
//            cout << matrix[i][j] << " ";
//        }
//        cout << endl;
//    }
//    return 0;
//}

// ----------------------------- TASK 3 -----------------------
//#include <iostream>
//#include <vector>
//#include <climits>
//#include <ctime>
//
//int main() {
//    setlocale(LC_ALL, "RU");
//    int arraySize;
//    std::cout << "Введите размер одномерного массива: ";
//    std::cin >> arraySize;
//
//    std::vector<int> Array1(arraySize);
//    std::cout << "Введите элементы одномерного массива :\n";
//    for (int i = 0; i < arraySize; ++i) {
//        std::cout << "Элемент " << i + 1 << ": ";
//        std::cin >> Array1[i];
//    }
//
//    int numElementsRow1 = arraySize / 2;
//    int numElementsRow2 = arraySize - numElementsRow1;
//
//    std::vector<std::vector<int>> Array2(2);
//    Array2[0].resize(numElementsRow1);
//    Array2[1].resize(numElementsRow2);
//
//    int index = 0;
//    for (int i = 0; i < 2; ++i) {
//        for (int j = 0; j < Array2[i].size(); ++j) {
//            Array2[i][j] = Array1[index++];
//        }
//    }
//
//    std::cout << "Двумерный массив :\n";
//    for (int i = 0; i < 2; ++i) {
//        for (int j = 0; j < Array2[i].size(); ++j) {
//            std::cout << Array2[i][j] << " ";
//        }
//        std::cout << std::endl;
//    }
//
//    return 0;
//}
