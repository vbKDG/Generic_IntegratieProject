using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.EF;
using Domain;
using Microsoft.AspNetCore.Identity;

namespace BL.Application
{
    public class OrchestratorProjectQuestionnaireController : IQuestionnaireManager
    {
        private UnitOfWorkManager uowManager;
        
      //  private IIdeationManager ideationMgr;
        private IProjectManager projectMgr;
        private IQuestionnaireManager questionnaireMgr;
        private UserManager<ApplicationUser> UserManager;

        public OrchestratorProjectQuestionnaireController(UserManager<ApplicationUser> userManager)
        {
            UserManager = userManager;
            uowManager = new UnitOfWorkManager();
           // ideationMgr = new IdeationManager(uowManager);
            projectMgr = new ProjectManager(uowManager);
            questionnaireMgr = new QuestionnaireManager(uowManager);
            
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

        #region Questionnaire

        public QuestionUser getQuestionUser(int questionUserId)
        {
           return questionnaireMgr.getQuestionUser(questionUserId);

        }

        public IEnumerable<Questionnaire> getQuestionnaires(int id)
         {
             return questionnaireMgr.getQuestionnaires(id);
         }

        public IEnumerable<IotSetup> getIotSetups()
        {
            return questionnaireMgr.getIotSetups();
        }

        public IEnumerable<Question> getQuestions(int id)
        {
            return questionnaireMgr.getQuestions(id);

        }

        public IEnumerable<Option> getOptions(int questionId)
        {
            return questionnaireMgr.getOptions(questionId);
        }

        public Questionnaire getQuestionnaire(int id)
        {
            return questionnaireMgr.getQuestionnaire(id);

        }

        public Question getQuestion(int id)
        {
            return questionnaireMgr.getQuestion(id);

        }

        public IEnumerable<QuestionUser> getQuestionUsers(int questionaireId)
        {
            return questionnaireMgr.getQuestionUsers(questionaireId);

        }

        public IEnumerable<QuestionUser> getQuestionUsers()
        {
            return questionnaireMgr.getQuestionUsers();
        }

        public void addQuestionnaire(List<Question> questions, string name, int questionAmount, int projectId)
        {
            questionnaireMgr.addQuestionnaire(questions, name, questionAmount, projectId);
            uowManager.Save();

        }

        public void addQuestion(string question, QuestionType questionType)
        {
             questionnaireMgr.addQuestion(question, questionType);
             uowManager.Save();

        }

       

        public void addQuestionUser(int userId, int questionId, string answer)
        {
            uowManager.Save();
        }

        public void removeQuestionUser(int questionUserId)
        {
            questionnaireMgr.removeQuestionUser(questionUserId);
            uowManager.Save();
            
        }

        public void changeQuestionUser(QuestionUser questionUser)
        {
            questionnaireMgr.changeQuestionUser(questionUser);
            uowManager.Save();
        }

        public void changeQuestion(Question q)
        {
            questionnaireMgr.changeQuestion(q);
            uowManager.Save();        }

        public void removeQuestion(int id)
        {
            questionnaireMgr.removeQuestion(id);
            uowManager.Save();        }

        public void changeOption(Option o)
        {
            questionnaireMgr.changeOption(o);
            uowManager.Save();
            
        }

        public void removeOption(int optionId)
        {
            questionnaireMgr.removeOption(optionId);
            uowManager.Save();        }
        
        
        public void addQuestion(Question question)
        {
            questionnaireMgr.addQuestion(question);
            uowManager.Save();
        }

        public void addOption(string option, Question question)
        {
            questionnaireMgr.addOption(option, question);
            uowManager.Save();
        }

        public void changeQuestionnaire(Questionnaire q)
        {
            questionnaireMgr.changeQuestionnaire(q);
            uowManager.Save();
        }

        public void removeQuestionnaire(int id)
        {
            questionnaireMgr.removeQuestionnaire(id);
            uowManager.Save();        }

        public void addQuestionUser(string userId, int questionId, string answer)
        {
            questionnaireMgr.addQuestionUser(userId,questionId,answer);
            uowManager.Save();
        }

        #endregion
    }
}