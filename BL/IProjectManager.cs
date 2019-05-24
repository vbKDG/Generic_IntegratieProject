using System.Collections.Generic;
using Domain;

namespace BL
{
    public interface IProjectManager
    {
        void addProject(Project p);
        void changeProject(Project p);
        void removeProject(int id);
        
        Project getProject(int id);
        
        IEnumerable<Project> getProjects();
        IEnumerable<Questionnaire> getQuestionnaires();
    }
}