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
        
//        public IdeationManager(ApplicationDbContext ctx)
//        {
//            ideationRepo = new IdeationRepository(ctx);
//        }

//        public IdeationManager(IIdeationRepository repo)
//        {
//            ideationRepo = repo;
//        }
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
        
        public IEnumerable<Report> getReports(int ideaId)
        {
            return ideationRepo.readReportsOfIdea(ideaId);
        }

        public Report addReport(int id, string reportMessage, string userId, string type)
        {
            if (type == "reaction")
            {
                Reaction reaction = getReaction(id);
                
                if (reaction != null)
                {
                    Report newReport = new Report();
                    newReport.reaction = reaction;
                    newReport.dateSubmitted = DateTime.Now;
                    newReport.reportMessage = reportMessage;

                    var reports = getReports(id);

                    if (reports != null)
                    {
                        reaction.reports = reports.ToList();
                    }
                    else
                    {
                        reaction.reports = new List<Report>();
                    }

                    reaction.reports.Add(newReport);

                    ideationRepo.createReport(newReport, userId);

                    return newReport;
                }
            } 
            else if (type == "idea")
            {
                Idea idea = getIdea(id);

                if (idea != null)
                {
                    Report newReport = new Report();
                    newReport.idea = idea;
                    newReport.dateSubmitted = DateTime.Now;
                    newReport.reportMessage = reportMessage;

                    var reports = getReports(id);

                    if (reports != null)
                    {
                        idea.reports = reports.ToList();
                    }
                    else
                    {
                        idea.reports = new List<Report>();
                    }

                    idea.reports.Add(newReport);

                    ideationRepo.createReport(newReport, userId);

                    return newReport;
                }
            }
            throw new ArgumentException("Id " + id + " not found!");
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

        public void ReactIdea(string ideaId, string userId, string content)
        {
            ideationRepo.ReactIdea(ideaId, userId, content);
        }

        #region Ideas
        public IEnumerable<Idea> getIdeas(int ideationId)
        {
            return ideationRepo.readIdeas(ideationId);
        }

        public void createIdea(Idea i)
        {
            ideationRepo.createIdea(i);        }

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