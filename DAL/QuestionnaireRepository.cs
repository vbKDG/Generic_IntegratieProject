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
            qu.Confirmed = false;
            if (!(userId == ""))
            {
                qu.User = ctx.Users.Find(userId);
                qu.Confirmed = true;
            }
            qu.Question = ctx.Questions.Find(questionId);
            qu.Answer = answer;
            ctx.QuestionUsers.Add(qu);
            ctx.SaveChanges();
        }

        public IEnumerable<Questionnaire> readQuestionnaires(int projectId)
        {
            return ctx.Questionnaires
                .Include(q => q.Project)
                .Where(q => q.Project.ProjectId == projectId);
        }

        public IEnumerable<IotSetup> readIotSetups()
        {
            return ctx.IotSetups.AsEnumerable();
        }

        public IEnumerable<Question> readQuestions(int questionnaireId)
        {
            return ctx.Questions
                .Include(q => q.Questionnaire)
                .Include(q => q.Options)
                .Include(q => q.IotSetup)
                .Where(q => q.Questionnaire.QuestionnaireId == questionnaireId);
        }

        public IEnumerable<Option> readOptions(int questionId)
        {
            return ctx.Options
                .Where(o => o.Question.QuestionId == questionId);
        }

        public IEnumerable<QuestionUser> readQuestionUsers(int questionnaireId)
        {
            IList<QuestionUser> questionUsers = new List<QuestionUser>();
            foreach (var q in ctx.Questions.Where(q => q.Questionnaire.QuestionnaireId == questionnaireId))
            {
                foreach (var qu in ctx.QuestionUsers.Where(qu => qu.Question.QuestionId == q.QuestionId))
                {
                    questionUsers.Add(qu);
                }
            }
            return questionUsers;
        }
        
        public IEnumerable<QuestionUser> readQuestionUsers()
        {
            return ctx.QuestionUsers;
        }

        public void createQuestionnaire(Questionnaire q, int projectId)
        {
            q.Project = ctx.Projects.Find(projectId);
            ctx.Questionnaires.Add(q);
            foreach (Question question in q.Questions)
            {
                question.Questionnaire = ctx.Questionnaires.Find(q.QuestionnaireId);
                ctx.Questions.Add(question);
            }
            ctx.SaveChanges();
        }

        public void createQuestion(Question q)
        {
            ctx.Questions.Add(q);
            ctx.SaveChanges();
        }

        public void createOption(Option o)
        {
            ctx.Options.Add(o);
            ctx.SaveChanges();
        }

        public Questionnaire readQuestionnaire(int questionnaireId)
        {
            return ctx.Questionnaires.Find(questionnaireId);
        }

        public QuestionUser readQuestionUser(int questionUserId)
        {
            return ctx.QuestionUsers.Find(questionUserId);
        }

        public Question readQuestion(int questionId)
        {
            return ctx.Questions.Find(questionId);
        }
        
        public void deleteQuestionUser(int questionUserId)
        {
            ctx.QuestionUsers.Remove(ctx.QuestionUsers.Find(questionUserId));
            ctx.SaveChanges();
        }

        public void updateQuestionnaire(Questionnaire q)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionnaireRepo.Ctx)");
            ctx.Questionnaires.Update(q);
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionnaireRepo.Ctx)");
            ctx.SaveChanges();
        }

        public void deleteQuestionnaire(int questionnaireId)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionnaireRepo.Ctx)");
            ctx.Questionnaires.Remove(ctx.Questionnaires.Find(questionnaireId));
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionnaireRepo.Ctx)");
            ctx.SaveChanges();
        }

        public void updateQuestionUser(QuestionUser questionUser)
        {
            ctx.QuestionUsers.Update(questionUser);
            ctx.SaveChanges();
        }

        public void updateQuestion(Question q)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionRepo.Ctx)");
            ctx.Questions.Update(q);
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionRepo.Ctx)");
            ctx.SaveChanges();
        }

        public void deleteQuestion(int questionId)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionRepo.Ctx)");
            ctx.Questions.Remove(ctx.Questions.Find(questionId));
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionRepo.Ctx)");
            ctx.SaveChanges();
        }

        public void updateOption(Option o)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (OptionRepo.Ctx)");
            ctx.Options.Update(o);
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (OptionRepo.Ctx)");
            ctx.SaveChanges();
        }

        public void deleteOption(int optionId)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (OptionRepo.Ctx)");
            ctx.Options.Remove(ctx.Options.Find(optionId));
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (OptionRepo.Ctx)");
            ctx.SaveChanges();
        }
        #endregion
    }
}