using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DAL;
using DAL.EF;
using Domain;

namespace BL
{
    public class ProjectManager : IProjectManager
    {
        private IProjectRepository repo;
        
        public ProjectManager(ApplicationDbContext ctx) 
        {
            repo = new ProjectRepository(ctx);
        }
        
        public IEnumerable<Project> getProjects()
        {
            return repo.readProjects();
        }

        public Project getProject(int id)
        {
            return repo.readProject(id);
        }

        public IEnumerable<Questionnaire> getQuestionnaires()
        {
            return repo.readQuestionnaires();
        }

        public Project addProject(int projectId)
        {
            Project project = this.getProject(projectId);
            this.changeProject(project);

            return project;
        }
        
        public void addProject(Project p)
        {
            repo.createProject(p);
        }

        public void changeProject(Project p)
        {
            Validator.ValidateObject(p, new ValidationContext(p));
            repo.updateProject(p);
        }

        public void removeProject(int id)
        {
            repo.deleteProject(id);
        }
    }
}