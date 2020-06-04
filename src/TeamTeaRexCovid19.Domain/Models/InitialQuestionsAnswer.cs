using System;

namespace TeamTeaRexCovid19.Domain.Models
{
    public class InitialQuestionsAnswer
    {
        public InitialQuestionsAnswer(string selectedProvince, string suburb, string selectedAgeGroup, bool isSmoker, bool isDrinker, int doesShareLivingSpace, string transportType)
        {
            SelectedProvince = selectedProvince;
            Suburb = suburb;
            SelectedAgeGroup = selectedAgeGroup;
            IsSmoker = isSmoker;
            IsDrinker = isDrinker;
            DoesShareLivingSpace = doesShareLivingSpace;
            TransportType = transportType;
        }

        public string SelectedProvince { get; set; }
        public string Suburb { get; set; }
        public string SelectedAgeGroup { get; set; }
        public bool IsSmoker { get; set; }
        public bool IsDrinker { get; set; }
        public int DoesShareLivingSpace { get; set; }
        public string TransportType { get; set; }
        public DateTime Timestamp => DateTime.Now;
    }
}