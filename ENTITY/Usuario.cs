using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Usuario
    {
        public Usuario() { }
        public Usuario(string idUsuario, string nombre, string apellido, string email, string nombreUsuario, string password, string rol)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            NombreUsuario = nombreUsuario;
            Password = password;
            Rol = rol;
        }

        public string IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string NombreUsuario { get; set; }   
        public string Password { get; set; }
        public string Rol { get; set; }
    }
}
