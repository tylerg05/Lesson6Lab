using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lesson5LabB
{
    public partial class MainPage : ContentPage
    {
        List<string> questionsList = new List<string>
        {
            "",
            "Which president was the first to be born in America?", // MARTIN VAN BUREN, Andrew Jackson
            "Which is the only president to have served more than two terms?", // FRANKLIN D. ROOSEVELT, Grover Cleveland
            "Which was the first president to be impeached?", // ANDREW JOHNSON, Richard Nixon
            "Which president turned down offers to play professional football?", // GERALD FORD, Barack Obama
            "Which is the only president with a PHD?" // WOODROW WILSON, Warren G. Harding
        };

        List<string> button1AnswersList = new List<string>
        {
            "",
            "Martin Van Buren",
            "Grover Cleveland",
            "Andrew Johnson",
            "Barack Obama",
            "Warren G. Harding"
        };

        List<string> button2AnswersList = new List<string>
        {
            "",
            "Andrew Jackson",
            "Franklin D. Roosevelt",
            "Richard Nixon",
            "Gerald Ford",
            "Woodrow Wilson"
        };

        List<string> correctAnswersList = new List<string>
        {
            "",
            "Martin Van Buren",
            "Franklin D. Roosevelt",
            "Andrew Johnson",
            "Gerald Ford",
            "Woodrow Wilson"
        };


        int score = 0;
        int qNum = 1;

        private void CheckAnswer(Object sender, System.EventArgs e)
        {
            Button senderButton = sender as Button;
            if (senderButton.Text.Equals(correctAnswersList[qNum]))
            {
                score++;
            }
            qNum++;
            if (qNum != 6)
            {
                ShowNextQuestion();
            }
            else
            {
                EndQuiz();
            }
        }

        private void ShowNextQuestion()
        {
            QuestionLbl.Text = questionsList[qNum];
            Btn1.Text = button1AnswersList[qNum];
            Btn2.Text = button2AnswersList[qNum];
        }

        private void EndQuiz()
        {
            QuestionLbl.Text = $"Your Score: {score}/5";
            Btn1.IsVisible = false;
            Btn2.IsVisible = false;
        }

        public MainPage()
        {
            InitializeComponent();
            ShowNextQuestion();
        }

    }
}
