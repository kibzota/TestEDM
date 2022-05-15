using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TestEDM.Domain.Entities;

namespace TestEDM.Infra.Persistence.EF
{
    public  class TestEDMDBContext : DbContext
    {
        public DbSet<Notas> Notas { get; set; }

        public TestEDMDBContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Shared.Constants.Config.BuscarStringDeConexao());

        }

    }
}
