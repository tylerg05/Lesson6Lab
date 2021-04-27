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
        
        // swipe left
        List<string> button1AnswersList = new List<string>
        {
            "",
            "Martin Van Buren",
            "Grover Cleveland",
            "Andrew Johnson",
            "Barack Obama",
            "Warren G. Harding"
        };

        // swipe right
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

        List<string> imageNamesList = new List<string>
        {
            "",
            "flag.png",
            "twoTerms.png",
            "impeach.jpg",
            "football.jpg",            
            "phd.jpg"
        };


        int score = 0;
        int qNum = 1;
        int imgNum = 1;

        private void CheckAnswer(Object sender, SwipedEventArgs e)
        {
            //Button senderButton = sender as Button;
            string direction = e.Direction.ToString();
            if (direction.Equals("Left") && (qNum == 1 || qNum == 3))
            {
                score++;
            }
            if (direction.Equals("Right") && (qNum == 2 || qNum == 4 || qNum == 5))
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
            Image.Source = imageNamesList[imgNum];
            QuestionLbl.Text = questionsList[qNum];
            SwipeLeftFor.Text = "Swipe left for " + button1AnswersList[qNum];
            SwipeRightFor.Text = "Swipe right for " + button2AnswersList[qNum];
            imgNum++;
        }

        private void EndQuiz()
        {
            QuestionLbl.Text = $"Your Score: {score}/5";
            SwipeLeftFor.IsVisible = false;
            SwipeRightFor.IsVisible = false;
            Image.IsVisible = false;
        }

        public MainPage()
        {
            InitializeComponent();
            ShowNextQuestion();
        }

    }
}
