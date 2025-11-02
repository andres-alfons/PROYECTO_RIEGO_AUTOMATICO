using ENTITY;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioRepository : BaseRepository<Usuario>
    {

        public UsuarioRepository(string nombreArchivo) : base(nombreArchivo)
        {

        }
        public bool Actualizar(Usuario obj)
        {
            var lista = MostrarTodos();
            bool actualizado = false;
            Usuario UsuarioActualizado = null;

            foreach (var item in lista)
            {
                if (item.IdUsuario == obj.IdUsuario)
                {
                    UsuarioActualizado = item;
                    item.Nombre = obj.Nombre;
                    item.Email = obj.Email;
                    item.NombreUsuario = obj.NombreUsuario;
                    item.Password = obj.Password;
                    item.Rol = obj.Rol;
                    actualizado = true;
                    break;
                }
            }
            if (actualizado)
            {
                try
                {
                    MostrarTodos();
                    Console.WriteLine($"El Usuario {UsuarioActualizado.Nombre} fue actualizado correctamente");
                    return true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Hubo un error...");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("No se encontro el usuario...");
                return false;
            }
        }

        public override Usuario ObtenerPorId(int obj)
        {
            var entidad = MostrarTodos().FirstOrDefault<Usuario>(x => x.IdUsuario == obj);
            if (entidad == null)
            {
                throw new KeyNotFoundException("No se encontro el registro con el id especificado");
            }
            return entidad;
        }

        public bool Eliminar(Usuario obj)
        {
            var lista = MostrarTodos();
            bool eliminado = false;
            Usuario UsuarioEliminado = null;

            foreach (var item in lista)
            {
                if (item.IdUsuario == obj.IdUsuario)
                {
                    UsuarioEliminado = item;
                    lista.Remove(item);
                    eliminado = true;
                    break;
                }
            }

            if (eliminado)
            {
                try
                {
                    MostrarTodos();
                    Console.WriteLine($"El Usuario {UsuarioEliminado.Nombre} fue eliminado correctamente");
                    return true;

                }
                catch (Exception)
                {
                    Console.WriteLine("Hubo un error...");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("No se encontro el usuario...");
                return false;
            }

        }

        public override IList<Usuario> MostrarTodos()
        {
            try
            {
                List<Usuario> lista = new List<Usuario>();
                StreamReader lector = new StreamReader(ruta);

                while (!lector.EndOfStream)
                {
                    lista.Add(Mappear(lector.ReadLine()));
                }
                lector.Close();
                return lista;
            }
            catch (Exception)
            {

                return null;
            }
        }
        private Usuario Mappear(string linea)
        {
            Usuario usuario = new Usuario();
            //var aux = linea.Split(';');

            usuario.IdUsuario = int.Parse(linea.Split(';')[0]);
            usuario.Nombre = linea.Split(';')[1];
            usuario.Email = linea.Split(';')[2];
            usuario.NombreUsuario = linea.Split(';')[3];
            usuario.Password = linea.Split(';')[4];
            usuario.Rol = linea.Split(';')[5];
            return usuario;
        }
    }
}
