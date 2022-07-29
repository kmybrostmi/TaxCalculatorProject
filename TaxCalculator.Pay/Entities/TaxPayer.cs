using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Pay.Entities;

public class TaxPayer
{
    //public bool IsCitizen { get; set; }
    //public bool HasDisability { get; set; }
    //public bool IsMuslim { get; set; }
    //public decimal ZakatPaid { get; set; }
    //public bool IsRetired { get; set; }

    public bool IsSingle { get; set; }
    public bool IsRetired { get; set; }
    public bool IsResidentOrCitizen { get; set; }
    public bool HasHealthInsurance { get; set; }
    public bool HasBusiness { get; set; }
    public bool AtLossInBusiness { get; set; }
    public double TaxedAmount { get; set; }           // مقدار مالیات بعد از فایر شدن انجین و محاسبه مالیات
    public double GrossIncome { get; set; }           // درآمد خالص
    public double HealthInsuranceAnnualPremium { get; set; }

}









