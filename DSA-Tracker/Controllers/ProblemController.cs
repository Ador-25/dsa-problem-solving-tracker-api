using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DSA_Tracker.Data;
using DSA_Tracker.Models;

namespace DSA_Tracker.Controllers
{
    public class ProblemController : Controller
    {
        private static ApplicationDbContext _context;

        public ProblemController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Problem
        public async Task<IActionResult> Index()
        {
            /*
             *     List<Problem> problems = _context.Problems.ToList();
               ViewBag.Message = "Total";
               dynamic mymodel = new ExpandoObject();
               mymodel.Problems = problems;
               return _context.Problems != null ? 
                             View(await mymodel) :
                             Problem("Entity set 'ApplicationDbContext.Problems'  is null.");
             */
            ViewBag.Total = "Total Problems Solved: " + _context.Problems.ToList().Count();
            return _context.Problems != null ? 
                          View(await _context.Problems.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Problems'  is null.");
        }
        public int TotalNumberOfProblems()
        {
            return _context.Problems.Count();
;       }

        // GET: Problem/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Problems == null)
            {
                return NotFound();
            }

            var problem = await _context.Problems
                .FirstOrDefaultAsync(m => m.ProblemId == id);
            if (problem == null)
            {
                return NotFound();
            }

            return View(problem);
        }

        // GET: Problem/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Problem/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProblemId,ProblemUrl,ProblemNumber,ProblemName,Note,NeedToRepeat,Date,DifficultyLevel,Platform,Tags")] Problem problem)
        {
            if (ModelState.IsValid)
            {
                problem.Date = DateTime.Now;
                _context.Add(problem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(problem);
        }

        // GET: Problem/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Problems == null)
            {
                return NotFound();
            }

            var problem = await _context.Problems.FindAsync(id);
            if (problem == null)
            {
                return NotFound();
            }
            return View(problem);
        }

        // POST: Problem/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProblemId,ProblemUrl,ProblemNumber,ProblemName,Note,NeedToRepeat,Date,DifficultyLevel,Platform,Tags")] Problem problem)
        {
            if (id != problem.ProblemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(problem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProblemExists(problem.ProblemId))
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
            return View(problem);
        }

        // GET: Problem/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Problems == null)
            {
                return NotFound();
            }

            var problem = await _context.Problems
                .FirstOrDefaultAsync(m => m.ProblemId == id);
            if (problem == null)
            {
                return NotFound();
            }

            return View(problem);
        }

        // POST: Problem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Problems == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Problems'  is null.");
            }
            var problem = await _context.Problems.FindAsync(id);
            if (problem != null)
            {
                _context.Problems.Remove(problem);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProblemExists(int id)
        {
          return (_context.Problems?.Any(e => e.ProblemId == id)).GetValueOrDefault();
        }
    }
}
