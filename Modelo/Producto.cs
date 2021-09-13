using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPrueba.Modelo
{
    public class Producto
    {
        public int id { get; set; }

        public int Nombre { get; set; }

        public int PrecioCompra { get; set; }

        public int PrecioVenta { get; set; }

        public int Stock { get; set; }

    }
}
