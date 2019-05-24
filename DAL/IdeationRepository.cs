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
            return ctx.ideations
                .Include(p => p.project)
                .Include(p => p.questions)
                .Include(p => p.ideas)
                    .ThenInclude(p => p.reactions)
                .Where(p => p.project.projectId == projectId);
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
            ICollection<IdeaLike> likes = ctx.ideaLikes.Where(l => l.Idea.ideaId == ideaId).ToList();
            return likes.Count;
        }

        public int getReactionLikes(int reactionId)
        {
            ICollection<ReactionLike> likes = ctx.reactionLikes
                .Where(r => r.reaction.reactionId == reactionId).ToList();
            return likes.Count;
        }

        public IEnumerable<Report> readReports(int ideaId)
        {
            IEnumerable<Report> reports = ctx.reports
                .Include(r => r.idea)
                .Include(r => r.reaction)
                .Include(r => r.user)
                .Where(r => r.idea.ideaId == ideaId).AsEnumerable();
            return reports;
        }

        public Report createReport(Report report, string userId)
        {
            report.user = ctx.Users.Find(userId);
            report.sendToAdmin = false;
            ctx.reports.Add(report);
            ctx.SaveChanges();
            return report;
        }
        
        public void sendToAdmin(int reportId)
        {
            Report report = ctx.reports.Find(reportId);
            report.sendToAdmin = true;
            ctx.reports.Update(report);
            ctx.SaveChanges();
        }

        public void blockUser(string userId)
        {
            ApplicationUser user = ctx.Users.Find(userId);
            user.blocked = true;
            ctx.Users.Update(user);
            ctx.SaveChanges();
        }

        public void updateReaction(Reaction reaction)
        {
            ctx.reactions.Update(reaction);
            ctx.SaveChanges();
        }

        public void approveReaction(int reactionId)
        {
            Reaction reaction = ctx.reactions.Find(reactionId);
            reaction.approved = true;
            reaction.disapproved = false;
            ctx.reactions.Update(reaction);
            ctx.SaveChanges();
        }

        public void disapproveReaction(int reactionId)
        {
            Reaction reaction = ctx.reactions.Find(reactionId);
            reaction.disapproved = true;
            reaction.approved = false;
            ctx.reactions.Update(reaction);
            ctx.SaveChanges();
        }

        public void approveIdea(int ideaId)
        {
            Idea idea = ctx.ideas.Find(ideaId);
            idea.approved = true;
            idea.disapproved = false;
            ctx.ideas.Update(idea);
            ctx.SaveChanges();
        }

        public void disapproveIdea(int ideaId)
        {
            Idea idea = ctx.ideas.Find(ideaId);
            idea.disapproved = true;
            idea.approved = false;
            ctx.ideas.Update(idea);
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
                .Include(i => i.reports)
                .Where( i => i.ideation.ideationId == ideationId);
        }

        public IEnumerable<Reaction> readReactions(int ideaId)
        {
            return ctx.reactions
                .Include(r => r.user)
                .Include(r => r.reactionLikes)
                .Include(r => r.reports)
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
            foreach(var userRole in ctx.UserRoles.Where(ur => ur.UserId == userId))
            {
                foreach (var role in ctx.Roles.Where(r => r.Id == userRole.RoleId))
                {
                    if (role.Name == "SignedInUserVerified")
                    {
                        reaction.verified = true;
                    }
                }
            }
            ctx.reactions.Add(reaction);
            ctx.SaveChanges();
        }

        #region Idea
        public void createIdea(Idea i)
        {

            ctx.ideas.Add(i);           
            ctx.SaveChanges();


        }

        public void createIdea(Idea i, string userId)
        {
            ApplicationUser user = ctx.Users.Find(userId);
            i.user = user;
            ctx.ideas.Add(i);
            ctx.SaveChanges();


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
            var questionFields = ctx.questionFields.Where(q => q.idea.ideaId == ideaId)
                .Include(q => q.question)
                .ThenInclude(o => o.Options);
            
            Idea idea = ctx.ideas
                .Include(i => i.fields)
                .Include(i => i.user)
                .SingleOrDefault(i => i.ideaId == ideaId);
            foreach (var questionField in questionFields)
            {
                idea.fields.Add(questionField);
            }
            
           
            return idea;


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