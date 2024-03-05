using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueOrFalse
{
    internal class Quiz
    {
        // Array of questions
        private string[] questions = new string[] {
            "An eggplant is also known as an aubergine.",
            "Eggplants are a species in the nightshade family.",
            "According to botanical definition, eggplant is a vegetable.",
            "When cut open, eggplants do not brown (oxidation)",
            "Eggplants were originally domesticated from the wild species bitter apple"
        };

        // Array of correct answers
        private bool[] answers = new bool[] { true, true, false, false, true };

        // Method to start the quiz
        public void Start()
        {
            // Welcome message
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();

            // Take the quiz
            TakeQuiz();

            // Display the results
            DisplayResults();
        }

        // Method to handle taking the quiz
        private void TakeQuiz()
        {
            // Array to store user responses
            bool[] responses = new bool[questions.Length];

            // Iterate through each question
            for (int i = 0; i < questions.Length; i++)
            {
                // Display the question
                Console.WriteLine(questions[i]);
                Console.WriteLine("True or false?");
                // Get user response
                responses[i] = GetUserResponse();
            }

            // Calculate the score
            CalculateScore(responses);
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
        private void CalculateScore(bool[] responses)
        {
            int score = 0;
            // Compare user responses with correct answers
            for (int i = 0; i < responses.Length; i++)
            {
                if (responses[i] == answers[i])
                    score++;
            }
            // Display the score
            DisplayScore(score);
        }

        // Method to display the final score
        private void DisplayScore(int score)
        {
            Console.WriteLine($"You got {score} out of {questions.Length} correct.");
        }

        // Method to display additional results (if needed)
        private void DisplayResults()
        {
            // Additional logic for displaying results, if needed
        }
    }
}
