using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeamTeaRexCovid19.Domain.Interfaces;
using TeamTeaRexCovid19.Domain.Models;
using TeamTeaRexCovid19.Web.Models;

namespace TeamTeaRexCovid19.Web.Controllers
{
    public class InitialQuestionsController : Controller
    {
        private readonly IInitialQuestionsRepository _initialQuestionsRepository;

        public InitialQuestionsController(IInitialQuestionsRepository initialQuestionsRepository)
        {
            _initialQuestionsRepository = initialQuestionsRepository;
        }

        public IActionResult Index()
        {
            var userId = HttpContext.Session.GetString("UserIdSession");
            if (string.IsNullOrEmpty(userId))
                return RedirectToAction("Index", "Login");

            return View();
        }

        [HttpPost]
        public IActionResult InitialQuestions(InitialQuestionsViewModel viewModel)
        {
            if (string.IsNullOrEmpty(viewModel.Suburb) || string.IsNullOrEmpty(viewModel.DoesShareLivingSpace.ToString()))
                return View("Validation");

            var initialQuestions = new InitialQuestionsAnswer(viewModel.SelectedProvince, viewModel.Suburb, viewModel.SelectedAgeGroup, viewModel.IsSmoker, viewModel.IsDrinker,
                viewModel.DoesShareLivingSpace, viewModel.TransportType);

            _initialQuestionsRepository.AddAnswer(viewModel.UserId, initialQuestions);

            return RedirectToAction("Index", "DailyQuestions");
        }

        public IActionResult Validation()
        {
            return View();
        }
    }
}