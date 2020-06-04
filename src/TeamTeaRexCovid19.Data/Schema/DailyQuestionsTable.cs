using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamTeaRexCovid19.Data.Schema
{
    [Table("DailyQuestions")]
    public class DailyQuestionsTable
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string PeopleInteractedWith { get; set; }
        public bool Fever { get; set; }
        public bool PersistentCough { get; set; }
        public bool UnusualFatigue { get; set; }
        public bool EatAnything { get; set; }
        public bool FeelNormalRightNow { get; set; }
        public bool LeaveHomeToday { get; set; }
        public string Treatment { get; set; }
        public DateTime Timestamp { get; set; }
    }
}