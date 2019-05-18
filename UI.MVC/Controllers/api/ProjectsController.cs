using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Mime;
using BL;
using D.UI.MVC.Models;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace UI.MVC.Controllers.api
{
    public class ProjectsController : Controller
    {
        IProjectManager mgr = new ProjectManager();
        
        [HttpGet("/api/Projects")]
        public IActionResult GetProjects()
        {
            IEnumerable<Project> projects = mgr.getProjects();
            List<ProjectRESTModel> newProjects = new List<ProjectRESTModel>();
            foreach (var project in projects)
            {
                Bitmap bmp;
                using (var ms = new MemoryStream(project.imageField.imageData))
                {
                    bmp = new Bitmap(ms);
                }

                int totalProjectDays = (project.endDate - project.startDate).Days;
                int daysSinceStartup = (DateTime.Now - project.startDate).Days;
                int percentageOfCompletion = daysSinceStartup / totalProjectDays;
                
                /*MemoryStream ms = new MemoryStream(project.imageField.imageData);
                Image returnImage = Image.FromStream(ms);*/
                ProjectRESTModel newProject = new ProjectRESTModel()
                {
                    projectId = project.projectId,
                    name = project.name,
                    projectImage = bmp,
                    description = project.description,
                    startDate = project.startDate.ToUniversalTime(),
                    endDate = project.endDate.ToUniversalTime(),
                    numberOfLikes = project.projectLikes.Count,
                    numberOfIdeations = project.ideations.Count,
                    percentageCompleted = percentageOfCompletion
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
            Bitmap bmp;
            using (var ms = new MemoryStream(project.imageField.imageData))
            {
                bmp = new Bitmap(ms);
            }
            double totalProjectDays = (project.endDate - project.startDate).Days;
            double daysSinceStartup = (DateTime.Now - project.startDate).Days;
            var percentageOfCompletion = (int)Math.Round(daysSinceStartup / totalProjectDays);
            /*MemoryStream ms = new MemoryStream(project.imageField.imageData);
            Image returnImage = Image.FromStream(ms);*/
            ProjectRESTModel newProject = new ProjectRESTModel()
            {
                projectId = project.projectId,
                name = project.name,
                projectImage = bmp,
                description = project.description,
                startDate = project.startDate.ToUniversalTime(),
                endDate = project.endDate.ToUniversalTime(),
                numberOfLikes = project.projectLikes.Count,
                numberOfIdeations = project.ideations.Count,
                percentageCompleted = percentageOfCompletion
            };
            return Ok(newProject);
        }
    }
}