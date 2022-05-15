using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEDM.Domain.Entities;
using TestEDM.Domain.Interfaces;
using TestEDM.Infra.Persistence.EF;
using TestEDM.Infra.Transactions;

namespace TestEDM.Infra.Persistence.Repositories
{
    public class NotasRepository : INotasRepository
    {
        private readonly TestEDMDBContext _context;
        private readonly DbSet<Notas> _dbSet;
        private readonly IUnitOfWork _unitOfWork;

        public NotasRepository(TestEDMDBContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _dbSet = context.Set<Notas>();
            _unitOfWork = unitOfWork;
        }
    }
}
