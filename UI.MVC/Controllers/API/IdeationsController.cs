using System;
using System.Collections.Generic;
using System.Linq;
using BL;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Practices.ObjectBuilder2;
using UI.MVC.Models.Ideations;

namespace UI.MVC.Controllers.api
{
    public class IdeationsController : Controller
    {
        IIdeationManager mgr = new IdeationManager();
        
        [HttpGet("/api/Ideations/{id}")]
        public IActionResult GetIdeations(int id)
        {
            IEnumerable<Ideation> ideations = mgr.getIdeations(id); 
            List<IdeationRESTModel> newIdeations = new List<IdeationRESTModel>();
            foreach (var ideation in ideations)
            {
                int numberOfLikes = 0;
                ideation.Ideas.ForEach( x => numberOfLikes += mgr.getIdeaLikes(x.IdeaId));
                ideation.Questions.ForEach(x => x.Ideation = null);
                ideation.Ideas.ForEach(x => x.Ideation = null);
                IdeationRESTModel model = new IdeationRESTModel()
                {
                    IdeationId = ideation.IdeationId,
                    Question = ideation.Questions.ElementAt(0).Question,
                    NumberOfLikes = numberOfLikes,
                    NumberOfIdeas = ideation.Ideas.Count
                };
                newIdeations.Add(model);
            }
            return Ok(newIdeations);
        }
    }
}