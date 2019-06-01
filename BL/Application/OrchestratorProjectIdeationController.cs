using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DAL.EF;
using Domain;
using Microsoft.AspNetCore.Identity;

namespace BL.Application
{
    public class OrchestratorProjectIdeationController : IIdeationManager
    {
        private UnitOfWorkManager uowManager;
        
        private IIdeationManager ideationMgr;
        private IProjectManager projectMgr;
        private UserManager<ApplicationUser> UserManager;

        public OrchestratorProjectIdeationController(UserManager<ApplicationUser> userManager)
        {
            UserManager = userManager;
            uowManager = new UnitOfWorkManager();
            ideationMgr = new IdeationManager(uowManager);
            projectMgr = new ProjectManager(uowManager);
        }

        #region User

        public Task<IList<DAL.EF.ApplicationUser>> GetUsersInRoleAsync(string role)
        {
            var usersOfRole =  UserManager.GetUsersInRoleAsync(role);
            return usersOfRole;
        }

        public Task<ApplicationUser> FindByIdAsync(string userId)
        {
            var applicationUser = UserManager.FindByIdAsync(userId);
            return applicationUser;
        }

        public Task<IList<string>> GetRolesAsync(ApplicationUser user)
        {
            var roles = UserManager.GetRolesAsync(user);

            return roles;
        }
        
        public void DeleteAsync(ApplicationUser user)
        {
            UserManager.DeleteAsync(user);
        }
        public void UpdateAsync(ApplicationUser user)
        {
            UserManager.UpdateAsync(user);
        }
        #endregion
       
        #region Ideation
        
        public IEnumerable<Faq> getFaqs()
        {
            return ideationMgr.getFaqs();
        }
        
        public void changeIdeation(Ideation i)
        {
            ideationMgr.changeIdeation(i);
            uowManager.Save();
        }

        public void createFaqAnswer(string userId, string answer, int faqId)
        {
            ideationMgr.createFaqAnswer(userId, answer, faqId);
        }

        public void createFaq(string question, string userId)
        {
            ideationMgr.createFaq(question, userId);
        }

        public Ideation getIdeation(int ideationId)
        {
            return ideationMgr.getIdeation(ideationId);
        }

        public IEnumerable<Ideation> getIdeations(int projectId)
        {
            return ideationMgr.getIdeations(projectId);
        }

        public IEnumerable<IdeationQuestion> GetIdeationQuestionsForProject(int projectId)
        {
            return ideationMgr.GetIdeationQuestionsForProject(projectId);

        }

        public IEnumerable<IdeationQuestion> GetIdeationQuestions(int ideationId)
        {
            return ideationMgr.GetIdeationQuestions(ideationId);
        }

        public IEnumerable<Reaction> getReactions(int ideaId)
        {
            return ideationMgr.getReactions(ideaId);
        }

        public void LikeIdea(int ideaId, string userId)
        {
            ideationMgr.LikeIdea(ideaId, userId);
        }

        public IEnumerable<Report> getReports(int ideaId)
        {
            return ideationMgr.getReports(ideaId);
        }

        public Reaction getReaction(int reactionId)
        {
            return ideationMgr.getReaction(reactionId);
        }

        public Report addReport(int ideaId, string reportMessage, string userId, string type, int reactionId)
        {
            return ideationMgr.addReport(ideaId, reportMessage, userId, type, reactionId);
        }

        public void sendToAdmin(int reportId)
        {
            ideationMgr.sendToAdmin(reportId);
        }

        public void approveReaction(int reactionId)
        {
            ideationMgr.approveReaction(reactionId);
        }

        public void disapproveReaction(int reactionId)
        {
            ideationMgr.disapproveReaction(reactionId);
        }

        public void approveIdea(int ideaId)
        {
            ideationMgr.approveIdea(ideaId);
        }

        public void disapproveIdea(int ideaId)
        {
            ideationMgr.disapproveIdea(ideaId);
        }

        public void blockUser(string userId)
        {
            ideationMgr.blockUser(userId);
        }

        public int getIdeaLikes(int ideaId)
        {
            return ideationMgr.getIdeaLikes(ideaId);
        }

        public int getReactionLikes(int reactionId)
        {
            return ideationMgr.getReactionLikes(reactionId);
        }

        public void changeReaction(Reaction reaction)
        {
            ideationMgr.changeReaction(reaction);
        }

        public void ReactIdea(string ideaId, string userId, string content)
        {
            ideationMgr.ReactIdea(ideaId, userId, content);
        }

        public void LikeReaction(int reactionId, string userId)
        {
            ideationMgr.LikeReaction(reactionId, userId);
        }

        public IEnumerable<TextField> GetFields(int ideaId)
        {
            return ideationMgr.GetFields(ideaId);
        }

        public void CreateIdeation(Ideation ideation, int projectId)
        {
            ideationMgr.CreateIdeation(ideation,projectId);
            uowManager.Save();
        }

        public void CreateIdeation(Ideation ideation)
        {
           ideationMgr.CreateIdeation(ideation);
           uowManager.Save();

        }

        public IEnumerable<Idea> getIdeas(int ideationId)
        {
            return ideationMgr.getIdeas(ideationId);

        }

        public void createIdea(Idea i)
        {
             ideationMgr.createIdea(i);
             uowManager.Save();


        }

        public void createIdea(Idea i, string userId)
        {
            ideationMgr.createIdea(i,userId);
            uowManager.Save();
        }

        public void createIdea(ICollection<Field> fields)
        {
             ideationMgr.createIdea(fields);
             uowManager.Save();


        }

        public Idea getIdea(int id)
        {
            return ideationMgr.getIdea(id);

        }

        #endregion

        #region Project

        public IEnumerable<Project> getProjects()
        {
            return projectMgr.getProjects();
        }

        public Project getProject(int id)
        {
            return projectMgr.getProject(id);

        }

        public IEnumerable<Questionnaire> getQuestionnaires()
        {
            return projectMgr.getQuestionnaires();

        }

        public void addProject(Project p)
        {
             projectMgr.addProject(p);
             uowManager.Save();


        }

        public void changeProject(Project p)
        {
             projectMgr.changeProject(p);
             uowManager.Save();
        }

        public void removeProject(int id)
        {
             projectMgr.removeProject(id);
             uowManager.Save();

        }

        #endregion
    }
}