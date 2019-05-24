using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using BL;
using BL.Application;
using D.UI.MVC.Models.Projects;
using DAL.EF;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UI.MVC.Models;
using UI.MVC.Models.Ideations;

namespace UI.MVC.Controllers
{
    public class ProjectController : Controller
    {
        private readonly OrchestratorSystemController orchestrator;
        
//        private IProjectManager projectMgr;
//        private IIdeationManager ideationMgr;
//
//        public ProjectController(ApplicationDbContext ctx)
//        {
//            projectMgr = new ProjectManager(ctx);
//            ideationMgr = new IdeationManager(ctx);
//        }

        public ProjectController()
        {
            orchestrator = new OrchestratorSystemController();
        }

        public IActionResult Projects()
        {
            IEnumerable<Project> allProjects = orchestrator.getProjects();
            return View(allProjects);
        }
        
        /*[HttpGet]
        public IActionResult GetAllProjects()
        {
            IEnumerable<Project> allProjects = orchestrator.getProjects();
            return new JsonResult(allProjects.ToList()[0].name);
        }*/
        
        [HttpGet]
        public IActionResult GetAllProjects()
        {
            var projects = new List<Project>();
            foreach (var project in orchestrator.getProjects().ToList())
            {
                projects.Add(new Project()
                {
                    ProjectId = project.ProjectId,
                    Name = project.Name
                });
            }
            return new JsonResult(projects);
        }
        
        public IActionResult Project(int id)
        {
            Project p1 = orchestrator.getProject(id);
            IEnumerable<IdeationQuestion> ideationQuestions1 = orchestrator.GetIdeationQuestionsForProject(id);
            p1.Phases.ToList().Sort((x, y) => DateTime.Compare(x.StartDate, y.StartDate));
            var model = new ProjectAndQuestions() {IdeationQuestions = ideationQuestions1, Project = p1};

            return View(model);
        }

        public IActionResult CloseProject(int projectId)
        {
            Project p = orchestrator.getProject(projectId);
            p.Closed = true;
            orchestrator.changeProject(p);
            return RedirectToAction("Projects","Project");
        }
        
        public IActionResult OpenProject(int projectId)
        {
            Project p = orchestrator.getProject(projectId);
            p.Closed = false;
            orchestrator.changeProject(p);
            return RedirectToAction("Projects","Project");
        }

        public IActionResult EditProjectPage(int projectId)
        {
            ProjectVM projectVm = new ProjectVM();
            projectVm.Phases = new List<PhaseVM>();
            projectVm.SettingVm = new SettingVM();
            Project project = orchestrator.getProject(projectId);
            projectVm.ProjectId = project.ProjectId;
            projectVm.Name = project.Name;
            projectVm.Description = project.Description;
            projectVm.StartDate = project.StartDate;
            projectVm.EndDate = project.EndDate;
            foreach (var phase in project.Phases)
            {
                PhaseVM phaseVm = new PhaseVM();
                phaseVm.PhaseId = phase.PhaseId;
                phaseVm.Name = phase.Name;
                phaseVm.Description = phase.Description;
                phaseVm.StartDate = phase.StartDate;
                phaseVm.EndDate = phase.EndDate;
                projectVm.Phases.Add(phaseVm);
            }
            projectVm.SettingVm.SettingId = project.Setting.SettingId;
            projectVm.SettingVm.FontFamily = project.Setting.FontFamily;
            projectVm.SettingVm.BackGroundColor1 = project.Setting.BackGroundColor1;
            projectVm.SettingVm.BackGroundColor2 = project.Setting.BackGroundColor2;
            return View(projectVm);
        }

        public IActionResult ProjectDetailPage(int projectId)
        {
            ProjectDetailModel projectDetailModel = new ProjectDetailModel();
            Dictionary<int, int> likeDictionary = new Dictionary<int, int>();
            Dictionary<int, int> commentDictionary = new Dictionary<int, int>();
            Dictionary<int, int> combinedDictionary = new Dictionary<int, int>();
            Project p = orchestrator.getProject(projectId);
            p.Phases = p.Phases.OrderBy(x => x.StartDate).ToList();
            p.Ideations = orchestrator.getIdeations(projectId).ToList();
            foreach (var ideation in p.Ideations)
            {
                var likeAmount = 0;
                var commentAmount = 0;
                foreach (var idea in ideation.Ideas)
                {
                    likeAmount = likeAmount + orchestrator.getIdeaLikes(idea.IdeaId);
                    foreach (var reaction in idea.Reactions)
                    {
                        likeAmount = likeAmount + orchestrator.getReactionLikes(reaction.ReactionId);
                    } 
                    commentAmount = commentAmount + orchestrator.getReactions(idea.IdeaId).ToList().Count;
                }
                var total = likeAmount + commentAmount;
                combinedDictionary.Add(ideation.IdeationId, total);
                likeDictionary.Add(ideation.IdeationId, likeAmount);
                commentDictionary.Add(ideation.IdeationId, commentAmount);
            }

            var counter = 0;
            foreach (var total in combinedDictionary.OrderByDescending(i => i.Value))
            {
                counter++;
                if (counter > 5)
                {
                    likeDictionary.Remove(total.Key);
                    commentDictionary.Remove(total.Key);
                }
            }
            
            projectDetailModel.LikeAmounts = likeDictionary;
            projectDetailModel.CommentAmounts = commentDictionary;
            
            ICollection<IdeationQuestion> ideationQuestions =
                orchestrator.GetIdeationQuestionsForProject(projectId).ToList();
            projectDetailModel.IdeationQuestions = ideationQuestions;
            projectDetailModel.Project = p;
            
            return View(projectDetailModel);
        }
        

