using System;
using System.Collections.Generic;
using Domain;

namespace BL
{
    public interface IQuestionnaireManager
    {
        void addQuestionnaire(List<Question> questions, String name, int questionAmount, int projectId);
        void addQuestion(String question, QuestionType questionType);
        void addQuestion(Question question);
        void addOption(String option, Question question);
        void changeQuestionnaire(Questionnaire q);
        void removeQuestionnaire(int id);
        void addQuestionUser(string userId, int questionId, String answer);
        void removeQuestionUser(int questionUserId);
        void changeQuestionUser(QuestionUser questionUser);
        void changeQuestion(Question q);
        void removeQuestion(int id);
        void changeOption(Option o);
        void removeOption(int optionId);
        
        Questionnaire getQuestionnaire(int id);
        Question getQuestion(int id);
        QuestionUser getQuestionUser(int questionUserId);
        
        IEnumerable<Questionnaire> getQuestionnaires(int id);
        IEnumerable<IotSetup> getIotSetups();
        IEnumerable<Question> getQuestions(int id);
        IEnumerable<Option> getOptions(int questionId);
        IEnumerable<QuestionUser> getQuestionUsers(int questionnaireId);
        IEnumerable<QuestionUser> getQuestionUsers();
    }
}