using TaxCalculator.Pay.Entities;
using TaxCalculator.Pay.Interface;

namespace TaxCalculator.Pay.Infra;

public class TaxRuleEngine
{
    List<ITaxRule> rules = new List<ITaxRule>();
    public TaxRuleEngine(IEnumerable<ITaxRule> taxRules)
    {
        rules.AddRange(taxRules);
    }
    public TaxPayer CalculationTaxPercentage(TaxPayer taxPayer)
    {
        //int taxPercentage = 0;
        foreach (var rule in rules)
        {
            //taxPercentage = Math.Max(taxPercentage, rule.CalculationTaxPercentage(taxPayer, taxPercentage));
            taxPayer.TaxedAmount += rule.CalculationTaxPercentage(taxPayer, taxPayer.TaxedAmount).TaxedAmount;
        }
        return taxPayer;
    }
}

