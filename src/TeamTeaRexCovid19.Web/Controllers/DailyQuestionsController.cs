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

        // GET: DailyQuestions/Create
        public ActionResult DailyQuestions()
        {
            return View();
        }

        // POST: DailyQuestions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateDailyQuestions(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                return RedirectToAction($"Reminder", $"DailyQuestions");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Reminder()
        {
            return View();
        }

    }
}