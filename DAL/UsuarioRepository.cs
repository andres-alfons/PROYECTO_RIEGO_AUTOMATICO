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

            // 🔹 Buscar el usuario por Id y actualizar sus datos
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].IdUsuario == obj.IdUsuario)
                {
                    lista[i].Nombre = obj.Nombre;
                    lista[i].Email = obj.Email;
                    lista[i].NombreUsuario = obj.NombreUsuario;
                    lista[i].Password = obj.Password;
                    lista[i].Rol = obj.Rol;
                    lista[i].RutaImagen = obj.RutaImagen;
                    lista[i].Accedio = obj.Accedio;
                    actualizado = true;
                    break;
                }
            }

            if (actualizado)
            {
                try
                {
                    // 🔹 Paso 1: limpiar el archivo antes de volver a escribir
                    File.WriteAllText(ruta, string.Empty);

                    // 🔹 Paso 2: volver a guardar todos los usuarios actualizados
                    foreach (var usuario in lista)
                    {
                        Guardar(usuario);
                    }

                    Console.WriteLine($"El usuario {obj.Nombre} fue actualizado correctamente.");
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al actualizar usuario: {ex.Message}");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("No se encontró el usuario a actualizar.");
                return false;
            }
        }



        public override Usuario ObtenerPorId(int obj)
        {
            return MostrarTodos().FirstOrDefault<Usuario>(x => x.IdUsuario == obj);
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

                using (StreamReader lector = new StreamReader(ruta))
                {
                    while (!lector.EndOfStream)
                    {
                        var linea = lector.ReadLine();
                        if (!string.IsNullOrWhiteSpace(linea))
                        {
                            lista.Add(Mappear(linea));
                        }
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer usuarios: " + ex.Message);
                return new List<Usuario>();
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
            usuario.RutaImagen = linea.Split(';')[6];
            usuario.Accedio = int.Parse(linea.Split(';')[7]);
            return usuario;
        }
        
    }
}
