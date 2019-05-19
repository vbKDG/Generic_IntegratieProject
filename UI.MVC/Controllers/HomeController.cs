using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using BL;
using BL.Application;
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
            List<Project> projects = orchestrator.getProjects().ToList();
            List<Project> Top3 = new List<Project>();

            Top3.Add(projects[4]);
            Top3.Add(projects[5]);
            Top3.Add(projects[6]);
            return View(Top3);
            
            /*
              ProjectCollectionsVM projectCollectionsVm = new ProjectCollectionsVM();
              List<Project> projects = orchestrator.getProjects().ToList(); 
              //top3projects
              projectCollectionsVm.top3Projects.Add(projects[0]); 
              projectCollectionsVm.top3Projects.Add(projects[1]); 
              projectCollectionsVm.top3Projects.Add(projects[2]);
              projectCollectionsVm.top3Projects.Add(projects[3]); 
              //popularProjects
              projectCollectionsVm.popularProjects.Add(projects[6]);
              projectCollectionsVm.popularProjects.Add(projects[7]);
              projectCollectionsVm.popularProjects.Add(projects[8]);
              projectCollectionsVm.popularProjects.Add(projects[9]);
              //newestProjects
              projectCollectionsVm.newestProjects.Add(projects[10]);
              //closedProjects
              projectCollectionsVm.closedProjects.Add(projects[11]);
              projectCollectionsVm.closedProjects.Add(projects[12]);
              
              return View(projectCollectionsVm);
 */
        }

        public IActionResult ProjectsGeneral()
        {
            IEnumerable<Project> allProjects = orchestrator.getProjects();
            return View(allProjects);

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