using Microsoft.Extensions.DependencyInjection;

namespace TestEDM;
class Program
{

    public Program()
    {
    }


    public static void Main(string[] args)
    {
        IServiceCollection services = new ServiceCollection();
        // Startup.cs finally :)
        Startup startup = new Startup();
        startup.ConfigureServices(services);
        startup.Configure();
        IServiceProvider serviceProvider = services.BuildServiceProvider();

    }


}