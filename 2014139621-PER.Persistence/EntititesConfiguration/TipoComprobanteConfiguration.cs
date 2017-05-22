using _2014139621_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_PER.EntititesConfiguration
{
    public class TipoComprobanteConfiguration : EntityTypeConfiguration<TipoComprobante>
    {
        public TipoComprobanteConfiguration()
        {
            //Table configurations
            ToTable("TipoCombrobantes");
            HasKey(c => c.TipoComprobanteId);
            Property(c => c.NombreComprobante).IsRequired().HasMaxLength(300);

            //Relationships configurations
            HasRequired(c => c.Venta)
                .WithMany(c => c.TipoComprobante)
                .HasForeignKey(c => c.VentaId);
        }
    }
}
