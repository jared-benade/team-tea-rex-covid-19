using Microsoft.AspNetCore.Http;
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
            HttpContext.Session.SetString("UserIdSession", userId);
            return RedirectToAction("Index", isReturningUser ? "DailyQuestions" : "InitialQuestions");
        }
    }
}