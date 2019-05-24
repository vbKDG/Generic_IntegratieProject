using System.Collections.Generic;
using Domain;

namespace DAL
{
    public interface IProjectRepository
    {
        void createProject(Project p);
        void updateProject(Project p);
        void deleteProject(int id);
        
        Project readProject(int id);
        
        IEnumerable<Questionnaire> readQuestionnaires();
        IEnumerable<Project> readProjects();
    }
}