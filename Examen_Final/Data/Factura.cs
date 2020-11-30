using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_Final.Data
{
    public class Factura
    {
        public int FacturaID { get; set; }
        public bool Cancelada { get; set; }
        public int ClienteID { get; set; }
        public virtual Cliente Cliente { get; set; }
        public string UsuarioID { get; set; }
        public DateTime Fecha { get; set; }
        public double SubTotal { get; set; }
        public double Total { get; set; }
        public double Itbis { get; set; }
        public int ProductoID { get; set; }
        public virtual Producto producto { get; set; }
        // public List<Producto> productos { get; set; } = new List<Producto>();
    }
}
