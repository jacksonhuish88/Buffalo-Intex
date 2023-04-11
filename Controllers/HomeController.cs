using Buffalo_Intex.Models;
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
        private IMummyRepository repo;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IMummyRepository temp)
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

        public IActionResult BurialSummary(int pageNum = 1)
        {
            //var tables = new BurialSummaryViewModel
            //{
            //    Color = repo.Color.ToList(),
            //    Bodyanalysischart = repo.Bodyanalysischart.ToList(),
            //    Textilefunction = repo.Textilefunction.ToList(),
            //    Structure = repo.Structure.ToList(),
            //    Burialmain = repo.Burialmain.ToList(),

            //};

            var numResults = 20;

            var temp = repo.Burialmain
                .ToList()
                .Skip((pageNum - 1) * numResults)
                .Take(numResults);

            return View(temp);
        }

        public IActionResult SupervisedAnalysis()
        {
            var temp = repo.Bodyanalysischart.ToList();

            return View(temp);

        }

        public IActionResult UnsupervisedAnalysis()
        {
            return View();
        }

        public IActionResult RegistrationConfirmation()
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
