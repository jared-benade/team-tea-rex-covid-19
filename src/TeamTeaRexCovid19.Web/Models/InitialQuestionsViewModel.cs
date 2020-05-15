using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TeamTeaRexCovid19.Web.Models
{
    public class InitialQuestionsViewModel
    {
        [DisplayName("What Province do you currently stay in?")]
        public string SelectedProvince { get; set; }
        public IEnumerable<SelectListItem> Provinces { get; set; }
       
        [DisplayName("What suburb do you currently stay in?")]
        public string Suburb { get; set; }

        [DisplayName("What is your Age Group?")]
        public string SelectedAgeGroup { get; set; }
        public IEnumerable<SelectListItem> AgeGroups { get; set; }

        [DisplayName("Do you Smoke?")]
        public bool IsSmoker { get; set; }
        
        [DisplayName("Do you drink?")]
        public bool IsDrinker { get; set; }

        [DisplayName("How many people do you share your living space with?")]
        public int DoesShareLivingSpace { get; set; }

        [DisplayName("What are you're means of transport?")]
        public string TransportType { get; set; }
        public IEnumerable<SelectListItem> TransportTypes { get; set; }
    }
}
