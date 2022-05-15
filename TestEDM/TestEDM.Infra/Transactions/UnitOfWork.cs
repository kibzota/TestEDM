using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEDM.Infra.Persistence.EF;

namespace TestEDM.Infra.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TestEDMDBContext _context;

        public UnitOfWork(TestEDMDBContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
