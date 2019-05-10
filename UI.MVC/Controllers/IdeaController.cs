using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using BL;
using D.UI.MVC.Models.Fields;
using D.UI.MVC.Models.Ideas;
using DAL.EF;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.MVC.Controllers
{
    public class IdeaController : Controller
    {
        private IIdeationManager ideationMgr;
        private IQuestionnaireManager questionnaireMgr;
        private readonly DependencyInjectionConfig DIConfig = new DependencyInjectionConfig();

//        public IdeaController(ApplicationDbContext ctx)
//        {
//            ideationMgr = new IdeationManager(ctx);
//        }

//        public IdeaController()
//        {
//            ideationMgr = DIConfig.container.Resolve<IdeationManager>();
//        }

        public IdeaController()
        {
            ideationMgr = new IdeationManager();
            questionnaireMgr = new QuestionnaireManager();
        }

        public IActionResult CreateIdeaPage(int ideationId)
        {

            IdeationQuestion[] ideationQuestions = ideationMgr.GetIdeationQuestions(ideationId).ToArray();
            IdeaVM ideaVm = new IdeaVM();
            ideaVm.textfields = new TextFieldVm[0];
            

            String[] questions = new string[ideationQuestions.Length];

            for (int i = 0; i < ideationQuestions.Length; i++)
            {
                questions[i] = ideationQuestions[i].question;

            }

            ideaVm.ideationQuestion = questions;
            ideaVm.ideationId = ideationId;




            return View(ideaVm);
        }

        public IActionResult MapInput()
        {
            return View();
        }



        public IActionResult CreateIdea(IdeaVM ideaVm)
        {
            Idea idea = new Idea();
            ICollection<Field> fields = new List<Field>();
            TextField textField = new TextField();
            ImageField imageField = new ImageField();
            VideoField videoField = new VideoField();
            MapField mapField = new MapField();

            textField.text = Convert.ToString(ideaVm.textFieldVM.text);
            mapField.latitude = ideaVm.mapFieldVM.latitude;
            mapField.longitude = ideaVm.mapFieldVM.longitude;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                ideaVm.imageFieldVM.imageFile.CopyTo(memoryStream);
                imageField.imageData = memoryStream.ToArray();
            }

            using (var reader = ideaVm.imageFieldVM.imageFile.OpenReadStream())
            using (var stream = new MemoryStream())
            {
                {
                    reader.CopyTo(stream);
                    imageField.imageData = stream.ToArray();

                }

            }

            using (var reader = ideaVm.videoFieldVM.videoFile.OpenReadStream())
            using (var stream = new MemoryStream())
            {
                {
                    reader.CopyTo(stream);
                    videoField.videoData = stream.ToArray();

                }

            }

            Ideation ideation = ideationMgr.getIdeation(ideaVm.ideationId);

            
            idea.ideation = ideation;
            fields.Add(textField);
            fields.Add(imageField);
            fields.Add(videoField);
            fields.Add(mapField);
            idea.fields = fields;
            ideationMgr.createIdea(idea);

            var projectId = ideationMgr.getIdeation(ideaVm.ideationId).project.projectId;


            return RedirectToAction("Project", "Project", new {id = projectId});
        }

        public IActionResult CreateIdeationPage(int projectId)
        {
            
            
            return View();
        }

        public IActionResult CreateQuestionPage()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult CreateQuestion(IFormCollection form)
        {
            /*Idea idea = new Idea();
            ICollection<Field> fields = new List<Field>();
            
            Ideation ideation = ideationMgr.getIdeation(1);
            idea.ideation = ideation;
            
            QuestionField q = new QuestionField()
            {
                question = new Question()
                {
                    question = ideaVm.QuestionFieldVm.question.question,
                    questionType = ideaVm.QuestionFieldVm.question.questionType
                }
            };
            
            fields.Add(q);
            idea.fields = fields;
            ideationMgr.createIdea(idea);*/

           
            Question question = new Question()
            {
                options = new List<Option>()
            };
            IList<Option> options = new List<Option>();
            
            foreach (var key in form.Keys)
            {
                if (key == "questionFieldset")
                {
                    if (form[key] == "radiobutton") { question.questionType = QuestionType.RADIO_BUTTON; }
                    if (form[key] == "checkbox") { question.questionType = QuestionType.CHECK_BOX; }
                }

                if (key == "question")
                {
                    question.question = form[key];
                }
                if (key.StartsWith("question.options"))
                {
                    Option o = new Option()
                    {
                        option = form[key]
                    };
                    options.Add(o);
                }
            }
            questionnaireMgr.addQuestion(question);

            foreach (var option in options)
            {
                questionnaireMgr.addOption(option.option, question);
            }

            question.options = options;
            questionnaireMgr.changeQuestion(question);
            return RedirectToAction("Index","Home");
        }
    }
}