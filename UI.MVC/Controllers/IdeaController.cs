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
using UI.MVC.Models.Ideations;

namespace UI.MVC.Controllers
{
    public class IdeaController : Controller
    {
        private IIdeationManager ideationMgr;
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

       
        
        



    }

}