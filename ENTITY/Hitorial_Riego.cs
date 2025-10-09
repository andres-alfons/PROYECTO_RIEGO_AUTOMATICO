using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Hitorial_Riego
    {
        public Hitorial_Riego() { }
        public Hitorial_Riego(int idHistorialRiego, DateTime fechaHora, float cantidadAgua, int idPlanta_FK, int idUsuario_FK)
        {
            IdHistorialRiego = idHistorialRiego;
            FechaHora = fechaHora;
            CantidadAgua = cantidadAgua;
            IdPlanta_FK = idPlanta_FK;
            IdUsuario_FK = idUsuario_FK;
        }
        public int IdHistorialRiego { get; set; }
        public DateTime FechaHora { get; set; }
        public int duracion_en_segundos { get; set; }
        public string Observaciones { get; set; } = "Se hizo el riego por humedad baja"; //Pero este se pone asi por si el usuario hizo el riego manual pueda especificar el por qué hizo el riego, ejemplo: “riego por estrés hídrico” o “riego adicional por altas temperaturas”.

        public float CantidadAgua { get; set; } // Cantidad de agua utilizada en litros
        public int IdPlanta_FK { get; set; } // Planta que fue regada
        public int IdUsuario_FK { get; set; } // Usuario que realizó el riego
    }
}
