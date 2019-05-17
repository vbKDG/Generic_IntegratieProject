using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
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
        private UserManager<ApplicationUser> _userManager;
        private IIdeationManager ideationMgr;
        private IProjectManager projectMgr;

        public AdminController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            ideationMgr = new IdeationManager();
            projectMgr = new ProjectManager();
        }
        
        [Authorize(Roles="SuperAdmin")]
        public IActionResult ManageAdmins()
        {
            var usersOfRole =  _userManager.GetUsersInRoleAsync("Admin");
            return View(usersOfRole);
        }
        
        [Authorize(Roles="SuperAdmin")]
        public IActionResult EditAdminPage(string userId)
        {
            ApplicationUser applicationUser = _userManager.FindByIdAsync(userId).Result;
            return View(applicationUser);
        }

        [Authorize(Roles = "Moderator")]
        public IActionResult ShowReportsModerator(int ideaId)
        {
            ReportModel reportModel = new ReportModel
            {
                reports = ideationMgr.getReports(ideaId).ToList(),
                idea = ideationMgr.getIdea(ideaId),
                reactions = ideationMgr.getReactions(ideaId).ToList(),
                TextFields = ideationMgr.GetFields(ideaId).ToList()
            };
            return View(reportModel);
        }
        
        [HttpGet]
        public IActionResult GetIdeaLikes(int ideaId)
        {
            int likes = ideationMgr.getIdeaLikes(ideaId);
            return new JsonResult(likes);
        }
        
        [HttpGet]
        public IActionResult GetReactionLikes(int reactionId)
        {
            int likes = ideationMgr.getReactionLikes(reactionId);
            return new JsonResult(likes);
        }
        
        [Authorize(Roles = "Moderator")]
        public IActionResult ManagePosts(int projectId)
        {
            ReportModel reportModel = new ReportModel
            {
                ideations = (ideationMgr.getIdeations(projectId)).ToList(),
                ideas = new List<Idea>(),
                reactions = new List<Reaction>(),
                TextFields = new List<TextField>(),
                reports = new List<Report>(),
                projects = projectMgr.getProjects().ToList(),
                selectedProject = projectId
            };

            foreach (var ideation in reportModel.ideations)
            {
                foreach (var idea in ideationMgr.getIdeas(ideation.ideationId))
                {
                    foreach(var report in ideationMgr.getReports(idea.ideaId))
                    {
                        reportModel.reports.Add(report);
                    }
                    foreach (var field in ideationMgr.GetFields(idea.ideaId).ToList())
                    {
                        reportModel.TextFields.Add(field);
                    }
                    ideation.ideas.Add(idea);
                }
            }
            return View(reportModel);
        }
        
        public IActionResult SendToAdmin(int reportId)
        {
            ideationMgr.sendToAdmin(reportId);
            return NoContent();
        }

        public IActionResult ApproveReaction(int reactionId)
        {
            ideationMgr.approveReaction(reactionId);
            return NoContent();
        }
        
        public IActionResult DisapproveReaction(int reactionId)
        {
            ideationMgr.disapproveReaction(reactionId);
            return NoContent();
        }
        
        public IActionResult ApproveIdea(int ideaId)
        {
            ideationMgr.approveIdea(ideaId);
            return NoContent();
        }
        
        public IActionResult DisapproveIdea(int ideaId)
        {
            ideationMgr.disapproveIdea(ideaId);
            return NoContent();
        }

        public IActionResult BlockUser(string userId)
        {
            ideationMgr.blockUser(userId);
            return NoContent();
        }
        
        public IActionResult ChangeReaction(IFormCollection form, int reactionId, int ideaId)
        {
            Reaction reaction = ideationMgr.getReaction(reactionId);
            foreach (var key in form.Keys)
            {
                if (key == "reportText")
                {
                    reaction.content = form[key];
                }
            }
            ideationMgr.changeReaction(reaction);
            return RedirectToAction("ShowReportsModerator", "Admin", new {ideaId = ideaId});
        }
        
        [Authorize(Roles="SuperAdmin, Admin")]
        public IActionResult EditModeratorPage(string userId)
        {
            ApplicationUser applicationUser = _userManager.FindByIdAsync(userId).Result;
            return View(applicationUser);
        }
        
        [Authorize(Roles="SuperAdmin")]
        public IActionResult DeleteAdminPage(string userId)
        {
            ApplicationUser applicationUser = _userManager.FindByIdAsync(userId).Result;
            return View(applicationUser);
        }
        
        [Authorize(Roles="SuperAdmin, Admin")]
        public IActionResult DeleteModeratorPage(string userId)
        {
            ApplicationUser applicationUser = _userManager.FindByIdAsync(userId).Result;
            return View(applicationUser);
        }

        [Authorize(Roles = "SuperAdmin, Admin")]
        public IActionResult ManageModerators()
        {
            var usersOfRole =  _userManager.GetUsersInRoleAsync("Moderator");
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
                    user = _userManager.FindByIdAsync(formCollection[key]).Result;
                    list = _userManager.GetRolesAsync(user).Result;
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
            _userManager.UpdateAsync(user);
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
                    ApplicationUser user = _userManager.FindByIdAsync(formCollection[key]).Result;
                    list = _userManager.GetRolesAsync(user).Result;
                    _userManager.DeleteAsync(_userManager.FindByIdAsync(formCollection[key]).Result);
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