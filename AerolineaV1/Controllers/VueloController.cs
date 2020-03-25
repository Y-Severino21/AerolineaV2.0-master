using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using AerolineaV1.Models;

namespace AerolineaV1.Controllers
{
    public class VueloController : Controller
    {
        private readonly VueloContext _context;
        private EmpleadoContext _empleadoContext;

        public VueloController(VueloContext context, EmpleadoContext empleadoContext)
        {
            _context = context;
            _empleadoContext = empleadoContext;
        }

        // GET: Vuelo
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vuelos.ToListAsync());
        }

        // GET: Vuelo/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            _ = new List<Empleado>();
            List<Empleado> li = _empleadoContext.Empleados.ToList();
            ViewBag.LaPutaLista = li;

            if (id == 0)
                return View(new Vuelo());
            else
                return View(_context.Vuelos.Find(id));
        }

        // POST: Vuelo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("VueloID,Destino,Piloto,ModeloAvion,Pasajeros,FechaAbordaje")] Vuelo vuelo)
        {
            List<Empleado> li = new List<Empleado>();
            li = _empleadoContext.Empleados.ToList();
            ViewBag.LaPutaLista = li;

            if (ModelState.IsValid)
            {
                if (vuelo.VueloID == 0)
                    _context.Add(vuelo);
                else
                    _context.Update(vuelo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(vuelo);
        }

        // GET: Vuelo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var vue = await _context.Vuelos.FindAsync(id);
            _context.Vuelos.Remove(vue);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}
