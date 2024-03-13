#include <iostream>
#include <string>
using namespace std;

int main()
{
    system("chcp 1251");
    string input;
    int k;

    cout << "Введите исходную строку: ";
    getline(cin, input);

    cout << "Введите длину первой подстроки: ";
    cin >> k;

    string first = input.substr(0, k);
    string second = input.substr(k);

    if (!first.empty() && !second.empty() && first.back() != ' ' && second.front() != ' ') {
       
        size_t lastSpace = first.find_last_of(' ');

        if (lastSpace != string::npos) {
            second = first.substr(lastSpace + 1) + " " + second;
            first = first.substr(0, lastSpace);
        }
    }

    cout << "Первая подстрока: " << first << endl;
    cout << "Вторая подстрока: " << second << endl;

    return 0;
}


// ------------- task 2 ----------------

// Определить количество символов во втором слове
//#include <iostream>
//#include <string>
//#include <vector>
//using namespace std;
//
//int main()
//{
//    system("chcp 1251");
//
//    string str;
//    int countSymb = 0;
//    string word;
//    vector<string> words;
//
//    cout << "Введите предложение (минимум 2 слова): " << endl;
//    getline(cin, str);
//
//    for (int i = 0; i < str.length(); i++)
//    {
//        if (str[i] != ' ')
//        {
//            word += str[i];
//        }
//        else
//        {
//            words.push_back(word);
//            word = "";
//        }
//    }
//    words.push_back(word);
//
//    for (int i = 0; i < words.size(); i++)
//    {
//        cout << words[i] << endl;
//    }
//
//    countSymb = words[1].size();
//    cout << "Количество символов во втором слове: " << countSymb;
//
//    return 0;
//}

// ------------- task 3 ----------------
// Подсчитать количество слов, заканчивающихся на букву «z»

//#include <iostream>
//#include <string>
//#include <vector>
//using namespace std;
//
//int main()
//{
//    system("chcp 1251");
//
//    string str;
//    int countWords = 0;
//    string word;
//    vector<string> words;
//
//    cout << "Введите предложение: " << endl;
//    getline(cin, str);
//
//    for (int i = 0; i < str.length(); i++)
//    {
//        if (str[i] != ' ')
//        {
//            word += str[i];
//        }
//        else if (word.find_last_of('z'))
//        {
//            words.push_back(word);
//            word = "";
//        }
//    }
//
//    for (int i = 0; i < words.size(); i++)
//    {
//        cout << words[i] << endl;
//    }
//
//    countWords = words.size();
//    cout << "Количество слов, заканчивающихся на букву «z»: " << countWords;
//
//    return 0;
//}

// ================== || ====================
//
//#include <iostream>
//#include <sstream>
//
//using namespace std;
//
//int main() {
//    system("chcp 1251");
//    string str;
//    cout << "Введите строку: ";
//    getline(cin, str);
//
//    istringstream iss(str);
//    string word;
//    int count = 0;
//
//    while (iss >> word) {
//        if (word.back() == 'z') {
//            count++;
//        }
//    }
//
//    cout << "Количество слов, заканчивающихся на 'z': " << count << endl;
//
//    return 0;
//}