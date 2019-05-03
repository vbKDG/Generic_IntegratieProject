using System;
using System.Collections.Generic;
using Domain;

namespace UI.MVC.Models
{
    public class QuestionnaireQuestion
    {
        public int projectId { get; set; }
        public Questionnaire questionnaire { get; set; }
        public Question question { get; set; }
        public IEnumerable<Question> questions { get; set; }
    }
}