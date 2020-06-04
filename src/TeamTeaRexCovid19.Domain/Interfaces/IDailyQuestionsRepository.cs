using TeamTeaRexCovid19.Domain.Models;

namespace TeamTeaRexCovid19.Domain.Interfaces
{
    public interface IDailyQuestionsRepository
    {
        void AddAnswer(string userId, DailyQuestionsAnswer dailyQuestionsAnswer);
    }
}