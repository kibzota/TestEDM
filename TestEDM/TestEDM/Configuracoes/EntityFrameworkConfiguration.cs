using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestEDM.Infra.Persistence.EF;

namespace TestEDM.Configuracoes
{
    public static class EntityFrameworkConfiguration
    {
        public static void ConfigureService(IServiceCollection services, IConfigurationRoot configuration)
        {

            services.AddSingleton<DbContext, TestEDMDBContext>();
        }

    }
}
