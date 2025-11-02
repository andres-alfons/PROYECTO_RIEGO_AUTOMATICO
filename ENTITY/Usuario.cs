using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Usuario
    {

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }

        public override string ToString()
        {
            return $"{IdUsuario};{Nombre};{Email};{NombreUsuario};{Password};{Rol}";
        }
    }
}
