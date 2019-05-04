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

        public IdeationRepository(ApplicationDbContext ctx)
        {
            this.ctx = ctx;
        }
        
        public IEnumerable<Ideation> readIdeations(int projectId)
        {
            return ctx.ideations.Include(p => p.project).Where(p => p.project.projectId == projectId);
        }

        public void createIdeation(Ideation i)
        {
            throw new System.NotImplementedException();
        }

        public Ideation readIdeation(int id)
        {
            return ctx.ideations.Include(p => p.project).SingleOrDefault(i => i.ideationId == id);

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
            // return ctx.ideas.Include(i => i.ideation).Include(i => i.UserId).Where( i => i.ideation.ideationId == ideationId);
            return ctx.ideas.Include(i => i.ideation).Include(i => i.ideaId).Where( i => i.ideation.ideationId == ideationId);
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