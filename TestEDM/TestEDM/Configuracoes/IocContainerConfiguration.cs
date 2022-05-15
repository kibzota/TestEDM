using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestEDM.Domain.Interfaces;
using TestEDM.Domain.Services;
using TestEDM.Infra.Persistence.EF;
using TestEDM.Infra.Persistence.Repositories;
using TestEDM.Infra.Transactions;
using TestEDM.Interfaces;

namespace TestEDM.Configuracoes
{
    public static class IocContainerConfiguration
    {
        public static void ConfigureService(IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddSingleton<TestEDMDBContext, TestEDMDBContext>();
            services.AddTransient<IMenu, Menu>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<INotasRepository, NotasRepository>();
            services.AddTransient<ISacarNotas, SacarNotasService>();
            services.AddTransient<IAdicionarNotas, AdicionarNotasService>();
        }
    }
}
