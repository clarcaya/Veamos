using _2014139621_ENT;
using _2014139621_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_PER.Repositories
{
    public class TipoPagoRepository : Repository<TipoPago>, ITipoPagoRepository
    {
        private readonly TransporteDbContext _Context;

        private TipoPagoRepository()
        {

        }

        public TipoPagoRepository(TransporteDbContext context)
        {
            _Context = context;
        }
    }
}
