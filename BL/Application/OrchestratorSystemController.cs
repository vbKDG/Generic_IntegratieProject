using System.Collections.Generic;
using Domain;

namespace BL.Application
{
    public class OrchestratorSystemController : IQuestionnaireManager
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
            throw new System.NotImplementedException();
        }

        public IEnumerable<IotSetup> getIotSetups()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Question> getQuestions(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Option> getOptions(int questionId)
        {
            throw new System.NotImplementedException();
        }

        public Questionnaire getQuestionnaire(int id)
        {
            throw new System.NotImplementedException();
        }

        public Question getQuestion(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<QuestionUser> getQuestionUsers(int questionaireId)
        {
            throw new System.NotImplementedException();
        }

        public void addQuestionnaire(List<Question> questions, string name, int questionAmount, int projectId)
        {
            throw new System.NotImplementedException();
        }

        public void addQuestion(string question, QuestionType questionType)
        {
            throw new System.NotImplementedException();
        }

        public void addQuestion(Question question)
        {
            throw new System.NotImplementedException();
        }

        public void addOption(string option, Question question)
        {
            throw new System.NotImplementedException();
        }

        public void changeQuestionnaire(Questionnaire q)
        {
            throw new System.NotImplementedException();
        }

        public void removeQuestionnaire(int id)
        {
            throw new System.NotImplementedException();
        }

        public void addQuestionUser(int userId, int questionId, string answer)
        {
            throw new System.NotImplementedException();
        }

        public void removeQuestionUser(int questionUserId)
        {
            throw new System.NotImplementedException();
        }

        public void changeQuestion(Question q)
        {
            throw new System.NotImplementedException();
        }

        public void removeQuestion(int id)
        {
            throw new System.NotImplementedException();
        }

        public void changeOption(Option o)
        {
            throw new System.NotImplementedException();
        }

        public void removeOption(int optionId)
        {
            throw new System.NotImplementedException();
        }

        #endregion


       
    }
}