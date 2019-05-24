using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Domain
{
    public class Question
    {
        [Required]
        public int QuestionId { get; set; }
        public QuestionType QuestionType { get; set; }
        public String TheQuestion { get; set; }
        public Questionnaire Questionnaire { get; set; }
        public QuestionField QuestionField { get; set; }
        public int QuestionFk_Shadow { get; set; }
        public ICollection<Option> Options { get; set; }
        public ICollection<QuestionUser> QuestionnaireAnswers { get; set; }
        public IotSetup IotSetup { get; set; }
        public ICollection<IotVote> IotVotes { get; set; }


        public Question()
        {
        }

        public Question(string theQuestion)
        {
            this.TheQuestion = theQuestion;
        }

        public Question(QuestionType questionType, String theQuestion)
        {
            this.QuestionType = questionType;
            this.TheQuestion = theQuestion;
        }
    }
}