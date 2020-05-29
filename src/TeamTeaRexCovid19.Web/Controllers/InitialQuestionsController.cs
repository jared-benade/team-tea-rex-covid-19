using Microsoft.AspNetCore.Mvc;
using TeamTeaRexCovid19.Domain.Models;
using TeamTeaRexCovid19.Web.Models;

namespace TeamTeaRexCovid19.Web.Controllers
{
    public class InitialQuestionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InitialQuestions(InitialQuestionsViewModel initialQuestionsViewModel)
        {
            if (string.IsNullOrEmpty(initialQuestionsViewModel.Suburb) || string.IsNullOrEmpty(initialQuestionsViewModel.DoesShareLivingSpace.ToString()))
                return View("Validation");

            var initialQuestions = new InitialQuestions(initialQuestionsViewModel.SelectedProvince, initialQuestionsViewModel.Suburb, 
                initialQuestionsViewModel.SelectedAgeGroup, initialQuestionsViewModel.IsSmoker, initialQuestionsViewModel.IsDrinker,
                initialQuestionsViewModel.DoesShareLivingSpace, initialQuestionsViewModel.TransportType);

            return RedirectToAction("Index", "DailyQuestions");
        }

        public IActionResult Validation()
        {
            return View();
        }
    }
}