using System;
using System.Collections.Generic;
using System.Drawing;
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
            ideationRepo.createIdea(fields);        }

        public Idea getIdea(int id)
        {
           return ideationRepo.readIdea(id);
        }

        #endregion
        
        
        
    }
}