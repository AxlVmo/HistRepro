using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HistRepro.Models;
using AspNetCoreHero.ToastNotification.Abstractions;
using Newtonsoft.Json;

namespace HistRepro.Controllers
{
    public class AforesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly INotyfService _notyf;

        public AforesController(ApplicationDbContext context, INotyfService notyf)
        {
            _context = context;
            _notyf = notyf;
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
        [HttpGet]
        public ActionResult f_historico(int id)
        {
            var h_afores = _context.BitacoraPrestadores.Where(s => s.IdControl == id).ToList();
            return Json(h_afores);
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
        public async Task<IActionResult> Create([Bind("Idafore,Claveconsar,Clavecorta,Fechaautorizacionoficio,Nombrecorto,Numerooficioautorizacion")] Afore afore)
        {

            var f_afore = _context.Afores.Where(s => s.Idafore > 5000).ToList();
            var c_afores = int.Parse(f_afore.Count().ToString()) + 1;
            var _idafores = 5000 + c_afores;

            var addParticipante = new Participante
            {
                Idparticipante = _idafores,
                Descripcion = afore.Nombrecorto,
                Fechaalta = DateTime.Now,
                Fechacambio = DateTime.Now,
                Fechaestatus = DateTime.Now,
                Paginainternet = afore.Nombrecorto,
                Razonsocial = afore.Nombrecorto,
                Rfc = afore.Nombrecorto,
            };
            _context.Add(addParticipante);

            afore.Idafore = _idafores;
            afore.Estatusparticipacion = "EN_AUTORIZACION";
            afore.Fechaaltaparticipacion = DateTime.Now;
            afore.Fechacambioparticipacion = DateTime.Now;
            afore.Fechaestatusparticipacion = DateTime.Now;
            afore.Responsableinformacion = "SIN DATOS";
            afore.Claveentidad = 0;
            afore.Descripcionentidad = "SIN DATOS";
            _context.Add(afore);

            string jsonString = afore.Idafore + "," + afore.Claveconsar + "," + afore.Clavecorta + "," + afore.Estatusparticipacion + "," + afore.Fechaaltaparticipacion + "," + afore.Fechaautorizacionoficio + "," + afore.Fechacambioparticipacion + "," + afore.Fechaestatusparticipacion + "," + afore.Nombrecorto + "," + afore.Numerooficioautorizacion + "," + afore.Responsableinformacion + "," + afore.Claveentidad + "," + afore.Descripcionentidad;

            var addMovimiento = new BitacoraPrestadore
            {
                IdControl = _idafores,
                IdTipoAccion = 1,
                NombreTabla = "AFORES",
                Contenido = jsonString,
                Usuario = "TEST",
                EstatusRegistro = 1,
                FechaRegistro = DateTime.Now
            };

            _context.Add(addMovimiento);
            _notyf.Success("Registro creado con éxito", 5);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
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


            try
            {
                int _idafores = int.Parse(afore.Idafore.ToString());
                string jsonString = afore.Idafore + "," + afore.Claveconsar + "," + afore.Clavecorta + "," + afore.Estatusparticipacion + "," + afore.Fechaaltaparticipacion + "," + afore.Fechaautorizacionoficio + "," + afore.Fechacambioparticipacion + "," + afore.Fechaestatusparticipacion + "," + afore.Nombrecorto + "," + afore.Numerooficioautorizacion + "," + afore.Responsableinformacion + "," + afore.Claveentidad + "," + afore.Descripcionentidad;

                var addMovimiento = new BitacoraPrestadore
                {
                    IdControl = _idafores,
                    IdTipoAccion = 2,
                    NombreTabla = "AFORES",
                    Contenido = jsonString,
                    Usuario = "TEST",
                    EstatusRegistro = 1,
                    FechaRegistro = DateTime.Now
                };
 _context.Add(addMovimiento);
                _context.Update(afore);
                await _context.SaveChangesAsync();
                _notyf.Warning("Registro actualizado con éxito", 5);
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
