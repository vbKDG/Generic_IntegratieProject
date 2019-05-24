using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;
using BL;
using DAL.EF;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using UI.MVC.Models;

namespace UI.MVC.Controllers
{
    public class QuestionnaireController : Controller
    {
        private readonly IQuestionnaireManager qmgr;
        private readonly IProjectManager pmgr;

        private UserManager<ApplicationUser> _userManager;
        private readonly IEmailSender _emailSender;


        public QuestionnaireController(UserManager<ApplicationUser> userManager, IEmailSender emailSender)
        {
            qmgr = new QuestionnaireManager();
            pmgr = new ProjectManager();
            _userManager = userManager;
            _emailSender = emailSender;
        }
        
        public IActionResult Questionnaires(int projectId)
        {
            ProjectAndQuestionnaires projectAndQuestionnaires = new ProjectAndQuestionnaires();
            projectAndQuestionnaires.Project = pmgr.getProject(projectId);
            projectAndQuestionnaires.Questionnaires = qmgr.getQuestionnaires(projectId);
            return View(projectAndQuestionnaires);
        }
        
        public IActionResult Questionnaire(int questionnaireId)
        {
            FillInQuestionnaireModel fillInQuestionnaireModel = new FillInQuestionnaireModel();
            fillInQuestionnaireModel.Questions = qmgr.getQuestions(questionnaireId);
            fillInQuestionnaireModel.Questionnaire = qmgr.getQuestionnaire(questionnaireId);

            if (User.Identity.IsAuthenticated)
            {
                var applicationUserId =  User.FindFirst(ClaimTypes.NameIdentifier).Value;
                var applicationUser = _userManager.FindByIdAsync(applicationUserId).Result;
                fillInQuestionnaireModel.ApplicationUser = applicationUser;
            }
            return View(fillInQuestionnaireModel);
        }
        
        [Authorize(Roles="SuperAdmin, Admin")]
        public IActionResult CreateQuestionnairePage(int projectId)
        {
            QuestionnaireQuestion combinedModel = new QuestionnaireQuestion();
            combinedModel.ProjectId = projectId;
            return View(combinedModel);
        }

        [Authorize(Roles="SuperAdmin, Admin")]
        public IActionResult ShowResultsPage(int questionnaireId)
        {
            QuestionResultModel combinedModel = new QuestionResultModel();
            IList<QuestionUser> questionUsers = new List<QuestionUser>();
            IList<string> answers = new List<string>();
            IList<Question> ques = new List<Question>();
            IList<OptionsAmount> optionsAmounts = new List<OptionsAmount>();
            combinedModel.Questionnaire = qmgr.getQuestionnaire(questionnaireId); 
            
            foreach (var qu in qmgr.getQuestionUsers(questionnaireId))
            {
                questionUsers.Add(qu);
            }

            if (questionUsers.Count == 0)
            {
                return View(combinedModel);
            }
            combinedModel.QuestionUsers = questionUsers;
            var questionnaireAnswerCount = combinedModel.QuestionUsers.GroupBy(q => q.Question.QuestionId).ToList()[0].Count();
            combinedModel.AnsweredQuestionAmount = questionnaireAnswerCount;

            foreach (var qu in combinedModel.QuestionUsers)
            {
                Question q = qu.Question;
                if (q.QuestionType == QuestionType.DROPDOWN || q.QuestionType == QuestionType.RADIO_BUTTON)
                {
                    IList<Option> op = qmgr.getOptions(q.QuestionId).ToList();
                    foreach (var o in op)
                    {
                        if (o.TheOption == qu.Answer)
                        {
                            answers.Add(o.OptionId + "-" + o.Question.QuestionId);
                        }
                    }
                }
                if (q.QuestionType == QuestionType.CHECK_BOX)
                {
                    IList<Option> op = qmgr.getOptions(q.QuestionId).ToList();
                    foreach (var o in op)
                    {
                        var parts = qu.Answer.Split(",");
                        foreach (var part in parts)
                        {
                            if (part == o.TheOption)
                            {
                                answers.Add(o.OptionId + "-" + o.Question.QuestionId);
                            }
                        }
                    }
                }
            }

            foreach (var q in qmgr.getQuestions(questionnaireId))
            {
                if (q.QuestionType == QuestionType.DROPDOWN || q.QuestionType == QuestionType.RADIO_BUTTON || q.QuestionType == QuestionType.CHECK_BOX)
                {
                    foreach (var o in q.Options)
                    {
                        q.Options.Append(o);
                    }
                    ques.Add(q);
                }
            }
            var amountVotedPerQuestion = answers.GroupBy(o => o);
            foreach (var o in amountVotedPerQuestion)
            {
                var parts = o.Key.Split("-");
                OptionsAmount oa = new OptionsAmount()
                {
                    OptionId = Convert.ToInt32(parts[0]),
                    QuestionId = Convert.ToInt32(parts[1]),
                    Count = o.Count()
                };
                optionsAmounts.Add(oa);
            }

            combinedModel.OptionsAmounts = optionsAmounts;
            combinedModel.Questions = ques;
            
            return View(combinedModel);
        }

