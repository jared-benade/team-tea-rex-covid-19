using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TeamTeaRexCovid19.Web.Controllers
{
    public class DailyQuestionsController : Controller
    {
        public ActionResult DailyQuestions()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitDailyQuestions(IFormCollection collection)
        {
            return RedirectToAction($"Reminder", $"DailyQuestions");
        }

        public ActionResult Reminder()
        {
            return View();
        }
    }
}