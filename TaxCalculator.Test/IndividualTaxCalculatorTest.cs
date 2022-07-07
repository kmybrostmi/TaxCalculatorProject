using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Pay;
using TaxCalculator.Pay.Entities;


namespace TaxCalculator.Test
{
    public class IndividualTaxCalculatorTest
    {
        [Fact]
        public void Non_TaxtResident_Should_Not_Calculated()
        {
            //Arrange
            TaxPayer taxPayer = new TaxPayer
            {
                IsCitizen = false,
            };
            IndividualTaxCalculator individualTax = new IndividualTaxCalculator();

            //Act

            string expectedErrorMessage = "Person is not citizen";
            var exceptionResult = Assert.Throws<InvalidOperationException>(() =>
            {
                individualTax.CalculationTaxPercentage(taxPayer);
            });

            //Assert

            Assert.Equal(expectedErrorMessage, exceptionResult.Message);
        }


        [Fact]
        public void Diaable_Taxtpayer_Should_Pay_Zero_Percent_Tax()
        {
            //Arrange
            TaxPayer taxPayer = new TaxPayer
            {
                IsCitizen = true,
                HasDisability = true
            };
            IndividualTaxCalculator individualTax = new IndividualTaxCalculator();

            //Act
            var result = individualTax.CalculationTaxPercentage(taxPayer);

            //Assert

            Assert.Equal(0, result);
        }

        //private TaxCalculator _taxCalculator = new TaxCalculator();

        [Fact]
        public void Retired_Taxpayer_Should_Pay_One_Percent_Tax()
        {
            //Arrange
            
            TaxPayer taxPayer = new TaxPayer
            {
                IsCitizen = true,
                HasDisability = true
            };
            IndividualTaxCalculator individualTax = new IndividualTaxCalculator();

            //Act
            var result = individualTax.CalculationTaxPercentage(taxPayer);

            //Assert

            Assert.Equal(0, result);
        }
    }
}