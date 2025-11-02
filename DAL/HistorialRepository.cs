using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DAL
{
    public class HistorialRepository : BaseRepository<Historial_Riego>
    {
        private static List<Historial_Riego> historialSimulado = new List<Historial_Riego>();

        public HistorialRepository(string nombreArchivo) : base(nombreArchivo)
        {

        }

        public Historial_Riego BuscarPorId(int id)
        {
            var entidad = historialSimulado.Find(x => x.Id == id);
            if (entidad == null)
            {
                throw new KeyNotFoundException("No se encontro el registro con el id especificado");
            }
            return entidad;
        }

        public void Eliminar(Historial_Riego obj)
        {

        }

        public override IList<Historial_Riego> MostrarTodos()
        {
            try
            {
                StreamReader lector = new StreamReader(ruta);
                List<Historial_Riego> lista = new List<Historial_Riego>();

                while (!lector.EndOfStream)
                {

                    lista.Add(Mappear(lector.ReadLine()));
                }
                lector.Close();
                return lista;
            }
            catch (Exception)
            {

                return null;
            }
        }
        private Historial_Riego Mappear(string linea)
        {
            Historial_Riego historial = new Historial_Riego();

            var aux = linea.Split(';');

            //historial.Id = int.Parse(aux[0]);
            historial.Fecha = DateTime.Parse(aux[1]);
            historial.Humedad = float.Parse(aux[2]);
            historial.Temperatura = float.Parse(aux[3]);

            return historial;
        }

        //public string GuardarLectura(float humedad)
        //{
        //    var registro = new Historial_Riego
        //    {
        //        Fecha = DateTime.Now,
        //        Humedad = humedad
        //    };
        //    historialSimulado.Add(registro);
        //    Console.WriteLine($"💾 Dato guardado: {humedad} ({registro.Fecha})");
        //    return "Dato guardado correctamente";
        //}

        public override Historial_Riego ObtenerPorId(int id)
        {
            return MostrarTodos().FirstOrDefault<Historial_Riego>(x => x.Id == id);
        }
    }
}

