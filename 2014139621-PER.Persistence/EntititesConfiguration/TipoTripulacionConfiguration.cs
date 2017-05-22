using _2014139621_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_PER.EntititesConfiguration
{
    public class TipoTripulacionConfiguration : EntityTypeConfiguration<TipoTripulacion>
    {
        public TipoTripulacionConfiguration()
        {
            //Table configurations
            ToTable("TipoTripulacion");
            HasKey(c => c.TipoTripulacionId);
            Property(c => c.Nombre).IsRequired().HasMaxLength(300);

            //Relationships configurations
            HasRequired(c => c.Tripulacion)
                .WithMany(c => c.TipoTripulacion)
                .HasForeignKey(c => c.TripulacionId);
        }
    }
}
