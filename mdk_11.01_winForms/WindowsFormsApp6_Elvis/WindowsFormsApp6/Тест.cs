using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static WindowsFormsApp6.Тест;

namespace WindowsFormsApp6
{
    public partial class Тест : Form
    {

        
        private int currentQuestionIndex = 0;
        private int correctAnswers = 0;
        private List<Question> questions = new List<Question>();
        private bool isTestStarted = true;
        List<string> answersResults = new List<string>();
        public string UserName { get; set; }

        public Тест()
        {
            InitializeComponent();
            InitializeQuestions();
            checkedListBoxAnswers.ItemCheck += CheckedListBoxAnswer_ItemCheck;
            ShowQuestion(currentQuestionIndex);
            label5.Text = "Привет, " + UserName + "!";
        }
        private void CheckedListBoxAnswer_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           
            if (checkedListBoxAnswers.CheckedItems.Count > 0 && e.NewValue == CheckState.Checked)
            {
                e.NewValue = CheckState.Unchecked;
            }
        }

        private void InitializeQuestions()
        {


            var question1 = new Question("Вопрос 1: Какая ОС популярнее?", "Windows", "Linux", "macOS");
            question1.AddCorrectAnswers("Windows");
            var question2 = new Question("Вопрос 2: Самая популярная версия ОС Windows?", "7", "10", "11");
            question2.AddCorrectAnswers("7");
            var question3 = new Question("Вопрос 3: Кто создал ОС Windows?", "Соул Гудман", "Билл Гейтс", "Стив Джобс");
            question3.AddCorrectAnswers("Билл Гейтс");
            var question4 = new Question("Вопрос 4: Самая новейшая версия ОС Windows?", "7", "8", "8.1", "11");
            question4.AddCorrectAnswers("11");
            var question5 = new Question("Вопрос 5: Какая команда используется для перезагрузки в Windows?", "restart", "shutdown /r", "reboot");
            question4.AddCorrectAnswers("restart");
            var question6 = new Question("Вопрос 6: Как называется программа, позволяющая удалять или устанавливать программы?", "Control Panel", "Task Manager", "Registry Editor");
            question6.AddCorrectAnswers("Task Manager");
            var question7 = new Question("Вопрос 7: Какое ядро используется в ОС Windows?", "Linux", "macOS", "Windows NT");
            question7.AddCorrectAnswers("Windows NT");
            var question8 = new Question("Вопрос 8: Какая команда используется для открытия командной строки?", "cmd", "cmd.exe", "command");
            question8.AddCorrectAnswers("cmd");
            var question9 = new Question("Вопрос 9: Какой командой можно закрыть активное окно?", "ALT+F4", "Cntrl + C", "Cntrl + X");
            question9.AddCorrectAnswers("ALT+F4");
            var question10 = new Question("Вопрос 10: Какая версия ОС Windows является самой старой?", "Windows 95", "Windows 98", "Windows XP", "Windows 10");
            question10.AddCorrectAnswers("Windows 95");
            var question11 = new Question("Вопрос 11: Какая компания владеет Windows?", "Microsoft", "Apple", "Samsung", "LG");
            question11.AddCorrectAnswers("Microsoft");
            var question12 = new Question("Вопрос 12: Какой версии ОС Windows не существует?", "12", "11", "10", "8.1");
            question12.AddCorrectAnswers("12");
            var question13 = new Question("Вопрос 13: Можно ли установить Windows через флешку?", "Да", "Нет");
            question13.AddCorrectAnswers("Да");
            questions.Add(question1);
            questions.Add(question2);
            questions.Add(question3);
            questions.Add(question4);
            questions.Add(question5);
            questions.Add(question6);
            questions.Add(question7);
            questions.Add(question8);
            questions.Add(question9);
            questions.Add(question10);
            questions.Add(question11);
            questions.Add(question12);
            questions.Add(question13);
            questions.Add(question13);


        }
        private void CheckAnswer()
        {
            if (isTestStarted)
            {
              
                List<string> selectedAnswers = new List<string>();
                foreach (var checkedItem in checkedListBoxAnswers.CheckedItems)
                {
                    selectedAnswers.Add(checkedItem.ToString());
                }

              
                bool isCorrect = questions[currentQuestionIndex].IsCorrect(selectedAnswers);

                
                if (isCorrect)
                {
                    label2.Text = "Правильно";
                    
                }
                else
                {
                    label2.Text = "Не правильно";
                    
                }

                
                if (isCorrect)
                {
                    correctAnswers++;
                }
            }

        }

        public void ShowQuestion(int index)
        {
            if (index >= 0 && index < questions.Count)
            {
                label4.Text = questions[index].Text;
                checkedListBoxAnswers.Items.Clear();
                foreach (string answer in questions[index].PossibleAnswers)
                {
                    checkedListBoxAnswers.Items.Add(answer);
                }
                if (index == questions.Count - 1)
                {
                    button2.Enabled = true;
                }
            }
            else
            {
                
                button1.Enabled = false;
                checkedListBoxAnswers.Visible = false;
                groupBox1.Visible = false;
                button2.Visible = true;
            }
        }

        



        private void button1_Click(object sender, EventArgs e)
        {
            CheckAnswer(); 

            if (currentQuestionIndex < questions.Count - 1) 
            {
                currentQuestionIndex++;
                ShowQuestion(currentQuestionIndex);
                checkedListBoxAnswers.ClearSelected();

                
            }
            else
            {
                MessageBox.Show("Вы ответили на все вопросы. Нажмите 'Завершить тест'.", "Сообщение");
            }
        }

        private void SaveTestResult()
        {
            string fileName = "C:\\Users\\amets\\OneDrive\\Рабочий стол\\Результат.txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine($"Имя студента: {UserName}");
                writer.WriteLine($"Всего вопросов: {questions.Count}");
                writer.WriteLine($"Правильных ответов: {correctAnswers}");
                writer.WriteLine($"Оценка: {(double)correctAnswers / questions.Count * 5:F1} из 5");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveTestResult();
            string message = $"Имя пользователя: {UserName}\n" +
                    $"Всего вопросов: {questions.Count}\n" +
                    $"Правильных ответов: {correctAnswers}\n" +
                    $"Неправильных ответов: {questions.Count - correctAnswers}";

           
            MessageBox.Show(message, "Результаты теста", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Тест_Load(object sender, EventArgs e)
        {
            label5.Text = "Привет, " + UserName + "!";
        }

      
    }

    public class Question
    {
        public string Text { get; }
        public List<string> PossibleAnswers { get; }
        public List<string> CorrectAnswers { get; }

        public Question(string text, params string[] possibleAnswers)
        {
            Text = text;
            PossibleAnswers = new List<string>(possibleAnswers);
            CorrectAnswers = new List<string>();
        }

        public void AddCorrectAnswers(params string[] correctAnswers)
        {
            CorrectAnswers.AddRange(correctAnswers);
        }

        public bool IsCorrect(List<string> selectedAnswers)
        {
            return CorrectAnswers.Count == selectedAnswers.Count &&
                   CorrectAnswers.TrueForAll(selectedAnswers.Contains);
        }
    }
}




