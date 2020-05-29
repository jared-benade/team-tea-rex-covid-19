﻿using Microsoft.AspNetCore.Mvc;
using TeamTeaRexCovid19.Domain.Models;

namespace TeamTeaRexCovid19.Web.Controllers
{
    public class InitialQuestionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InitialQuestions(string SelectedProvince, string Suburb, string SelectedAgeGroup, bool IsSmoker,
            bool IsDrinker, int DoesShareLivingSpace, string TransportType, string userId)
        {
            if (string.IsNullOrEmpty(Suburb) || string.IsNullOrEmpty(DoesShareLivingSpace.ToString()))
                return View("Validation");

            var initialQuestions = new InitialQuestions(SelectedProvince, Suburb, SelectedAgeGroup, IsSmoker, IsDrinker, DoesShareLivingSpace, TransportType);

            return RedirectToAction("Index", "DailyQuestions");
        }

        public IActionResult Validation()
        {
            return View();
        }
    }
}