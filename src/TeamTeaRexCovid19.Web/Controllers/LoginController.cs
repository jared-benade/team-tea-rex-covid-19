using Microsoft.AspNetCore.Mvc;

namespace TeamTeaRexCovid19.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string userId, bool isReturningUser)
        {
            return RedirectToAction("Index", isReturningUser ? "DailyQuestions" : "InitialQuestions");
        }
    }
}