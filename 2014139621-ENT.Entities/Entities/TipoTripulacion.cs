using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_ENT
{
    public class TipoTripulacion
    {
        public int TipoTripulacionId { get; set; }
        public string Nombre { get; set; }

        public int TripulacionId { get; set; }
        public Tripulacion Tripulacion { get; set; }
    }
}
