using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase12.Views.Clientes
{
    public class Cliente
    {
        public int ID { get; set; }
        (Required)
        (StringLength(255))

        public string nombre { get; set; }
        public string apellido { get; set; }
    }

}