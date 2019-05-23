using System;
using System.Collections.Generic;
using Domain;

namespace UI.MVC.Models.Questions
{
    public class QuestionRESTModel
    {
        public int id { get; set; }
        public QuestionType questionType { get; set; }
        public String question { get; set; }
        public ICollection<string> options { get; set; }
        public int viewId { get; set; }
    }
}