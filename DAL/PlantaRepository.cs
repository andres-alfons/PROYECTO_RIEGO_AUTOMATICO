using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PlantaRepository : BaseRepository<Cultivo>
    {
        public PlantaRepository(string nombreArchivo) : base(nombreArchivo)
        {
        }

        public string Actualizar(Cultivo obj)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Cultivo obj)
        {
            throw new NotImplementedException();
        }

        public override IList<Cultivo> MostrarTodos()
        {
            IList<Cultivo> listaRazas = new List<Cultivo>();
            try
            {
                StreamReader lector = new StreamReader(ruta);
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    listaRazas.Add(MapearRaza(linea));
                }
                lector.Close();
                return listaRazas;
            }
            catch (Exception)
            {
                return null;
            }
        }
        private Cultivo MapearRaza(string linea)
        {
            Cultivo planta = new Cultivo();

            var aux = linea.Split(';');
            planta.IdPlanta = int.Parse(aux[0]);
            planta.Nombre = aux[1];
            planta.Descripcion = aux[2];
            planta.nivel_optimo_humedad = float.Parse(aux[3]);
            planta.nivel_optimo_temperatura = float.Parse(aux[4]);
            planta.nivel_optimo_luz = float.Parse(aux[5]);
            return planta;
        }

        public override Cultivo ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
