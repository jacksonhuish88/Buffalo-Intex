using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Buffalo_Intex.Data.Repositories;
using Buffalo_Intex.Models.ViewModels;

namespace Buffalo_Intex.Controllers
{
    public class HomeController : Controller
    {

        private IMummyRepository repo { get; set; }

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

        public IActionResult BurialSummary(string mummyCategory, int pageNum=1)
        {
            int pageSize = 10;
            var x = new MummyViewModel
            {
                // CALL AND ORDER BOOK REPO
                Burialmain = repo.Burialmain
                .Where(m => m.Depth == mummyCategory || mummyCategory == null) // Change this to be one of the filters
                .OrderBy(b => b.Sex)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                // ESTABLISH BOOK PAGE INFO 
                PageInfo = new PageInfo
                {
                    TotalNumMummies =
                        (mummyCategory == null
                            ? repo.Burialmain.Count()
                            : repo.Burialmain.Where(x => x.Depth == mummyCategory).Count()), // Depth should be a category filter
                    MummiesPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };
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
    }
}
