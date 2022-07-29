using TaxCalculator.Pay.Entities;

namespace TaxCalculator.Pay.Interface;

public interface ITaxRule
{
    TaxPayer CalculationTaxPercentage(TaxPayer taxPayer, double currentPercentage);
}

