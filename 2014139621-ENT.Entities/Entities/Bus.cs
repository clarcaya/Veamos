using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_ENT
{
    public class Bus
    {
        public int BusId { get; set; }
        public string Placa { get; set; }
        public string SerieMotor { get; set; }

        public int TransporteId { get; set; }
        public Transporte Transporte { get; set; }

        public ICollection<Tripulacion> Tripulacion { get; set; }

        public ICollection<Encomienda> Encomienda { get; set; }

        public Bus()
        {
            Tripulacion = new List<Tripulacion>();
            Encomienda = new List<Encomienda>();
        }

    }
}
