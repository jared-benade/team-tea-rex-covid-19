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
        [Description("What Province do you currently stay in?")]
        public string SelectedProvince { get; set; }
        public IEnumerable<SelectListItem> Provinces { get; set; }
       
        [Description("What suburb do you currently stay in?")]
        public string Suburb { get; set; }

        [Description("What is your Age Group?")]
        public string SelectedAgeGroup { get; set; }
        public IEnumerable<SelectListItem> AgeGroups { get; set; }

        [Description("Do you Smoke?")]
        public bool IsSmoker { get; set; }
        
        [Description("Do you drink?")]
        public bool IsDrinker { get; set; }

        [Description("How many people do you share your living space with?")]
        public int DoesShareLivingSpace { get; set; }

        [Description("What are you're means of transport?")]
        public bool TransportType { get; set; }
        public IEnumerable<SelectListItem> TransportTypes { get; set; }
    }
}
