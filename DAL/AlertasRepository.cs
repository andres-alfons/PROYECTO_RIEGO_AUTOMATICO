using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AlertasRepository : BaseRepository<Alertas>
    {
        public AlertasRepository(string nombreArchivo) : base(nombreArchivo)
        {
        }

        public override IList<Alertas> MostrarTodos()
        {
            throw new NotImplementedException();
        }

        public override Alertas ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
