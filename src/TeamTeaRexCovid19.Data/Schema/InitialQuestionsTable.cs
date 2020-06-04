using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamTeaRexCovid19.Data.Schema
{
    [Table("InitialQuestions")]
    public class InitialQuestionsTable
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string SelectedProvince { get; set; }
        public string Suburb { get; set; }
        public string SelectedAgeGroup { get; set; }
        public bool IsSmoker { get; set; }
        public bool IsDrinker { get; set; }
        public int DoesShareLivingSpace { get; set; }
        public string TransportType { get; set; }
        public DateTime Timestamp { get; set; }
    }
}