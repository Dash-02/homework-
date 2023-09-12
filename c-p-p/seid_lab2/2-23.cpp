#include <iostream>

int main() {
    int number;
    
    std::cout << "Введите номер недели ";
    std::cin >>  number;
    if (number == 6) {
        std::cout << "суббота" << std::endl;
    } else if(number==7) {
        std::cout << "воскресенье" << std::endl;
    } else {
        std::cout << "рабочий день"<<std::endl;
    }
    
    return 0;
}