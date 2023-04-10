using Buffalo_Intex.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Buffalo_Intex.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private SupervisedResponseContext saContext { get; set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
            return View();
        }

        [HttpPost]
        public IActionResult SupervisedAnalysis(SupervisedResponse ar)
        {

            saContext.Add(ar);
            saContext.SaveChanges();


            return View("Prediction", ar);
        }

        [HttpGet]

        public IActionResult SupervisedAnalysis()
        {
            var excavations saContext.Responses.ToList();

            return View(excavations);

        }

        public IActionResult UnsupervisedAnalysis()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
