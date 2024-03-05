namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a quiz with a specific set of questions and answers
            Quiz quiz = new Quiz(new DefaultQuestionProvider());
            quiz.Start();
        }
    }
}