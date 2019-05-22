using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Security.Policy;
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
            List<QuestionFieldVm> questionFieldVms = new List<QuestionFieldVm>();
            List<MapFieldVm> mapFieldVms = new List<MapFieldVm>();
            
            
            IdeaVM ideaVm = new IdeaVM();
            ideaVm.ImageFieldVms = imageFieldVms;
            ideaVm.VideoFieldVms = videoFieldVms;
            ideaVm.TextFieldVms = textFieldVms;
            ideaVm.QuestionFieldVms = questionFieldVms;
            ideaVm.MapFieldVms = mapFieldVms;
            
            
            for (int i = 0; i < ideation.QuestionFieldRange.Maximum ; i++)
            {        
                ideaVm.QuestionFieldVms.Add(new QuestionFieldVm{Options = new string[5]});   
            }         
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
           for (int i = 0; i < ideation.MapFieldRange.Maximum ; i++)
           {        
               ideaVm.MapFieldVms.Add(new MapFieldVm());    
           }

            
            

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

        public IActionResult Sort()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateIdea(IdeaVM ideaVm)
        {
            Idea idea = new Idea();
            
            
            ICollection<Field> fields = new List<Field>();
            List<ImageField> imageFields = new List<ImageField>();
            List<VideoField> videoFields = new List<VideoField>();
            List<QuestionField> questionFields = new List<QuestionField>();
            List<MapField> mapFields = new List<MapField>();
            List<TextField> textFields = new List<TextField>();

           // ImageField[] imageFields; // = new ImageField[ideaVm.images.Files.Count];
            //VideoField[] videoFields; //= new VideoField[ideaVm.images.Files.Count];
           // MapField mapField = new MapField();
           
           
           foreach (var mapfield in ideaVm.MapFieldVms)
           {
               if (!(mapfield.latitude == 0 && mapfield.longitude == 0))
               {
                   mapFields.Add(new MapField{latitude = mapfield.latitude , longitude = mapfield.longitude});
                   
               }
           }

           foreach (var textField in ideaVm.TextFieldVms)
           {
               if (textField.text != null && textField.text != "")
               {
                   textFields.Add(new TextField{text = textField.text});
               }
              
           }
           
            foreach (var questionVM in ideaVm.QuestionFieldVms)
            {
                if (questionVM.question != null)
                {
                    Question question = new Question();
                    List<Option> options = new List<Option>();
                    question.question = questionVM.question;
                    if (questionVM.questionType.Equals("radiobutton"))
                    {
                        question.questionType = QuestionType.RADIO_BUTTON;
                    }
                    else
                    {
                        question.questionType = QuestionType.CHECK_BOX;

                    }
                    foreach (var OptionVM in questionVM.Options)
                    {
                        if (OptionVM != null)
                        {
                            options.Add(new Option{ option = OptionVM});
                        }
                        
                    }
                    QuestionField questionField = new QuestionField();
                    question.options = options;
                    questionField.question = question;
                    questionFields.Add(questionField);
                    
                }
               

            }

          
            
            
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
            
      

            Ideation ideation = ideationMgr.getIdeation(ideaVm.ideationId);
           // ApplicationUser user = new ApplicationUser{Id = User.FindFirst(ClaimTypes.NameIdentifier).Value};
           // idea.user = user;
            
            idea.ideation = ideation;
//           
            foreach (var imageField in imageFields)
            {
                fields.Add(imageField);

            }

            foreach (var videoField in videoFields)
            {
                fields.Add(videoField);

            }

            foreach (var questionField in questionFields)
            {
                fields.Add(questionField);
            }

            foreach (var mapField in mapFields)
            {
                fields.Add(mapField);

            }

            foreach (var textfield in textFields)
            {
                fields.Add(textfield);
            }
            idea.fields = fields;
            ideationMgr.createIdea(idea);

            var projectId = ideationMgr.getIdeation(ideaVm.ideationId).project.projectId;


            return RedirectToAction("Project", "Project", new {id = projectId});
        }

        public IActionResult Idea(int ideaId = 6)
        {
            String[] test = new string[8];
            Idea idea = ideationMgr.getIdea(ideaId);
            IdeaVM ideaVm = new IdeaVM();
            List<TextFieldVm> textFieldVms = new List<TextFieldVm>();
            List<ImageFieldVm> imageFieldVms = new List<ImageFieldVm>();
            List<VideoFieldVm> videoFieldVms = new List<VideoFieldVm>();
            List<MapFieldVm> mapFieldVms = new List<MapFieldVm>();
            List<QuestionFieldVm> questionFieldVms = new List<QuestionFieldVm>();


            foreach (var field in idea.fields)
            {
                
                if (field.GetType() == typeof(TextField))
                  {
                      var textField = (TextField) field;
                      textFieldVms.Add(new TextFieldVm{text = textField.text});
                  }
//                  
//                if (field.GetType() == typeof(MapField))
//                {
//                    var textField = (TextField) field;
//                    textFieldVms.Add(new TextFieldVm{text = textField.text});
//                }
                 
                if (field.GetType() == typeof(ImageField))
                {
                    var imagefield = (ImageField) field;
                    imageFieldVms.Add(new ImageFieldVm{Base64Image = imagefield.GetImageString()});
                }
               
  
                if (field.GetType() == typeof(VideoField))
                {
                    var videoField = (VideoField) field;
                    videoFieldVms.Add(new VideoFieldVm{Base64Video = videoField.GetVideoString() });
                }
                   
                  if (field.GetType() == typeof(QuestionField))
                  {
                      var questionField = (QuestionField) field;
                     // Question question = new Question();
                      //question.question = question.question;
                      questionFieldVms.Add(new QuestionFieldVm{Question = questionField.question});
                  }

               
            }

            ideaVm.ImageFieldVms = imageFieldVms;
            ideaVm.TextFieldVms = textFieldVms;
            ideaVm.VideoFieldVms = videoFieldVms;
            ideaVm.QuestionFieldVms = questionFieldVms;


            return View(ideaVm);
        }

        public IActionResult AnswerFaq(IFormCollection form)
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            string answer = "";
            int faqId = 0;
            foreach (var key in form.Keys)
            {
                if (key == "answer")
                {
                    answer = form[key];
                }
                if (key == "faq")
                {
                    faqId = Convert.ToInt32(form[key]);
                }
            }
            ideationMgr.createFaqAnswer(userId, answer, faqId);
            return NoContent();
        }

        public IActionResult NewFaqQuestion(IFormCollection form)
        {
            foreach (var key in form.Keys)
            {
                if (key == "answer")
                {
                    ideationMgr.createFaq(form[key], User.FindFirst(ClaimTypes.NameIdentifier).Value);
                }
            }
            return NoContent();
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
            ideasVm.reactions = new List<Reaction>();
            foreach (var idea in ideasVm.ideas)
            {
                foreach (var field in ideationMgr.GetFields(idea.ideaId).ToList())
                {
                    ideasVm.fields.Add(field);
                }

                foreach (var reaction in ideationMgr.getReactions(idea.ideaId).ToList())
                {
                    ideasVm.reactions.Add(reaction);
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

        public IActionResult LikeReaction(int reactionId)
        {
            if (User.Identity.IsAuthenticated)
            {
                ideationMgr.LikeReaction(reactionId, User.FindFirst(ClaimTypes.NameIdentifier).Value);
            }
            return NoContent();
        }
        public IActionResult ReactIdea(IFormCollection form)
        {
            string content = "";
            string userId = "";
            string ideaId = "";
            foreach (var key in form.Keys)
            {
                if (key == "reaction")
                {
                    content = form[key];
                    userId =  User.FindFirst(ClaimTypes.NameIdentifier).Value;
                }
                if (key == "idea")
                {
                    ideaId = form[key];
                }
            }
            ideationMgr.ReactIdea(ideaId, userId, content);
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