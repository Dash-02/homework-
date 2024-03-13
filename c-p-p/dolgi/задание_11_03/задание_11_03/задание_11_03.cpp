#include <iostream>
#include <vector>
using namespace std;

struct pupilsList {
    string fio;
    int class_num;
    char class_letter;
    int math;
    int rus;
    int it;
};

int main()
{
    setlocale(LC_ALL, "Ru");

    vector<pupilsList> pupils = {
    {"Крюков", 2, 'Б', 4,4,3},
    {"Шнурков", 3, 'А', 5, 5, 5},
    {"Стивс", 2, 'Б', 5, 4, 4},
    {"Джонатанс", 2, 'Б', 5, 4, 5},
    {"Волкова", 3, 'А', 5, 4, 3},
    {"Орлова", 2, 'А', 5, 4, 5},
    {"Цветкова", 3, 'Б', 4, 4, 5},
    {"Луков", 2, 'А', 3, 5, 5},
    {"Зубов", 2, 'А', 5, 4, 5},
    {"Цветова", 3, 'Б', 5, 5, 5}
    };
    vector<pupilsList> pupilExl;
    cout << "Все ученики: \n";

    for (const auto& pupil : pupils) {
       cout << pupil.fio << " " << pupil.class_num << "-" << pupil.class_letter << " Матем: " << pupil.math << " Русс: " << pupil.rus << " Информ: " << pupil.it << "\n";
    }

    cout << "\n";
    cout << "Отличники: \n";

    for (const auto& pupil : pupils) {
        if (pupil.math == 5 & pupil.rus == 5 & pupil.it == 5)
        {
            cout << pupil.fio << " " << pupil.class_num << "-" << pupil.class_letter << " Матем: " << pupil.math << " Русс: " << pupil.rus << " Информ: " << pupil.it << "\n";
            pupilExl.push_back(pupil);
        }
    }

    /*for (const auto& puplex : pupilExl) {
        cout << puplex.fio << puplex.class_num << puplex.class_letter << puplex.math << puplex.rus << puplex.it;
    }*/

    return 0;
}