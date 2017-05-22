using _2014139621_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_PER.EntititesConfiguration
{
    public class TipoLugarConfiguration : EntityTypeConfiguration<TipoLugar>
    {
        public TipoLugarConfiguration()
        {
            //Table configurations
            ToTable("TipoLugares");
            HasKey(c => c.TipoLugarId);
            Property(c => c.NombreTipo).IsRequired().HasMaxLength(300);
        }
    }
}
