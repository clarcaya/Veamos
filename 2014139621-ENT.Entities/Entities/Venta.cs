using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_ENT
{
    public class Venta
    {
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }

        public ICollection<Administrativo> Administrativo { get; set; }
        public ICollection<Cliente> Cliente { get; set; }
        public ICollection<Servicio> Servicio { get; set; }
        public ICollection<TipoPago> TipoPago { get; set; }
        public ICollection<TipoComprobante> TipoComprobante { get; set; }

        public Venta()
        {
            Administrativo = new List<Administrativo>();
            Cliente = new List<Cliente>();
            Servicio = new List<Servicio>();
            TipoPago = new List<TipoPago>();
            TipoComprobante = new List<TipoComprobante>();
        }

    }
}
