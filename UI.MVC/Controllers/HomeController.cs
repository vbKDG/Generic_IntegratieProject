using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using BL;
using Microsoft.AspNetCore.Mvc;
using Domain;
using Microsoft.AspNetCore.Http;
using UI.MVC.Models;
using BL.Application;

namespace UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly OrchestratorSystemController orchestrator;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult AdminPage()
        {
            return View();
        }

        public IActionResult BestProject()
        {
            Project p = orchestrator.getProject(1);

            return View(p);

        }

        public IActionResult Login()
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