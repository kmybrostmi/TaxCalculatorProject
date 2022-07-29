using TaxCalculator.Pay;
using TaxCalculator.Pay.Entities;
using TaxCalculator.Pay.Services;
using Xunit;

namespace TaxCalculator.Test;

public class IndividualTaxCalculatorTest
{
    private TaxCalculatorService _Calculator = new TaxCalculatorService();
    //public IndividualTaxCalculatorTest(TaxCalculatorService Calculator)
    //{
    //    _Calculator = Calculator;
    //}


    [Fact]
    public void Income_For_Single_TaxPayer()
    {
        //Arrange 
        TaxPayer taxPayer = new TaxPayer
        {
            GrossIncome = 300000,
            IsSingle = true,
            IsResidentOrCitizen = true,
        };

        //Act
        var result = _Calculator.CalculationTaxPercentage(taxPayer);

        //Assert
        Assert.Equal(78000, result.TaxedAmount);

    }


    //[Fact]
    //public void Non_TaxtResident_Should_Not_Calculated()
    //{
    //    //Arrange
    //    TaxPayer taxPayer = new TaxPayer
    //    {
    //        IsCitizen = false,
    //    };
    //    IndividualTaxCalculator individualTax = new IndividualTaxCalculator();

    //    //Act

    //    string expectedErrorMessage = "Person is not citizen";
    //    var exceptionResult = Assert.Throws<InvalidOperationException>(() =>
    //    {
    //        individualTax.CalculationTaxPercentage(taxPayer);
    //    });

    //    //Assert

    //    Assert.Equal(expectedErrorMessage, exceptionResult.Message);
    //}


    //[Fact]
    //public void Disable_Taxtpayer_Should_Pay_Zero_Percent_Tax()
    //{
    //    //Arrange
    //    TaxPayer taxPayer = new TaxPayer
    //    {
    //        IsCitizen = true,
    //        HasDisability = true
    //    };
    //    IndividualTaxCalculator individualTax = new IndividualTaxCalculator();

    //    //Act
    //    var result = individualTax.CalculationTaxPercentage(taxPayer);

    //    //Assert

    //    Assert.Equal(0, result);
    //}

    //private TaxCalculator _taxCalculator = new TaxCalculator();

    //[Fact]
    //public void Retired_Taxpayer_Should_Pay_One_Percent_Tax()
    //{
    //    //Arrange
    
    //    TaxPayer taxPayer = new TaxPayer
    //    {
    //        IsCitizen = true,
    //        HasDisability = false,
    //        IsRetired = true    
    //    };
    //    IndividualTaxCalculator individualTax = new IndividualTaxCalculator();

    //    //Act
    //    var result = individualTax.CalculationTaxPercentage(taxPayer);

    //    //Assert

    //    Assert.Equal(1, result);
    //}
}

