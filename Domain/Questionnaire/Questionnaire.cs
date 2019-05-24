using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Questionnaire
    {
        [Required]
        public int QuestionnaireId { get; set; }
        
        public string Name { get; set; }
        public int QuestionAmount { get; set; }
        public Project Project { get; set; }
        public ICollection<Question> Questions { get; set; }

        public Questionnaire()
        {
        }

        public Questionnaire(int questionAmount, ICollection<Question> questions)
        {
            this.QuestionAmount = questionAmount;
            this.Questions = questions;
        }
    }
}