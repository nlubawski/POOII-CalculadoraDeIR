using Microsoft.Extensions.DependencyInjection;
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
            var serviceProvicer = services.BuildServiceProvider();

        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ITaxCalculator, TaxCalculator>();

        }
    }
}

