using System;
using System.Collections;
using System.Collections.Generic;
using BL;
using Domain;
using Microsoft.AspNetCore.Mvc;
using UI.MVC.Models.Questions;

namespace UI.MVC.Controllers.api
{
    public class QuestionnairesController : Controller
    {
        IQuestionnaireManager mgr = new QuestionnaireManager();

        [HttpGet("/api/Questions/{id}")]
        public IActionResult GetQuestionnaireQuestions(int id)
        {
            IEnumerable<Question> questions = mgr.getQuestions(id);
            List<QuestionRESTModel> newQuestions = new List<QuestionRESTModel>();
            foreach (var question in questions)
            {
                List<string> options = new List<string>();
                foreach (var option in question.options)
                {
                    options.Add(option.option);
                }
                
                QuestionRESTModel model = new QuestionRESTModel()
                {
                    id = question.id,
                    questionType = question.questionType,
                    question = question.question,
                    options = options,
                    viewId = 0
                };
                newQuestions.Add(model);
            }
            
            return Ok(newQuestions);
        }

        [HttpPost("/api/SubmitQuestionnaire")]
        public IActionResult SubmitQuestionnaire([FromBody] IEnumerable<QuestionAnswerRESTModel> model)
        {
            foreach (var question in model)
            {
                mgr.addQuestionUser("", question.questionId, question.answer);
            }

            return Ok(model);
        }
    }
}