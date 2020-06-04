using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeamTeaRexCovid19.Domain.Interfaces;
using TeamTeaRexCovid19.Domain.Models;
using TeamTeaRexCovid19.Web.Models;

namespace TeamTeaRexCovid19.Web.Controllers
{
    public class DailyQuestionsController : Controller
    {
        private readonly IDailyQuestionsRepository _dailyQuestionsRepository;

        public DailyQuestionsController(IDailyQuestionsRepository dailyQuestionsRepository)
        {
            _dailyQuestionsRepository = dailyQuestionsRepository;
        }

        public ActionResult Index()
        {
            var userId = HttpContext.Session.GetString("UserIdSession");
            if (string.IsNullOrEmpty(userId))
                return RedirectToAction("Index", "Login");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitDailyQuestions(DailyQuestionsViewModel dailyQuestionsViewModel)
        {
            var dailyQuestionsAnswer = new DailyQuestionsAnswer(viewModel.PeopleInteractedWith, viewModel.IsFever, viewModel.IsPersistentCough, viewModel.IsUnusualFatigue, viewModel.IsEatAnything, viewModel.FeelNormalRightNow, viewModel.IsLeaveHomeToday, viewModel.Treatment);

            _dailyQuestionsRepository.AddAnswer(viewModel.UserId, dailyQuestionsAnswer);

            return RedirectToAction("Reminder", "DailyQuestions");
        }

        public ActionResult Reminder()
        {
            HttpContext.Session.SetString("UserIdSession", string.Empty);
            return View();
        }
    }
}