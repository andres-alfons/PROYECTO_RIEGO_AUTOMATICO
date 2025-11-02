using System;
using System.Collections.Generic;
using System.IO;

namespace DAL
{
    public abstract class BaseRepository<T>
    {
        protected string ruta;

        protected BaseRepository(string nombreArchivo)
        {
            this.ruta = nombreArchivo;
        }

        public string Guardar(T entidad)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta, true))
                {
                    sw.WriteLine(entidad.ToString());
                }
                return $"Se guardaron los datos de la entidad {typeof(T).Name}.";
            }
            catch (Exception ex)
            {
                return $"Error al guardar la entidad {typeof(T).Name}: {ex.Message}";
            }
        }

        public abstract IList<T> MostrarTodos();
        public abstract T ObtenerPorId(int id);

    }
}