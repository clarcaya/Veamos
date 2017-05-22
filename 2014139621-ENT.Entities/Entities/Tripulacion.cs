using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_ENT
{
    public class Tripulacion : Empleado
    {
        public int BusId { get; set; }
        public Bus Bus { get; set; }

        public ICollection<TipoTripulacion> TipoTripulacion { get; set; }

        public Tripulacion()
        {
            TipoTripulacion = new List<TipoTripulacion>();
        }
    }
}
