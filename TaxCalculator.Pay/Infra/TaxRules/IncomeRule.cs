using TaxCalculator.Pay.Entities;
using TaxCalculator.Pay.Interface;

namespace TaxCalculator.Pay.Infra.TaxRules;
public class IncomeRule : ITaxRule
{
    public TaxPayer CalculationTaxPercentage(TaxPayer taxPayer, double currentPercentage)
    {
        if (taxPayer.GrossIncome < 40000) taxPayer.TaxedAmount = 0;
        else
        {
            taxPayer.TaxedAmount += ((taxPayer.GrossIncome - 40000) * .1);
        }
        return taxPayer;
    }
}
