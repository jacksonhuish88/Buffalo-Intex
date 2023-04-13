using Buffalo_Intex.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Buffalo_Intex.Controllers
{
    public class HomeController : Controller
    {

        private postgresContext repo { get; set; }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, postgresContext temp)
        {
            _logger = logger;
            repo = temp;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AdminCrud()
        {
            return View();
        }

        public IActionResult BurialSummary()
        {
            // var burials = repo.Burialmain.ToList();
            var b = new BurialmainViewModel
            {
                Burialmain = repo.Burialmain
            };
            return View(b);
        }

        public IActionResult SupervisedAnalysis()
        {
            return View();

        }

        public IActionResult UnsupervisedAnalysis()
        {
            return View();
        }

        public IActionResult RegistrationConfirmation()
        {
            return View();
        }
    }
}
