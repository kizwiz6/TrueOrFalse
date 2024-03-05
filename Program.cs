namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine(); // Waiting for user to press Enter

            // Array of questions
            string[] questions = new string[] {
                "An eggplant is also known as an aubergine.",
                "Eggplants are a species in the nightshade family.",
                "According to botanical definition, eggplant is a vegetable.",
                "When cut open, eggplants do not brown (oxidation)",
                "Eggplants were originally domesticated from the wild species bitter apple"
            };

            // Array of correct answers
            bool[] answers = new bool[]
            {
                true,
                true,
                false,
                false,
                true
            };

            // Array to store user responses
            bool[] responses = new bool[questions.Length];

            // Warning if the number of questions and answers don't match
            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Warning! The number of answers supplied does not match the number of questions.");
            }

            // Iterating through questions and taking user input
            int askingIndex = 0;
            foreach (string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;
                Console.WriteLine(question);
                Console.WriteLine("True or false?");
                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);
                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses[askingIndex] = inputBool;
                askingIndex++;
            }

            // Scoring and displaying results
            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.Write(scoringIndex + 1 + ".");
                Console.WriteLine($"Input: {response} | Answer: {answer}");

                if (response == answer)
                {
                    score++;
                }
                scoringIndex++;

            }

            // Displaying final score
            Console.WriteLine($"You got {score} out of {questions.Length} correct.");

        }
    }
}