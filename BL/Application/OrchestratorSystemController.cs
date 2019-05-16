using System.Collections.Generic;
using Domain;

namespace BL.Application
{
    public class OrchestratorSystemController : IIdeationManager
    {
        private UnitOfWorkManager uowManager;
        
        private IIdeationManager ideationMgr;
        private IProjectManager projectMgr;
        private IQuestionnaireManager questionnaireMgr;

        public OrchestratorSystemController()
        {
            uowManager = new UnitOfWorkManager();
            ideationMgr = new IdeationManager(uowManager);
            projectMgr = new ProjectManager(uowManager);
            questionnaireMgr = new QuestionnaireManager(uowManager);
            
        }

        #region Ideation

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

        #region Questionnaire

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

        public void addQuestionUser(int userId, int questionId, string answer)
        {
          //  questionnaireMgr.addQuestionUser(userId ,questionId,answer);
            uowManager.Save();

        }

        public void removeQuestionUser(int questionUserId)
        {
            questionnaireMgr.removeQuestionUser(questionUserId);
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

        #endregion


       
    }
}