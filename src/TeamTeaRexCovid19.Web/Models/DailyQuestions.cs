namespace TeamTeaRexCovid19.Web.Models
{
    public class DailyQuestions
    {
        public string PeopleInteractedWith { get; set; }
        public bool Fever { get; set; }
        public bool PersistentCough { get; set; }
        public bool UnusualFatigue { get; set; }
        public bool EatAnything { get; set; }
        public string FeelRightNow { get; set; }
        public bool LeaveHomeToday { get; set; }
        public string Treatment { get; set; }
    }
}
