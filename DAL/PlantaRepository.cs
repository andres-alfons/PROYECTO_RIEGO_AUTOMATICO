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
        public override IList<Cultivo> MostrarTodos()
        {
            try
            {
                var lista = new List<Cultivo>();

                using (StreamReader lector = new StreamReader(ruta))
                {
                    while (!lector.EndOfStream)
                    {
                        var linea = lector.ReadLine();
                        if (!string.IsNullOrWhiteSpace(linea))
                        {
                            lista.Add(Mappear(linea));
                        }
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer el archivo: " + ex.Message);
                return new List<Cultivo>();
            }
        }
        private Cultivo Mappear(string linea)
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
        public bool Eliminar(Cultivo obj)
        {
            var lista = MostrarTodos();
            bool eliminado = false;
            Cultivo PlantaEliminada = null;

            foreach (var item in lista)
            {
                if (item.IdPlanta == obj.IdPlanta)
                {
                    PlantaEliminada = item;
                    lista.Remove(item);
                    eliminado = true;
                    break;
                }
            }

            if (eliminado)
            {
                try
                {
                    MostrarTodos();
                    Console.WriteLine($"El Usuario {PlantaEliminada.Nombre} fue eliminado correctamente");
                    return true;

                }
                catch (Exception)
                {
                    Console.WriteLine("Hubo un error...");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("No se encontro el usuario...");
                return false;
            }

        }
        public bool Actualizar(Cultivo obj)
        {
            var lista = MostrarTodos();
            bool actualizado = false;
            Cultivo PlantaActualizado = null;

            foreach (var item in lista)
            {
                if (item.IdPlanta == obj.IdPlanta)
                {
                    PlantaActualizado = item;
                    item.Nombre = obj.Nombre;
                    item.Descripcion = obj.Descripcion;
                    item.nivel_optimo_humedad = obj.nivel_optimo_humedad;
                    item.nivel_optimo_temperatura = obj.nivel_optimo_temperatura;
                    item.nivel_optimo_luz = obj.nivel_optimo_luz;
                    actualizado = true;
                    break;
                }
            }
            if (actualizado)
            {
                try
                {
                    MostrarTodos();
                    Console.WriteLine($"El Usuario {PlantaActualizado.Nombre} fue actualizado correctamente");
                    return true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Hubo un error...");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("No se encontro el usuario...");
                return false;
            }
        }



        public override Cultivo ObtenerPorId(int id)
        {
            return MostrarTodos().FirstOrDefault<Cultivo>(x => x.IdPlanta == id);
        }
    }
}
