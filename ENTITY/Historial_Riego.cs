using System;

namespace ENTITY
{
    public class Historial_Riego
    {
        private static int contador = 1; // contador compartido por todas las instancias
        public Historial_Riego()
        {
            Id = contador++;
        }
        public int Id { get; private set; }
        public DateTime Fecha { get; set; }
        public float Humedad { get; set; }
        public float Temperatura { get; set; }

        //public Historial_Riego(DateTime fecha, float humedad, float temperatura)
        //{
        //    Fecha = fecha;
        //    Humedad = humedad;
        //    Temperatura = temperatura;
        //}
        public override string ToString()
        {
            return $"{Id};{Fecha};{Humedad};{Temperatura}";
        }
    }

}
