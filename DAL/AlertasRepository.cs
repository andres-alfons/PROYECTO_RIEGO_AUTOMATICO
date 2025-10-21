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
        public override string Actualizar(Alertas obj)
        {
            MostrarTodos();
            return "Datos Actualizados";
        }

        public override Alertas BuscarPorId(int obj)
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(Alertas obj)
        {
            throw new NotImplementedException();
        }

        public override IList<Alertas> MostrarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
