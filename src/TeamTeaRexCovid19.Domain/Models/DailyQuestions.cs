namespace TeamTeaRexCovid19.Domain.Models
{
    public class DailyQuestions
    {
        public DailyQuestions(int peopleInteractedWith, bool fever, bool persistentCough, bool unusualFatigue, bool eatAnything, bool feelRightNow, bool leaveHomeToday, string treatment)
        {
            PeopleInteractedWith = peopleInteractedWith;
            Fever = fever;
            PersistentCough = persistentCough;
            UnusualFatigue = unusualFatigue;
            EatAnything = eatAnything;
            FeelRightNow = feelRightNow;
            LeaveHomeToday = leaveHomeToday;
            Treatment = treatment;
        }

        public int PeopleInteractedWith { get; set; }
        public bool Fever { get; set; }
        public bool PersistentCough { get; set; }
        public bool UnusualFatigue { get; set; }
        public bool EatAnything { get; set; }
        public bool FeelRightNow { get; set; }
        public bool LeaveHomeToday { get; set; }
        public string Treatment { get; set; }
    }
}