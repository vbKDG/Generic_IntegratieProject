using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Autofac;
using BL;
using D.UI.MVC.Models.Fields;
using D.UI.MVC.Models.Ideas;
using DAL.EF;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UI.MVC.Models.Ideations;

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

            Ideation ideation = ideationMgr.getIdeation(ideationId);
            IdeationQuestion[] ideationQuestions = ideationMgr.GetIdeationQuestions(ideationId).ToArray();
            IdeaVM ideaVm = new IdeaVM();
         //   TextFieldVm[] textFieldVms = new TextFieldVm[ideation.TextFieldRange.Maximum];
            ideaVm.TextFieldVms = new TextFieldVm[ideation.TextFieldRange.Maximum];
            ideaVm.ImageFieldVms = new ImageFieldVm[ideation.ImageFieldRange.Maximum];
            ideaVm.VideoFieldVms = new VideoFieldVm[ideation.VideoRange.Maximum];
            ideaVm.MapFieldVms = new MapFieldVm[ideation.MapFieldRange.Maximum];

            
            

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
        
        public IActionResult Ideas(int ideationId)
        {
            /*IdeasVM ideasVm = new IdeasVM();
            List<IdeaVM> ideaVmList = new List<IdeaVM>();
            IEnumerable<Idea> ideas = ideationMgr.getIdeas(ideationId);
            
            ideationMgr.GetIdeationQuestions(ideationId);
            foreach (var idea in ideas)
            {
                ideaVmList.Add(new IdeaVM
                {
                    ideationId = idea.ideaId,
                    
                });
            }

            ideasVm.IdeationId = ideationId;
            ideasVm.IdeaVms = ideaVmList;
            
            return View(ideasVm);*/
            
            IdeasVM ideasVm = new IdeasVM();
            ideasVm.IdeationId = ideationId;
            ideasVm.ideas = ideationMgr.getIdeas(ideationId).ToList();
            ideasVm.fields = new List<TextField>();
            foreach (var idea in ideasVm.ideas)
            {
                foreach (var field in ideationMgr.GetFields(idea.ideaId).ToList())
                {
                    ideasVm.fields.Add(field);
                }
            }
            return View(ideasVm);
        }

        public IActionResult LikeIdea(int ideaId)
        {
            if (User.Identity.IsAuthenticated)
            {
                ideationMgr.LikeIdea(ideaId, User.FindFirst(ClaimTypes.NameIdentifier).Value);
            }
            return NoContent();
        }
       
        public IActionResult CreateIdeation(IdeationVM ideationVm)
        {
            
            Ideation ideation = new Ideation();
            ideation.TextFieldRange = ideationVm.TextField;
            ideation.ImageFieldRange = ideationVm.ImageField;
            ideation.VideoRange = ideationVm.VideoField;
            ideation.MapFieldRange = ideationVm.MapField;
            ideation.QuestionFieldRange = ideationVm.QuestionField;

            ideation.adminOnly = ideationVm.AdminOnly;
            
            List<IdeationQuestion> ideationQuestions = new List<IdeationQuestion>();

            foreach (var item in ideationVm.ideationQuestionVMs)
            {            
                ideationQuestions.Add(new IdeationQuestion{question = item.question}); 
            }

            ideation.questions = ideationQuestions;
             
            ideationMgr.CreateIdeation(ideation,ideationVm.ProjectId);
            
           
            
          
            
            
            return RedirectToAction("Project", "Project", new {id = ideationVm.ProjectId});

            
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