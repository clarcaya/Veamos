using _2014139621_ENT;
using _2014139621_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139621_PER.Repositories
{
    public class EncomiendaRepository : Repository<Encomienda>, IEncomiendaRepository
    {
        private readonly TransporteDbContext _Context;

        private EncomiendaRepository()
        {

        }

        public EncomiendaRepository(TransporteDbContext context)
        {
            _Context = context;
        }
    }
}
