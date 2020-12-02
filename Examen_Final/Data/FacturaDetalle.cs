using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_Final.Data
{
    public class FacturaDetalle
    {
        public int FacturaDetalleID { get; set; }

        public int ProductoID { get; set; }

        public virtual Producto producto { get; set; }

        public double Cantidad { get; set; }
        public double Itbis { get; set; }

        public double Precio { get; set; }

        public double SubTotal { get; set; }

        public double Total { get; set; }
    }
}
