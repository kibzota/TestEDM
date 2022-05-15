using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEDM.Infra.Persistence.EF;

namespace TestEDM.Infra.Seeds
{
    public class InitialDbBuilder
    {
        private readonly TestEDMDBContext _context;
        public InitialDbBuilder(TestEDMDBContext context)
        {
            _context = context;
        }

        public void Create()
        {
           var x =  _context.ChangeTracker;
            _context.SaveChanges();
        }
    }
}
