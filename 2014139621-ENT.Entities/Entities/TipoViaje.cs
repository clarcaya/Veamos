using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_ENT
{
    public class TipoViaje
    {
        public int TipoViajeId { get; set; }
        public string Nombre { get; set; }

        public int TransporteId { get; set; }
        public Transporte Transporte { get; set; }
    }
}
