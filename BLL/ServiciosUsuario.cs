using DAL;
using ENTITY;
using System.Collections.ObjectModel;


namespace BLL
{
    public class ServiciosUsuario : ICrudEscritura<Usuario>, ICrudLectura<Usuario>
    {
        UsuarioRepository usuarioRepository;
        public ServiciosUsuario()
        {
            usuarioRepository = new UsuarioRepository(Utils.ARC_USUARIO);
        }

        public bool Actualizar(Usuario entidad)
        {
            return usuarioRepository.Actualizar(entidad);
        }

        public ReadOnlyCollection<Usuario> MostrarTodos()
        {
            var lista = usuarioRepository.MostrarTodos();
            return new ReadOnlyCollection<Usuario>(lista);
        }

        public bool Eliminar(Usuario entidad)
        {
            return usuarioRepository.Eliminar(entidad);
        }

        public string Guardar(Usuario entidad)
        {
            return usuarioRepository.Guardar(entidad);
        }

        public Usuario ObtenerPorId(int id)
        {
            //validar
            return usuarioRepository.ObtenerPorId(id);
        }
    }
}

