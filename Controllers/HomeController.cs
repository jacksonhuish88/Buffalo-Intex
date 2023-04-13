using Buffalo_Intex.Models;
using Buffalo_Intex.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public IActionResult BurialSummary()
        {
            // var burials = repo.Burialmain.ToList();
            var b = new BurialmainViewModel
            {
                Burialmain = repo.Burialmain
            };
            return View(b);
        }

        //public IActionResult BurialSummary(string textileColor, string textileStructure, string sex, decimal? burialDepth, decimal? burialLength, decimal? ageAtDeath, string headDirection, string squareNorthSouth, string northSouth, string squareEastWest, string eastWest, string area, string burialNumber, string textileFunction, string hairColor, string colorValue, string structureValue, int pageNum = 1)
        //{
        //    //int pageSize = 10;

        //    var viewModel = new List<BurialTextileViewModel>();

        //    //var query = repo.Burialmain
        //    //                .Include(b => b.BurialmainTextiles)
        //    //                    .ThenInclude(t => t.Textile)
        //    //                        .ThenInclude(t => t.ColorTextiles)
        //    //                            .ThenInclude(c => c.Color);
        //    //.Include(t => t.StructureTextiles)
        //    //.ThenInclude(s => s.Structure)
        //    //.Include(t => t.TextileFunctions)
        //    //.ThenInclude(tf => tf.TextileFunction);


        //    //if (!string.IsNullOrEmpty(textileColor))
        //    //{
        //    //    query = query.Where(b => b.TextileColor == textileColor);
        //    //}

        //    //if (!string.IsNullOrEmpty(textileStructure))
        //    //{
        //    //    query = query.Where(b => b.TextileStructure == textileStructure);
        //    //}

        //    //if (!string.IsNullOrEmpty(sex))
        //    //{
        //    //    query = query.Where(b => b.Sex == sex);
        //    //}

        //    //if (burialDepth.HasValue)
        //    //{
        //    //    query = query.Where(b => b.BurialDepth == burialDepth.Value);
        //    //}

        //    //if (burialLength.HasValue)
        //    //{
        //    //    query = query.Where(b => b.BurialLength == burialLength.Value);
        //    //}

        //    //if (ageAtDeath.HasValue)
        //    //{
        //    //    query = query.Where(b => b.AgeAtDeath == ageAtDeath.Value);
        //    //}

        //    //if (!string.IsNullOrEmpty(headDirection))
        //    //{
        //    //    query = query.Where(b => b.HeadDirection == headDirection);
        //    //}

        //    //if (!string.IsNullOrEmpty(squareNorthSouth))
        //    //{
        //    //    query = query.Where(b => b.SquareNorthSouth == squareNorthSouth);
        //    //}

        //    //if (!string.IsNullOrEmpty(northSouth))
        //    //{
        //    //    query = query.Where(b => b.NorthSouth == northSouth);
        //    //}

        //    //if (!string.IsNullOrEmpty(squareEastWest))
        //    //{
        //    //    query = query.Where(b => b.SquareEastWest == squareEastWest);
        //    //}

        //    //if (!string.IsNullOrEmpty(eastWest))
        //    //{
        //    //    query = query.Where(b => b.EastWest == eastWest);
        //    //}

        //    //if (!string.IsNullOrEmpty(area))
        //    //{
        //    //    query = query.Where(b => b.Area == area);
        //    //}

        //    //if (!string.IsNullOrEmpty(burialNumber))
        //    //{
        //    //    query = query.Where(b => b.BurialNumber == burialNumber);
        //    //}

        //    //if (!string.IsNullOrEmpty(textileFunction))
        //    //{
        //    //    query = query.Where(b => b.Textile == textileFunction);
        //    //}

        //    //if (!string.IsNullOrEmpty(hairColor))
        //    //{
        //    //    query = query.Where(b => b.HairColor == hairColor);
        //    //}

        //    //if (!string.IsNullOrEmpty(colorValue))
        //    //{
        //    //    query = query.Where(b => b.Color.Value == colorValue);
        //    //}

        //    //if (!string.IsNullOrEmpty(structureValue))
        //    //{
        //    //    query = query.Where(b => b.Structure.Value == structureValue);
        //    //}

        //    //var burials = query.OrderBy(b => b.Id)
        //    //    .Skip((pageNum - 1) * pageSize)
        //    //    .Take(pageSize)
        //    //    .ToList();

        //    //foreach (var burial in burials)
        //    //{
        //    //    viewModel.Add(new BurialTextileViewModel
        //    //    {
        //    //        BurialId = burial.BurialId,
        //    //        BurialDepth = burial.BurialDepth,
        //    //        BurialLength = burial.BurialLength,
        //    //        AgeAtDeath = burial.AgeAtDeath,
        //    //        Sex = burial.Sex,
        //    //        HeadDirection = burial.HeadDirection,
        //    //        SquareNorthSouth = burial.SquareNorthSouth,
        //    //        NorthSouth = burial.NorthSouth,
        //    //        SquareEastWest = burial.SquareEastWest,
        //    //        EastWest = burial.EastWest,
        //    //        Area = burial.Area,
        //    //        BurialNumber = burial.BurialNumber,
        //    //        TextileFunction = burial.TextileFunction,
        //    //        TextileColor = burial.TextileColor,
        //    //        TextileStructure = burial.TextileStructure,
        //    //        HairColor = burial.HairColor,
        //    //        ColorValue = burial.Color.Value,
        //    //        StructureValue = burial.Structure.Value
        //    //    });
        //    //}

        //    //var pageInfo = new PageInfo
        //    //{
        //    //    TotalNumBurials = query.Count(),
        //    //    BurialsPerPage = pageSize,
        //    //    CurrentPage = pageNum
        //    //};

        //    //var filterInfo = new FilterInfo
        //    //{
        //    //    TextileColor = textileColor,
        //    //    TextileStructure = textileStructure,
        //    //    Sex = sex,
        //    //    BurialDepth = burialDepth,
        //    //    BurialLength = burialLength,
        //    //    AgeAtDeath = ageAtDeath,
        //    //    HeadDirection = headDirection,
        //    //    SquareNorthSouth = squareNorthSouth,
        //    //    NorthSouth = northSouth,
        //    //    SquareEastWest = squareEastWest,
        //    //    EastWest = eastWest,
        //    //    Area = area,
        //    //    BurialNumber = burialNumber,
        //    //    TextileFunction = textileFunction,
        //    //    HairColor = hairColor,
        //    //    ColorValue = colorValue,
        //    //    StructureValue = structureValue
        //    //};

        //    //var burialTextileListViewModel = new BurialTextileListViewModel
        //    //{
        //        //Burials = viewModel,
        //        //PageInfo = pageInfo,
        //        //FilterInfo = filterInfo
        //    //};

        //    // return View(burialTextileListViewModel);
        //    return View(viewModel);
        //}

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
