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
<<<<<<< HEAD
       // private readonly DependencyInjectionConfig DIConfig = new DependencyInjectionConfig();

=======
        private UserManager<ApplicationUser> _userManager;
        private readonly IEmailSender _emailSender;
>>>>>>> origin/VB/QuestionIdeaForm
        
        public QuestionnaireController(UserManager<ApplicationUser> userManager, IEmailSender emailSender)
        {
            qmgr = new QuestionnaireManager();
            _userManager = userManager;
            _emailSender = emailSender;
        }
        
        public IActionResult Questionnaires(int projectId)
        {
            IEnumerable<Questionnaire> allQuestionnaires = qmgr.getQuestionnaires(projectId);
            return View(allQuestionnaires);
        }
        
        public IActionResult Questionnaire(int questionnaireId)
        {
            FillInQuestionnaireModel fillInQuestionnaireModel = new FillInQuestionnaireModel();
            fillInQuestionnaireModel.questions = qmgr.getQuestions(questionnaireId);
            fillInQuestionnaireModel.questionnaire = qmgr.getQuestionnaire(questionnaireId);

            if (User.Identity.IsAuthenticated)
            {
                var ApplicationUserId =  User.FindFirst(ClaimTypes.NameIdentifier).Value;
                var ApplicationUser = _userManager.FindByIdAsync(ApplicationUserId).Result;
                fillInQuestionnaireModel.ApplicationUser = ApplicationUser;
            }
            return View(fillInQuestionnaireModel);
        }
        
        [Authorize(Roles="SuperAdmin, Admin")]
        public IActionResult CreateQuestionnairePage(int projectId)
        {
            QuestionnaireQuestion combinedModel = new QuestionnaireQuestion();
            combinedModel.projectId = projectId;
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
            combinedModel.questionnaire = qmgr.getQuestionnaire(questionnaireId); 
            
            foreach (var qu in qmgr.getQuestionUsers(questionnaireId))
            {
                questionUsers.Add(qu);
            }

            if (questionUsers.Count == 0)
            {
                return View(combinedModel);
            }
            combinedModel.questionUsers = questionUsers;
            var questionnaireAnswerCount = combinedModel.questionUsers.GroupBy(q => q.Question.id).ToList()[0].Count();
            combinedModel.answeredQuestionAmount = questionnaireAnswerCount;

            foreach (var qu in combinedModel.questionUsers)
            {
                Question q = qu.Question;
                if (q.questionType == QuestionType.DROPDOWN || q.questionType == QuestionType.RADIO_BUTTON)
                {
                    IList<Option> op = qmgr.getOptions(q.id).ToList();
                    foreach (var o in op)
                    {
                        if (o.option == qu.Answer)
                        {
                            answers.Add(o.id + "-" + o.question.id);
                        }
                    }
                }
                if (q.questionType == QuestionType.CHECK_BOX)
                {
                    IList<Option> op = qmgr.getOptions(q.id).ToList();
                    foreach (var o in op)
                    {
                        var parts = qu.Answer.Split(",");
                        foreach (var part in parts)
                        {
                            if (part == o.option)
                            {
                                answers.Add(o.id + "-" + o.question.id);
                            }
                        }
                    }
                }
            }

            foreach (var q in qmgr.getQuestions(questionnaireId))
            {
                if (q.questionType == QuestionType.DROPDOWN || q.questionType == QuestionType.RADIO_BUTTON || q.questionType == QuestionType.CHECK_BOX)
                {
                    foreach (var o in q.options)
                    {
                        q.options.Append(o);
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
                    optionId = Convert.ToInt32(parts[0]),
                    questionId = Convert.ToInt32(parts[1]),
                    count = o.Count()
                };
                optionsAmounts.Add(oa);
            }

            combinedModel.optionsAmounts = optionsAmounts;
            combinedModel.questions = ques;
            
            return View(combinedModel);
        }

        [Authorize(Roles="SuperAdmin, Admin")]
        public IActionResult EditQuestionnairePage(int questionnaireId)
        {
            QuestionnaireQuestion combinedModel = new QuestionnaireQuestion();
            combinedModel.questionnaire = qmgr.getQuestionnaire(questionnaireId);
            combinedModel.questions = qmgr.getQuestions(questionnaireId);
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
                qmgr.removeQuestionUser(qu.id);
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
                        question = "",                      
                        questionnaire = oldQuestionnaire,          
                        questionType = QuestionType.OPEN_QUESTION, 
                        IotSetup = null,                           
                        options = new List<Option>()               
                    };
                    IList<Option> newOptions = new List<Option>();
                    string[] parts = key.Split("-");
                    int optionAmount = 1;
                    foreach (var subKey in form.Keys)
                    {
                        if (subKey == "dynamicFieldset" + parts[1])                                             
                        {        
                            if (form[subKey] == "email") { q.questionType = QuestionType.MAILADDRESS; }       
                            if (form[subKey] == "dropdown") { q.questionType = QuestionType.DROPDOWN; }         
                            if (form[subKey] == "radiobutton") { q.questionType = QuestionType.RADIO_BUTTON; }  
                            if (form[subKey] == "checkbox") { q.questionType = QuestionType.CHECK_BOX; }        
                            if (form[subKey] == "textarea") { q.questionType = QuestionType.OPEN_QUESTION; } 
                        }
                        if (subKey == "question.options-" + optionAmount + "-" + parts[1] + "-0")
                        {
                            Option o = new Option()
                            {
                                option = form[subKey],
                                question = q
                            };
                            newOptions.Add(o);
                            optionAmount++;
                        }
                    }
                    q.question = form[key];
                    qmgr.addQuestion(q);                           
                    qmgr.changeQuestionnaire(oldQuestionnaire);    
                    foreach (var o in newOptions)
                    {
                        qmgr.addOption(o.option, o.question);
                    }
                    q.options = newOptions;
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
                    int testt = 1;
                    for (var i = 0; i < oldQuestions.Count; i++)
                    {
                        if (Convert.ToInt32(parts[1]) == oldQuestions.ToList()[i].id)
                        {
                            Question q = oldQuestions.ToList()[i];
                            q.question = form[key];
                            qmgr.changeQuestion(q);

                            ICollection<Option> options = qmgr.getOptions(q.id).ToList();

                            foreach (var o in options)
                            {
                                qmgr.removeOption(o.id);
                            }

                            for (var a = 0; a < questionOptionKey.Count(); a++)
                            {
                                string[] partsKey = questionOptionKey.ToList()[a].Split("-");
                                if (Convert.ToInt32(partsKey[3]) == q.id)
                                {
                                    Option o = new Option()
                                    {
                                        option = questionOptionValue.ToList()[a],
                                        question = q
                                    };
                                    q.options.ToList().Add(o);
                                    qmgr.changeQuestion(q);
                                    qmgr.addOption(o.option, o.question);
                                }
                                if (Convert.ToInt32(partsKey[2]) == testt && Convert.ToInt32(partsKey[3]) == 0)
                                {
                                    Option o = new Option()
                                    {
                                        option = questionOptionValue.ToList()[a],
                                        question = q
                                    };
                                    q.options.ToList().Add(o);
                                    qmgr.addOption(o.option, q);
                                    qmgr.changeQuestion(q);
                                }
                            }
                        }
                        testt++;
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
                            if (form[key] == "email") { q.questionType = QuestionType.MAILADDRESS; }
                            if (form[key] == "dropdown") { q.questionType = QuestionType.DROPDOWN; }
                            if (form[key] == "radiobutton") { q.questionType = QuestionType.RADIO_BUTTON; }
                            if (form[key] == "checkbox") { q.questionType = QuestionType.CHECK_BOX; }
                            if (form[key] == "textarea") { q.questionType = QuestionType.OPEN_QUESTION; }
                            qmgr.changeQuestion(q);
                        }
                    }
                }
            }
            oldQuestionnaire.name = oldQuestionnaireName;
            oldQuestionnaire.questionAmount = oldQuestions.Count;
            qmgr.changeQuestionnaire(oldQuestionnaire);
            foreach (var q in oldQuestions)
            {
                var removeThis = true;
                foreach (var id in notRemovedQuestionIds)
                {
                    if (q.id == id)
                    {
                        removeThis = false;
                    }
                }
                if (removeThis)
                {
                    IList<Option> remOptions = qmgr.getOptions(q.id).ToList();
                    foreach (var o in remOptions)
                    {
                        qmgr.removeOption(o.id);
                    }
                    qmgr.removeQuestion(q.id);
                }
            }
            oldQuestionnaire.questionAmount = qmgr.getQuestions(oldQuestionnaire.id).Count();
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
                        qmgr.removeQuestionUser(qu.id);
                    }
                    foreach (var q in questions)
                    {
                        IList<Option> options = qmgr.getOptions(q.id).ToList();
                        foreach (var o in options)
                        {
                            qmgr.removeOption(o.id);
                        }
                        qmgr.removeQuestion(q.id);
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
                        option = form[fieldset]
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
                            question = question,
                            questionnaire = null,
                            questionType = QuestionType.OPEN_QUESTION,
                            IotSetup = null,
                            options = new List<Option>()
                        };
                        IList<Option> finalOptions = new List<Option>();
                        if (fieldTypes[currentField] == "email") { q.questionType = QuestionType.MAILADDRESS; }
                        if (fieldTypes[currentField] == "dropdown") { q.questionType = QuestionType.DROPDOWN; }
                        if (fieldTypes[currentField] == "radiobutton") { q.questionType = QuestionType.RADIO_BUTTON; }
                        if (fieldTypes[currentField] == "checkbox") { q.questionType = QuestionType.CHECK_BOX; }
                        if (fieldTypes[currentField] == "textarea") { q.questionType = QuestionType.OPEN_QUESTION; }
                        currentField++;
                        for (var i = 1; i < options.Count+1; i++)
                        {
                            if (currentQuestion[i] == currentOption)
                            {
                                finalOptions.Add(options[i-1]);
                            }
                        }
                        q.options = finalOptions;
                        questions.Add(q);
                        currentOption++;
                    }
                }
            }
            qmgr.addQuestionnaire(questions, questionnaireName, questions.Count, projectId);
            return RedirectToAction("Projects","Project");
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
                        questionUserIds.Add(qmgr.getQuestionUsers().Last().id);
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