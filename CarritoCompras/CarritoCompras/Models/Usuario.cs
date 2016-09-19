using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarritoCompras.Models
{
    public class Usuario
    {
        public Int32 IdUsuario { get; set; }

        public String NombreUsuario { get; set; }

        public String FechaNacimiento { get; set; }

        public String CorreoUsuario { get; set; }

        public String CodigoUsuario { get; set; }

        public String ContrasenaUsuario { get; set; }
    }
}