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
            var numResults = 20;

            //var x = new BurialSummaryViewModel
            //{
            //    Burialmain = (IQueryable<Burialmain>)repo.Burialmain
            //    .ToList()
            //    .Skip((pageNum - 1) * numResults)
            //    .Take(numResults),

            //    PageInfo = new PageInfo
            //    {
            //        TotalNumMummy = repo.Burialmain.Count(),
            //        MummyPerPage = numResults,
            //        CurrentPage = pageNum
            //    }
            //};

            var x = repo.Burialmain
                .ToList()
                .Skip((pageNum - 1) * numResults)
                .Take(numResults);

            return View(x);
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

        [HttpPost]
        public IActionResult AdminCRUD()
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
