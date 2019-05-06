using System;
using System.Collections.Generic;
using System.Linq;
using DAL.EF;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class QuestionnaireRepository : IQuestionnaireRepository
    {
        private ApplicationDbContext ctx;

        public QuestionnaireRepository()
        {
            ctx = new ApplicationDbContext();
        }
        
        public QuestionnaireRepository(UnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
                throw new ArgumentNullException("unitOfWork");

            ctx = unitOfWork.Context;
        }
        #region Interface Implementation

        public void createQuestionUser(string userId, int questionId, String answer)
        {
            QuestionUser qu = new QuestionUser();
            if (!(userId == ""))
            {
                qu.User = ctx.Users.Find(userId);
            }
            qu.Question = ctx.questions.Find(questionId);
            qu.Answer = answer;
            ctx.questionUsers.Add(qu);
            ctx.SaveChanges();
        }

        public IEnumerable<Questionnaire> readQuestionnaires(int projectId)
        {
            return ctx.questionnaires
                .Include(q => q.project)
                .Where(q => q.project.projectId == projectId);
        }

        public IEnumerable<IotSetup> readIotSetups()
        {
            return ctx.iotSetups.AsEnumerable();
        }

        public IEnumerable<Question> readQuestions(int questionnaireId)
        {
            return ctx.questions
                .Include(q => q.questionnaire)
                .Include(q => q.options)
                .Include(q => q.IotSetup)
                .Where(q => q.questionnaire.id == questionnaireId);
        }

        public IEnumerable<Option> readOptions(int questionId)
        {
            return ctx.options
                .Where(o => o.question.id == questionId);
        }

        public IEnumerable<QuestionUser> readQuestionUsers(int questionnaireId)
        {
            IList<QuestionUser> questionUsers = new List<QuestionUser>();
            foreach (var q in ctx.questions.Where(q => q.questionnaire.id == questionnaireId))
            {
                foreach (var qu in ctx.questionUsers.Where(qu => qu.Question.id == q.id))
                {
                    questionUsers.Add(qu);
                }
            }
            return questionUsers;
        }

        public void createQuestionnaire(Questionnaire q, int projectId)
        {
            q.project = ctx.projects.Find(projectId);
            ctx.questionnaires.Add(q);
            foreach (Question question in q.questions)
            {
                question.questionnaire = ctx.questionnaires.Find(q.id);
                ctx.questions.Add(question);
            }
            ctx.SaveChanges();
        }

        public void createQuestion(Question q)
        {
            ctx.questions.Add(q);
            ctx.SaveChanges();
        }

        public void createOption(Option o)
        {
            ctx.options.Add(o);
            ctx.SaveChanges();
        }

        public Questionnaire readQuestionnaire(int questionnaireId)
        {
            return ctx.questionnaires.Find(questionnaireId);
        }

        public Question readQuestion(int questionId)
        {
            return ctx.questions.Find(questionId);
        }
        
        public void deleteQuestionUser(int questionUserId)
        {
            ctx.questionUsers.Remove(ctx.questionUsers.Find(questionUserId));
            ctx.SaveChanges();
        }

        public void updateQuestionnaire(Questionnaire q)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionnaireRepo.Ctx)");
            ctx.questionnaires.Update(q);
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionnaireRepo.Ctx)");
            ctx.SaveChanges();
        }

        public void deleteQuestionnaire(int questionnaireId)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionnaireRepo.Ctx)");
            ctx.questionnaires.Remove(ctx.questionnaires.Find(questionnaireId));
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionnaireRepo.Ctx)");
            ctx.SaveChanges();
        }

        public void updateQuestion(Question q)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionRepo.Ctx)");
            ctx.questions.Update(q);
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionRepo.Ctx)");
            ctx.SaveChanges();
        }

        public void deleteQuestion(int questionId)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionRepo.Ctx)");
            ctx.questions.Remove(ctx.questions.Find(questionId));
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionRepo.Ctx)");
            ctx.SaveChanges();
        }

        public void updateOption(Option o)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (OptionRepo.Ctx)");
            ctx.options.Update(o);
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (OptionRepo.Ctx)");
            ctx.SaveChanges();
        }

        public void deleteOption(int optionId)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (OptionRepo.Ctx)");
            ctx.options.Remove(ctx.options.Find(optionId));
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (OptionRepo.Ctx)");
            ctx.SaveChanges();
        }
        #endregion
    }
}