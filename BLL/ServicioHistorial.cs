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
    public class ServicioHistorial : ICrudEscritura<Historial_Riego>, ICrudLectura<Historial_Riego>
    {
        HistorialRepository historial;
        public ServicioHistorial()
        {
            historial = new HistorialRepository(Utils.ARC_HISTORIAL);
        }
        public bool Actualizar(Historial_Riego entidad)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<Historial_Riego> MostrarTodos()
        {
            var lista = historial.MostrarTodos();
            if (lista == null)
            {
                return new ReadOnlyCollection<Historial_Riego>(new List<Historial_Riego>());
            }
            return new ReadOnlyCollection<Historial_Riego>(lista);
        }

        public bool Eliminar(Historial_Riego entidad)
        {
            throw new NotImplementedException();
        }

        public string Guardar(Historial_Riego entidad)
        {
            try
            {
                if (entidad == null)
                {
                    throw new ArgumentNullException("El registro que se intento guardar es nulo");
                }
                
                return historial.Guardar(entidad);

            }
            catch (Exception)
            {

                throw;
            }

        }

        public Historial_Riego ObtenerPorId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException("El id debe ser mayor a cero");
            }
            return historial.ObtenerPorId(id);
        }

    }
}
