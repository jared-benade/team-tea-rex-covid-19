using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            return RedirectToAction("Reminder", "DailyQuestions");
        }

        public ActionResult Reminder()
        {
            return View();
        }
    }
}