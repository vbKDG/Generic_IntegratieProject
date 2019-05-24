using System;
using System.Linq;
using System.Security.Claims;
using BL;
using D.UI.MVC.Models;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using UI.MVC.Models;

namespace D.UI.MVC.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportsController : Controller
    {
        private IIdeationManager ideationMgr;
        
        public ReportsController()
        {
            ideationMgr = new IdeationManager();
        }
        
        [HttpGet]
        public IActionResult Get(int ideaId)
        {
            var reports = ideationMgr.getReports(ideaId);
            
            if (reports == null || !EnumerableExtensions.Any(reports))
            {
                return NoContent();
            }

            return Ok(reports);
        }
        
        [HttpPost]
        public IActionResult Post(NewReportDTO newReport)
        {
            if (User.Identity.IsAuthenticated)
            {
                Report createdReport = new Report();
                if (newReport.Reaction == 0)
                {
                    createdReport = ideationMgr.addReport(newReport.Idea, newReport.Message, User.FindFirst(ClaimTypes.NameIdentifier).Value, "idea", newReport.Reaction);
                } 
                else if (newReport.Reaction != 0)
                {
                    createdReport = ideationMgr.addReport(newReport.Idea, newReport.Message, User.FindFirst(ClaimTypes.NameIdentifier).Value, "reaction", newReport.Reaction);
                }
                
                if (createdReport == null)
                {
                    return BadRequest("Something went wrong.");
                }
            
                ReportDTO responseData = new ReportDTO()
                {
                    ReportDtoId = createdReport.ReportId,
                    DateSubmitted = createdReport.DateSubmitted,
                    ReportMessage = createdReport.ReportMessage
                };
                if (newReport.Reaction == 0)
                {
                    responseData.IdeaId = createdReport.Idea.IdeaId;
                }
                else if (newReport.Idea == 0)
                {
                    responseData.ReactionId = createdReport.Reaction.ReactionId;
                }
                return CreatedAtAction("Get", new {id = responseData.ReportDtoId}, responseData);
            }

            return NoContent();
        }
    }
}