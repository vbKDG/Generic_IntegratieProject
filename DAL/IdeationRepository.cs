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
            Console.WriteLine(unique);
                
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