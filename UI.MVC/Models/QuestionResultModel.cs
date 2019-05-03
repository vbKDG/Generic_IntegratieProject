using System.Collections.Generic;
using Domain;

namespace UI.MVC.Models
{
    public class QuestionResultModel
    {
        public IEnumerable<QuestionUser> questionUsers { get; set; }
        public IEnumerable<Question> questions { get; set; }
        public Questionnaire questionnaire { get; set; }
        public IList<OptionsAmount> optionsAmounts { get; set; }
        public int answeredQuestionAmount { get; set; }
    }
}