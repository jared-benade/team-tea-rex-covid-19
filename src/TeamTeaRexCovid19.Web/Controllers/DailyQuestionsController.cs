using Microsoft.AspNetCore.Mvc;
using TeamTeaRexCovid19.Domain.Models;
using TeamTeaRexCovid19.Web.Models;

namespace TeamTeaRexCovid19.Web.Controllers
{
    public class DailyQuestionsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult SubmitDailyQuestions(DailyQuestionsViewModel dailyQuestionsViewModel)
        {
            var dailyQuestionsList = new DailyQuestions(dailyQuestionsViewModel.PeopleInteractedWith, dailyQuestionsViewModel.IsFever, dailyQuestionsViewModel.IsPersistentCough, dailyQuestionsViewModel.IsUnusualFatigue, dailyQuestionsViewModel.IsEatAnything, dailyQuestionsViewModel.FeelRightNow, dailyQuestionsViewModel.IsLeaveHomeToday, dailyQuestionsViewModel.Treatment);

            

            return RedirectToAction("Reminder", "DailyQuestions");
        }

        public ActionResult Reminder()
        {
            return View();
        }
    }
}