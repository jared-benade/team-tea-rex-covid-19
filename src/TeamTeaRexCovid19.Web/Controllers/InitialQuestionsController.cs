using Microsoft.AspNetCore.Mvc;

namespace TeamTeaRexCovid19.Web.Controllers
{
    public class InitialQuestionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InitialQuestions()
        {
            return RedirectToAction($"DailyQuestions", $"DailyQuestions");
        }
    }
}