        public IActionResult MapTest()
        {
            return View();
        }

        public IActionResult ProjectImageDisplay()
        {
            Project p = orchestrator.getProject(3);

            return View(p);

        }

        public IActionResult CreateProjectPage()
        {
            ProjectVM projectVm = new ProjectVM();
            List<PhaseVM> phases = new List<PhaseVM>();

            return View(projectVm);
        }

        public IActionResult EditProject(ProjectVM projectVm)
        {
            Project project = new Project();
            ICollection<Phase> phases = new List<Phase>();
            Setting setting = new Setting();

            project.ProjectId = projectVm.ProjectId;
            project.Name = projectVm.Name;
            project.Description = projectVm.Description;
            project.StartDate = projectVm.StartDate;
            project.EndDate = projectVm.EndDate;
            
            foreach (var phaseVm in projectVm.Phases)
            {
                phases.Add(new Phase
                {
                    Name = phaseVm.Name, Description = phaseVm.Description, StartDate = phaseVm.StartDate,
                    EndDate = phaseVm.EndDate
                });
            }
            project.Phases = phases;

            setting.SettingId = projectVm.SettingVm.SettingId;
            setting.FontFamily = projectVm.SettingVm.FontFamily;
            setting.BackGroundColor1 = projectVm.SettingVm.BackGroundColor1;
            setting.BackGroundColor2 = projectVm.SettingVm.BackGroundColor2;
            project.Setting = setting;
            
            orchestrator.changeProject(project);
            
            return RedirectToAction("Projects", "Project");
        }

        public IActionResult CreateProject(ProjectVM projectVm)
        {
            Project project = new Project();
            MapField mapField = new MapField();
            ImageField imageField = new ImageField();
            ICollection<Phase> phases = new List<Phase>();
            Setting setting = new Setting();

            project.Name = projectVm.Name;
            project.Description = projectVm.Description;
            project.StartDate = projectVm.StartDate;
            project.EndDate = projectVm.EndDate;

            mapField.Latitude = projectVm.MapFieldVM.Latitude;
            mapField.Longitude = projectVm.MapFieldVM.Longitude;
            project.MapField = mapField;
            
            using (var reader = projectVm.ImageFieldVM.ImageFile.Files[0].OpenReadStream())
            using (var stream = new MemoryStream())
            {
                {
                    reader.CopyTo(stream);
                    imageField.imageData = stream.ToArray();

                }

            }

            project.ImageField = imageField;

            foreach (var phaseVm in projectVm.Phases)
            {
                phases.Add(new Phase
                {
                    Name = phaseVm.Name, Description = phaseVm.Description, StartDate = phaseVm.StartDate,
                    EndDate = phaseVm.EndDate
                });
            }

            project.Phases = phases;

            setting.FontFamily = projectVm.SettingVm.FontFamily;
            setting.BackGroundColor1 = projectVm.SettingVm.BackGroundColor1;
            setting.BackGroundColor2 = projectVm.SettingVm.BackGroundColor2;
            project.Setting = setting;

            orchestrator.addProject(project);
            return RedirectToAction("Project", "Project", new {id = 1});
        }

        public IActionResult CreateIdeationPage( int projectId)
        {
            IdeationVM ideationVm = new IdeationVM();
            List<IdeationQuestionVM> questionVms = new List<IdeationQuestionVM>{new IdeationQuestionVM()};
            ideationVm.IdeationQuestionVMs = questionVms;
            Project project = orchestrator.getProject(projectId);
            ideationVm.ProjectId = projectId;
            ideationVm.ProjectName = project.Name;
            
            
            return View(ideationVm);
        }

    }
}