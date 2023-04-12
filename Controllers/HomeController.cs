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

        private MummyDbContext context { get; set; }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MummyDbContext temp)
        {
            _logger = logger;
            context = temp;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult BurialSummary()
        {
            var data = context.Burialmain.ToList();
            return View(data);
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
