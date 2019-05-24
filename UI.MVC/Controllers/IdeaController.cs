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
using BL.Application;
using D.UI.MVC.Models.Fields;
using D.UI.MVC.Models.Ideas;
using DAL.EF;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using UI.MVC.Models.Ideations;

namespace UI.MVC.Controllers
{
    public class IdeaController : Controller
    {
        private OrchestratorProjectIdeationController orchestrator;
        
        public IdeaController(UserManager<ApplicationUser> userManager)
        {
            orchestrator = new OrchestratorProjectIdeationController(userManager);
        }


        private readonly DependencyInjectionConfig DIConfig = new DependencyInjectionConfig();


        public IActionResult Ideation(int ideationId =  8)
        {
            Ideation ideation = orchestrator.getIdeation(ideationId);
            IdeationPageVM ideationPageVm = new IdeationPageVM();
            List<IdeaListItemVM> ideaListItemVms = new List<IdeaListItemVM>();
            List<String> ideationQuestions = new List<string>();   
           

            foreach (var idea in ideation.Ideas)
            {
                int likeCount = idea.IdeaLikes.Count;
                int reactionCount = idea.Reactions.Count;
                var username = idea.User.FirstName + '.' + idea.User.LastName.Substring(0,1);
                string base64String = String.Format("data:image/png;base64,{0}", Convert.ToBase64String(System.IO.File.ReadAllBytes(".\\wwwroot\\images\\lightbulb.jpg")));

                var teller = 0;
                foreach (var field in idea.Fields)
                {
                    if (field.GetType() == typeof(ImageField) && teller==0)
                    {
                        teller++;
                        var imagefield = (ImageField) field;
                        base64String = imagefield.ImageData;
                        
                    }
                   
                    
                }
                
                ideaListItemVms.Add(new IdeaListItemVM{IdeaId = idea.IdeaId, UserName = username,Base64Image = base64String, IdeaTitle = idea.IdeaTitle , LikeCount = likeCount , ReactionCount = reactionCount});
            }

            foreach (var question in ideation.Questions)
            {
                ideationQuestions.Add(question.Question);
            }

            ideationPageVm.IdeationId = ideationId;
            ideationPageVm.IdeaListItemVms = ideaListItemVms;
            ideationPageVm.IdeationQuestions = ideationQuestions;
            return View(ideationPageVm);
            

        }

        
        public IActionResult CreateIdeaPage(int ideationId)
        {

            Ideation ideation = orchestrator.getIdeation(ideationId);
            IdeationQuestion[] ideationQuestions = orchestrator.GetIdeationQuestions(ideationId).ToArray();
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
                questions[i] = ideationQuestions[i].Question;

            }

            ideaVm.IdeationQuestion = questions;
            ideaVm.IdeationId = ideationId;




            return View(ideaVm);
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
            idea.IdeaTitle = ideaVm.IdeaTitle;
           
           foreach (var mapfield in ideaVm.MapFieldVms)
           {
               if (!(mapfield.Latitude == 0 && mapfield.Longitude == 0))
               {
                   mapFields.Add(new MapField{Latitude = mapfield.Latitude , Longitude = mapfield.Longitude});
                   
               }
           }

           foreach (var textField in ideaVm.TextFieldVms)
           {
               if (textField.Text != null && textField.Text != "")
               {
                   textFields.Add(new TextField{Text = textField.Text});
               }
              
           }
           
            foreach (var questionVM in ideaVm.QuestionFieldVms)
            {
                if (questionVM.QuestionText != null)
                {
                    Question question = new Question();
                    List<Option> options = new List<Option>();
                    question.TheQuestion = questionVM.QuestionText;
                    if (questionVM.QuestionType.Equals("radiobutton"))
                    {
                        question.QuestionType = QuestionType.RADIO_BUTTON;
                    }
                    else
                    {
                        question.QuestionType = QuestionType.CHECK_BOX;

                    }
                    foreach (var OptionVM in questionVM.Options)
                    {
                        if (OptionVM != null)
                        {
                            options.Add(new Option{ TheOption = OptionVM});
                        }
                        
                    }
                    QuestionField questionField = new QuestionField();
                    question.Options = options;
                    questionField.Question = question;
                    questionFields.Add(questionField);
                }
            }
           
           
           
           

