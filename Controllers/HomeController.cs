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

        private MummyDbContext repo { get; set; }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MummyDbContext temp)
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
            // var data = repo.Burialmain.ToList();
            return View();
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
