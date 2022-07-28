using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DSA_Tracker.Data;
using DSA_Tracker.Models;
using Microsoft.AspNetCore.Authorization;

namespace DSA_Tracker.Controllers
{
    [Authorize]
    public class ProblemController : Controller
    {
        private static ApplicationDbContext _context;

        public ProblemController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Problem
        // TRY IACTION
        [Authorize]
        public async Task<IActionResult> Index()
        {
            string userEmail = User.Identity.Name;
            /*
             *     List<Problem> problems = _context.Problems.ToList();
               ViewBag.Message = "Total";
               dynamic mymodel = new ExpandoObject();
               mymodel.Problems = problems;
               return _context.Problems != null ? 
                             View(await mymodel) :
                             Problem("Entity set 'ApplicationDbContext.Problems'  is null.");
             */
            ViewBag.Total = "Total Problems Solved: " + 
                _context.Problems
                .Where(user=>user.User.Email==userEmail)
                .ToList()
                .Count();
            return _context.Problems != null ? 
                          View(await _context.Problems
                          .Where(user=>user.User.Email==userEmail)
                          .ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Problems'  is null.");
        }

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
            List<Solution> solutions = _context
                .Solutions
                .Where(sol => sol.Problem.ProblemId == id)
                .ToList();
            ViewBag.TotalSolutions = solutions.Count();
            ViewData["solutions"] = solutions;

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
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProblemId,ProblemUrl,ProblemNumber,ProblemName,Note,NeedToRepeat,Date,DifficultyLevel,Platform,Tags")] Problem problem)
        {
            var username = User.Identity.Name;
            problem.User = _context.Users.Find(username);

            // modelstate.is valid => make it work
                // work here
                
                //problem.User.Email = userName;
                problem.Date = DateTime.Now;
                _context.Add(problem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
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

            //if (ModelState.IsValid){} => put try catch inside this

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
