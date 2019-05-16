using System.Collections.Generic;
using Domain;

namespace DAL
{
    public interface IIdeationRepository
    {
        #region Ideations

        IEnumerable<Ideation> readIdeations(int projectId);
        void createIdeation(Ideation ideation);
        void createIdeation(Ideation ideation , int projectId);

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
         Reaction readReaction(int reactionId);
         void updateIdea(Idea i);
         void deleteIdea(int ideaId);
         IEnumerable<TextField> readFields(int ideaId);
         IEnumerable<Reaction> readReactions(int ideaId);
         void LikeIdea(int ideaId, string userId);
         void ReactIdea(string ideaId, string userId, string content);
         void LikeReaction(int reactionId, string userId);
         IEnumerable<Report> readReports(int ideaId);
         Report createReport(Report report, string userId);
         void sendToAdmin(int reportId);
         void updateReaction(Reaction reaction);
         void approveReaction(int reactionId);
         void disapproveReaction(int reactionId);
         void approveIdea(int ideaId);
         void disapproveIdea(int ideaId);
         void blockUser(string userId);


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