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
            return ctx.Ideations
                .Include(p => p.Project)
                .Include(p => p.Questions)
                .Include(p => p.Ideas)
                    .ThenInclude(p => p.Reactions)
                .Where(p => p.Project.ProjectId == projectId);
        }

        public void createIdeation(Ideation ideation)
        {
             
            ctx.Ideations.Add(ideation);
            ctx.SaveChanges();

        }

        public void createIdeation(Ideation ideation, int projectId)
        {
            ideation.Project = ctx.Projects.Find(projectId);
            ctx.Ideations.Add(ideation);
            ctx.SaveChanges();
        }

        public Ideation readIdeation(int id)
        {
            return ctx.Ideations.Include(p => p.Project)
                .Include(f => f.TextFieldRange)
                .Include(f => f.ImageFieldRange)
                .Include(f => f.VideoRange)
                .Include(f => f.MapFieldRange)
                .Include(f => f.QuestionFieldRange)
                .SingleOrDefault(i => i.IdeationId == id);
        }

        public void addFaqAnswer(string userId, string answer, int faqId)
        {
            FaqAnswer faqAnswer = new FaqAnswer
            {
                User = ctx.Users.Find(userId),
                Answer = answer,
                Faq = ctx.Faqs.Find(faqId)
            };
            ctx.FaqAnswers.Add(faqAnswer);
            ctx.SaveChanges();
        }

        public void addFaq(string question, string userId)
        {
            Faq faq = new Faq
            {
                Question = question,
                User = ctx.Users.Find(userId)
            };
            ctx.Faqs.Add(faq);
            ctx.SaveChanges();
        }

        public IEnumerable<Faq> readFaqs()
        {
            IEnumerable<Faq> faqs = ctx.Faqs
                .Include(f => f.Answers)
                .Include(f => f.User);
            IEnumerable<FaqAnswer> faqAnswers = ctx.FaqAnswers
                .Include(f => f.Faq)
                .Include(f => f.User);
            foreach (var faq in faqs)
            {
                foreach (var answer in faqAnswers)
                {
                    if (answer.Faq == faq)
                    {
                        faq.Answers.Add(answer);
                    }
                }
            }

            return faqs;
        }

        public int getIdeaLikes(int ideaId)
        {
            ICollection<IdeaLike> likes = ctx.IdeaLikes.Where(l => l.Idea.IdeaId == ideaId).ToList();
            return likes.Count;
        }

        public int getReactionLikes(int reactionId)
        {
            ICollection<ReactionLike> likes = ctx.ReactionLikes
                .Where(r => r.Reaction.ReactionId == reactionId).ToList();
            return likes.Count;
        }

        public IEnumerable<Report> readReports(int ideaId)
        {
            IEnumerable<Report> reports = ctx.Reports
                .Include(r => r.Idea)
                .Include(r => r.Reaction)
                .Include(r => r.User)
                .Where(r => r.Idea.IdeaId == ideaId).AsEnumerable();
            return reports;
        }

        public Report createReport(Report report, string userId)
        {
            report.User = ctx.Users.Find(userId);
            report.SendToAdmin = false;
            ctx.Reports.Add(report);
            ctx.SaveChanges();
            return report;
        }
        
        public void sendToAdmin(int reportId)
        {
            Report report = ctx.Reports.Find(reportId);
            report.SendToAdmin = true;
            ctx.Reports.Update(report);
            ctx.SaveChanges();
        }

        public void blockUser(string userId)
        {
            ApplicationUser user = ctx.Users.Find(userId);
            user.Blocked = true;
            ctx.Users.Update(user);
            ctx.SaveChanges();
        }

        public void updateReaction(Reaction reaction)
        {
            ctx.Reactions.Update(reaction);
            ctx.SaveChanges();
        }

        public void approveReaction(int reactionId)
        {
            Reaction reaction = ctx.Reactions.Find(reactionId);
            reaction.Approved = true;
            reaction.Disapproved = false;
            ctx.Reactions.Update(reaction);
            ctx.SaveChanges();
        }

        public void disapproveReaction(int reactionId)
        {
            Reaction reaction = ctx.Reactions.Find(reactionId);
            reaction.Disapproved = true;
            reaction.Approved = false;
            ctx.Reactions.Update(reaction);
            ctx.SaveChanges();
        }

        public void approveIdea(int ideaId)
        {
            Idea idea = ctx.Ideas.Find(ideaId);
            idea.Approved = true;
            idea.Disapproved = false;
            ctx.Ideas.Update(idea);
            ctx.SaveChanges();
        }

        public void disapproveIdea(int ideaId)
        {
            Idea idea = ctx.Ideas.Find(ideaId);
            idea.Disapproved = true;
            idea.Approved = false;
            ctx.Ideas.Update(idea);
            ctx.SaveChanges();
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
            return ctx.IdeationQuestions.Include(i => i.Ideation).Where(i => i.Ideation.Project.ProjectId == ProjectId);

        }

        public IEnumerable<IdeationQuestion> ReadIdeationQuestions(int ideationId)
        {
            return ctx.IdeationQuestions.Where(i => i.Ideation.IdeationId == ideationId);
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
            return ctx.Ideas
                .Include(i => i.Fields)
                .Include(i => i.User)
                .Include(i => i.IdeaLikes)
                .Include(i => i.Reactions)
                .Include(i => i.Reports)
                .Where( i => i.Ideation.IdeationId == ideationId);
        }

        public IEnumerable<Reaction> readReactions(int ideaId)
        {
            return ctx.Reactions
                .Include(r => r.User)
                .Include(r => r.ReactionLikes)
                .Include(r => r.Reports)
                .Where(r => r.Idea.IdeaId == ideaId);
        }

        public IEnumerable<TextField> readFields(int ideaId)
        {
            IEnumerable<TextField> fields = ctx.TextFields
                .Where(f => f.Idea.IdeaId == ideaId);

            return fields;
        }

        public void LikeIdea(int ideaId, string userId)
        {
            bool unique = ctx.IdeaLikes
                .Any(x => x.User.Id == userId && x.Idea.IdeaId == ideaId);
                
            if (!unique)
            {
                IdeaLike like = new IdeaLike();
                like.User = ctx.Users.Find(userId);
                like.LikeTime = DateTime.Now;
                like.Idea = ctx.Ideas.Find(ideaId);
                ctx.IdeaLikes.Add(like);
                ctx.SaveChanges();
            }
        }

        public void LikeReaction(int reactionId, string userId)
        {
            bool unique = ctx.ReactionLikes
                .Any(x => x.User.Id == userId && x.Reaction.ReactionId == reactionId);

            if (!unique)
            {
                ReactionLike like = new ReactionLike();
                like.Reaction = ctx.Reactions.Find(reactionId);
                like.User = ctx.Users.Find(userId);
                like.LikeTime = DateTime.Now;
                ctx.ReactionLikes.Add(like);
                ctx.SaveChanges();
            }
        }

        public void ReactIdea(string ideaId, string userId, string content)
        {
            Reaction reaction = new Reaction
            {
                Content = content,
                User = ctx.Users.Find(userId),
                Date = DateTime.Now,
                Idea = ctx.Ideas.Find(Convert.ToInt32(ideaId))
            };
            foreach(var userRole in ctx.UserRoles.Where(ur => ur.UserId == userId))
            {
                foreach (var role in ctx.Roles.Where(r => r.Id == userRole.RoleId))
                {
                    if (role.Name == "SignedInUserVerified")
                    {
                        reaction.Verified = true;
                    }
                }
            }
            ctx.Reactions.Add(reaction);
            ctx.SaveChanges();
        }

        #region Idea
        public void createIdea(Idea i)
        {

            ctx.Ideas.Add(i);           
            ctx.SaveChanges();


        }

        public void createIdea(Idea i, string userId)
        {
            ApplicationUser user = ctx.Users.Find(userId);
            i.User = user;
            ctx.Ideas.Add(i);
            ctx.SaveChanges();


        }

        public void createIdea(ICollection<Field> fields)
        {
            Idea i = new Idea();
            i.Fields = fields;
            ctx.Ideas.Add(i);
            ctx.SaveChanges();
        }
        

        public Idea readIdea(int ideaId)
        {
            var questionFields = ctx.QuestionFields.Where(q => q.Idea.IdeaId == ideaId)
                .Include(q => q.Question)
                .ThenInclude(o => o.Options);
            
            Idea idea = ctx.Ideas
                .Include(i => i.Fields)
                .Include(i => i.User)
                .SingleOrDefault(i => i.IdeaId == ideaId);
            foreach (var questionField in questionFields)
            {
                idea.Fields.Add(questionField);
            }
            
           
            return idea;


        }

        public Reaction readReaction(int reactionId)
        {
            return ctx.Reactions.SingleOrDefault(r => r.ReactionId == reactionId);
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