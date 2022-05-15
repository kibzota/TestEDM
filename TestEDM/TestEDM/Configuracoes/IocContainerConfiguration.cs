using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestEDM.Domain.Interfaces;
using TestEDM.Infra.Persistence.EF;
using TestEDM.Infra.Persistence.Repositories;
using TestEDM.Infra.Transactions;

namespace TestEDM.Configuracoes
{
    public static class IocContainerConfiguration
    {
        public static void ConfigureService(IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddSingleton<TestEDMDBContext, TestEDMDBContext>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<INotasRepository, NotasRepository>();
        }
    }
}
