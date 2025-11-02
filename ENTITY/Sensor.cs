using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{

    public class Sensor
    {
        private static int contador = 1; // contador compartido por todas las instancias
        public Sensor()
        {
            sensor_id = contador++;
        }
        public int sensor_id { get; private set; } // solo lectura
        public float Humedad { get; set; }
        public DateTime Fecha { get; set; }
        public float Temperatura { get; set; } = 0.0f;
    }

}

