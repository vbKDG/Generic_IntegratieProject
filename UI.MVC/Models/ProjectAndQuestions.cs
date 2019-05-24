using System.Collections.Generic;
using Domain;

namespace UI.MVC.Models
{
    public class ProjectAndQuestions
    {
        public IEnumerable<IdeationQuestion> IdeationQuestions { get; set; }
        public Project Project { get; set; }
    }
}