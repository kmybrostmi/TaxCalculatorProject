using TaxCalculator.Pay.Entities;
using TaxCalculator.Pay.Infra;
using TaxCalculator.Pay.Interface;

namespace TaxCalculator.Pay.Services;

public class TaxCalculatorService
{
    public class TaxCalculator
    {
        public int CalculationTaxPercentage(TaxPayer taxPayer)
        {
            var ruleType = typeof(ITaxRule);


            IEnumerable<ITaxRule> rules = GetType().Assembly.GetTypes()
                .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
                .Select(s => Activator.CreateInstance(s) as ITaxRule);


            var engine = new TaxRuleEngine(rules);
            return engine.CalculationTaxPercentage(taxPayer);

        }
    }

}
