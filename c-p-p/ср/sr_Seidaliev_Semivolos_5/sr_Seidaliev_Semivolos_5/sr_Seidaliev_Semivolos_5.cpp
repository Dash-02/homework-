// task-1
//#include <iostream>
//#include <cmath>
//
//using namespace std;
//
//double funcY(double x) {
//    double result = 0;
//    for (int n = 1; n <= 20; ++n) {
//        result += (pow(x, 2 * n - 2) / (4 * cos(n * pow(x, 2))));
//    }
//    return result;
//}
//
//int main() {
//    double a = 0.1;
//    double b = 1.2;
//    double h = 0.1;
//
//    cout << "x\t\ty(x)" << endl;
//    for (double x = a; x <= b; x += h) {
//        double y = funcY(x);
//        cout << x << "\t\t" << y << endl;
//    }
//
//    return 0;
//}
// --------------- task-2
//
//#include <iostream>
//#include <cmath>
//
//using namespace std;
//
//double funcRecY(double x, int n) {
//    if (n == 0) {
//        return 0;
//    }
//    return funcRecY(x, n - 1) + (pow(x, 2 * n - 2) / (4 * cos(n * pow(x, 2))));
//}
//
//int main() {
//    double a = 0.1;
//    double b = 1.2;
//    double h = 0.1;
//
//    cout << "x\t\ty(x)" << endl;
//    for (double x = a; x <= b; x += h) {
//        double y = funcRecY(x, 20);
//        cout << x << "\t\t" << y << endl;
//    }
//
//    return 0;
//}
 
//task-
//
//#include <iostream>
//#include <cmath>
//
//using namespace std;
//double funcY(double x) {
//        double result = 0;
//        for (int n = 1; n <= 20; ++n) {
//            result += (1 + pow(x, n - 1)) / fabs(pow(sin(x), n));
//        }
//        return result;
//    }
//    
//    int main() {
//        double a = 0.1;
//        double b = 1.2;
//        double h = 0.1;
//    
//        cout << "x\t\ty(x)" << endl;
//        for (double x = a; x <= b; x += h) {
//            double y = funcY(x);
//            cout << x << "\t\t" << y << endl;
//        }
//    
//        return 0;
//    }
//
//
//#include <iostream>
//#include <cmath>
//
//using namespace std;
//double funcY(double x) {
//    double result = 0;
//    for (int n = 1; n <= 20; ++n) {
//        result += (1 + pow(x, n - 1)) / fabs(pow(sin(x), n));
//    }
//    return result;
//}
//
//int main() {
//    double a = 0.1;
//    double b = 1.2;
//    double h = 0.1;
//
//    cout << "x\t\ty(x)" << endl;
//    for (double x = a; x <= b; x += h) {
//        double y = funcY(x);
//        cout << x << "\t\t" << y << endl;
//    }
//
//    return 0;
//}


//task 3-1
#include <iostream>
#include <vector>

using namespace std;

void findIncreasingNumbers(int currentNumber, int n, int lastDigit, vector<int>& result) {
    if (n == 0) {
        result.push_back(currentNumber);
        return;
    }
    if (lastDigit == 0 || lastDigit == 9) {
        return;
    }
    int newNumber1 = currentNumber * 10 + lastDigit + 1;
    findIncreasingNumbers(newNumber1, n - 1, lastDigit + 1, result);
}

int main() {
    setlocale(LC_ALL, "RU");
    int n;
    cout << "Введите количество цифр (n): ";
    cin >> n;

    vector<int> result;
    for (int digit = 1; digit <= 8; ++digit) {
        findIncreasingNumbers(digit, n - 1, digit, result);
    }

    cout << "Все натуральные " << n << "-значные числа с возрастающей последовательностью цифр:" << endl;
    for (int number : result) {
        cout << number << endl;
    }

    return 0;
}


//task 3-2

//#include <iostream>
//#include <vector>
//
//using namespace std;
//
//int sumOfDigits(int number) {
//    int sum = 0;
//    while (number > 0) {
//        sum += number % 10;
//        number /= 10;
//    }
//    return sum;
//}
//
//int main() {
//    setlocale(LC_ALL, "RU");
//
//    int input;
//    std::cout << "Введите число: ";
//    std::cin >> input;
//
//    int count = 0;
//    while (input != 0) {
//        input -= sumOfDigits(input);
//        count++;
//    }
//
//    std::cout << "Число действий: " << count << std::endl;
//
//    return 0;
//}
