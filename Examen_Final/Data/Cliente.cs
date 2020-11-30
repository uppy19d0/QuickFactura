using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_Final.Data
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        [Required]
        public string Nombres { get; set; }

        public string Direccion { get; set; }
        public string Foto { get; set; }
        [Required]
        public string Rnc { get; set; }

        public string Lat { get; set; }

        public string Long { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }
        
        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
