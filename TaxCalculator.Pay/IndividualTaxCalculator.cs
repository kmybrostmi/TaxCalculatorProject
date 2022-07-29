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
        }else
        {
            if (taxPayer.HasDisability)
            {
                return 0;
            }
            if (taxPayer.IsMuslim)
            {
                if (taxPayer.ZakatPaid > 10000 && taxPayer.ZakatPaid < 50000)
                {
                    return 5;
                }
                if (taxPayer.ZakatPaid > 10000 && taxPayer.ZakatPaid < 100000)
                {
                    return 4;
                }
                if (taxPayer.ZakatPaid > 10000 && taxPayer.ZakatPaid < 200000)
                {
                    return 3;
                }
            }
            if (taxPayer.IsRetired)
            {
                return 1;
            }
        }
        return 0;
    }
}
