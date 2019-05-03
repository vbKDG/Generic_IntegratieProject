using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BL;
using D.UI.MVC.Models.Projects;
using DAL.EF;
using Domain;
using Microsoft.AspNetCore.Mvc;
using UI.MVC.Models;

namespace UI.MVC.Controllers
{
    public class ProjectController : Controller
    {
        private IProjectManager projectMgr;
        private IIdeationManager ideationMgr;

        public ProjectController(ApplicationDbContext ctx)
        {
            projectMgr = new ProjectManager(ctx);
            ideationMgr = new IdeationManager(ctx);
        }

        public IActionResult Projects()
        {
            IEnumerable<Project> allProjects = projectMgr.getProjects();
            return View(allProjects);
        }

        public IActionResult Project(int id)
        {
            Project p1 = projectMgr.getProject(id);
            IEnumerable<IdeationQuestion> ideationQuestions1 = ideationMgr.GetIdeationQuestionsForProject(id);
            var model = new ProjectAndQuestions() {ideationQuestions = ideationQuestions1, project = p1};

            return View(model);
        }

        public IActionResult Ideas(int id)
        {
            IEnumerable<Idea> ideas = ideationMgr.getIdeas(id);
            return View(ideas);
        }

        public IActionResult MapTest()
        {
            return View();
        }

        public IActionResult ProjectImageDisplay()
        {
            Project p = projectMgr.getProject(3);

            return View(p);

        }

        public IActionResult CreateProjectPage()
        {
            ProjectVM projectVm = new ProjectVM();
            List<PhaseVM> phases = new List<PhaseVM>();

            return View(projectVm);
        }

        public IActionResult CreateProject(ProjectVM projectVm)
        {
            Project project = new Project();
            MapField mapField = new MapField();
            ImageField imageField = new ImageField();
            ICollection<Phase> phases = new List<Phase>();

            project.name = projectVm.name;
            project.description = projectVm.description;
            project.startDate = projectVm.startDate;
            project.endDate = projectVm.endDate;

            mapField.latitude = projectVm.mapFieldVM.latitude;
            mapField.longitude = projectVm.mapFieldVM.longitude;
            project.mapField = mapField;

            using (var reader = projectVm.imageFieldVM.imageFile.OpenReadStream())
            using (var stream = new MemoryStream())
            {
                {
                    reader.CopyTo(stream);
                    imageField.imageData = stream.ToArray();

                }

            }

            project.imageField = imageField;

            foreach (var phaseVm in projectVm.phases)
            {
                phases.Add(new Phase
                {
                    name = phaseVm.name, description = phaseVm.description, startDate = phaseVm.startDate,
                    endDate = phaseVm.endDate
                });
            }

            project.phases = phases;

            projectMgr.addProject(project);




            return RedirectToAction("Project", "Project", new {id = 1});
        }


    }
}
