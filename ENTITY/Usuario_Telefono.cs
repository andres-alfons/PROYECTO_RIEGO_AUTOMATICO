using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Usuario_Telefono : Usuario
    {
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public int IdUsuario_Telefono { get; set; }
        public string IdUsuario_FK { get; set; }
    }
}
