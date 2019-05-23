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
                projectVm.projectId = project.projectId;
                projectVm.name = project.name;
                projectVm.startDate = project.startDate;
                projectVm.endDate = project.endDate;
                projectVm.Base64Image = project.imageField.GetImageString();
                var likeAmount = 0;
                var commentAmount = 0;
                var ideaAmount = 0;
                foreach (var ideation in project.ideations)
                {
                    foreach (var idea in ideation.ideas)
                    {
                        ideaAmount++;
                        likeAmount = likeAmount + orchestrator.getIdeaLikes(idea.ideaId);
                        foreach (var reaction in idea.reactions)
                        {
                            likeAmount = likeAmount + orchestrator.getReactionLikes(reaction.reactionId);
                        } 
                        commentAmount = commentAmount + orchestrator.getReactions(idea.ideaId).ToList().Count;
                    }
                }
                var total = likeAmount + commentAmount;
                combinedDictionary.Add(project.projectId, total);
                likeDictionary.Add(project.projectId, likeAmount);
                commentDictionary.Add(project.projectId, commentAmount);
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
                projectVm.projectId = project.projectId;
                projectVm.name = project.name;
                projectVm.startDate = project.startDate;
                projectVm.endDate = project.endDate;
                projectVm.Base64Image = project.imageField.GetImageString();
                projectVm.description = project.description;
                var likeAmount = 0;
                var commentAmount = 0;
                var ideaAmount = 0;
                foreach (var ideation in project.ideations)
                {
                    foreach (var idea in ideation.ideas)
                    {
                        ideaAmount++;
                        likeAmount = likeAmount + orchestrator.getIdeaLikes(idea.ideaId);
                        foreach (var reaction in idea.reactions)
                        {
                            likeAmount = likeAmount + orchestrator.getReactionLikes(reaction.reactionId);
                        }
                        commentAmount = commentAmount + orchestrator.getReactions(idea.ideaId).ToList().Count;
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

//        public IActionResult Login()
//        {
//            return View();
//        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
        
        
        
    }
}