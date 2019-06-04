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
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UI.MVC.Models;
using UI.MVC.Models.Ideations;

namespace UI.MVC.Controllers
{
    public class ProjectController : Controller
    {
        private readonly OrchestratorProjectIdeationController orchestrator;
        
        public ProjectController(UserManager<ApplicationUser> userManager)
        {
            orchestrator = new OrchestratorProjectIdeationController(userManager);
        }

        [Authorize(Roles = "SuperAdmin, Admin")]
        public IActionResult Projects()
        {
            IEnumerable<Project> allProjects = orchestrator.getProjects();
            return View(allProjects);
        }
        
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
        
        public IActionResult Ideations(int id)
        {
            Project project = orchestrator.getProject(id);
            return View(project);
        }

        [Authorize(Roles = "SuperAdmin, Admin")]
        public IActionResult CloseProject(int projectId)
        {
            Project p = orchestrator.getProject(projectId);
            p.Closed = true;
            orchestrator.changeProject(p);
            return RedirectToAction("Projects","Project");
        }
        
        [Authorize(Roles = "SuperAdmin, Admin")]
        public IActionResult OpenProject(int projectId)
        {
            Project p = orchestrator.getProject(projectId);
            p.Closed = false;
            orchestrator.changeProject(p);
            return RedirectToAction("Projects","Project");
        }

        [Authorize(Roles = "SuperAdmin, Admin")]
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
            Random random = new Random();  
            ProjectDetailModel projectDetailModel = new ProjectDetailModel();
            projectDetailModel.SelectedQuestionVms = new List<SelectedQuestionVM>();
            ICollection<Question> questions = new List<Question>();
            Dictionary<int, int> likeDictionary = new Dictionary<int, int>();
            Dictionary<int, int> commentDictionary = new Dictionary<int, int>();
            Dictionary<int, int> combinedDictionary = new Dictionary<int, int>();
            Project p = orchestrator.getProject(projectId);
            p.Phases = p.Phases.OrderBy(x => x.StartDate).ToList();
            p.Ideations = orchestrator.getIdeations(projectId).ToList();

            foreach (var questionnaire in p.Questionnaires.ToList())
            {
                foreach (var question in questionnaire.Questions.ToList())
                {
                    if (question.QuestionType == QuestionType.DROPDOWN ||
                        question.QuestionType == QuestionType.CHECK_BOX ||
                        question.QuestionType == QuestionType.RADIO_BUTTON)
                    {
                        if (question.QuestionnaireAnswers.ToList().Count > 0)
                        {
                            questions.Add(question);   
                        }
                    }
                }
            }
            foreach (var questionnaire in p.Questionnaires.ToList())
            {
                if (questionnaire.Closed == true)
                {
                    p.Questionnaires.Remove(questionnaire);
                }
            }
            foreach (var ideation in p.Ideations.ToList())
            {
                if (ideation.Closed == false)
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
                else
                {
                    p.Ideations.Remove(ideation);
                }
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

            for (int i = 0; i < 3; i++)
            {
                if (questions.ToList().Count >= 1)
                {
                    int randomSelected = random.Next(0, questions.Count);
                    SelectedQuestionVM selectedQuestionVm = new SelectedQuestionVM();
                    selectedQuestionVm.QuestionAnswerCount = 0;
                    selectedQuestionVm.OptionsVms = new List<OptionsVM>();
                    selectedQuestionVm.Question = questions.ToList()[randomSelected];

                    foreach (var answer in questions.ToList()[randomSelected].QuestionnaireAnswers)
                    {
                        if (answer.Question == questions.ToList()[randomSelected] && questions.ToList()[randomSelected].QuestionType == QuestionType.CHECK_BOX)
                        {
                            selectedQuestionVm.QuestionAnswerCount++;
                        }
                    }
                    
                    foreach (var option in questions.ToList()[randomSelected].Options)
                    {
                        OptionsVM optionsVm = new OptionsVM();
                        optionsVm.Option = option;
                        foreach (var answer in questions.ToList()[randomSelected].QuestionnaireAnswers)
                        {
                            if (questions.ToList()[randomSelected].QuestionType == QuestionType.CHECK_BOX)
                            {
                                var parts = answer.Answer.Split(",");
                                foreach (var part in parts)
                                {
                                    if (part == option.TheOption)
                                    {
                                        optionsVm.OptionVoteCount++;
                                    }
                                }
                            }
                            else
                            {
                                if (option.TheOption == answer.Answer)
                                {
                                    selectedQuestionVm.QuestionAnswerCount++;
                                    optionsVm.OptionVoteCount++;
                                }
                            }
                        }
                        selectedQuestionVm.OptionsVms.Add(optionsVm);
                    }
                    projectDetailModel.SelectedQuestionVms.Add(selectedQuestionVm);
                    questions.Remove(questions.ToList()[randomSelected]);
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

        [Authorize(Roles = "SuperAdmin, Admin")]
        public IActionResult CreateProjectPage()
        {
            ProjectVM projectVm = new ProjectVM();
            List<PhaseVM> phases = new List<PhaseVM>();

            return View(projectVm);
        }

        [Authorize(Roles = "SuperAdmin, Admin")]
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

        [Authorize(Roles = "SuperAdmin, Admin")]
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
                    var base64 = Convert.ToBase64String(stream.ToArray());
                    base64 =  String.Format("data:image/png;base64,{0}", base64);
                    imageField.ImageData = base64;

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
            return RedirectToAction("Ideations", "Project", new {id = 1});
        }

        [Authorize(Roles = "SuperAdmin, Admin")]
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