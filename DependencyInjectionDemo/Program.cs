using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            services.AddTransient<App>();
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            serviceProvider.GetService(typeof(App));
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ITransientService, TransientService>();
            services.AddSingleton<ISingletonService, SingletonService>();
        }
    }
}
