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
    public class EmpleadoController : Controller
    {
        private readonly EmpleadoContext _context;

        public EmpleadoController(EmpleadoContext context)
        {
            _context = context;
        }

        // GET: Empleado
        public async Task<IActionResult> Index()
        {
            return View(await _context.Empleados.ToListAsync());
        }

        // GET: Empleado/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Empleado());
            else
                return View(_context.Empleados.Find(id));

        }

        // POST: Empleado/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("EmpID,Cedula,Nombre,Puesto,Salario")] Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                if (empleado.EmpID == 0)
                    _context.Add(empleado);
                else
                    _context.Update(empleado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(empleado);
        }

        // GET: Empleado/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var emp = await _context.Empleados.FindAsync(id);
            _context.Empleados.Remove(emp);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
