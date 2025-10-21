using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PlantaRepository : BaseRepository<Cultivo>
    {
        public override string Actualizar(Cultivo obj)
        {
            throw new NotImplementedException();
        }

        public override Cultivo BuscarPorId(int obj)
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(Cultivo obj)
        {
            throw new NotImplementedException();
        }

        public override IList<Cultivo> MostrarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
