using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueOrFalse
{
    /// <summary>
    /// Interface for providing questions and answers
    /// </summary>
    internal interface IQuestionProvider
    {
        // Method to get questions and answers
        IEnumerable<(string, bool)> GetQuestionsAndAnswers();
    }
}
