using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Planta
    {
        public Planta() { }
        public Planta(int idPlanta, string nombre, string descripcion, float nivel_optimo_humedad, float nivel_optimo_temperatura)
        {
            IdPlanta = idPlanta;
            Nombre = nombre;
            Descripcion = descripcion;
            this.nivel_optimo_humedad = nivel_optimo_humedad;
            this.nivel_optimo_temperatura = nivel_optimo_temperatura;
        }
        public int IdPlanta { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public string Descripcion { get; set; }
        public float nivel_optimo_humedad { get; set; }
        public float nivel_optimo_temperatura { get; set; }
        public float nivel_optimo_luz { get; set; } //No se sabe si tendremos este sensor, asi que lo pongo como opcional este atributo

        public float GetArea()
        {
            // Implementación ficticia para obtener el área de la planta
            return 1000.0f; // Valor de ejemplo
        }

    }
}
