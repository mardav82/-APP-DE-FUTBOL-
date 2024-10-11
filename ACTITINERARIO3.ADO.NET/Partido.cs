using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTITINERARIO3.ADO.NET
{
    public class Partido
    {

        // Propiedades de lectura y escritura
        public DateTime Fecha { get; set; }
        public string EquipoLocal { get; set; }
        public string EquipoVisitante { get; set; }
        public int GolesEquipoLocal { get; set; }
        public int GolesEquipoVisitante { get; set; }
        public bool Finalizado { get; set; }

        // Constructor opcional para inicializar propiedades
        public Partido(DateTime fecha, string equipoLocal, string equipoVisitante, int golesEquipoLocal, int golesEquipoVisitante, bool finalizado)
        {
            Fecha = fecha;
            EquipoLocal = equipoLocal;
            EquipoVisitante = equipoVisitante;
            GolesEquipoLocal = golesEquipoLocal;
            GolesEquipoVisitante = golesEquipoVisitante;
            Finalizado = finalizado;
        }

        // Constructor por defecto
        public Partido() { }
    }
}

