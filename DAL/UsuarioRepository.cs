using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioRepository : BaseRepository<Usuario>
    {
        List<Usuario> list;
        public UsuarioRepository() { }
        public override string Actualizar(Usuario obj)
        {
            throw new NotImplementedException();
        }
        public string Guardar(Usuario usuario)
        {
            //validar
            //GUARDAR EL USUARIO EN LA BASE DE DATOS
            return "Usuario guardado exitosamente";

        }

        public override Usuario BuscarPorId(int obj)
        {
            foreach (var usuario in list)
            {
                if (usuario.IdUsuario.Equals(obj))
                {
                    //ELIMINAR EL USUARIO DE LA BASE DE DATOS
                    return usuario;
                }
            }
            Console.WriteLine("No se encontro el usuario");
            return null;
        }

        public override void Eliminar(Usuario obj)
        {
            if (BuscarPorId(int.Parse(obj.IdUsuario))!= null)
            {
                //PROCESO PARA ELIMINARLO EN LA BASE DE DATOS
                return;
            }            
            Console.WriteLine("NO SE ENCONTRO EL USUARIO");

        }

        public override IList<Usuario> MostrarTodos()
        {
            List<Usuario> lista = new List<Usuario>();
            foreach (var item in list)
            {
                lista.Add(item);
            }
            
            if (list != null) {
                Console.WriteLine("No hay datos");
                return null;
            }
            return lista;
        }
    }
}
