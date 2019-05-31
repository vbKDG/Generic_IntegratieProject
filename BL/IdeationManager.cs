using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DAL;
using DAL.EF;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace BL
{
    public class IdeationManager : IIdeationManager
    {
        private IIdeationRepository ideationRepo;
        
        public IdeationManager()
        {
            ideationRepo = new IdeationRepository();
        }
        
        public IdeationManager(UnitOfWorkManager unitOfWorkManager)
        {
            if (unitOfWorkManager == null)
                throw new ArgumentNullException("unitOfWorkManager");

            ideationRepo = new DAL.IdeationRepository(unitOfWorkManager.UnitOfWork);
        }
        
        public void createFaqAnswer(string userId, string answer, int faqId)
        {
            ideationRepo.addFaqAnswer(userId, answer, faqId);
        }

        public void createFaq(string question, string userId)
        {
            ideationRepo.addFaq(question, userId);
        }

        public IEnumerable<Faq> getFaqs()
        {
            return ideationRepo.readFaqs();
        }

        public Ideation getIdeation(int ideationId)
        {
            return ideationRepo.readIdeation(ideationId);
        }

        public IEnumerable<Ideation> getIdeations(int projectId)
        {
           return  ideationRepo.readIdeations(projectId);
        }

        public IEnumerable<TextField> GetFields(int ideaId)
        {
            return ideationRepo.readFields(ideaId);
        }

        public void LikeIdea(int ideaId, string userId)
        {
            ideationRepo.LikeIdea(ideaId, userId);
        }

        public void LikeReaction(int reactionId, string userId)
        {
            ideationRepo.LikeReaction(reactionId, userId);
        }

        public int getIdeaLikes(int ideaId)
        {
            return ideationRepo.getIdeaLikes(ideaId);
        }

        public int getReactionLikes(int reactionId)
        {
            return ideationRepo.getReactionLikes(reactionId);
        }

        public IEnumerable<Report> getReports(int ideaId)
        {
            return ideationRepo.readReports(ideaId);
        }

        public void sendToAdmin(int reportId)
        {
            ideationRepo.sendToAdmin(reportId);
        }

        public Report addReport(int ideaId, string reportMessage, string userId, string type, int reactionId)
        {
            if (type == "reaction")
            {
                Reaction reaction = getReaction(reactionId);
                Idea idea = getIdea(ideaId);
                
                if (reaction != null)
                {
                    Report newReport = new Report();
                    newReport.Reaction = reaction;
                    newReport.DateSubmitted = DateTime.Now;
                    newReport.Idea = idea;
                    newReport.ReportMessage = reportMessage;

                    var reports = getReports(ideaId);

                    if (reports != null)
                    {
                        idea.Reports = reports.ToList();
                    }
                    else
                    {
                        idea.Reports = new List<Report>();
                    }

                    idea.Reports.Add(newReport);

                    ideationRepo.createReport(newReport, userId);

                    return newReport;
                }
            } 
            else if (type == "idea")
            {
                Idea idea = getIdea(ideaId);

                if (idea != null)
                {
                    Report newReport = new Report();
                    newReport.Idea = idea;
                    newReport.DateSubmitted = DateTime.Now;
                    newReport.ReportMessage = reportMessage;

                    var reports = getReports(ideaId);

                    if (reports != null)
                    {
                        idea.Reports = reports.ToList();
                    }
                    else
                    {
                        idea.Reports = new List<Report>();
                    }

                    idea.Reports.Add(newReport);

                    ideationRepo.createReport(newReport, userId);

                    return newReport;
                }
            }
            throw new ArgumentException("ideaId " + ideaId + " or reactionId " + reactionId + " not found!");
        }

        public IEnumerable<Reaction> getReactions(int ideaId)
        {
            return ideationRepo.readReactions(ideaId);
        }

        public IEnumerable<IdeationQuestion> GetIdeationQuestionsForProject(int projectId)
        {
            return  ideationRepo.ReadIdeationQuestionsForProject(projectId);
        }

        public IEnumerable<IdeationQuestion> GetIdeationQuestions(int ideationId)
        {
            return ideationRepo.ReadIdeationQuestions(ideationId);
        }

        public void CreateIdeation(Ideation ideation)
        {
            ideationRepo.createIdeation(ideation);
        }

        public void CreateIdeation(Ideation ideation, int projectId)
        {
            ideationRepo.createIdeation(ideation,projectId);
        }

        public void approveReaction(int reactionId)
        {
            ideationRepo.approveReaction(reactionId);
        }

        public void disapproveReaction(int reactionId)
        {
            ideationRepo.disapproveReaction(reactionId);
        }

        public void approveIdea(int ideaId)
        {
            ideationRepo.approveIdea(ideaId);
        }

        public void disapproveIdea(int ideaId)
        {
            ideationRepo.disapproveIdea(ideaId);
        }

        public void blockUser(string userId)
        {
            ideationRepo.blockUser(userId);
        }

        public void ReactIdea(string ideaId, string userId, string content)
        {
            ideationRepo.ReactIdea(ideaId, userId, content);
        }

        public void changeReaction(Reaction reaction)
        {
            ideationRepo.updateReaction(reaction);
        }

        #region Ideas
        public IEnumerable<Idea> getIdeas(int ideationId)
        {
            return ideationRepo.readIdeas(ideationId);
        }

        public void createIdea(Idea i)
        {
            ideationRepo.createIdea(i);        }

        public void createIdea(Idea i, string userId)
        {
           ideationRepo.createIdea(i,userId);
        }

        public void createIdea(ICollection<Field> fields)
        {
            ideationRepo.createIdea(fields);        
        }

        public Idea getIdea(int id)
        {
           return ideationRepo.readIdea(id);
        }

        public Reaction getReaction(int reactionId)
        {
            return ideationRepo.readReaction(reactionId);
        }
        #endregion
    }
}