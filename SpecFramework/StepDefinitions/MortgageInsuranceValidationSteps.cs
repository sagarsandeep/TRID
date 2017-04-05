using System;
using System.Globalization;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TRID.ActionClasses;
using TRID.CommonUtils;
using TRID.ProjectLibs.Common;
using TRID.TestClasses;

namespace TRID.StepDefinitions
{
    [Binding]
    public class MortgageInsuranceValidationSteps : TridTest
    {

        readonly GetExcelData _getData = new GetExcelData();

        #region Given

        [Given(@"user launches TRID application")]
        public void GivenUserLaunchesTridApplication()
        {
            UIActions.WebDriverWait(PcPrepaidChargesText, 60);
            Thread.Sleep(5000);
        }

        [Given(@"user navigates to Mortgage Insurance Page")]
        public void GivenUserNavigatesToMortgageInsurancePage()
        {
            UIActions.Click(MortgageInsuranceLink);
            Thread.Sleep(5000);
        }


        [Given(@"user have closing disclosure data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHaveClosingDisclosureDataFromExcelSheetForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }

        [Given(@"user have the input values from excel sheet (.*) for scenario (.*)")]
        public void GivenUserHaveTheInputValuesFromExcelSheetForScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }

        [Given(@"user have Mortgage Insurance data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHaveMortgageInsuranceDataFromExcelSheetForTheScenarioMortgageInsurance(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }


        #endregion

        #region When


        [When(@"user enters pmi rate values")]
        public void WhenUserEntersPmiRateValues()
        {
            ProjActions.AddPmiRate();
            ProjActions.PmiRatesGridValidation();
        }

        [When(@"user enter input value for Lower Of Cost Or Appraisal")]
        public void WhenUserEnterInputValueForLowerOfCostOrAppraisal()
        {
            var lowerOfCostOfAppraisal = TridVariable.LowerOfCostOfAppraisal;
            UIActions.Clear(MiLowerOfCostOrAppraisal);
            UIActions.GiveInput(MiLowerOfCostOrAppraisal, lowerOfCostOfAppraisal);
        }


        //[When(@"user navigate to Closing Disclosure Page")]
        //public void WhenUserNavigateToClosingDisclosurePage()
        //{
        //    UIActions.Click(ClosingDisclosureLink);
        //    UIActions.WebDriverWait(CdLoanDetailsText, 60);
        //    Thread.Sleep(3000);
        //}

        [When(@"user clicks on Mortgage Insurance Test Button")]
        public void WhenUserClicksOnMortgageInsuranceTestButton()
        {
            UIActions.Click(MiTestButton);
            Thread.Sleep(5000);
        }


        //[When(@"user enters (.*) greater than default value for lower of cost or appraisal")]
        //public void WhenUserEntersGreaterThanDefaultValueForLowerOfCostOrAppraisal(string newInputValue)
        //{
        //    UIActions.Clear(UIElements.MiLowerOfCostOrAppraisal);
        //    UIActions.GiveInput(UIElements.MiLowerOfCostOrAppraisal,newInputValue);
        //}

        //[When(@"user enters (.*) lesser than default value for lower of cost or appraisal")]
        //public void WhenUserEntersLesserThanDefaultValueForLowerOfCostOrAppraisal(string newInputValue)
        //{
        //    UIActions.Clear(UIElements.MiLowerOfCostOrAppraisal);
        //    UIActions.GiveInput(UIElements.MiLowerOfCostOrAppraisal, newInputValue);
        //}

        [When(@"user enters new (.*) other than default value for lower of cost or appraisal")]
        public void WhenUserEntersNewOtherThanDefaultValueForLowerOfCostOrAppraisal(string newInputValue)
        {
            UIActions.Clear(MiLowerOfCostOrAppraisal);
            UIActions.GiveInput(MiLowerOfCostOrAppraisal, newInputValue);
        }


        #endregion

        #region Then


        //[Then(@"Payment Schedule is recalculated with new lower of cost value (.*)")]
        //public void ThenPaymentScheduleIsRecalculatedWithNewLowerOfCostValue(int newInputValue)
        //{
        //    ProjActions.PaymentScheduleValidation(newInputValue);
        //}

        //[Then(@"Drop off years for PMI changes to (.*)")]
        //public void ThenDropOffYearsForPmiChangesTo(string computedDate)
        //{
        //    string dropOffYearsForPmi = computedDate;
        //    string actualDropOffYearsForPmi = UIActions.GetText(MiDoyfpComputedValue);

        //    Assert.AreNotEqual(dropOffYearsForPmi,actualDropOffYearsForPmi, "Drop Off Years for PMI does not matches with expected result");
        //}


        [Then(@"Pmi Rates Grid should have inserted values")]
        public void ThenPmiRatesGridShouldHaveInsertedValues()
        {
            ProjActions.PmiRatesGridValidation();
        }

        [Then(@"updated/computed pmi value should display on Mortgage Insurance")]
        public void ThenUpdatedComputedPmiValueShouldDisplayOnMortgageInsurance()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(MiPmiComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.Pmi);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(MiPmiDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(MiPmiVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed Drop off years for PMI value should display on Mortgage Insurance")]
        public void ThenUpdatedComputedDropOffYearsForPmiValueShouldDisplayOnMortgageInsurance()
        {
            var cValue = ProjActions.GetDatePart(MiDoyfpComputedValue);

            var actualCValue = Convert.ToDateTime(DateTime.FromOADate(Convert.ToDouble(TridVariable.DropOffYearsForPmi)).ToString("M/d/yyyy"));
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetDatePart(MiDoyfpDisclosureValue);
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(MiDoyfpVarianceValue));

            var actualVarianceValue = (cValue - dValue).TotalDays;

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed Total Period Payment value should display on Mortgage Insurance")]
        public void ThenUpdatedComputedTotalPeriodPaymentValueShouldDisplayOnMortgageInsurance()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(MiTppComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.TotalPeriodPayment);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(MiTppDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(MiTppVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed Total Of Payments value should display on Mortgage Insurance")]
        public void ThenUpdatedComputedTotalOfPaymentsValueShouldDisplayOnMortgageInsurance()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(MiTopComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.TotalOfPayments);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(MiTopDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(MiTopVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed Amount Financed value should display on Mortgage Insurance")]
        public void ThenUpdatedComputedAmountFinancedValueShouldDisplayOnMortgageInsurance()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(MiAfComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.AmountFinanced);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(MiAfDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(MiAfVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed APR value should display on Mortgage Insurance")]
        public void ThenUpdatedComputedAprValueShouldDisplayOnMortgageInsurance()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(MiAprComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.Apr);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(MiAprDisclosureValue)), 2);
            var vValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(MiAprVarianceValue)), 2);

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");
            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        #endregion

        [AfterScenario("MortgageInsurance")]
        public void TearDown()
        {
            UIActions.Quit();
        }
    }
}
