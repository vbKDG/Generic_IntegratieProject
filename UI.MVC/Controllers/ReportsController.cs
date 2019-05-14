using System;
using System.Security.Claims;
using BL;
using D.UI.MVC.Models;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;

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
            
            if (reports == null || !reports.Any())
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
                    createdReport = ideationMgr.addReport(newReport.Idea, newReport.Message, User.FindFirst(ClaimTypes.NameIdentifier).Value, "idea");
                } 
                else if (newReport.Idea == 0)
                {
                    createdReport = ideationMgr.addReport(newReport.Reaction, newReport.Message, User.FindFirst(ClaimTypes.NameIdentifier).Value, "reaction");
                }
                
                if (createdReport == null)
                {
                    return BadRequest("Something went wrong.");
                }
            
                ReportDTO responseData = new ReportDTO()
                {
                    id = createdReport.id,
                    dateSubmitted = createdReport.dateSubmitted,
                    reportMessage = createdReport.reportMessage
                };
                if (newReport.Reaction == 0)
                {
                    responseData.ideaId = createdReport.idea.ideaId;
                }
                else if (newReport.Idea == 0)
                {
                    responseData.reactionId = createdReport.reaction.reactionId;
                }
                return CreatedAtAction("Get", new {id = responseData.id}, responseData);
            }

            return NoContent();
        }
    }
}