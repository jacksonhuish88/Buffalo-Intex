using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Buffalo_Intex;

namespace Buffalo_Intex.Controllers
{
    public class BurialmainsController : Controller
    {
        private readonly postgresContext _context;

        public BurialmainsController(postgresContext context)
        {
            _context = context;
        }

        // GET: Burialmains
        public IActionResult Index(int pageNum = 1)
        {
            int pageSize = 25; // number of records per page

            // calculate the number of records to skip based on the current page number and page size
            int skip = (pageNum - 1) * pageSize;

            // retrieve a subset of the data from the database using Skip() and Take() methods
            var burials = _context.Burialmain
                .Skip(skip)
                .Take(pageSize)
                .ToList();

            // calculate the total number of pages based on the total number of records and page size
            int totalPages = (int)Math.Ceiling(_context.Burialmain.Count() / (double)pageSize);

            // pass the subset of data and pagination information to the view
            ViewBag.CurrentPage = pageNum;
            ViewBag.TotalPages = totalPages;

            return View(burials);
        }

        // GET: Burialmains/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burialmain = await _context.Burialmain
                .FirstOrDefaultAsync(m => m.Id == id);
            if (burialmain == null)
            {
                return NotFound();
            }

            return View(burialmain);
        }

        // GET: Burialmains/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Burialmains/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Squarenorthsouth,Headdirection,Sex,Northsouth,Depth,Eastwest,Adultsubadult,Facebundles,Southtohead,Preservation,Fieldbookpage,Squareeastwest,Goods,Text,Wrapping,Haircolor,Westtohead,Samplescollected,Area,Burialid,Length,Burialnumber,Dataexpertinitials,Westtofeet,Ageatdeath,Southtofeet,Excavationrecorder,Photos,Hair,Burialmaterials,Dateofexcavation,Fieldbookexcavationyear,Clusternumber,Shaftnumber")] Burialmain burialmain)
        {
            if (ModelState.IsValid)
            {
                _context.Add(burialmain);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(burialmain);
        }

        // GET: Burialmains/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burialmain = await _context.Burialmain.FindAsync(id);
            if (burialmain == null)
            {
                return NotFound();
            }
            return View(burialmain);
        }

        // POST: Burialmains/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Squarenorthsouth,Headdirection,Sex,Northsouth,Depth,Eastwest,Adultsubadult,Facebundles,Southtohead,Preservation,Fieldbookpage,Squareeastwest,Goods,Text,Wrapping,Haircolor,Westtohead,Samplescollected,Area,Burialid,Length,Burialnumber,Dataexpertinitials,Westtofeet,Ageatdeath,Southtofeet,Excavationrecorder,Photos,Hair,Burialmaterials,Dateofexcavation,Fieldbookexcavationyear,Clusternumber,Shaftnumber")] Burialmain burialmain)
        {
            if (id != burialmain.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(burialmain);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BurialmainExists(burialmain.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(burialmain);
        }

        // GET: Burialmains/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var burialmain = await _context.Burialmain
                .FirstOrDefaultAsync(m => m.Id == id);
            if (burialmain == null)
            {
                return NotFound();
            }

            return View(burialmain);
        }

        // POST: Burialmains/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var burialmain = await _context.Burialmain.FindAsync(id);
            _context.Burialmain.Remove(burialmain);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BurialmainExists(long id)
        {
            return _context.Burialmain.Any(e => e.Id == id);
        }

        // GET FILTER
        public IActionResult Filter()
        {
            return View();
        }
        public IActionResult FilterMummies(string sex, string burialdepth, string estimatestature, string ageatdeath, string headdirection, string squarenorthsouth, string northsouth, string squareeastwest, string eastwest, string area, string burialnumber, string haircolor)
        {
            var burials = _context.Burialmain;

            // Your code to filter records based on the form values goes here
            var filteredRecords = burials.Where(b =>
           (string.IsNullOrEmpty(sex) || b.Sex == sex) &&
           (string.IsNullOrEmpty(burialdepth) || b.Depth == burialdepth) &&
           (string.IsNullOrEmpty(estimatestature) || b.Length == estimatestature) &&
           (string.IsNullOrEmpty(ageatdeath) || b.Ageatdeath == ageatdeath) &&
           (string.IsNullOrEmpty(headdirection) || b.Headdirection == headdirection) &&
           (string.IsNullOrEmpty(squarenorthsouth) || b.Squarenorthsouth == squarenorthsouth) &&
           (string.IsNullOrEmpty(northsouth) || b.Northsouth == northsouth) &&
           (string.IsNullOrEmpty(squareeastwest) || b.Squareeastwest == squareeastwest) &&
           (string.IsNullOrEmpty(eastwest) || b.Eastwest == eastwest) &&
           (string.IsNullOrEmpty(area) || b.Area == area) &&
           (string.IsNullOrEmpty(burialnumber) || b.Burialnumber == burialnumber) &&
           (string.IsNullOrEmpty(haircolor) || b.Haircolor == haircolor)).ToList();

            // Return the filtered records to the BurialRecord view
            return View("Index", filteredRecords);
        }

        //Clear Filter
        public IActionResult ClearFilter()
        {
            return RedirectToAction("Index");
        }
    }
}

