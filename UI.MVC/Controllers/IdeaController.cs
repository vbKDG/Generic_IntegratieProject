using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using BL;
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

            IdeationQuestion[] ideationQuestions = ideationMgr.GetIdeationQuestions(ideationId).ToArray();
            IdeaVM ideaVm = new IdeaVM();
            

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

        public IActionResult CreateIdeationPage( int projectId)
        {
            
            
            return View();
        }
        
        



    }

}