using TeamTeaRexCovid19.Data.Schema;
using TeamTeaRexCovid19.Domain.Interfaces;
using TeamTeaRexCovid19.Domain.Models;

namespace TeamTeaRexCovid19.Data.Repositories
{
    public class DailyQuestionsRepository : IDailyQuestionsRepository
    {
        private readonly Covid19DbContext _dbContext;

        public DailyQuestionsRepository(Covid19DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddAnswer(string userId, DailyQuestionsAnswer dailyQuestionsAnswer)
        {
            var dailyQuestionsEntity = new DailyQuestionsTable
            {
                UserId = userId,
                Timestamp = dailyQuestionsAnswer.Timestamp,
                Fever = dailyQuestionsAnswer.Fever,
                PersistentCough = dailyQuestionsAnswer.PersistentCough,
                UnusualFatigue = dailyQuestionsAnswer.UnusualFatigue,
                EatAnything = dailyQuestionsAnswer.EatAnything,
                PeopleInteractedWith = dailyQuestionsAnswer.PeopleInteractedWith,
                FeelNormalRightNow = dailyQuestionsAnswer.FeelNormalRightNow,
                LeaveHomeToday = dailyQuestionsAnswer.LeaveHomeToday,
                Treatment = dailyQuestionsAnswer.Treatment
            };
            _dbContext.DailyQuestions.Add(dailyQuestionsEntity);
            _dbContext.SaveChanges();
        }
    }
}