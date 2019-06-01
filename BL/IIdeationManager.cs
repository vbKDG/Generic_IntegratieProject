using System;
using System.Collections.Generic;
using Domain;

namespace BL
{
    public interface IIdeationManager
    {
        void CreateIdeation(Ideation ideation);
        void CreateIdeation(Ideation ideation, int projectId);
        void createIdea(Idea i);
        void createIdea(Idea i,String userId);
        void createIdea(ICollection<Field> fields);
        void LikeIdea(int ideaId, string userId);
        void LikeReaction(int reactionId, string userId);
        void ReactIdea(string ideaId, string userId, string content);
        void sendToAdmin(int reportId);
        void changeReaction(Reaction reaction);
        void approveReaction(int reactionId);
        void disapproveReaction(int reactionId);
        void approveIdea(int ideaId);
        void disapproveIdea(int ideaId);
        void blockUser(string userId);
        void createFaqAnswer(string userId, string answer, int faqId);
        void createFaq(string question, string userId);
        void changeIdeation(Ideation i);
        
        Ideation getIdeation(int ideationId);
        Idea getIdea(int id);
        Report addReport(int ideaId, string reportMessage,string userId, string type, int reactionId);
        Reaction getReaction(int reactionId);
        int getIdeaLikes(int ideaId);
        int getReactionLikes(int reactionId);
        
        IEnumerable<Ideation> getIdeations(int projectId);
        IEnumerable<IdeationQuestion> GetIdeationQuestionsForProject(int projectId);
        IEnumerable<IdeationQuestion> GetIdeationQuestions(int ideationId);
        IEnumerable<TextField> GetFields(int ideaId); 
        IEnumerable<Idea> getIdeas(int ideationId);
        IEnumerable<Reaction> getReactions(int ideaId);
        IEnumerable<Report> getReports(int ideaId);
        IEnumerable<Faq> getFaqs();
    }
}