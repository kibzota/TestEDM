using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestEDM.Configuracoes;
using TestEDM.Infra.Persistence.EF;
using TestEDM.Infra.Seeds;
using TestEDM.Shared.Constants;

namespace TestEDM
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }

        public Startup()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
        }



        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<TestEDMDBContext>();
            services.AddSingleton<IConfigurationRoot>(Configuration);
            EntityFrameworkConfiguration.ConfigureService(services, Configuration);
            IocContainerConfiguration.ConfigureService(services, Configuration);
            Config.Load(Configuration);

        }

        public void Configure()
        {
            var contextBD = new TestEDMDBContext();
            var db = new InitialDbBuilder(contextBD);
            db.Create();
        }

    }
}
