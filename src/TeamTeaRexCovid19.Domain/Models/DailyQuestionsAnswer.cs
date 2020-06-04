using System;

namespace TeamTeaRexCovid19.Domain.Models
{
    public class DailyQuestionsAnswer
    {
        public DailyQuestionsAnswer(string peopleInteractedWith, bool fever, bool persistentCough, bool unusualFatigue, bool eatAnything, bool feelNormalRightNow, bool leaveHomeToday, string treatment)
        {
            PeopleInteractedWith = peopleInteractedWith;
            Fever = fever;
            PersistentCough = persistentCough;
            UnusualFatigue = unusualFatigue;
            EatAnything = eatAnything;
            FeelNormalRightNow = feelNormalRightNow;
            LeaveHomeToday = leaveHomeToday;
            Treatment = treatment;
        }

        public string PeopleInteractedWith { get; set; }
        public bool Fever { get; set; }
        public bool PersistentCough { get; set; }
        public bool UnusualFatigue { get; set; }
        public bool EatAnything { get; set; }
        public bool FeelNormalRightNow { get; set; }
        public bool LeaveHomeToday { get; set; }
        public string Treatment { get; set; }
        public DateTime Timestamp => DateTime.Now;
    }
}