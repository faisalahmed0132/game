using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment1MCQGame_AnyaScheinman
{
    public partial class Form5 : Form
    {
        private List<Question> questions;
        private int currentQuestionIndex = 0;

        public Form5()
        {
            InitializeComponent();
            InitializeQuestions();
            DisplayQuestion();
        }

        private void InitializeQuestions()
        {
            // Add your MCQ questions here
            questions = new List<Question>
            {
                new Question("What is the capital of France?", new List<string> { "Berlin", "Madrid", "Paris", "Rome" }, 2),
                new Question("Which planet is known as the Red Planet?", new List<string> { "Mars", "Venus", "Jupiter", "Saturn" }, 0),
                // Add more questions as needed
            };
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                Question currentQuestion = questions[currentQuestionIndex];
                lblQuestion.Text = currentQuestion.Text;

                btnOption1.Text = currentQuestion.Options[0];
                btnOption2.Text = currentQuestion.Options[1];
                btnOption3.Text = currentQuestion.Options[2];
                btnOption4.Text = currentQuestion.Options[3];
            }
            else
            {
                MessageBox.Show("Quiz Completed!");
                // You can add logic for what happens after the quiz is completed
                // For example, show the user's score or display a summary
            }
        }

        private void CheckAnswer(int selectedOption)
        {
            Question currentQuestion = questions[currentQuestionIndex];

            if (selectedOption == currentQuestion.CorrectOption)
            {
                MessageBox.Show("Correct!");
                // Add logic for handling correct answers, update score, etc.
            }
            else
            {
                MessageBox.Show("Incorrect!");
                // Add logic for handling incorrect answers
            }

            // Move to the next question
            currentQuestionIndex++;
            DisplayQuestion();
        }

        private void btnOption1_Click(object sender, EventArgs e)
        {
            CheckAnswer(0);
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            CheckAnswer(1);
        }

        private void btnOption3_Click(object sender, EventArgs e)
        {
            CheckAnswer(2);
        }

        private void btnOption4_Click(object sender, EventArgs e)
        {
            CheckAnswer(3);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }

    public class Question
    {
        public string Text { get; }
        public List<string> Options { get; }
        public int CorrectOption { get; }

        public Question(string text, List<string> options, int correctOption)
        {
            Text = text;
            Options = options;
            CorrectOption = correctOption;
        }
    }
}