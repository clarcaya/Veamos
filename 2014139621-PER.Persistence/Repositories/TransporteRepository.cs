using _2014139621_ENT;
using _2014139621_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_PER.Repositories
{
    public class TransporteRepository : Repository<Transporte>, ITransporteRepository
    {
        private readonly TransporteDbContext _Context;

        private TransporteRepository()
        {

        }

        public TransporteRepository(TransporteDbContext context)
        {
            _Context = context;
        }
    }
}
