using System.Collections.Generic;
using Domain;

namespace UI.MVC.Models
{
    public class QuestionResultModel
    {
        public IEnumerable<QuestionUser> QuestionUsers { get; set; }
        public IEnumerable<Question> Questions { get; set; }
        public Questionnaire Questionnaire { get; set; }
        public IList<OptionsAmount> OptionsAmounts { get; set; }
        public int AnsweredQuestionAmount { get; set; }
    }
}