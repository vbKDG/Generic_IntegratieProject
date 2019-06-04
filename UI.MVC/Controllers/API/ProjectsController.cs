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
using UI.MVC.Models.Questions;

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
                    projectId = project.ProjectId,
                    name = project.Name,
                    numberOfLikes = project.ProjectLikes.Count,
                    numberOfIdeations = project.Ideations.Count
                };
                newProjects.Add(newProject);
            }
            return Ok(newProjects);
        }
        
        [HttpGet("/api/Projects/{id}")]
        public IActionResult GetProject(int id)
        {
            Project project = mgr.getProject(id);
            
            double totalProjectDays = (project.EndDate - project.StartDate).Days;
            double daysSinceStartup = (DateTime.Now - project.StartDate).Days;
            var percentageOfCompletion = 0;
            if (DateTime.Now >= project.EndDate)
            {
                percentageOfCompletion = 100;
            } else if (DateTime.Now > project.StartDate && DateTime.Now < project.EndDate)
            {
                percentageOfCompletion = Convert.ToInt32((daysSinceStartup / totalProjectDays)*100);
            }

            foreach (var questionnaire in project.Questionnaires)
            {
                questionnaire.Project = null;
            }
            ProjectRESTModel newProject = new ProjectRESTModel()
            {
                projectId = project.ProjectId,
                name = project.Name,
                description = project.Description,
                startDate = project.StartDate.ToUniversalTime(),
                endDate = project.EndDate.ToUniversalTime(),
                numberOfLikes = project.ProjectLikes.Count,
                numberOfIdeations = project.Ideations.Count,
                percentageCompleted = percentageOfCompletion
            };
            return Ok(newProject);
        }

        [HttpGet("/api/ProjectImage/{id}")]
        public IActionResult GetProjectImage(int id)
        {
            Project project = mgr.getProject(id);
            string imageString = project.ImageField.ImageData;
            
            
            return File(imageString, "image/png");
        }
        
        [HttpGet("/api/Questionnaires/{id}")]
        public IActionResult GetQuestionnaires(int id)
        {
            Project project = mgr.getProject(id);
            IEnumerable<Questionnaire> questionnaires = project.Questionnaires;
            List<QuestionnaireRESTModel> newQuestionnaires = new List<QuestionnaireRESTModel>();
            foreach (var questionnaire in questionnaires)
            {
                QuestionnaireRESTModel model = new QuestionnaireRESTModel()
                {
                    questionnaireId = questionnaire.QuestionnaireId,
                    name = questionnaire.Name
                };
                newQuestionnaires.Add(model);
            }

            return Ok(newQuestionnaires);
        }
        
    }
}