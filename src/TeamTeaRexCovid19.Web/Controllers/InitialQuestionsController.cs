using Microsoft.AspNetCore.Mvc;

namespace TeamTeaRexCovid19.Web.Controllers
{
    public class InitialQuestionsController : Controller
    {

        [HttpPost]
        public IActionResult InitialQuestions()
        {
            return RedirectToAction("CreateDailyQuestions", "DailyQuestions");
        }
    }
}