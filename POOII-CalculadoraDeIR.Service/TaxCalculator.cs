using POOII_CalculadoraDeIR.Service.Interfaces;

namespace POOII_CalculadoraDeIR.Service
{
    public class TaxCalculator : ITaxCalculator
    {
        public double TaxCalculation(double value)
        {
            var range = 20000;
            return value * 444 - 222; //value * aliquot of range - deduction of range
        }
    }
}