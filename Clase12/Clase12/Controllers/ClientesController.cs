using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clase12.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes = GetClientes();

        public ViewResult Lista()
        {
            var clientes = GetClientes();
            //var clientes = _context.Clientes.(ToList();
            return View(clientes);
        }
        public ActionResult Details(int id)
        {
            var cliente = GetClientes().SingleOrDefault(c => c.ID  == id);
            //var clientes = _context.Clientes().singleOrDefault(c => c.ID == ID == id);
            if (cliente = null)

                return HttpNotFound();

            return View(cliente);

        }
        private IEnumerable<Cliente> GetClientes()
        {
            return new List<Cliente>
            {
            new Cliente  { ID = 1, nombre = "John Smith" },
        }
            }

       
