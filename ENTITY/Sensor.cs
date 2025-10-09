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
        public string sensor_name { get; set; } 
        public DateTime ultima_medicion { get; set; }
        public float valor_medicion { get; set; } = 0.0f;
        public string tipo_sensor { get; set; }
        public string unidad_de_medida { get; set; }

        

    }

}

