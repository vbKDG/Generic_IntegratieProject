using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Questionnaire
    {
        [Required]
        public int id { get; set; }
        
        public string name { get; set; }
        public int questionAmount { get; set; }
        public Project project { get; set; }
        public ICollection<Question> questions { get; set; }

        public Questionnaire()
        {
        }

        public Questionnaire(int questionAmount, ICollection<Question> questions)
        {
            this.questionAmount = questionAmount;
            this.questions = questions;
        }
    }
}