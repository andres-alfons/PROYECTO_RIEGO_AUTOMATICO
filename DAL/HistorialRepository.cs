using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HistorialRepository : BaseRepository<Hitorial_Riego>
    {
        public HistorialRepository() { }
        public override string Actualizar(Hitorial_Riego obj)
        {
            throw new NotImplementedException();
        }

        public override Hitorial_Riego BuscarPorId(int obj)
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(Hitorial_Riego obj)
        {
            throw new NotImplementedException();
        }

        public override IList<Hitorial_Riego> MostrarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
