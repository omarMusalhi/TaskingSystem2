using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaskingSystem2.Data;
using TaskingSystem2.Models;

namespace TaskingSystem2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DirectoratesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DirectoratesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Directorates
        public async Task<IActionResult> Index()
        {
            return View(await _context.Directorate.ToListAsync());
        }

        // GET: Admin/Directorates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var directorate = await _context.Directorate
                .FirstOrDefaultAsync(m => m.Id == id);
            if (directorate == null)
            {
                return NotFound();
            }

            return View(directorate);
        }

        // GET: Admin/Directorates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Directorates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Directorate directorate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(directorate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(directorate);
        }

        // GET: Admin/Directorates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var directorate = await _context.Directorate.FindAsync(id);
            if (directorate == null)
            {
                return NotFound();
            }
            return View(directorate);
        }

        // POST: Admin/Directorates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Directorate directorate)
        {
            if (id != directorate.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(directorate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DirectorateExists(directorate.Id))
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
            return View(directorate);
        }

        // GET: Admin/Directorates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var directorate = await _context.Directorate
                .FirstOrDefaultAsync(m => m.Id == id);
            if (directorate == null)
            {
                return NotFound();
            }

            return View(directorate);
        }

        // POST: Admin/Directorates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var directorate = await _context.Directorate.FindAsync(id);
            _context.Directorate.Remove(directorate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DirectorateExists(int id)
        {
            return _context.Directorate.Any(e => e.Id == id);
        }
    }
}
