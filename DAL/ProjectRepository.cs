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
        
        public IEnumerable<Project> readProjects()
        {
            return ctx.Projects
                .Include(p => p.Questionnaires)
                .Include(p => p.ImageField)
                .Include(p => p.MapField)
                .Include(p => p.Phases)
                .Include(p => p.Ideations)
                .ThenInclude(i => i.Ideas)
                .ThenInclude(i => i.Reactions)
                .Include(p => p.ProjectLikes)
                .Include(p => p.Setting);
        }

        public Project readProject(int id)
        {
            return ctx.Projects
                .Include(p => p.Questionnaires)
                .Include(p => p.ImageField)
                .Include(p => p.MapField)
                .Include(p => p.Phases)
                .Include(p => p.Questionnaires)
                    .ThenInclude(q => q.Questions)
                    .ThenInclude(q => q.Options)
                .Include(p => p.Questionnaires)
                    .ThenInclude(q => q.Questions)
                    .ThenInclude(q => q.QuestionnaireAnswers)
                .Include(p => p.Ideations)
                    .ThenInclude(i => i.Questions)
                .Include(p => p.ProjectLikes)
                .Include(p => p.Setting)
                .SingleOrDefault(p => p.ProjectId == id);
        }

        public IEnumerable<Questionnaire> readQuestionnaires()
        {
            return ctx.Questionnaires.AsEnumerable();
        }

        public void createProject(Project p)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (ProjectRepo.Ctx)");
            ctx.Projects.Add(p);
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (ProjectRepo.Ctx)");
            ctx.SaveChanges();
        }

        public void updateProject(Project p)
        {
            foreach (var phase in ctx.Phases.Where(ph => ph.Project.ProjectId == p.ProjectId))
            {
                ctx.Phases.Remove(ctx.Phases.Find(phase.PhaseId));
            }
            updateSetting(p.Setting);
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (ProjectRepo.Ctx)");
            ctx.Projects.Update(p);
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
            ctx.Projects.Remove(ctx.Projects.Find(id));
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (ProjectRepo.Ctx)");
            ctx.SaveChanges();
        }
    }
}