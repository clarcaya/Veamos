using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_ENT
{
    public class LugarViaje
    {
        public int LugarViajeId { get; set; }
        public string NombreLugar { get; set; }

        public int TransporteId { get; set; }
        public Transporte Transporte { get; set; }

        public int EncomiendaId { get; set; }
        public Encomienda Encomienda { get; set; }

        public int BusId { get; set; }
        public Bus Bus { get; set; }

        public ICollection<TipoLugar> TipoLugar { get; set; }

        public LugarViaje()
        {
            TipoLugar = new List<TipoLugar>();
        }

    }
}
