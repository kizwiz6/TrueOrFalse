using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueOrFalse
{
    /// <summary>
    /// Class representing quiz.
    /// </summary>
    internal class Quiz
    {
        private readonly IQuestionProvider questionProvider;

        public Quiz(IQuestionProvider questionProvider)
        {
            this.questionProvider = questionProvider;
        }

        // Start the quiz
        public void Start()
        {
            // Welcome message
            Console.WriteLine("Welcome to 'True or Flase?'\nPress Enter to begin:");
            string entry = Console.ReadLine();

            // Take the quiz
            TakeQuiz();
        }

        // Method to handle taking the quiz
        private void TakeQuiz()
        {
            // Retrieve questions and answers from the question provider
            IEnumerable<(string, bool)> questionsAndAnswers = questionProvider.GetQuestionsAndAnswers();
            List<(string, bool)> questionsAndAnswersList = new List<(string, bool)>(questionsAndAnswers);
            bool[] responses = new bool[questionsAndAnswersList.Count];
            int index = 0;

            // Iterate through each question
            foreach (var (question, answer) in questionsAndAnswers)
            {
                // Display the question
                Console.WriteLine(question);
                Console.WriteLine("True or false?");
                // Get user response and compare with the correct answer
                responses[index++] = GetUserResponse() == answer;
            }

            // Calculate and display the score
            CalculateAndDisplayScore(responses);
        }

        // Method to get user response for a question
        private bool GetUserResponse()
        {
            while (true)
            {
                // Get user input and convert to lowercase
                string input = Console.ReadLine().ToLower();
                // Check if input is valid
                if (input == "true")
                    return true;
                else if (input == "false")
                    return false;
                else
                    Console.WriteLine("Please respond with 'true' or 'false'");
            }
        }

        // Method to calculate and display the score
        private void CalculateAndDisplayScore(bool[] responses)
        {
            int score = 0;
            int index = 0;

            // Display user input and correct answers for each question
            foreach (var (question, answer) in questionProvider.GetQuestionsAndAnswers())
            {
                bool response = responses[index++];
                Console.WriteLine($"Question: {question}");
                Console.WriteLine($"Your Input: {(response ? "True" : "False")} | Correct Answer: {(answer ? "True" : "False")}");
                Console.WriteLine();
                if (response == answer)
                {
                    score++;
                }
            }

            // Display the final score
            Console.WriteLine($"You got {score} out of {responses.Length} correct.");
        }
    }
}
