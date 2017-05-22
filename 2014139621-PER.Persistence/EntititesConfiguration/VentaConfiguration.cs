using _2014139621_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_PER.EntititesConfiguration
{
    public class VentaConfiguration : EntityTypeConfiguration<Venta>
    {
        public VentaConfiguration()
        {
            //Table configurations
            ToTable("Ventas");
            HasKey(c => c.VentaId);
            Property(p => p.Fecha).IsRequired();


            //Relationships Configurations
            HasMany(c => c.Administrativo)
                .WithRequired(c => c.Venta)
                .HasForeignKey(c => c.VentaId);

            HasMany(c => c.Cliente)
                .WithRequired(c => c.Venta)
                .HasForeignKey(c => c.VentaId);

            HasMany(c => c.Servicio)
                .WithRequired(c => c.Venta)
                .HasForeignKey(c => c.VentaId);

            HasMany(c => c.TipoPago)
                .WithRequired(c => c.Venta)
                .HasForeignKey(c => c.VentaId);

            HasMany(c => c.TipoComprobante)
                .WithRequired(c => c.Venta)
                .HasForeignKey(c => c.VentaId);
        }
    }
}
