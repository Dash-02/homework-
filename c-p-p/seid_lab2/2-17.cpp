#include <iostream>

int main() {
    int minutes, seconds;
    
    std::cout << "Введите количество минут: ";
    std::cin >> minutes;
    
    std::cout << "Введите количество секунд: ";
    std::cin >> seconds;
    
    if (minutes >= 0 && seconds >= 0 && minutes <= 60 && seconds <= 60) {
        int totalSeconds = minutes * 60 + seconds;
        std::cout << "Общее количество секунд: " << totalSeconds << std::endl;
    } else {
        std::cout << "Ошибка! Проверьте правильность введенных данных." << std::endl;
    }
    
    return 0;
}