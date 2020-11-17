using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_Final.Data
{
    public class Usuario : IdentityUser
    {
        public int UsuarioId { get; set; }
        [Required]
        public string Nombres { get; set; }

        //public string Apellido1 { get; set; }

        //public string Apellido2 { get; set; }

        //public string Foto { get; set; }

        public string Documento_Identidad { get; set; }

        public string Telefono { get; set; }

        public string WebSite { get; set; }


        public string Nombre_Comercial { get; set; }

        public string Direccion { get; set; }

    }
}