        [Authorize(Roles="SuperAdmin, Admin")]
        public IActionResult EditQuestionnairePage(int questionnaireId)
        {
            QuestionnaireQuestion combinedModel = new QuestionnaireQuestion();
            combinedModel.Questionnaire = qmgr.getQuestionnaire(questionnaireId);
            combinedModel.Questions = qmgr.getQuestions(questionnaireId);
            return View(combinedModel);
        }

        [Authorize(Roles="SuperAdmin, Admin")]
        public IActionResult DeleteQuestionnairePage(int questionnaireId)
        {
            Questionnaire questionnaire = qmgr.getQuestionnaire(questionnaireId);
            return View(questionnaire);
        }

        [Authorize(Roles="SuperAdmin, Admin")]
        [HttpPost]
        public IActionResult EditQuestionnaire(IFormCollection form)
        {
            var oldQuestionnaireId = 0;
            var oldQuestionnaireName = "";
            ICollection<String> questionOptionKey = new List<string>();
            ICollection<String> questionOptionValue = new List<string>();
            
            foreach (var key in form.Keys)
            {
                if (key == "questionnaire.id")
                {
                    oldQuestionnaireId = Convert.ToInt32(form[key]);
                }
            }
            IList<QuestionUser> questionUsers = qmgr.getQuestionUsers(oldQuestionnaireId).ToList();
            foreach (var qu in questionUsers)
            {
                qmgr.removeQuestionUser(qu.QuestionUserId);
            }
            
            ICollection<int> notRemovedQuestionIds = new List<int>();
            Questionnaire oldQuestionnaire = qmgr.getQuestionnaire(oldQuestionnaireId);
            ICollection<Question> oldQuestions = qmgr.getQuestions(oldQuestionnaireId).ToList();

            foreach (var key in form.Keys)
            {
                if (key.StartsWith("question.question"))
                {
                    Question q = new Question()                    
                    {                                              
                        TheQuestion = "",                      
                        Questionnaire = oldQuestionnaire,          
                        QuestionType = QuestionType.OPEN_QUESTION, 
                        IotSetup = null,                           
                        Options = new List<Option>()               
                    };
                    IList<Option> newOptions = new List<Option>();
                    string[] parts = key.Split("-");
                    int optionAmount = 1;
                    foreach (var subKey in form.Keys)
                    {
                        if (subKey == "dynamicFieldset" + parts[1])                                             
                        {        
                            if (form[subKey] == "email") { q.QuestionType = QuestionType.MAILADDRESS; }       
                            if (form[subKey] == "dropdown") { q.QuestionType = QuestionType.DROPDOWN; }         
                            if (form[subKey] == "radiobutton") { q.QuestionType = QuestionType.RADIO_BUTTON; }  
                            if (form[subKey] == "checkbox") { q.QuestionType = QuestionType.CHECK_BOX; }        
                            if (form[subKey] == "textarea") { q.QuestionType = QuestionType.OPEN_QUESTION; } 
                        }
                        if (subKey == "question.options-" + optionAmount + "-" + parts[1] + "-0")
                        {
                            Option o = new Option()
                            {
                                TheOption = form[subKey],
                                Question = q
                            };
                            newOptions.Add(o);
                            optionAmount++;
                        }
                    }
                    q.TheQuestion = form[key];
                    qmgr.addQuestion(q);                           
                    qmgr.changeQuestionnaire(oldQuestionnaire);    
                    foreach (var o in newOptions)
                    {
                        qmgr.addOption(o.TheOption, o.Question);
                    }
                    q.Options = newOptions;
                    qmgr.changeQuestion(q);
                }    
                if (key.StartsWith("question.options-"))         
                {
                    questionOptionKey.Add(key);                  
                    questionOptionValue.Add(form[key]);          
                }
            }
            foreach (var key in form.Keys)
            {
                if (key == "questionnaire.name")
                {
                    oldQuestionnaireName = form[key];
                }
                if (key.StartsWith("question-"))
                {
                    string[] parts = key.Split("-");
                    notRemovedQuestionIds.Add(Convert.ToInt32(parts[1]));
                    int counter = 1;
                    for (var i = 0; i < oldQuestions.Count; i++)
                    {
                        if (Convert.ToInt32(parts[1]) == oldQuestions.ToList()[i].QuestionId)
                        {
                            Question q = oldQuestions.ToList()[i];
                            q.TheQuestion = form[key];
                            qmgr.changeQuestion(q);

                            ICollection<Option> options = qmgr.getOptions(q.QuestionId).ToList();

                            foreach (var o in options)
                            {
                                qmgr.removeOption(o.OptionId);
                            }

                            for (var a = 0; a < questionOptionKey.Count(); a++)
                            {
                                string[] partsKey = questionOptionKey.ToList()[a].Split("-");
                                if (Convert.ToInt32(partsKey[3]) == q.QuestionId)
                                {
                                    Option o = new Option()
                                    {
                                        TheOption = questionOptionValue.ToList()[a],
                                        Question = q
                                    };
                                    q.Options.ToList().Add(o);
                                    qmgr.changeQuestion(q);
                                    qmgr.addOption(o.TheOption, o.Question);
                                }
                                if (Convert.ToInt32(partsKey[2]) == counter && Convert.ToInt32(partsKey[3]) == 0)
                                {
                                    Option o = new Option()
                                    {
                                        TheOption = questionOptionValue.ToList()[a],
                                        Question = q
                                    };
                                    q.Options.ToList().Add(o);
                                    qmgr.addOption(o.TheOption, q);
                                    qmgr.changeQuestion(q);
                                }
                            }
                        }
                        counter++;
                    }
                }
                if (key.StartsWith("dynamicFieldset"))
                {
                    string[] parts = key.Split("t");
                    for (var i = 0; i < oldQuestions.Count; i++)
                    {
                        if (Convert.ToInt32(parts[1]) == i+1)
                        {
                            Question q = oldQuestions.ToList()[i];
                            if (form[key] == "email") { q.QuestionType = QuestionType.MAILADDRESS; }
                            if (form[key] == "dropdown") { q.QuestionType = QuestionType.DROPDOWN; }
                            if (form[key] == "radiobutton") { q.QuestionType = QuestionType.RADIO_BUTTON; }
                            if (form[key] == "checkbox") { q.QuestionType = QuestionType.CHECK_BOX; }
                            if (form[key] == "textarea") { q.QuestionType = QuestionType.OPEN_QUESTION; }
                            qmgr.changeQuestion(q);
                        }
                    }
                }
            }
            oldQuestionnaire.Name = oldQuestionnaireName;
            oldQuestionnaire.QuestionAmount = oldQuestions.Count;
            qmgr.changeQuestionnaire(oldQuestionnaire);
            foreach (var q in oldQuestions)
            {
                var removeThis = true;
                foreach (var id in notRemovedQuestionIds)
                {
                    if (q.QuestionId == id)
                    {
                        removeThis = false;
                    }
                }
                if (removeThis)
                {
                    IList<Option> remOptions = qmgr.getOptions(q.QuestionId).ToList();
                    foreach (var o in remOptions)
                    {
                        qmgr.removeOption(o.OptionId);
                    }
                    qmgr.removeQuestion(q.QuestionId);
                }
            }
            oldQuestionnaire.QuestionAmount = qmgr.getQuestions(oldQuestionnaire.QuestionnaireId).Count();
            qmgr.changeQuestionnaire(oldQuestionnaire);
            return RedirectToAction("Projects","Project");
        }

