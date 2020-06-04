using System.ComponentModel.DataAnnotations;

namespace TeamTeaRexCovid19.Web.Models
{
    public class DailyQuestionsViewModel
    {
        [Required(ErrorMessage = "Please specify if you have interacted with any people recently")]
        public string PeopleInteractedWith { get; set; }

        [Required(ErrorMessage = "Please select if you have fever")]
        public bool IsFever { get; set; }

        [Required(ErrorMessage = "Please select if you have any cough")]
        public bool IsPersistentCough { get; set; }

        [Required(ErrorMessage = "Please select if you have any unusual fatigue")]
        public bool IsUnusualFatigue { get; set; }

        [Required(ErrorMessage = "Please select if you have eat anything that may cause you to feel sick")]
        public bool IsEatAnything { get; set; }

        [Required(ErrorMessage = "Please specify if you feel any pain")]
        public bool FeelNormalRightNow { get; set; }

        [Required(ErrorMessage = "Please select on how you feel ritght now")]
        public bool IsLeaveHomeToday { get; set; }

        [Required(ErrorMessage = "Please choose if you currently taking any medication")]
        public string Treatment { get; set; }

        public string UserId { get; set; }
    }
}
