using Microsoft.AspNetCore.Mvc;
using TeamTeaRexCovid19.Domain.Models;

namespace TeamTeaRexCovid19.Web.Controllers
{
    public class DailyQuestionsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitDailyQuestions(string PeopleInteractedWith, bool Fever, bool PersistentCough, bool UnusualFatigue, bool EatAnything, bool FeelRightNow, bool LeaveHomeToday, string Treatment, string userId)
        {
            var dailyQuestions = new DailyQuestions(PeopleInteractedWith, Fever, PersistentCough, UnusualFatigue, EatAnything, FeelRightNow, LeaveHomeToday, Treatment);
            return RedirectToAction("Reminder", "DailyQuestions");
        }

        public ActionResult Reminder()
        {
            return View();
        }
    }
}