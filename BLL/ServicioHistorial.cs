using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioHistorial
    {
        List<Hitorial_Riego> hitorial_Riegos = new List<Hitorial_Riego>();
        public string guardar(Hitorial_Riego Histori)
        {
            throw new NotImplementedException();
        }
        public string actualizar(Hitorial_Riego Histori)
        {
            throw new NotFiniteNumberException();
        }
        public Hitorial_Riego buscarPorId(Hitorial_Riego Histori)
        {
            throw null;
        }
        public List<Hitorial_Riego> ObtenerTodas()
        {
            return hitorial_Riegos;
        }
    }
}
