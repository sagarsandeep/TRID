using System;
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

        [Given(@"user launches TRID application with (.*)")]
        public void GivenUserLaunchesTridApplicationWith(string url)
        {
            UIActions.WindowMaximize();
            UIActions.GoToUrl(url);
            Thread.Sleep(10000);
        }
        
        [Given(@"user navigates to Mortgage Insurance Page")]
        public void GivenUserNavigatesToMortgageInsurancePage()
        {
            UIActions.Click(MortgageInsuranceLink);
            Thread.Sleep(5000);
        }

        [Given(@"user have the input values from excel sheet (.*)")]
        public void GivenUserHaveTheInputValuesFromExcelSheet(string sheetName)
        {
            _getData.GetExcelValues(sheetName);
        }


        [When(@"user enters pmi rate values")]
        public void WhenUserEntersPmiRateValues()
        {
            ProjActions.AddPmiRate();
        }


        [When(@"user enters (.*) greater than default value for lower of cost or appraisal")]
        public void WhenUserEntersGreaterThanDefaultValueForLowerOfCostOrAppraisal(string newInputValue)
        {
            UIActions.Clear(MiLowerOfCostOrAppraisal);
            UIActions.GiveInput(MiLowerOfCostOrAppraisal,newInputValue);
        }
        
        [When(@"click on Other PMI inputs TEST Button")]
        public void WhenClickOnOtherPmiInputsTestButton()
        {
            UIActions.Click(MiTestButton);
            Thread.Sleep(5000);
        }
        
        [When(@"user enters (.*) lesser than default value for lower of cost or appraisal")]
        public void WhenUserEntersLesserThanDefaultValueForLowerOfCostOrAppraisal(string newInputValue)
        {
            UIActions.Clear(MiLowerOfCostOrAppraisal);
            UIActions.GiveInput(MiLowerOfCostOrAppraisal, newInputValue);
        }

        [Then(@"Payment Schedule is recalculated with new lower of cost value (.*)")]
        public void ThenPaymentScheduleIsRecalculatedWithNewLowerOfCostValue(int newInputValue)
        {
            ProjActions.PaymentScheduleValidation(newInputValue);
        }

        [Then(@"Drop off years for PMI changes to (.*)")]
        public void ThenDropOffYearsForPmiChangesTo(string computedDate)
        {
            string dropOffYearsForPmi = computedDate;
            string actualDropOffYearsForPmi = UIActions.GetText(MiDoyfpComputedValue);

            Assert.AreNotEqual(dropOffYearsForPmi,actualDropOffYearsForPmi, "Drop Off Years for PMI does not matches with expected result");
        }


        [Then(@"Pmi Rates Grid should have inserted values")]
        public void ThenPmiRatesGridShouldHaveInsertedValues()
        {
            ProjActions.PmiRatesGridValidation();
        }


        [AfterScenario("MortgageInsurance")]
        public void TearDown()
        {
            UIActions.Quit();
        }
    }
}
