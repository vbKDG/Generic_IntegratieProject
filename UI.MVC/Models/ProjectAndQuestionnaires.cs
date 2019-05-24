using System.Collections.Generic;
using Domain;

namespace UI.MVC.Models
{
    public class ProjectAndQuestionnaires
    {
        public IEnumerable<Questionnaire> Questionnaires { get; set; }
        public Project Project { get; set; }
    }
}