using System.Collections.Generic;
using Domain;

namespace BL
{
    public interface IIdeationManager
    {
        Ideation getIdeation(int ideationId);
        IEnumerable<Ideation> getIdeations(int projectId);
        IEnumerable<IdeationQuestion> GetIdeationQuestionsForProject(int projectId);

        IEnumerable<IdeationQuestion> GetIdeationQuestions(int ideationId);

        IEnumerable<Idea> getIdeas(int ideationId);
        void createIdea(Idea i);
        void createIdea(ICollection<Field> fields);

        Idea getIdea(int id);






    }
}