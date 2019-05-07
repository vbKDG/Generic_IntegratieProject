using System.Collections.Generic;
using DAL.EF;
using Domain;
using Microsoft.AspNetCore.Identity;

namespace UI.MVC.Models
{
    public class FillInQuestionnaireModel
    {
        public IEnumerable<Question> questions { get; set; }
        public Questionnaire questionnaire { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}