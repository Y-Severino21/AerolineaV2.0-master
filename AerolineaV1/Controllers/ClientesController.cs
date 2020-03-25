using AerolineaV1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AerolineaV1.Controllers
{
    public class ClientesController : Controller
    {
        private readonly CLientesContext _context;

        public ClientesController(CLientesContext context)
        {
            _context = context;
        }

        //DbContext
        public IActionResult Index()
        {
            return View(_context.CLientes.ToList());
        }

        [HttpGet]
        public ActionResult RegistroClientes()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> RegistroClientes(Clientes client)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(client);
                    await _context.SaveChangesAsync();
                }catch(Exception e)
                {
                    ModelState.AddModelError("", "Ocurrio un error guardando el cliente en la base de datos");
                }
            }
            return View();
        }
    }
}
