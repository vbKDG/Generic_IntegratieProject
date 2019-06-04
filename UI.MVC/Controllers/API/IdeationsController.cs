using System;
using System.Collections.Generic;
using System.Linq;
using BL;
using Domain;
using Microsoft.AspNetCore.Mvc;
using UI.MVC.Models.Ideations;

namespace UI.MVC.Controllers.api
{
    [ApiController]
    public class IdeationsController : Controller
    {
        IIdeationManager mgr = new IdeationManager();
        
        [HttpGet("/api/Ideations/{id}")]
        public IActionResult GetIdeations(int projectId)
        {
            List<Ideation> ideations = mgr.getIdeations(projectId).ToList();
            List<IdeationRESTModel> newIdeations = new List<IdeationRESTModel>();
            foreach (var ideation in ideations)
            {
                IdeationRESTModel model = new IdeationRESTModel()
                {
                    IdeationId = ideation.IdeationId,
                    Questions = ideation.Questions,
                    Ideas = ideation.Ideas
                };
                newIdeations.Add(model);
            }
            return Ok(newIdeations);
        }
    }
}