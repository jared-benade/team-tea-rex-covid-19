using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TeamTeaRexCovid19.Web.Models
{
    public class InitialQuestionsViewModel
    {
        [DisplayName("What Province do you currently stay in?")]
        [Required(ErrorMessage = "Please select a province")]
        public string SelectedProvince { get; set; }
        public IEnumerable<SelectListItem> Provinces { get; set; }
       
        [DisplayName("What suburb do you currently stay in?")]
        [Required(ErrorMessage = "Please specify where you stay")]
        public string Suburb { get; set; }

        [DisplayName("What is your Age Group?")]
        [Required(ErrorMessage = "Please select your age group")]
        public string SelectedAgeGroup { get; set; }
        public IEnumerable<SelectListItem> AgeGroups { get; set; }

        [DisplayName("Do you Smoke?")]
        [Required(ErrorMessage = "Please specify if you do smoke")]
        public bool IsSmoker { get; set; }
        
        [DisplayName("Do you drink?")]
        [Required(ErrorMessage = "Please specify if you drink ")]
        public bool IsDrinker { get; set; }

        [DisplayName("How many people do you share your living space with?")]
        [Required(ErrorMessage = "Please specify if you living with someone")]
        public int DoesShareLivingSpace { get; set; }

        [DisplayName("What are you're means of transport?")]
        [Required(ErrorMessage = "Please specify the type of transport you use")]
        public string TransportType { get; set; }

        public string UserId { get; set; }
    }
}
