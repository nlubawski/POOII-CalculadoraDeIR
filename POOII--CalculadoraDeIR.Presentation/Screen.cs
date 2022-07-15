using POOII__CalculadoraDeIR.Presentation.Interfaces;
using POOII_CalculadoraDeIR.Service.Interfaces;

namespace POOII__CalculadoraDeIR.Presentation
{
    public class Screen : IScreen
    {
        private ITaxCalculator taxCalculator;
        public Screen(ITaxCalculator taxCalculator)
        {
            this.taxCalculator = taxCalculator;
        }

        public void Calculation()
        {
            double tax;
            double value;
            string number;
            
            Console.WriteLine("Digite o valor: ");
            number = Console.ReadLine();

            while (!double.TryParse(number, out value) || value < 0)
            {
                Console.WriteLine("Digite novamente...");
                number = Console.ReadLine();
            }
            tax = taxCalculator.TaxCalculation(value);
            Console.WriteLine($"Valor do IR a ser pago é: {Math.Round(tax, 2)} ");
        }
    }
}