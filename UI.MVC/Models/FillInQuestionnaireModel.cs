using System.Collections.Generic;
using DAL.EF;
using Domain;
using Microsoft.AspNetCore.Identity;

namespace UI.MVC.Models
{
    public class FillInQuestionnaireModel
    {
        public IEnumerable<Question> Questions { get; set; }
        public Questionnaire Questionnaire { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}