using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
            planta.NombrePlanta = aux[1];
            planta.Descripcion = aux[2];
            planta.RutaImagen = aux[3];
            planta.nivel_optimo_humedad = float.Parse(aux[4]);
            planta.nivel_optimo_temperatura = float.Parse(aux[5]);
            planta.nivel_optimo_luz = float.Parse(aux[6]);
            return planta;
        }
        private void ReescribirArchivo(IList<Cultivo> lista)
        {
            using (StreamWriter sw = new StreamWriter(ruta, false))
            {
                foreach (var item in lista)
                {
                    sw.WriteLine(item.ToString());
                }
            }
        }
        public bool Eliminar(Cultivo obj)
        {
            var lista = MostrarTodos();
            bool eliminado = false;
            Cultivo PlantaEliminada = null;

            foreach (var item in lista.ToList()) // Evita modificar la colección mientras se recorre
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
                    ReescribirArchivo(lista);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                Console.WriteLine("No se encontró la planta...");
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
                    item.NombrePlanta = obj.NombrePlanta;
                    item.Descripcion = obj.Descripcion;
                    item.RutaImagen = obj.RutaImagen;
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
                    Console.WriteLine($"El Usuario {PlantaActualizado.NombrePlanta} fue actualizado correctamente");
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
