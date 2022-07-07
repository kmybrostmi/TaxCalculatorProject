using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Pay.Entities;

namespace TaxCalculator.Pay;

public class IndividualTaxCalculator
{
    public int CalculationTaxPercentage(TaxPayer taxPayer)
    {
        if (!taxPayer.IsCitizen)
        {
            throw new InvalidOperationException("Person is not citizen");
        }

        return 0;
    }
}
