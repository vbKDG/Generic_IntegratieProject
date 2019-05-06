using System.Collections.Generic;
using Domain;

namespace BL.Application
{
    public class OrchestratorSystemController 
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