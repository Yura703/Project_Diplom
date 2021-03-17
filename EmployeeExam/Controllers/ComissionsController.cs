using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeExam.Data;
using EmployeeExam.Data.Entities;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeExam.Controllers
{
    public class ComissionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComissionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Comissions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Comissions.ToListAsync());
        }

        // GET: Comissions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comission = await _context.Comissions
                .FirstOrDefaultAsync(m => m.Comission_id == id);
            if (comission == null)
            {
                return NotFound();
            }

            return View(comission);
        }


        // GET: Comissions/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Comissions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("Comission_id,NamberComission,FIO,Head,Role,Description")] Comission comission)
        {
            if (ModelState.IsValid)
            {
                _context.Add(comission);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comission);
        }

        // GET: Comissions/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comission = await _context.Comissions.FindAsync(id);
            if (comission == null)
            {
                return NotFound();
            }
            return View(comission);
        }

        // POST: Comissions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("Comission_id,NamberComission,FIO,Head,Role,Description")] Comission comission)
        {
            if (id != comission.Comission_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comission);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComissionExists(comission.Comission_id))
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
            return View(comission);
        }

        // GET: Comissions/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comission = await _context.Comissions
                .FirstOrDefaultAsync(m => m.Comission_id == id);
            if (comission == null)
            {
                return NotFound();
            }

            return View(comission);
        }

        // POST: Comissions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var comission = await _context.Comissions.FindAsync(id);
            _context.Comissions.Remove(comission);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComissionExists(int id)
        {
            return _context.Comissions.Any(e => e.Comission_id == id);
        }
    }
}
