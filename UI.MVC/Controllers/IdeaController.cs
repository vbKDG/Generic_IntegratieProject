using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BL;
using DAL.EF;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UI.MVC.Models.Ideas;

namespace UI.MVC.Controllers
{
    public class IdeaController : Controller
    {
        private IIdeationManager ideationMgr;
        public IdeaController(ApplicationDbContext ctx)
        {
            ideationMgr = new IdeationManager(ctx);
        }
        public IActionResult CreateIdeaPage(int ideationId)
        {
            
            IdeationQuestion[] ideationQuestions = ideationMgr.GetIdeationQuestions(ideationId).ToArray();
            IdeaViewModel ideaViewModel = new IdeaViewModel();


            String[] questions = new string[ideationQuestions.Length];

            for (int i = 0; i < ideationQuestions.Length; i++)
            {
                    questions[i] = ideationQuestions[i].question;

            }

            ideaViewModel.ideationQuestion = questions;
            ideaViewModel.ideationId = ideationId;
                
      
          
            
            return View(ideaViewModel);
        }

        public IActionResult MapInput()
        {
            return View();
        }
            


        public IActionResult CreateIdea(IdeaViewModel ideaViewModel)
        {
            Idea idea = new Idea();
            ICollection<Field> fields = new List<Field>();
            TextField textField = new TextField();
            ImageField imageField = new ImageField();
            VideoField videoField = new VideoField();
            MapField mapField = new MapField();

            textField.text = Convert.ToString(ideaViewModel.textFieldViewModel.text);
            mapField.latitude = ideaViewModel.mapFieldViewModel.latitude;
            mapField.longitude = ideaViewModel.mapFieldViewModel.longitude;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                ideaViewModel.imageFieldViewModel.imageFile.CopyTo(memoryStream);
                imageField.imageData = memoryStream.ToArray();
            }
            using (var reader = ideaViewModel.imageFieldViewModel.imageFile.OpenReadStream())
            using (var stream = new MemoryStream())
            {
                {    
                   reader.CopyTo(stream);
                   imageField.imageData = stream.ToArray();

                }    
                                        
            }
            using (var reader = ideaViewModel.videoFieldViewModel.videoFile.OpenReadStream())
            using (var stream = new MemoryStream())
            {
                {    
                    reader.CopyTo(stream);
                    videoField.videoData = stream.ToArray();

                }    
                                        
            }

            Ideation ideation = ideationMgr.getIdeation(ideaViewModel.ideationId);

            idea.ideation = ideation;
            fields.Add(textField);
            fields.Add(imageField);
            fields.Add(videoField);
            fields.Add(mapField);
            idea.fields = fields;
            ideationMgr.createIdea(idea);

            var projectId = ideationMgr.getIdeation(ideaViewModel.ideationId).project.projectId;
            
            


            return RedirectToAction("Project" , "Project" , new { id= projectId });
        }
        

      
    }
    
}