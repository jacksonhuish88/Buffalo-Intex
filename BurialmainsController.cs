using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Buffalo_Intex
{
    public class BurialmainsController : Controller
    {
        private readonly postgresContext _context;

        public BurialmainsController(postgresContext context)
        {
            _context = context;
        }

        // GET: Burialmains
        public async Task<IActionResult> Index()
        {
            return View(await _context.Burialmain.ToListAsync());
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
    }
}
