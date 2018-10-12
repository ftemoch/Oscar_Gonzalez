using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial2.Controllers
{
    public class ClienteController : Controller
    {
        public ActionResult Random()

        {
            var Cliente = new Cliente()
            {
                Nombre="elvis",
                Apellido="presley",
                Sueldo=234,5
            };
            return View();
        }

       
    }
}