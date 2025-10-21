using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServiciosUsuario
    {
        UsuarioRepository usuarioRepository;
        public ServiciosUsuario()
        {

        }

        public bool Actualizar(Usuario entidad)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<Usuario> Consultar()
        {
            var lista = usuarioRepository.MostrarTodos();
            return new ReadOnlyCollection<Usuario>(lista);
        }

        public void Eliminar(Usuario entidad)
        {
            usuarioRepository.Eliminar(entidad);
        }

        public string Guardar(Usuario entidad)
        {
            return usuarioRepository.Guardar(entidad);
        }

        public Usuario ObtenerPorId(int id)
        {
            //validar
            return usuarioRepository.BuscarPorId(id);
        }


    }
}
