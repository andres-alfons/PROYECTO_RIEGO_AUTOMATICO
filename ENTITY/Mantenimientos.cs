using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Mantenimientos
    {
        public Mantenimientos()
        {
        }
        public Mantenimientos(int idMantenimiento, string descripcion, DateTime fecha, string tipo, int idUsuario_FK, int idEquipo_FK, string observaciones)
        {
            IdMantenimiento = idMantenimiento;
            Descripcion = descripcion;
            Fecha = fecha;
            Tipo = tipo;
            IdUsuario_FK = idUsuario_FK;
            IdEquipo_FK = idEquipo_FK;
        }
        public int IdMantenimiento { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; } // Ejemplo: "Efectivo", "No logrado"
        public int IdUsuario_FK { get; set; } // Usuario que realizó el mantenimiento
        public int IdEquipo_FK { get; set; } // Equipo al que se le realizó el mantenimiento


    }
}
