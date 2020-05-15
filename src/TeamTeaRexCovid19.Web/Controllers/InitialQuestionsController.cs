using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeamTeaRexCovid19.Web.Controllers
{
    public class InitialQuestionsController : Controller
    {
        public IActionResult InitialQuestions()
        {
            
            return View();
        }
    }
}