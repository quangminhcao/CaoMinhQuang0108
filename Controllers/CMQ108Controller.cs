using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CAOMINHQUANG108.model;

namespace CaoMinhQuang108.Controllers
{
    public class CMQ108Controller : Controller
    {
        private readonly ApplicationDBcontext _context;

        public CMQ108Controller(ApplicationDBcontext context)
        {
            _context = context;
        }

        // GET: CMQ108
        public async Task<IActionResult> Index()
        {
            return View(await _context.CMQ108.ToListAsync());
        }

        // GET: CMQ108/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cMQ108 = await _context.CMQ108
                .FirstOrDefaultAsync(m => m.CMQId == id);
            if (cMQ108 == null)
            {
                return NotFound();
            }

            return View(cMQ108);
        }

        // GET: CMQ108/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CMQ108/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CMQId,CMQName,CMQGender")] CMQ108 cMQ108)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cMQ108);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cMQ108);
        }

        // GET: CMQ108/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cMQ108 = await _context.CMQ108.FindAsync(id);
            if (cMQ108 == null)
            {
                return NotFound();
            }
            return View(cMQ108);
        }

        // POST: CMQ108/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CMQId,CMQName,CMQGender")] CMQ108 cMQ108)
        {
            if (id != cMQ108.CMQId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cMQ108);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CMQ108Exists(cMQ108.CMQId))
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
            return View(cMQ108);
        }

        // GET: CMQ108/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cMQ108 = await _context.CMQ108
                .FirstOrDefaultAsync(m => m.CMQId == id);
            if (cMQ108 == null)
            {
                return NotFound();
            }

            return View(cMQ108);
        }

        // POST: CMQ108/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var cMQ108 = await _context.CMQ108.FindAsync(id);
            _context.CMQ108.Remove(cMQ108);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CMQ108Exists(string id)
        {
            return _context.CMQ108.Any(e => e.CMQId == id);
        }
    }
}
