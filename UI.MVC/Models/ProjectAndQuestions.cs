using System.Collections.Generic;
using Domain;

namespace UI.MVC.Models
{
    public class ProjectAndQuestions
    {
        public IEnumerable<IdeationQuestion> ideationQuestions { get; set; }
        public Project project { get; set; }
    }
}