            for (int i = 0; i < ideaVm.Files.Files.Count; i++)
            {
                if (ideaVm.Files.Files[i].ContentType.StartsWith("image"))
                {
                    using (var reader = ideaVm.Files.Files[i].OpenReadStream())
                    using (var stream = new MemoryStream())
                    {
                        {
                            reader.CopyTo(stream);
                            var base64 = Convert.ToBase64String(stream.ToArray());
                             base64 =  String.Format("data:image/png;base64,{0}", base64);
                            imageFields.Add(new ImageField{ImageData = base64});

                        }

                    }
                } 
                else if (ideaVm.Files.Files[i].ContentType.StartsWith("video"))
                {
                    using (var reader = ideaVm.Files.Files[i].OpenReadStream())
                    using (var stream = new MemoryStream())
                    {
                        {
                            reader.CopyTo(stream);
                            var base64 = Convert.ToBase64String(stream.ToArray());
                            base64=  String.Format("data:video/mp4;base64,{0}", base64);
                            videoFields.Add(new VideoField{VideoData = base64});

                        }

                    } 
                }
            }

            var applicationUserId = ""; 
            if (User.Identity.IsAuthenticated)
            {
                applicationUserId =  User.FindFirst(ClaimTypes.NameIdentifier).Value;
            }
            Ideation ideation = orchestrator.getIdeation(ideaVm.IdeationId);
            
            idea.Ideation = ideation;
          
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
            idea.Fields = fields;
            orchestrator.createIdea(idea,applicationUserId);

            var projectId = orchestrator.getIdeation(ideaVm.IdeationId).Project.ProjectId;


            return RedirectToAction("Ideation", "idea", new {ideationId = idea.Ideation.IdeationId});
        }

        public PartialViewResult Idea(int ideaId = 10)
        {
            String[] test = new string[8];
            Idea idea = orchestrator.getIdea(ideaId);
            IdeaVM ideaVm = new IdeaVM();
            List<TextFieldVm> textFieldVms = new List<TextFieldVm>();
            List<ImageFieldVm> imageFieldVms = new List<ImageFieldVm>();
            List<VideoFieldVm> videoFieldVms = new List<VideoFieldVm>();
            List<MapFieldVm> mapFieldVms = new List<MapFieldVm>();
            List<QuestionFieldVm> questionFieldVms = new List<QuestionFieldVm>();
            List<Reaction> reactions = orchestrator.getReactions(ideaId).ToList();

            foreach (var field in idea.Fields)
            {
                
                if (field.GetType() == typeof(TextField))
                {
                    var textField = (TextField) field;
                    textFieldVms.Add(new TextFieldVm{Text = textField.Text});
                }
                  
                if (field.GetType() == typeof(MapField))
                {
                    var mapfield = (MapField) field;
                    mapFieldVms.Add(new MapFieldVm{Latitude = mapfield.Latitude , Longitude = mapfield.Longitude});
                }
                 
                if (field.GetType() == typeof(ImageField))
                {
                    var imagefield = (ImageField) field;
                    imageFieldVms.Add(new ImageFieldVm{Base64Image = imagefield.ImageData});
                }
               
  
                if (field.GetType() == typeof(VideoField))
                {
                    var videoField = (VideoField) field;
                    videoFieldVms.Add(new VideoFieldVm{Base64Video = videoField.VideoData});
                }
                   
                if (field.GetType() == typeof(QuestionField))
                {
                    var questionField = (QuestionField) field;
                    questionFieldVms.Add(new QuestionFieldVm{Question = questionField.Question});
                }
            }
            
            ideaVm.ImageFieldVms = imageFieldVms;
            ideaVm.TextFieldVms = textFieldVms;
            ideaVm.VideoFieldVms = videoFieldVms;
            ideaVm.QuestionFieldVms = questionFieldVms;
            ideaVm.MapFieldVms = mapFieldVms;
            ideaVm._user = idea.User;
            ideaVm.Verified = idea.Verified;
            ideaVm.Reactions = reactions;
            ideaVm.IdeaId = ideaId;
            ideaVm.Disapproved = idea.Disapproved;
            ideaVm.AmountOfLikes = orchestrator.getIdeaLikes(ideaId);

            return  PartialView("Idea",ideaVm);
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
            orchestrator.createFaqAnswer(userId, answer, faqId);
            return NoContent();
        }

