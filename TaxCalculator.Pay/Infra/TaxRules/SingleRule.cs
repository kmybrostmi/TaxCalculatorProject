using TaxCalculator.Pay.Entities;
using TaxCalculator.Pay.Interface;

namespace TaxCalculator.Pay.Infra.TaxRules;
public class SingleRule : ITaxRule
{
    public TaxPayer CalculationTaxPercentage(TaxPayer taxPayer, double currentPercentage)
    {
        if (taxPayer.IsSingle) 
        {
            taxPayer.TaxedAmount += ((taxPayer.GrossIncome - 40000) * .1);
        }
        return taxPayer;
    }
}
