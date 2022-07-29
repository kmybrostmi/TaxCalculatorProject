using TaxCalculator.Pay.Entities;

namespace TaxCalculator.Pay.Interface;

public interface ITaxRule
{
    int CalculationTaxPercentage(TaxPayer taxPayer, int currentPercentage);
}
