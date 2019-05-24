using System;
using System.Collections.Generic;
using System.Linq;
using DAL.EF;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class ProjectRepository : IProjectRepository
    {
        private ApplicationDbContext ctx;

        public ProjectRepository()
        {
            ctx = new ApplicationDbContext();
        }
        
        public ProjectRepository(UnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
                throw new ArgumentNullException("unitOfWork");

            ctx = unitOfWork.Context;
        }
        
        #region Projects
        public IEnumerable<Project> readProjects()
        {
            return ctx.projects
                .Include(p => p.Questionnaires)
                .Include(p => p.ImageField)
                .Include(p => p.MapField)
                .Include(p => p.Phases)
                .Include(p => p.Ideations)
                .ThenInclude(i => i.ideas)
                .ThenInclude(i => i.reactions)
                .Include(p => p.ProjectLikes)
                .Include(p => p.Setting);
        }

        public Project readProject(int id)
        {
            return ctx.projects
                .Include(p => p.Questionnaires)
                .Include( p => p.ImageField)
                .Include(p => p.MapField)
                .Include(p => p.Phases)
                .Include(p => p.Ideations)
                .Include(p => p.ProjectLikes)
                .Include(p => p.Setting)
                .SingleOrDefault(p => p.ProjectId == id);
        }

        public IEnumerable<Questionnaire> readQuestionnaires()
        {
            return ctx.questionnaires.AsEnumerable();
        }

        public void createProject(Project p)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (ProjectRepo.Ctx)");
            ctx.projects.Add(p);
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (ProjectRepo.Ctx)");
            ctx.SaveChanges();
        }

        public void updateProject(Project p)
        {
            foreach (var phase in ctx.phases.Where(ph => ph.Project.ProjectId == p.ProjectId))
            {
                ctx.phases.Remove(ctx.phases.Find(phase.PhaseId));
            }
            updateSetting(p.Setting);
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (ProjectRepo.Ctx)");
            ctx.projects.Update(p);
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (ProjectRepo.Ctx)");
            ctx.SaveChanges();
        }

        public void updateSetting(Setting s)
        {
            ctx.Settings.Update(s);
            ctx.SaveChanges();
        }

        public void deleteProject(int id)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (ProjectRepo.Ctx)");
            ctx.projects.Remove(ctx.projects.Find(id));
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (ProjectRepo.Ctx)");
            ctx.SaveChanges();
        }
        #endregion
    }
}