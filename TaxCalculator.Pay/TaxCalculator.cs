using TaxCalculator.Pay.Entities;

namespace TaxCalculator.Pay;

public class TaxCalculator
{
    public int CalculationTaxPercentage(TaxPayer taxPayer)
    {
        var ruleType = typeof(ITaxRule);


        IEnumerable<ITaxRule> rules = this.GetType().Assembly.GetTypes()
            .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
            .Select(s => Activator.CreateInstance(s) as ITaxRule);

       
        var engine = new TaxRuleEngine(rules);
        return engine.CalculationTaxPercentage(taxPayer);   

    }
}