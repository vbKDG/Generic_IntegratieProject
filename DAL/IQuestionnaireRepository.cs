using System;
using System.Collections.Generic;
using Domain;

namespace DAL
{
    public interface IQuestionnaireRepository
    {
        IEnumerable<Questionnaire> readQuestionnaires(int projectId);
        void createQuestionnaire(Questionnaire q, int projectId);
        Questionnaire readQuestionnaire(int questionnaireId);
        Question readQuestion(int questionId);
        QuestionUser readQuestionUser(int questionUserId);
        IEnumerable<IotSetup> readIotSetups();
        IEnumerable<Question> readQuestions(int questionnaireId);
        IEnumerable<Option> readOptions(int questionId);
        IEnumerable<QuestionUser> readQuestionUsers(int questionnaireId);
        IEnumerable<QuestionUser> readQuestionUsers();
        void createQuestion(Question q);
        void createOption(Option o);
        void updateQuestionnaire(Questionnaire q);
        void deleteQuestionnaire(int questionnaireId);
        void updateQuestion(Question q);
        void deleteQuestion(int questionId);
        void updateOption(Option o);
        void deleteOption(int optionId);
        void createQuestionUser(string userId, int questionId, String answer);
        void deleteQuestionUser(int questionUserId);
        void updateQuestionUser(QuestionUser questionUser);
    }
}