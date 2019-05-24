using System;
using System.Collections.Generic;
using Domain;

namespace UI.MVC.Models
{
    public class QuestionnaireQuestion
    {
        public int ProjectId { get; set; }
        public Questionnaire Questionnaire { get; set; }
        public Question Question { get; set; }
        public IEnumerable<Question> Questions { get; set; }
    }
}