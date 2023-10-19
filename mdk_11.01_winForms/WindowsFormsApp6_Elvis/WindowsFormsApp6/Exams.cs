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

namespace WindowsFormsApp6
{
    public partial class Exams : Form
    {
        private int currentQuestionIndex = 0;
        private int correctAnswers = 0;

        private List<Question> questions = new List<Question>();
        private bool isTestStarted = true;
        List<string> answersResults = new List<string>();
        public string UserName { get; set; }
        public Exams()
        {
            InitializeComponent();
            checkedListBoxAns.ItemCheck += CheckedListBoxAns_ItemCheck;
            InitializeQuestions();
            ShowQuestion(currentQuestionIndex);
        }
        private void InitializeQuestions()
        {


            var question1 = new Question("Вопрос 1:Где находится Бразилия?", "Южная Америка", "Северная Америка", "Африка", "Азия");
            question1.AddCorrectAnswers("Южная Америка");
            var question2 = new Question("Вопрос 2: Какая страна самая большая в мире?", "Австралия", "Канада", "США", "Россия");
            question2.AddCorrectAnswers("Россия");
            var question3 = new Question("Вопрос 3:Как называется место, где река впадает в другую реку, море или озеро?", "Исток", "Русло", "Половодье");
            question3.AddCorrectAnswers("Устье");
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
            question10.AddCorrectAnswers("Widnows 95");
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
        }
        private void CheckedListBoxAns_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
            if (checkedListBoxAns.CheckedItems.Count > 0 && e.NewValue == CheckState.Checked)
            {
                e.NewValue = CheckState.Unchecked;
            }
        }
        private void CheckAnswer()
        {
            if (isTestStarted)
            {
                
                List<string> selectedAnswers = new List<string>();
                foreach (var checkedItem in checkedListBoxAns.CheckedItems)
                {
                    selectedAnswers.Add(checkedItem.ToString());
                }

                
                bool isCorrect = questions[currentQuestionIndex].IsCorrect(selectedAnswers);

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
                labelQuestion.Text = questions[index].Text;
                checkedListBoxAns.Items.Clear();
                foreach (string answer in questions[index].PossibleAnswers)
                {
                    checkedListBoxAns.Items.Add(answer);
                }

              
                if (index == questions.Count - 1)
                {
                    buttonSave.Enabled = true;
                }
            }
            else
            {
                
                buttonExam.Enabled = false;
                checkedListBoxAns.Visible = false;
                groupBoxVariant.Visible = false;
                buttonSave.Visible = true;
            }
        }

        private void Exams_Load(object sender, EventArgs e)
        {
            labelHello.Text = "Привет, " + UserName + "!";
        }

        private void buttonExam_Click(object sender, EventArgs e)
        {
            CheckAnswer(); 

            if (currentQuestionIndex < questions.Count - 1) 
            {
                currentQuestionIndex++;
                ShowQuestion(currentQuestionIndex);
                checkedListBoxAns.ClearSelected();

                
      
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
                writer.WriteLine($"Оценка: {(double)correctAnswers / questions.Count * 12:F1} из 12");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveTestResult();
            string message = $"Имя пользователя: {UserName}\n" +
                     $"Всего вопросов: {questions.Count}\n" +
                     $"Правильных ответов: {correctAnswers}\n" +
                     $"Неправильных ответов: {questions.Count - correctAnswers}";

         
            MessageBox.Show(message, "Результаты теста", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
}
