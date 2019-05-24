using System;
using System.Collections.Generic;
using Domain;

namespace DAL
{
    public interface IIdeationRepository
    {
        #region Ideations

        void createIdeation(Ideation ideation);
        void createIdeation(Ideation ideation, int projectId);
        void updateIdeation(Ideation i);
        void deleteIdeation(int id);
        
        Ideation readIdeation(int id);
        
        IEnumerable<Ideation> readIdeations(int projectId);
        
        #endregion

        #region IdeationQuestions
        
        void createIdeationQuestion(IdeationQuestion i);
        void updateIdeationQuestion(IdeationQuestion i);
        void deleteIdeationQuestion(int id);

        IdeationQuestion readIdeationQuestion(int id);
        
        IEnumerable<IdeationQuestion> ReadIdeationQuestionsForProject(int projectId);
        IEnumerable<IdeationQuestion> ReadIdeationQuestions(int ideationId);

        #endregion

        #region Ideas

        void createIdea(Idea i);
        void createIdea(Idea i, String userId);
        void createIdea(ICollection<Field> fields);
        void updateIdea(Idea i);
        void deleteIdea(int ideaId);
        void LikeIdea(int ideaId, string userId);
        void ReactIdea(string ideaId, string userId, string content);
        void LikeReaction(int reactionId, string userId);
        void sendToAdmin(int reportId);
        void updateReaction(Reaction reaction);
        void approveReaction(int reactionId);
        void disapproveReaction(int reactionId);
        void approveIdea(int ideaId);
        void disapproveIdea(int ideaId);
        void blockUser(string userId);
        void addFaqAnswer(string userId, string answer, int faqId);
        void addFaq(string question, string userId);
        
        Idea readIdea(int ideaId);
        Reaction readReaction(int reactionId);
        Report createReport(Report report, string userId);
        int getIdeaLikes(int ideaId);
        int getReactionLikes(int reactionId);
        
        IEnumerable<Idea> readIdeas(int ideationId);
        IEnumerable<TextField> readFields(int ideaId);
        IEnumerable<Reaction> readReactions(int ideaId);
        IEnumerable<Report> readReports(int ideaId);
        
        #endregion

        IEnumerable<Faq> readFaqs();
    }
}