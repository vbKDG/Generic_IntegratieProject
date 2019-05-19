using System.Collections.Generic;
using Domain;

namespace BL
{
    public interface IIdeationManager
    {
        Ideation getIdeation(int ideationId);
        IEnumerable<Ideation> getIdeations(int projectId);
        IEnumerable<IdeationQuestion> GetIdeationQuestionsForProject(int projectId);

        IEnumerable<IdeationQuestion> GetIdeationQuestions(int ideationId);
        IEnumerable<TextField> GetFields(int ideaId); 

        void CreateIdeation(Ideation ideation);
        
        void CreateIdeation(Ideation ideation, int projectId);

        IEnumerable<Idea> getIdeas(int ideationId);
        void createIdea(Idea i);
        void createIdea(ICollection<Field> fields);

        Idea getIdea(int id);
        IEnumerable<Reaction> getReactions(int ideaId);

        void LikeIdea(int ideaId, string userId);
        void LikeReaction(int reactionId, string userId);
        void ReactIdea(string ideaId, string userId, string content);

        IEnumerable<Report> getReports(int ideaId);
        Report addReport(int ideaId, string reportMessage,string userId, string type, int reactionId);
        Reaction getReaction(int reactionId);
        void sendToAdmin(int reportId);
        void changeReaction(Reaction reaction);
        void approveReaction(int reactionId);
        void disapproveReaction(int reactionId);
        void approveIdea(int ideaId);
        void disapproveIdea(int ideaId);
        void blockUser(string userId);
        int getIdeaLikes(int ideaId);
        int getReactionLikes(int reactionId);
        void createFaqAnswer(string userId, string answer, int faqId);
        void createFaq(string question, string userId);
        IEnumerable<Faq> getFaqs();
    }
}