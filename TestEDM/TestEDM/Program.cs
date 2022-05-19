using Microsoft.Extensions.DependencyInjection;
using TestEDM.Domain.Interfaces;

namespace TestEDM;
class Program
{

    public Program()
    {
    }


    public static void Main(string[] args)
    {
        IServiceCollection services = new ServiceCollection();
        Startup startup = new Startup();
        startup.ConfigureServices(services);
        startup.Configure();
        IServiceProvider serviceProvider = services.BuildServiceProvider();
        var service = serviceProvider.GetService<IMenu>();
        service.MenuCaixa();

    }


}