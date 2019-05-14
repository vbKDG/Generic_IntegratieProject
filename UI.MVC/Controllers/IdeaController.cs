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
using Microsoft.Extensions.Primitives;
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
            List<ImageFieldVm> imageFieldVms = new List<ImageFieldVm>();
            List<TextFieldVm> textFieldVms = new List<TextFieldVm>();
            List<VideoFieldVm> videoFieldVms  = new List<VideoFieldVm>();
            
            
            IdeaVM ideaVm = new IdeaVM();
            ideaVm.ImageFieldVms = imageFieldVms;
            ideaVm.VideoFieldVms = videoFieldVms;
            ideaVm.TextFieldVms = textFieldVms;
            
            
            
            for (int i = 0; i < ideation.TextFieldRange.Maximum ; i++)
            {        
                ideaVm.TextFieldVms.Add(new TextFieldVm());   
            }  
           for (int i = 0; i < ideation.VideoRange.Maximum ; i++)
           {        
              ideaVm.VideoFieldVms.Add(new VideoFieldVm());   
           }
           
           for (int i = 0; i < ideation.ImageFieldRange.Maximum ; i++)
            {        
                ideaVm.ImageFieldVms.Add(new ImageFieldVm());    
            }
           // ideaVm.ImageFieldVms = new ImageFieldVm[ideation.ImageFieldRange.Maximum];
           ideaVm.VideoFieldVms = videoFieldVms;
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


        [HttpPost]
        public IActionResult CreateIdea(IdeaVM ideaVm)
        {
            Idea idea = new Idea();
            
            
            ICollection<Field> fields = new List<Field>();
            TextField textField = new TextField();
            List<ImageField> imageFields = new List<ImageField>();
            List<VideoField> videoFields = new List<VideoField>();

           // ImageField[] imageFields; // = new ImageField[ideaVm.images.Files.Count];
            //VideoField[] videoFields; //= new VideoField[ideaVm.images.Files.Count];
            MapField mapField = new MapField();
            
            
            
//            textField.text = Convert.ToString(ideaVm.textFieldVM.text);
//            mapField.latitude = ideaVm.mapFieldVM.latitude;
//            mapField.longitude = ideaVm.mapFieldVM.longitude;

//            using (MemoryStream memoryStream = new MemoryStream())
//            {
//                ideaVm.imageFieldVM.imageFile.Files[0].CopyTo(memoryStream);
//                imageField.imageData = memoryStream.ToArray();
//            }
           // var imageIndex = 0;
           // var videoIndex = 0;

            for (int i = 0; i < ideaVm.Files.Files.Count; i++)
            {
                if (ideaVm.Files.Files[i].ContentType.StartsWith("image"))
                {
                   // imageFields[imageIndex] = new ImageField();
                   
                    using (var reader = ideaVm.Files.Files[i].OpenReadStream())
                    using (var stream = new MemoryStream())
                    {
                        {
                        
                            reader.CopyTo(stream);
                            imageFields.Add(new ImageField{imageData = stream.ToArray()});
                           // imageFields[imageIndex].imageData = stream.ToArray();

                        }

                    }
                  //  imageIndex++;
                    
                } else if (ideaVm.Files.Files[i].ContentType.StartsWith("video"))
                {
                   // videoFields[videoIndex] = new VideoField();
                    using (var reader = ideaVm.Files.Files[i].OpenReadStream())
                    using (var stream = new MemoryStream())
                    {
                        {
                        
                            reader.CopyTo(stream);
                            videoFields.Add(new VideoField{videoData = stream.ToArray()});

                        }

                    } 
                   // videoIndex++;

                }
               
            }
            
            /*for (int i = 0; i < ideaVm.images.Files.Count; i++)
            {
                videoFields[i] = new VideoField();
                using (var reader = ideaVm.images.Files[i].OpenReadStream())
                using (var stream = new MemoryStream())
                {
                    {
                        
                        reader.CopyTo(stream);
                        videoFields[i].videoData = stream.ToArray();

                    }

                }
            }*/
            

//            using (var reader = ideaVm.videoFieldVM.videoFile.OpenReadStream())
//            using (var stream = new MemoryStream())
//            {
//                {
//                    reader.CopyTo(stream);
//                    videoField.videoData = stream.ToArray();
//
//                }
//
//            }

            Ideation ideation = ideationMgr.getIdeation(ideaVm.ideationId);

            
            idea.ideation = ideation;
            fields.Add(textField);
            foreach (var imageField in imageFields)
            {
                fields.Add(imageField);

            }

            foreach (var videoField in videoFields)
            {
                fields.Add(videoField);

            }
            fields.Add(mapField);
            idea.fields = fields;
            ideationMgr.createIdea(idea);

            var projectId = ideationMgr.getIdeation(ideaVm.ideationId).project.projectId;


            return RedirectToAction("Project", "Project", new {id = projectId});
        }
        
        public IActionResult Ideas(int ideationId)
        {
            IdeasVM ideasVm = new IdeasVM();
            List<IdeaVM> ideaVmList = new List<IdeaVM>();
            IEnumerable<Idea> ideas = ideationMgr.getIdeas(ideationId);
            foreach (var idea in ideas)
            {
                ideaVmList.Add(new IdeaVM
                {
                    ideationId = idea.ideaId
                    
                });
            }

            ideasVm.IdeationId = ideationId;
            ideasVm.IdeaVms = ideaVmList;
            
            return View(ideasVm);
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