using System.Collections.Generic;
using Domain;

namespace DAL
{
    public interface IProjectRepository
    {
        IEnumerable<Project> readProjects();
        Project readProject(int id);
        IEnumerable<Questionnaire> readQuestionnaires();
        void createProject(Project p);
        void updateProject(Project p);
        void deleteProject(int id);
    }
}