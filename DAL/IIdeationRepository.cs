using System.Collections.Generic;
using Domain;

namespace DAL
{
    public interface IIdeationRepository
    {
        #region Ideations

        IEnumerable<Ideation> readIdeations(int projectId);
        void createIdeation(Ideation i);
        Ideation readIdeation(int id);
        void updateIdeation(Ideation i);
        void deleteIdeation(int id);

        

         #endregion

         #region IdeationQuestions
         IEnumerable<IdeationQuestion> ReadIdeationQuestionsForProject(int projectId);
         IEnumerable<IdeationQuestion> ReadIdeationQuestions(int ideationId);
         
         void createIdeationQuestion(IdeationQuestion i);
         IdeationQuestion readIdeationQuestion(int id);
         void updateIdeationQuestion(IdeationQuestion i);
         void deleteIdeationQuestion(int id);
         

         #endregion

         #region Ideas
         IEnumerable<Idea> readIdeas(int ideationId);
         void createIdea(Idea i);
         void createIdea(ICollection<Field> fields);
         Idea readIdea(int ideaId);
         void updateIdea(Idea i);
         void deleteIdea(int ideaId);

         

         #endregion
/*
         #region Answers
         IEnumerable<Ideation> readIdeations(int id);
         void createIdeation(Ideation i);
         Ideation readIdeation(int id);
         void updateIdeation(Ideation i);
         void deleteIdeation(int id);

         

         #endregion
        
        
        */
    }
}