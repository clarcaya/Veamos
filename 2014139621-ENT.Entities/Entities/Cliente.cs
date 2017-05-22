using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_ENT
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string DNI { get; set; }

        public int VentaId { get; set; }
        public Venta Venta { get; set; }

        public int TransporteId { get; set; }
        public Transporte Transporte { get; set; }
    }
}
