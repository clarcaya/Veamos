using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_ENT
{
    public class Transporte : Servicio
    {

        public ICollection<Cliente> Cliente { get; set; }
        public ICollection<TipoViaje> TipoViaje { get; set; }
        public ICollection<Bus> Bus { get; set; }
        public ICollection<LugarViaje> LugarViaje { get; set; }

        public Transporte()
        {
            Cliente = new List<Cliente>();
            TipoViaje = new List<TipoViaje>();
            Bus = new List<Bus>();
            LugarViaje = new List<LugarViaje>();
        }
    }
}
