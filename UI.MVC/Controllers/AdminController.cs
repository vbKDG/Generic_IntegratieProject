using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using BL.Application;
using DAL.EF;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UI.MVC.Models;

namespace UI.MVC.Controllers
{
    public class AdminController : Controller
    {
        private OrchestratorProjectIdeationController orchestrator;
        
        public AdminController(UserManager<ApplicationUser> userManager)
        {
            orchestrator = new OrchestratorProjectIdeationController(userManager);
        }
        
        [Authorize(Roles="SuperAdmin")]
        public IActionResult ManageAdmins()
        {
           var usersOfRole = orchestrator.GetUsersInRoleAsync("Admin");
            return View(usersOfRole);
        }
        
        [Authorize(Roles="SuperAdmin")]
        public IActionResult EditAdminPage(string userId)
        {
            ApplicationUser applicationUser = orchestrator.FindByIdAsync(userId).Result;
            return View(applicationUser);
        }
        
        [Authorize(Roles = "SuperAdmin, Admin, Moderator")]
        public IActionResult AdminPage()
        {
            return View();
        }

        [Authorize(Roles = "Moderator, Admin, SuperAdmin")]
        public IActionResult ShowReports(int ideaId)
        {
            ReportModel reportModel = new ReportModel
            {
                Reports = orchestrator.getReports(ideaId).ToList(),
                Idea = orchestrator.getIdea(ideaId),
                Reactions = orchestrator.getReactions(ideaId).ToList(),
                TextFields = orchestrator.GetFields(ideaId).ToList()
            };
            return View(reportModel);
        }
        
        [HttpGet]
        public IActionResult GetIdeaLikes(int ideaId)
        {
            int likes = orchestrator.getIdeaLikes(ideaId);
            return new JsonResult(likes);
        }
        
        [HttpGet]
        public IActionResult GetReactionLikes(int reactionId)
        {
            int likes = orchestrator.getReactionLikes(reactionId);
            return new JsonResult(likes);
        }
        
        [Authorize(Roles = "Moderator, Admin, SuperAdmin")]
        public IActionResult ManagePosts(int projectId)
        {
            ReportModel reportModel = new ReportModel
            {
                Ideations = (orchestrator.getIdeations(projectId)).ToList(),
                Ideas = new List<Idea>(),
                Reactions = new List<Reaction>(),
                TextFields = new List<TextField>(),
                Reports = new List<Report>(),
                Projects = orchestrator.getProjects().ToList(),
                SelectedProject = projectId
            };

            foreach (var ideation in reportModel.Ideations)
            {
                foreach (var idea in orchestrator.getIdeas(ideation.IdeationId))
                {
                    foreach(var report in orchestrator.getReports(idea.IdeaId))
                    {
                        reportModel.Reports.Add(report);
                    }
                    foreach (var field in orchestrator.GetFields(idea.IdeaId).ToList())
                    {
                        reportModel.TextFields.Add(field);
                    }
                    ideation.Ideas.Add(idea);
                }
            }
            return View(reportModel);
        }
        
        public IActionResult SendToAdmin(int reportId)
        {
            orchestrator.sendToAdmin(reportId);
            return NoContent();
        }

        public IActionResult ApproveReaction(int reactionId)
        {
            orchestrator.approveReaction(reactionId);
            return NoContent();
        }
        
        public IActionResult DisapproveReaction(int reactionId)
        {
            orchestrator.disapproveReaction(reactionId);
            return NoContent();
        }
        
        public IActionResult ApproveIdea(int ideaId)
        {
            orchestrator.approveIdea(ideaId);
            return NoContent();
        }
        
        public IActionResult DisapproveIdea(int ideaId)
        {
            orchestrator.disapproveIdea(ideaId);
            return NoContent();
        }

        public IActionResult BlockUser(string userId)
        {
            orchestrator.blockUser(userId);
            return NoContent();
        }
        
        public IActionResult ChangeReaction(IFormCollection form, int reactionId, int ideaId)
        {
            Reaction reaction = orchestrator.getReaction(reactionId);
            foreach (var key in form.Keys)
            {
                if (key == "reportText")
                {
                    reaction.Content = form[key];
                }
            }
            orchestrator.changeReaction(reaction);
            return RedirectToAction("ShowReports", "Admin", new {ideaId = ideaId});
        }
        
        [Authorize(Roles="SuperAdmin, Admin")]
        public IActionResult EditModeratorPage(string userId)
        {
            ApplicationUser applicationUser = orchestrator.FindByIdAsync(userId).Result;
            return View(applicationUser);
        }
        
        [Authorize(Roles="SuperAdmin")]
        public IActionResult DeleteAdminPage(string userId)
        {
            ApplicationUser applicationUser = orchestrator.FindByIdAsync(userId).Result;
            return View(applicationUser);
        }
        
        [Authorize(Roles="SuperAdmin, Admin")]
        public IActionResult DeleteModeratorPage(string userId)
        {
            ApplicationUser applicationUser = orchestrator.FindByIdAsync(userId).Result;
            return View(applicationUser);
        }

        [Authorize(Roles = "SuperAdmin, Admin")]
        public IActionResult ManageModerators()
        {
            var usersOfRole =  orchestrator.GetUsersInRoleAsync("Moderator");
            return View(usersOfRole);
        }

        [Authorize(Roles="SuperAdmin, Admin")]
        [HttpPost]
        public IActionResult EditUser(IFormCollection formCollection)
        {
            IList<string> list = new List<string>();
            ApplicationUser user = new ApplicationUser();
            foreach (var key in formCollection.Keys)
            {
                if (key == "Id")
                {
                    user = orchestrator.FindByIdAsync(formCollection[key]).Result;
                    list = orchestrator.GetRolesAsync(user).Result;
                }
            }
            foreach (var key in formCollection.Keys)
            {
                switch (key)
                {
                    case "FirstName":
                        user.FirstName = formCollection[key];
                        break;
                    case "LastName":
                        user.LastName = formCollection[key];
                        break;
                    case "Age":
                        user.Age = formCollection[key];
                        break;
                    case "Email":
                        user.Email = formCollection[key];
                        break;
                    case "Gender":
                        user.Gender = formCollection[key];
                        break;
                    case "PostalCode":
                        user.PostalCode = formCollection[key];
                        break;
                }
            }
            orchestrator.UpdateAsync(user);
            if (list[0] == "Admin")
            {
                return LocalRedirect("~/Admin/ManageAdmins");
            }
            if (list[0] == "Moderator")
            {
                return LocalRedirect("~/Admin/ManageModerators");
            }
            return RedirectToAction("Index","Home");
        }

        [Authorize(Roles="SuperAdmin, Admin")]
        [HttpPost]
        public IActionResult DeleteUser(IFormCollection formCollection)
        {
            IList<string> list = new List<string>();
            foreach (var key in formCollection.Keys)
            {
                if (key == "Id")
                {
                    ApplicationUser user = orchestrator.FindByIdAsync(formCollection[key]).Result;
                    list = orchestrator.GetRolesAsync(user).Result;
                    orchestrator.DeleteAsync(orchestrator.FindByIdAsync(formCollection[key]).Result);
                }
            }
            if (list[0] == "Admin")
            {
                return LocalRedirect("~/Admin/ManageAdmins");
            }   
            if (list[0] == "Moderator")
            {
                return LocalRedirect("~/Admin/ManageModerators");
            }
            
            return RedirectToAction("Index","Home");
        }
    }
}