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
                    projectId = project.projectId,
                    name = project.name
                });
            }
            return new JsonResult(projects);
        }
        
        public IActionResult Project(int id)
        {
            Project p1 = orchestrator.getProject(id);
            IEnumerable<IdeationQuestion> ideationQuestions1 = orchestrator.GetIdeationQuestionsForProject(id);
            p1.phases.ToList().Sort((x, y) => DateTime.Compare(x.startDate, y.startDate));
            var model = new ProjectAndQuestions() {ideationQuestions = ideationQuestions1, project = p1};

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
            projectVm.phases = new List<PhaseVM>();
            projectVm.SettingVm = new SettingVM();
            Project project = orchestrator.getProject(projectId);
            projectVm.projectId = project.projectId;
            projectVm.name = project.name;
            projectVm.description = project.description;
            projectVm.startDate = project.startDate;
            projectVm.endDate = project.endDate;
            foreach (var phase in project.phases)
            {
                PhaseVM phaseVm = new PhaseVM();
                phaseVm.phaseId = phase.phaseId;
                phaseVm.name = phase.name;
                phaseVm.description = phase.description;
                phaseVm.startDate = phase.startDate;
                phaseVm.endDate = phase.endDate;
                projectVm.phases.Add(phaseVm);
            }
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
            p.phases = p.phases.OrderBy(x => x.startDate).ToList();
            p.ideations = orchestrator.getIdeations(projectId).ToList();
            foreach (var ideation in p.ideations)
            {
                var LikeAmount = 0;
                var CommentAmount = 0;
                foreach (var idea in ideation.ideas)
                {
                    LikeAmount = LikeAmount + orchestrator.getIdeaLikes(idea.ideaId);
                    foreach (var reaction in idea.reactions)
                    {
                        LikeAmount = LikeAmount + orchestrator.getReactionLikes(reaction.reactionId);
                    } 
                    CommentAmount = CommentAmount + orchestrator.getReactions(idea.ideaId).ToList().Count;
                }
                var total = LikeAmount + CommentAmount;
                combinedDictionary.Add(ideation.ideationId, total);
                likeDictionary.Add(ideation.ideationId, LikeAmount);
                commentDictionary.Add(ideation.ideationId, CommentAmount);
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
            projectDetailModel.ideationQuestions = ideationQuestions;
            projectDetailModel.project = p;
            
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

        public IActionResult CreateProject(ProjectVM projectVm)
        {
            Project project = new Project();
            MapField mapField = new MapField();
            ImageField imageField = new ImageField();
            ICollection<Phase> phases = new List<Phase>();
            Setting Setting = new Setting();

            project.name = projectVm.name;
            project.description = projectVm.description;
            project.startDate = projectVm.startDate;
            project.endDate = projectVm.endDate;

            mapField.latitude = projectVm.mapFieldVM.latitude;
            mapField.longitude = projectVm.mapFieldVM.longitude;
            project.mapField = mapField;
            
            using (var reader = projectVm.imageFieldVM.imageFile.Files[0].OpenReadStream())
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

            Setting.FontFamily = projectVm.SettingVm.FontFamily;
            Setting.BackGroundColor1 = projectVm.SettingVm.BackGroundColor1;
            Setting.BackGroundColor2 = projectVm.SettingVm.BackGroundColor2;
            project.Setting = Setting;

            orchestrator.addProject(project);
            return RedirectToAction("Project", "Project", new {id = 1});
        }

        public IActionResult CreateIdeationPage( int projectId)
        {
            IdeationVM ideationVm = new IdeationVM();
            List<IdeationQuestionVM> questionVms = new List<IdeationQuestionVM>{new IdeationQuestionVM()};
            ideationVm.ideationQuestionVMs = questionVms;
            Project project = orchestrator.getProject(projectId);
            ideationVm.ProjectId = projectId;
            ideationVm.ProjectName = project.name;
            
            
            return View(ideationVm);
        }

    }
}