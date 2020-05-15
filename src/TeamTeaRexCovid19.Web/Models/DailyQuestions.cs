using System.ComponentModel.DataAnnotations;

namespace TeamTeaRexCovid19.Web.Models
{
    public class DailyQuestions
    {
        [Required(ErrorMessage = "Please specify if you have interacted with any people recently")]
        public string PeopleInteractedWith { get; set; }

        [Required(ErrorMessage = "Please select if you have fever")]
        public bool Fever { get; set; }

        [Required(ErrorMessage = "Please select if you have any cough")]
        public bool PersistentCough { get; set; }

        [Required(ErrorMessage = "Please select if you have any unusual fatigue")]
        public bool UnusualFatigue { get; set; }

        [Required(ErrorMessage = "Please select if you have eat anything that may cause you to feel sick")]
        public bool EatAnything { get; set; }

        [Required(ErrorMessage = "Please specify if you feel any pain")]
        public string FeelRightNow { get; set; }

        [Required(ErrorMessage = "Please select on how you feel ritght now")]
        public bool LeaveHomeToday { get; set; }

        [Required(ErrorMessage = "Please choose if you currently taking any medication")]
        public string Treatment { get; set; }
    }
}
