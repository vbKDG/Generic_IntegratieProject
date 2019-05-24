using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Mime;
using BL;
using D.UI.MVC.Models;
using Domain;
using Microsoft.AspNetCore.Mvc;
using UI.MVC.Models.Projects;

namespace UI.MVC.Controllers.api
{
    public class ProjectsController : Controller
    {
        IProjectManager mgr = new ProjectManager();
        
        [HttpGet("/api/Projects")]
        public IActionResult GetProjects()
        {
            IEnumerable<Project> projects = mgr.getProjects();
            List<ProjectRESTModelBasic> newProjects = new List<ProjectRESTModelBasic>();
            foreach (var project in projects)
            {
                ProjectRESTModelBasic newProject = new ProjectRESTModelBasic()
                {
                    projectId = project.projectId,
                    name = project.name,
                    numberOfLikes = project.projectLikes.Count,
                    numberOfIdeations = project.ideations.Count
                };
                newProjects.Add(newProject);
            }
            return Ok(newProjects);
        }
        
        [HttpGet("/api/Projects/{id}")]
        public IActionResult GetProject(int id)
        {
            Project project = mgr.getProject(id);
            
            double totalProjectDays = (project.endDate - project.startDate).Days;
            double daysSinceStartup = (DateTime.Now - project.startDate).Days;
            var percentageOfCompletion = 0;
            if (DateTime.Now >= project.endDate)
            {
                percentageOfCompletion = 100;
            } else if (DateTime.Now > project.startDate && DateTime.Now < project.endDate)
            {
                percentageOfCompletion = Convert.ToInt32((daysSinceStartup / totalProjectDays)*100);
            }

            foreach (var questionnaire in project.questionnaires)
            {
                questionnaire.project = null;
            }
            ProjectRESTModel newProject = new ProjectRESTModel()
            {
                projectId = project.projectId,
                name = project.name,
                description = project.description,
                startDate = project.startDate.ToUniversalTime(),
                endDate = project.endDate.ToUniversalTime(),
                numberOfLikes = project.projectLikes.Count,
                numberOfIdeations = project.ideations.Count,
                percentageCompleted = percentageOfCompletion
            };
            return Ok(newProject);
        }

        [HttpGet("/api/ProjectImage/{id}")]
        public IActionResult GetProjectImage(int id)
        {
            Project project = mgr.getProject(id);
            byte[] imageString = project.imageField.imageData;
            //string imageString = project.imageField.imageData;
            
            
            return File(imageString, "image/png");
            //return "data:image/png;base64," + Convert.ToBase64String(imageString);
        }
        
        [HttpGet("/api/Questionnaires/{id}")]
        public IActionResult GetQuestionnaires(int id)
        {
            Project project = mgr.getProject(id);
            IEnumerable<Questionnaire> questionnaires = project.questionnaires;
            foreach (var questionnaire in questionnaires)
            {
                questionnaire.project = null;
            }

            return Ok(questionnaires);
        }
        
    }
}