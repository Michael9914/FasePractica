using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FasePractica.WebApp.Data;
using FasePractica.WebApp.Models;

namespace FasePractica.WebApp.Controllers
{
    public class ConveniosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ConveniosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Convenios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Convenios.ToListAsync());
        }

        // GET: Convenios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var convenio = await _context.Convenios
                .FirstOrDefaultAsync(m => m.DocumentoId == id);
            if (convenio == null)
            {
                return NotFound();
            }

            return View(convenio);
        }

        // GET: Convenios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Convenios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ConvenioId,FechaFinal,Descripcion,CantidadEstudiantes,DocumentoId,Codigo,FirmadoEl,AlmacenadoEn,Estado")] Convenio convenio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(convenio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(convenio);
        }

        // GET: Convenios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var convenio = await _context.Convenios.FindAsync(id);
            if (convenio == null)
            {
                return NotFound();
            }
            return View(convenio);
        }

        // POST: Convenios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ConvenioId,FechaFinal,Descripcion,CantidadEstudiantes,DocumentoId,Codigo,FirmadoEl,AlmacenadoEn,Estado")] Convenio convenio)
        {
            if (id != convenio.DocumentoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(convenio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConvenioExists(convenio.DocumentoId))
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
            return View(convenio);
        }

        // GET: Convenios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var convenio = await _context.Convenios
                .FirstOrDefaultAsync(m => m.DocumentoId == id);
            if (convenio == null)
            {
                return NotFound();
            }

            return View(convenio);
        }

        // POST: Convenios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var convenio = await _context.Convenios.FindAsync(id);
            _context.Convenios.Remove(convenio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConvenioExists(int id)
        {
            return _context.Convenios.Any(e => e.DocumentoId == id);
        }
    }
}
