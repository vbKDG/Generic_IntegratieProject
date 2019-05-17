using System;
using System.Collections.Generic;
using Domain;

namespace UI.MVC.Models.Questions
{
    public class QuestionVM
    {
        public int id { get; set; }
        public String questionType { get; set; }
        public String question { get; set; }

        public ICollection<String> Options { get; set; }
    }

}