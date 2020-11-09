using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_Final.Data
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        [Required]
        public string Nombres { get; set; }

        public string Apellido1 { get; set; }

        public string Apellido2 { get; set; }

        public string Foto { get; set; }
        [Required]
        public string Cedula { get; set; }

        public string Lat { get; set; }

        public string Long { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }

    }
}
