using System.Collections.Generic;
using BL;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace UI.MVC.Controllers.api
{
    public class QuestionnairesController : Controller
    {
        IQuestionnaireManager mgr = new QuestionnaireManager();

        [HttpGet("/api/Questions/{id}")]
        public IActionResult GetQuestionnaireQuestions(int id)
        {
            IEnumerable<Question> questions = mgr.getQuestions(id);

            foreach (var question in questions)
            {
                question.questionnaire = null;
            }
            
            return Ok(questions);
        }
    }
}