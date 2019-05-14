using System;
using System.Collections.Generic;
using System.Linq;
using DAL.EF;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class IdeationRepository : IIdeationRepository
    {
        private ApplicationDbContext ctx;

        public IdeationRepository()
        {
            ctx = new ApplicationDbContext();
        }
        public IdeationRepository(UnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
                throw new ArgumentNullException("unitOfWork");

            ctx = unitOfWork.Context;
        }
        
        public IEnumerable<Ideation> readIdeations(int projectId)
        {
            return ctx.ideations.Include(p => p.project).Where(p => p.project.projectId == projectId);
        }

        public void createIdeation(Ideation ideation)
        {
             
            ctx.ideations.Add(ideation);
            ctx.SaveChanges();

        }

        public void createIdeation(Ideation ideation, int projectId)
        {
            ideation.project = ctx.projects.Find(projectId);
            ctx.ideations.Add(ideation);
            ctx.SaveChanges();
        }

        public Ideation readIdeation(int id)
        {
            return ctx.ideations.Include(p => p.project)
                .Include(f => f.TextFieldRange)
                .Include(f => f.ImageFieldRange)
                .Include(f => f.VideoRange)
                .Include(f => f.MapFieldRange)
                .Include(f => f.QuestionFieldRange)
                .SingleOrDefault(i => i.ideationId == id);

        }
        
        public IEnumerable<Report> readReportsOfIdea(int ideaId)
        {
            IEnumerable<Report> reports = ctx.reports.Where(r => r.idea.ideaId == ideaId).AsEnumerable();
            return reports;
        }

        public Report createReport(Report report, string userId)
        {
            report.user = ctx.Users.Find(userId);
            ctx.reports.Add(report);
            ctx.SaveChanges();
            return report;
        }

        public void updateIdeation(Ideation i)
        {
            throw new System.NotImplementedException();
        }

        public void deleteIdeation(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<IdeationQuestion> ReadIdeationQuestionsForProject(int ProjectId)
        {
            return ctx.ideationQuestions.Include(i => i.ideation).Where(i => i.ideation.project.projectId == ProjectId);

        }

        public IEnumerable<IdeationQuestion> ReadIdeationQuestions(int ideationId)
        {
            return ctx.ideationQuestions.Where(i => i.ideation.ideationId == ideationId);
        }

        public void createIdeationQuestion(IdeationQuestion i)
        {
            throw new System.NotImplementedException();
        }

        public IdeationQuestion readIdeationQuestion(int id)
        {
            throw new System.NotImplementedException();
        }

        public void updateIdeationQuestion(IdeationQuestion i)
        {
            throw new System.NotImplementedException();
        }

        public void deleteIdeationQuestion(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Idea> readIdeas(int ideationId)
        {
            //return ctx.ideas.Include(i => i.ideation).Where(i => i.ideation.ideationId == ideationId);
            // return ctx.ideas.Include(i => i.ideation).Include(i => i.UserId).Where( i => i.ideation.ideationId == ideationId);
            return ctx.ideas
                .Include(i => i.fields)
                .Include(i => i.user)
                .Include(i => i.ideaLikes)
                .Include(i => i.reactions)
                .Where( i => i.ideation.ideationId == ideationId);
        }

        public IEnumerable<Reaction> readReactions(int ideaId)
        {
            return ctx.reactions
                .Include(r => r.user)
                .Include(r => r.reactionLikes)
                .Where(r => r.idea.ideaId == ideaId);
        }

        public IEnumerable<TextField> readFields(int ideaId)
        {
            IEnumerable<TextField> fields = ctx.textFields
                .Where(f => f.idea.ideaId == ideaId);

            return fields;
        }

        public void LikeIdea(int ideaId, string userId)
        {
            bool unique = ctx.ideaLikes
                .Any(x => x.User.Id == userId && x.Idea.ideaId == ideaId);
                
            if (!unique)
            {
                IdeaLike like = new IdeaLike();
                like.User = ctx.Users.Find(userId);
                like.likeTime = DateTime.Now;
                like.Idea = ctx.ideas.Find(ideaId);
                ctx.ideaLikes.Add(like);
                ctx.SaveChanges();
            }
        }

        public void LikeReaction(int reactionId, string userId)
        {
            bool unique = ctx.reactionLikes
                .Any(x => x.User.Id == userId && x.reaction.reactionId == reactionId);

            if (!unique)
            {
                ReactionLike like = new ReactionLike();
                like.reaction = ctx.reactions.Find(reactionId);
                like.User = ctx.Users.Find(userId);
                like.likeTime = DateTime.Now;
                ctx.reactionLikes.Add(like);
                ctx.SaveChanges();
            }
        }

        public void ReactIdea(string ideaId, string userId, string content)
        {
            Reaction reaction = new Reaction
            {
                content = content,
                user = ctx.Users.Find(userId),
                date = DateTime.Now,
                idea = ctx.ideas.Find(Convert.ToInt32(ideaId))
            };
            ctx.reactions.Add(reaction);
            ctx.SaveChanges();
        }

        #region Idea
        public void createIdea(Idea i)
        {

            ctx.ideas.Add(i);           
            ctx.SaveChanges();
            Console.WriteLine("Opslagen gelukt!");


        }
        public void createIdea(ICollection<Field> fields)
        {
            Idea i = new Idea();
            i.fields = fields;
            ctx.ideas.Add(i);
            ctx.SaveChanges();
            Console.WriteLine("Opslagen gelukt!");
        }
        

        public Idea readIdea(int ideaId)
        {
            return ctx.ideas.Include(i => i.fields).SingleOrDefault(i => i.ideaId == ideaId);
        }

        public Reaction readReaction(int reactionId)
        {
            return ctx.reactions.SingleOrDefault(r => r.reactionId == reactionId);
        }

        public void updateIdea(Idea i)
        {
            throw new NotImplementedException();
        }

        public void deleteIdea(int ideaId)
        {
            throw new NotImplementedException();
        }
        

        #endregion
       
    }
}