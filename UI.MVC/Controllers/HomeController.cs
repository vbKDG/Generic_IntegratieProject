using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using BL;
using BL.Application;
using D.UI.MVC.Models.Projects;
using Microsoft.AspNetCore.Mvc;
using Domain;
using Microsoft.AspNetCore.Http;
using UI.MVC.Models;

namespace UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly OrchestratorSystemController orchestrator;
        
        public HomeController()
        {
            orchestrator = new OrchestratorSystemController();
        }

        public IActionResult EmailConfirmInfo()
        {
            return View();
        }

        public IActionResult Faq()
        {
            ICollection<Faq> faqs = orchestrator.getFaqs().ToList();
            return View(faqs);
        }
        
        public IActionResult Index()
        {
            ICollection<ProjectVM> projectVmsOpen = new List<ProjectVM>();
            ICollection<ProjectVM> projectVmsClosed = new List<ProjectVM>();
            ICollection<ProjectVM> allProjectVms = new List<ProjectVM>();
            ICollection<Project> projects = orchestrator.getProjects().ToList();
            Dictionary<int, int> likeDictionary = new Dictionary<int, int>();
            Dictionary<int, int> commentDictionary = new Dictionary<int, int>();
            Dictionary<int, int> combinedDictionary = new Dictionary<int, int>();
            
            foreach (var project in projects)
            {
                ProjectVM projectVm = new ProjectVM();
                projectVm.projectId = project.ProjectId;
                projectVm.name = project.Name;
                projectVm.startDate = project.StartDate;
                projectVm.endDate = project.EndDate;
                projectVm.Base64Image = project.ImageField.GetImageString();
                var likeAmount = 0;
                var commentAmount = 0;
                var ideaAmount = 0;
                foreach (var ideation in project.Ideations)
                {
                    foreach (var idea in ideation.Ideas)
                    {
                        ideaAmount++;
                        likeAmount = likeAmount + orchestrator.getIdeaLikes(idea.IdeaId);
                        foreach (var reaction in idea.Reactions)
                        {
                            likeAmount = likeAmount + orchestrator.getReactionLikes(reaction.ReactionId);
                        } 
                        commentAmount = commentAmount + orchestrator.getReactions(idea.IdeaId).ToList().Count;
                    }
                }
                var total = likeAmount + commentAmount;
                combinedDictionary.Add(project.ProjectId, total);
                likeDictionary.Add(project.ProjectId, likeAmount);
                commentDictionary.Add(project.ProjectId, commentAmount);
                projectVm.AmountOfLikes = likeAmount;
                projectVm.AmountOfComments = commentAmount;
                projectVm.ideaAmount = ideaAmount;
                projectVm.CombinedTotal = total;
                projectVm.Closed = project.Closed;
                var daysBetweenStartEnd = (projectVm.startDate - projectVm.endDate).TotalDays;
                var daysBetweenStartNow = (projectVm.startDate - DateTime.Now).TotalDays;
                double percentage = Convert.ToDouble(daysBetweenStartNow) / Convert.ToDouble(daysBetweenStartEnd) * 100;
                if (percentage < 0)
                {
                    projectVm.Progress = 0;
                }
                else if (percentage > 100)
                {
                    projectVm.Progress = 100;
                }
                else if (percentage < 100 && percentage > 0)
                {
                    projectVm.Progress = Convert.ToInt32(percentage);
                }
                
                if (project.Closed)
                {
                    projectVmsClosed.Add(projectVm);  
                } 
                else if (!project.Closed)
                {
                    projectVmsOpen.Add(projectVm);
                }
            }
            var counterOpen = 0;
            foreach (var project in projectVmsOpen.OrderByDescending(i => i.CombinedTotal))
            {
                counterOpen++;
                if (counterOpen > 3)
                {
                    projectVmsOpen.Remove(project);
                }
                else
                {
                    allProjectVms.Add(project);
                }
            }
            var counterClosed = 0;
            foreach (var project in projectVmsClosed.OrderByDescending(i => i.CombinedTotal))
            {
                counterClosed++;
                if (counterClosed > 3)
                {
                    projectVmsClosed.Remove(project);
                }
                else
                {
                    allProjectVms.Add(project);
                }
            }
            return View(allProjectVms);
        }

        public IActionResult ProjectsGeneral()
        {
            ICollection<ProjectVM> allProjectVms = new List<ProjectVM>();
            ICollection<Project> projects = orchestrator.getProjects().ToList();
            
            foreach (var project in projects)
            {
                ProjectVM projectVm = new ProjectVM();
                projectVm.projectId = project.ProjectId;
                projectVm.name = project.Name;
                projectVm.startDate = project.StartDate;
                projectVm.endDate = project.EndDate;
                projectVm.Base64Image = project.ImageField.GetImageString();
                projectVm.description = project.Description;
                var likeAmount = 0;
                var commentAmount = 0;
                var ideaAmount = 0;
                foreach (var ideation in project.Ideations)
                {
                    foreach (var idea in ideation.Ideas)
                    {
                        ideaAmount++;
                        likeAmount = likeAmount + orchestrator.getIdeaLikes(idea.IdeaId);
                        foreach (var reaction in idea.Reactions)
                        {
                            likeAmount = likeAmount + orchestrator.getReactionLikes(reaction.ReactionId);
                        }
                        commentAmount = commentAmount + orchestrator.getReactions(idea.IdeaId).ToList().Count;
                    }
                }

                projectVm.AmountOfLikes = likeAmount;
                projectVm.AmountOfComments = commentAmount;
                projectVm.ideaAmount = ideaAmount;
                projectVm.Closed = project.Closed;
                var daysBetweenStartEnd = (projectVm.startDate - projectVm.endDate).TotalDays;
                var daysBetweenStartNow = (projectVm.startDate - DateTime.Now).TotalDays;
                double percentage = Convert.ToDouble(daysBetweenStartNow) / Convert.ToDouble(daysBetweenStartEnd) * 100;
                if (percentage < 0)
                {
                    projectVm.Progress = 0;
                }
                else if (percentage > 100)
                {
                    projectVm.Progress = 100;
                }
                else if (percentage < 100 && percentage > 0)
                {
                    projectVm.Progress = Convert.ToInt32(percentage);
                }
                allProjectVms.Add(projectVm);
            }
            return View(allProjectVms);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
        
        
        
    }
}