        public IActionResult NewFaqQuestion(IFormCollection form)
        {
            foreach (var key in form.Keys)
            {
                if (key == "answer")
                {
                    orchestrator.createFaq(form[key], User.FindFirst(ClaimTypes.NameIdentifier).Value);
                }
            }
            return NoContent();
        }
        
        public IActionResult Ideas(int ideationId)
        {
            IdeasVM ideasVm = new IdeasVM();
            ideasVm.IdeationId = ideationId;
            ideasVm.ideas = orchestrator.getIdeas(ideationId).ToList();
            ideasVm.fields = new List<TextField>();
            ideasVm.reactions = new List<Reaction>();
            foreach (var idea in ideasVm.ideas)
            {
                foreach (var field in orchestrator.GetFields(idea.IdeaId).ToList())
                {
                    ideasVm.fields.Add(field);
                }

                foreach (var reaction in orchestrator.getReactions(idea.IdeaId).ToList())
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
                orchestrator.LikeIdea(ideaId, User.FindFirst(ClaimTypes.NameIdentifier).Value);
            }
            return NoContent();
        }

        public IActionResult LikeReaction(int reactionId)
        {
            if (User.Identity.IsAuthenticated)
            {
                orchestrator.LikeReaction(reactionId, User.FindFirst(ClaimTypes.NameIdentifier).Value);
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
            orchestrator.ReactIdea(ideaId, userId, content);
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

            ideation.AdminOnly = ideationVm.AdminOnly;
            
            List<IdeationQuestion> ideationQuestions = new List<IdeationQuestion>();

            foreach (var item in ideationVm.IdeationQuestionVMs)
            {            
                ideationQuestions.Add(new IdeationQuestion{Question = item.Question}); 
            }

            ideation.Questions = ideationQuestions;
             
            orchestrator.CreateIdeation(ideation,ideationVm.ProjectId);
            
            return RedirectToAction("Ideations", "Project", new {id = ideationVm.ProjectId});
        }

        public IActionResult CreateQuestionPage()
        {
            return View();
        }
        
        /*[HttpPost]
        public IActionResult CreateQuestion(IFormCollection form)
        {
            Question question = new Question()
            {
                Options = new List<Option>()
            };
            IList<Option> options = new List<Option>();
            
            foreach (var key in form.Keys)
            {
                if (key == "questionFieldset")
                {
                    if (form[key] == "radiobutton") { question.QuestionType = QuestionType.RADIO_BUTTON; }
                    if (form[key] == "checkbox") { question.QuestionType = QuestionType.CHECK_BOX; }
                }

                if (key == "question")
                {
                    question.TheQuestion = form[key];
                }
                if (key.StartsWith("question.options"))
                {
                    Option o = new Option()
                    {
                        TheOption = form[key]
                    };
                    options.Add(o);
                }
            }
            questionnaireMgr.addQuestion(question);

            foreach (var option in options)
            {
                questionnaireMgr.addOption(option.TheOption, question);
            }

            question.Options = options;
            questionnaireMgr.changeQuestion(question);
            return RedirectToAction("Index","Home");
        }*/
    }
}