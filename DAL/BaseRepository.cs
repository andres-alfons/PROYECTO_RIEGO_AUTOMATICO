using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class BaseRepository<T>
    {
        protected BaseRepository() { }
        public abstract string Actualizar(T obj);
        public abstract void Eliminar(T obj);
        public abstract IList<T> MostrarTodos();
        public abstract T BuscarPorId(int obj);


    }
}
