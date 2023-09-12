#include <iostream>
#include<cmath>
using namespace std;

int main() {
    setlocale(LC_ALL, "Ru");
    int y;
    cout << "Введите  y: ";
    cin>>y;
    int x;
    cout << "Введите  x: ";
    cin >> x;
    int  R = 1;
    if(pow(x,2) + pow(y, 2) >= R) {
        cout<<"принадлежит\n";
    } else {
        cout<<"не принадлежит\n";
    }
    return 0;
}