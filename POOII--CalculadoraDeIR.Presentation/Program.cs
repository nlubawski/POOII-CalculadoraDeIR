using Microsoft.Extensions.DependencyInjection;
using POOII__CalculadoraDeIR.Presentation;
using POOII__CalculadoraDeIR.Presentation.Interfaces;
using POOII_CalculadoraDeIR.Service;
using POOII_CalculadoraDeIR.Service.Interfaces;

namespace POOII_CalculadoraDeIR.Presentation
{
    public class Program
    {
        public static void Main()
        {
            IServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            var serviceProvider = services.BuildServiceProvider();
            var screen = serviceProvider.GetService<IScreen>();
            screen.Calculation();
        }
        public static void ConfigureServices(IServiceCollection services)
        {
            services
                .AddScoped<ITaxCalculator, TaxCalculator>()
                .AddScoped<IScreen, Screen>();
        }
    }
}

