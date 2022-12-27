using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HistRepro.Models;

namespace HistRepro.Controllers
{
    public class AforesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AforesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Afores
        public async Task<IActionResult> Index()
        {
            var _afores = _context.Afores.Where(s => s.Idafore > 5000).ToListAsync();
            return View(await _afores);
        }

        // GET: Afores/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.Afores == null)
            {
                return NotFound();
            }

            var afore = await _context.Afores
                .Include(a => a.IdaforeNavigation)
                .FirstOrDefaultAsync(m => m.Idafore == id);
            if (afore == null)
            {
                return NotFound();
            }

            return View(afore);
        }

        // GET: Afores/Create
        public IActionResult Create()
        {
            ViewData["Idafore"] = new SelectList(_context.Participantes, "Idparticipante", "Idparticipante");
            return View();
        }

        // POST: Afores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idafore,Claveconsar,Clavecorta,Estatusparticipacion,Fechaaltaparticipacion,Fechaautorizacionoficio,Fechacambioparticipacion,Fechaestatusparticipacion,Nombrecorto,Numerooficioautorizacion,Responsableinformacion,Claveentidad,Descripcionentidad")] Afore afore)
        {
            if (ModelState.IsValid)
            {
                _context.Add(afore);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Idafore"] = new SelectList(_context.Participantes, "Idparticipante", "Idparticipante", afore.Idafore);
            return View(afore);
        }

        // GET: Afores/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.Afores == null)
            {
                return NotFound();
            }

            var afore = await _context.Afores.FindAsync(id);
            if (afore == null)
            {
                return NotFound();
            }
            ViewData["Idafore"] = new SelectList(_context.Participantes, "Idparticipante", "Idparticipante", afore.Idafore);
            return View(afore);
        }

        // POST: Afores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Idafore,Claveconsar,Clavecorta,Estatusparticipacion,Fechaaltaparticipacion,Fechaautorizacionoficio,Fechacambioparticipacion,Fechaestatusparticipacion,Nombrecorto,Numerooficioautorizacion,Responsableinformacion,Claveentidad,Descripcionentidad")] Afore afore)
        {
            if (id != afore.Idafore)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(afore);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AforeExists(afore.Idafore))
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
            ViewData["Idafore"] = new SelectList(_context.Participantes, "Idparticipante", "Idparticipante", afore.Idafore);
            return View(afore);
        }

        // GET: Afores/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.Afores == null)
            {
                return NotFound();
            }

            var afore = await _context.Afores
                .Include(a => a.IdaforeNavigation)
                .FirstOrDefaultAsync(m => m.Idafore == id);
            if (afore == null)
            {
                return NotFound();
            }

            return View(afore);
        }

        // POST: Afores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.Afores == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Afores'  is null.");
            }
            var afore = await _context.Afores.FindAsync(id);
            if (afore != null)
            {
                _context.Afores.Remove(afore);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AforeExists(long id)
        {
          return _context.Afores.Any(e => e.Idafore == id);
        }
    }
}
