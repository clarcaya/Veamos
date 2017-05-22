using _2014139621_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_PER.EntititesConfiguration
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            //Table configurations
            ToTable("Clientes");
            HasKey(c => c.ClienteId);
            Property(c => c.Nombre).IsRequired().HasMaxLength(50);
            Property(c => c.Apellidos).IsRequired().HasMaxLength(200);
            Property(c => c.DNI).IsRequired().HasMaxLength(8);

            //Relationships configurations
            HasRequired(c => c.Transporte)
                .WithMany(c => c.Cliente)
                .HasForeignKey(c => c.TransporteId);
            
            HasRequired(c => c.Venta)
                .WithMany(c => c.Cliente)
                .HasForeignKey(c => c.VentaId);
        }
    }
}
