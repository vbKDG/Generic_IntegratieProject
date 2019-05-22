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
                /*int totalProjectDays = (project.endDate - project.startDate).Days;
                int daysSinceStartup = (DateTime.Now - project.startDate).Days;
                int percentageOfCompletion = daysSinceStartup / totalProjectDays;*/
                
                ProjectRESTModelBasic newProject = new ProjectRESTModelBasic()
                {
                    projectId = project.projectId,
                    name = project.name,
                    numberOfLikes = project.projectLikes.Count,
                    numberOfIdeations = project.ideations.Count
                    //numberOfReports = project.reports.Count?
                };
                newProjects.Add(newProject);
            }
            return Ok(newProjects);
        }
        
        [HttpGet("/api/Projects/{id}")]
        public IActionResult GetProject(int id)
        {
            //Either you add a service in startup.cs to ignore reference loop handling
            //or you comment/delete the 'include' line in the project repository
            Project project = mgr.getProject(id);
            /*Bitmap bmp;
            using (var ms = new MemoryStream(project.imageField.imageData))
            {
                bmp = new Bitmap(ms);
            }*/
            double totalProjectDays = (project.endDate - project.startDate).Days;
            double daysSinceStartup = (DateTime.Now - project.startDate).Days;
            var percentageOfCompletion = (int)Math.Round(daysSinceStartup / totalProjectDays);
            /*MemoryStream ms = new MemoryStream(project.imageField.imageData);
            Image returnImage = Image.FromStream(ms);*/
            foreach (var questionnaire in project.questionnaires)
            {
                questionnaire.project = null;
            }
            ProjectRESTModel newProject = new ProjectRESTModel()
            {
                projectId = project.projectId,
                name = project.name,
                projectImage = project.imageField.imageData,
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
            
            return Ok(imageString);
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