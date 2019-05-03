using System.Collections.Generic;
using Domain;

namespace BL
{
    public interface IProjectManager
    {
        IEnumerable<Project> getProjects();
        Project getProject(int id);
        IEnumerable<Questionnaire> getQuestionnaires();
        void addProject(Project p);
        void changeProject(Project p);
        void removeProject(int id);
    }
}