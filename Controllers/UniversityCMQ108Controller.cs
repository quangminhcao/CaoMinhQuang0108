using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CaoMinhQuang108.Models;

namespace CaoMinhQuang108.Controllers
{
    public class UniversityCMQ108Controller : Controller
    {
        private readonly ApplicationDBcontext _context;

        public UniversityCMQ108Controller(ApplicationDBcontext context)
        {
            _context = context;
        }

        // GET: UniversityCMQ108
        public async Task<IActionResult> Index()
        {
            return View(await _context.UniversityCMQ108.ToListAsync());
        }

        // GET: UniversityCMQ108/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityCMQ108 = await _context.UniversityCMQ108
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityCMQ108 == null)
            {
                return NotFound();
            }

            return View(universityCMQ108);
        }

        // GET: UniversityCMQ108/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UniversityCMQ108/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UniversityId,UniversityName")] UniversityCMQ108 universityCMQ108)
        {
            if (ModelState.IsValid)
            {
                _context.Add(universityCMQ108);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(universityCMQ108);
        }

        // GET: UniversityCMQ108/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityCMQ108 = await _context.UniversityCMQ108.FindAsync(id);
            if (universityCMQ108 == null)
            {
                return NotFound();
            }
            return View(universityCMQ108);
        }

        // POST: UniversityCMQ108/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UniversityId,UniversityName")] UniversityCMQ108 universityCMQ108)
        {
            if (id != universityCMQ108.UniversityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(universityCMQ108);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UniversityCMQ108Exists(universityCMQ108.UniversityId))
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
            return View(universityCMQ108);
        }

        // GET: UniversityCMQ108/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityCMQ108 = await _context.UniversityCMQ108
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityCMQ108 == null)
            {
                return NotFound();
            }

            return View(universityCMQ108);
        }

        // POST: UniversityCMQ108/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var universityCMQ108 = await _context.UniversityCMQ108.FindAsync(id);
            _context.UniversityCMQ108.Remove(universityCMQ108);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UniversityCMQ108Exists(string id)
        {
            return _context.UniversityCMQ108.Any(e => e.UniversityId == id);
        }
    }
}
