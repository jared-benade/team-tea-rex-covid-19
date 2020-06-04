using TeamTeaRexCovid19.Data.Schema;
using TeamTeaRexCovid19.Domain.Interfaces;
using TeamTeaRexCovid19.Domain.Models;

namespace TeamTeaRexCovid19.Data.Repositories
{
    public class InitialQuestionsRepository : IInitialQuestionsRepository
    {
        private readonly Covid19DbContext _dbContext;

        public InitialQuestionsRepository(Covid19DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddAnswer(string userId, InitialQuestionsAnswer initialQuestionsAnswer)
        {
            var initialQuestionEntity = new InitialQuestionsTable
            {
                SelectedProvince = initialQuestionsAnswer.SelectedProvince, 
                Suburb = initialQuestionsAnswer.Suburb,
                SelectedAgeGroup = initialQuestionsAnswer.SelectedAgeGroup,
                IsSmoker = initialQuestionsAnswer.IsSmoker,
                IsDrinker = initialQuestionsAnswer.IsDrinker,
                DoesShareLivingSpace = initialQuestionsAnswer.DoesShareLivingSpace,
                TransportType = initialQuestionsAnswer.TransportType,
                UserId = userId,
                Timestamp = initialQuestionsAnswer.Timestamp
            };
            _dbContext.InitialQuestions.Add(initialQuestionEntity);
            _dbContext.SaveChanges();
        }
    }
}