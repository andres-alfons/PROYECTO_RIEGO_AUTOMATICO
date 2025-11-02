using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Alertas
    {
        public Alertas() { }
        public Alertas(int idAlerta, string descripcion, DateTime fechaCreacion, string nivel, bool leida, int idUsuario_FK)
        {
            IdAlerta = idAlerta;
            Descripcion = descripcion;
            FechaCreacion = fechaCreacion;
            Nivel = nivel;
            Leida = leida;
            IdUsuario_FK = idUsuario_FK;
        }
        public int IdAlerta { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Nivel { get; set; } // Ejemplo: "Sin tanta importancia", "Observacion", "Atencion Urgente"
        public bool Leida { get; set; }
        public int IdUsuario_FK { get; set; } // Usuario al que va dirigida la alerta   
    }
}
