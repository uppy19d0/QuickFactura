using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_Final.Data
{
    public class Producto
    {
        public int ProductoID { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        public string img { get; set; }

        public double Precio { get; set; }

        public bool Servicio { get; set; }

        public double Cantidad { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
