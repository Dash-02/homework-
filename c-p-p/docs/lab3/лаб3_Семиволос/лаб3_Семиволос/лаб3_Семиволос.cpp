#include <iostream>
#include <iomanip>
using namespace std;

int main() {
    setlocale(LC_ALL, "Ru");

    cout << " x    |    y" << endl;
    cout << "-------------" << endl;

    for (float x = -2; x <= 2; x += 0.5) {

        float y = -2.4 * x * x + 5 * x - 3;
        cout << fixed << setprecision(2) << setw(5) << x << " | " << setw(7) << y << endl;
    }

    return 0;
}