        [Authorize(Roles="SuperAdmin, Admin")]
        [HttpPost]
        public IActionResult DeleteQuestionnaire(IFormCollection form)
        {
            foreach (var key in form.Keys)
            {
                if (key == "id")
                {
                    int questionnaireId = Convert.ToInt32(form[key]);
                    IList<Question> questions = qmgr.getQuestions(questionnaireId).ToList();
                    IList<QuestionUser> questionUsers = qmgr.getQuestionUsers(questionnaireId).ToList();
                    foreach (var qu in questionUsers)
                    {
                        qmgr.removeQuestionUser(qu.QuestionUserId);
                    }
                    foreach (var q in questions)
                    {
                        IList<Option> options = qmgr.getOptions(q.QuestionId).ToList();
                        foreach (var o in options)
                        {
                            qmgr.removeOption(o.OptionId);
                        }
                        qmgr.removeQuestion(q.QuestionId);
                    }
                    qmgr.removeQuestionnaire(questionnaireId);
                }
            }
            return RedirectToAction("Projects","Project");
        }
        
        [Authorize(Roles="SuperAdmin, Admin")]
        [HttpPost]
        public IActionResult CreateQuestionnaire(IFormCollection form)
        {
            int projectId = 0;
            String questionnaireName = null;
            List<Question> questions = new List<Question>();
            var currentFieldset = 1;
            IList<String> fieldTypes = new List<String>();
            var currentField = 0;
            IList<Option> options = new List<Option>();
            IList<int> currentQuestion = new List<int>();
            currentQuestion.Add(0);
            var currentOption = 1;
            
            foreach (var fieldset in form.Keys)
            {
                var ending = "dynamicFieldset" + currentFieldset;
                if (fieldset == ending)
                {
                    if (form[fieldset] == "email") { fieldTypes.Add("email"); currentFieldset++; }
                    if (form[fieldset] == "dropdown") { fieldTypes.Add("dropdown"); currentFieldset++; }
                    if (form[fieldset] == "radiobutton") { fieldTypes.Add("radiobutton"); currentFieldset++; }
                    if (form[fieldset] == "checkbox") { fieldTypes.Add("checkbox"); currentFieldset++; }
                    if (form[fieldset] == "textarea") { fieldTypes.Add("textarea"); currentFieldset++; }
                }
                if (fieldset.StartsWith("question.options"))
                {
                    var parts = fieldset.Split("-");
                    currentQuestion.Add(Convert.ToInt32(parts[2]));
                    Option o = new Option()
                    {
                        TheOption = form[fieldset]
                    };
                    options.Add(o);
                }
            }
            foreach (var key in form.Keys)
            {
                if (key == "projectId")
                {
                    foreach (var id in form[key])
                    {
                        projectId = Convert.ToInt32(id);
                    }
                }
                if (key == "questionnaire.name")
                {
                    foreach (var name in form[key])
                    {
                        questionnaireName = name;
                    }
                }
                if (key.StartsWith("question.question"))
                {
                    foreach (var question in form[key])
                    {
                        Question q = new Question()
                        {
                            TheQuestion = question,
                            Questionnaire = null,
                            QuestionType = QuestionType.OPEN_QUESTION,
                            IotSetup = null,
                            Options = new List<Option>()
                        };
                        IList<Option> finalOptions = new List<Option>();
                        if (fieldTypes[currentField] == "email") { q.QuestionType = QuestionType.MAILADDRESS; }
                        if (fieldTypes[currentField] == "dropdown") { q.QuestionType = QuestionType.DROPDOWN; }
                        if (fieldTypes[currentField] == "radiobutton") { q.QuestionType = QuestionType.RADIO_BUTTON; }
                        if (fieldTypes[currentField] == "checkbox") { q.QuestionType = QuestionType.CHECK_BOX; }
                        if (fieldTypes[currentField] == "textarea") { q.QuestionType = QuestionType.OPEN_QUESTION; }
                        currentField++;
                        for (var i = 1; i < options.Count+1; i++)
                        {
                            if (currentQuestion[i] == currentOption)
                            {
                                finalOptions.Add(options[i-1]);
                            }
                        }
                        q.Options = finalOptions;
                        questions.Add(q);
                        currentOption++;
                    }
                }
            }
            qmgr.addQuestionnaire(questions, questionnaireName, questions.Count, projectId);
            return RedirectToAction("Projects","Project");
        }

