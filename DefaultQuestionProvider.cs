using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueOrFalse
{
    /// <summary>
    /// Default implementation of question provider
    /// </summary>
    internal class DefaultQuestionProvider : IQuestionProvider
    {
        public IEnumerable<(string, bool)> GetQuestionsAndAnswers()
        {
            // Provide default set of questions and answers
            return new List<(string, bool)>
            {
                ("An eggplant is also known as an aubergine.", true),
                ("Eggplants are a species in the nightshade family.", true),
                ("According to botanical definition, eggplant is a vegetable.", false),
                ("When cut open, eggplants do not brown (oxidation)", false),
                ("Eggplants were originally domesticated from the wild species bitter apple", true)
            };
        }
    }
}
