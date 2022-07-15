using POOII_CalculadoraDeIR.Service.Interfaces;

namespace POOII_CalculadoraDeIR.Service
{
    public class TaxCalculator : ITaxCalculator
    {
        public double TaxCalculation(double value)
        {
                double aliquot = 0;
                double deduction = 0;
                switch(value)
                {
                    case <= 22847.76: 
                        aliquot = 0;
                        deduction = 0;
                        break;
                    case <= 33919.80:
                        aliquot = 0.075;
                        deduction = 1713.58;
                        break;
                    case <= 45012.6:
                        aliquot = 0.15;
                        deduction = 4257.57;
                        break;
                    case <= 55976.16:
                        aliquot = 0.225;
                        deduction = 7633.51;
                        break;
                    case > 55976.16:
                        aliquot = 0.275;
                        deduction = 10432.32;
                        break;
                }
                return value * aliquot - deduction;
        }
    }
}