using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace math_games.Models
{
    public class Usuario
    {
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public string Edad { get; set; }
        public string Mail { get; set; }
        public string Contraseña { get; set; }
    }
}