        [HttpPost]
        public IActionResult AnswerQuestionFieldIdea(IFormCollection form)
        {
            foreach (var key in form.Keys)
            {
                if (key.StartsWith("Answer-"))
                {
                    var parts = key.Split("-");
                    if (User.Identity.IsAuthenticated)
                    {
                        qmgr.addQuestionUser(User.FindFirst(ClaimTypes.NameIdentifier).Value, Convert.ToInt32(parts[1]), form[key]);
                    }
                }
            }
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserQuestion(IFormCollection form)
        {
            IList<int> questionUserIds = new List<int>();
            foreach (var key in form.Keys)
            {
                if (key.StartsWith("Answer-"))
                {
                    var parts = key.Split("-");
                    if (User.Identity.IsAuthenticated)
                    {
                        qmgr.addQuestionUser(User.FindFirst(ClaimTypes.NameIdentifier).Value, Convert.ToInt32(parts[1]), form[key]);
                    }
                    else
                    {
                        qmgr.addQuestionUser("", Convert.ToInt32(parts[1]), form[key]);
                        questionUserIds.Add(qmgr.getQuestionUsers().Last().QuestionUserId);
                    }
                }
            }
            foreach (var key in form.Keys)
            {
                if (key == "email")
                {
                    var callbackUrl = Url.Action(
                        "QuestionnaireConfirmed", "Questionnaire",
                        values: new { questionUserIds = questionUserIds },
                        protocol: Request.Scheme);
                        
                    await _emailSender.SendEmailAsync(form[key], "Confirm your answered questionnaire",
                        $"Please confirm your recently answered questionnaire by " +
                        $"<a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");
                }       
            }
            return RedirectToAction("Projects", "Project");
        }
        
        public IActionResult ConfirmQuestionnairePage()
        {
            return View();
        }
        
        public IActionResult QuestionnaireConfirmed(IList<int> questionUserIds)
        {
            foreach (var quId in questionUserIds)
            {
                QuestionUser questionUser = qmgr.getQuestionUser(quId);
                questionUser.Confirmed = true;
                qmgr.changeQuestionUser(questionUser);
            }
            return RedirectToAction("ConfirmQuestionnairePage", "Questionnaire");
        }
    }
}