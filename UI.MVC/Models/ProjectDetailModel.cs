using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace UI.MVC.Models
{
    public class ProjectDetailModel
    {
        public Project project { get; set; }
        public ICollection<IdeationQuestion> ideationQuestions { get; set; }
    }
}