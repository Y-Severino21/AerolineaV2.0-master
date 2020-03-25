using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AerolineaV1.Models;

namespace AerolineaV1.Controllers
{
    public class AvionController : Controller
    {
        private readonly AvionContext _context;

        public AvionController(AvionContext context)
        {
            _context = context;
        }

        // GET: Avion
        public async Task<IActionResult> Index()
        {
            return View(await _context.Aviones.ToListAsync());
        }

        // GET: Avion/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Avion());
            else
                return View(_context.Aviones.Find(id));
        }

        // POST: Avion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("AvionID,Modelo,Capacidad,TipoAvion,CantMotor,Velocidad")] Avion avion)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (avion.AvionID == 0)
                        _context.Add(avion);
                    else
                        _context.Update(avion);
                    await _context.SaveChangesAsync();

                }catch(Exception e)
                {
                    //ModelState.AddModelError("");
                }

                return RedirectToAction(nameof(Index));
            }
            
            return View(avion);
        }

        // GET: Avion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var avi = await _context.Aviones.FindAsync(id);
            _context.Aviones.Remove(avi);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}
