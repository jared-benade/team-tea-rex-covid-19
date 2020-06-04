using TeamTeaRexCovid19.Domain.Models;

namespace TeamTeaRexCovid19.Domain.Interfaces
{
    public interface IInitialQuestionsRepository
    {
        void AddAnswer(string userId, InitialQuestionsAnswer initialQuestionsAnswer);
    }
}