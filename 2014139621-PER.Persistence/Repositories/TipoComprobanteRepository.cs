using _2014139621_ENT;
using _2014139621_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_PER.Repositories
{
    public class TipoComprobanteRepository : Repository<TipoComprobante>, ITipoComprobanteRepository
    {
        private readonly TransporteDbContext _Context;

        private TipoComprobanteRepository()
        {

        }

        public TipoComprobanteRepository(TransporteDbContext context)
        {
            _Context = context;
        }
    }
}
