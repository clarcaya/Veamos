using _2014139621_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_PER.EntititesConfiguration
{
    public class TipoViajeConfiguration : EntityTypeConfiguration<TipoViaje>
    {
        public TipoViajeConfiguration()
        {
            //Table configurations
            ToTable("TipoViajes");
            HasKey(c => c.TipoViajeId);
            Property(c => c.Nombre).IsRequired().HasMaxLength(300);

            //Relationships configurations
            HasRequired(c => c.Transporte)
                .WithMany(c => c.TipoViaje)
                .HasForeignKey(c => c.TransporteId);
        }
    }
}
