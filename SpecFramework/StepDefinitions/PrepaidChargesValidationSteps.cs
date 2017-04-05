//using System;
//using System.Threading;
//using NUnit.Framework;
//using TechTalk.SpecFlow;
//using TRID.ActionClasses;
//using TRID.CommonUtils;
//using TRID.ProjectLibs.Common;
//using TRID.TestClasses;

//namespace TRID.StepDefinitions
//{
//    [Binding]
//    public class PrepaidChargesValidationSteps : TridTest
//    {
//        readonly GetExcelData _getData = new GetExcelData();

//        #region Given      

//        [Given(@"user opens TRID application")]
//        public void GivenUserOpensTridApplication()
//        {
//            UIActions.WebDriverWait(PcPrepaidChargesText, 60);
//            Thread.Sleep(5000);
//        }
        


//        [Given(@"user have test data from excel sheet (.*) for the scenario (.*)")]
//        public void GivenUserHaveTestDataFromExcelSheetForTheScenario(string sheetName, int scenarioNo)
//        {
//            _getData.GetExcelValues(scenarioNo, sheetName);
//        }

//        #endregion

//        #region When
       
//        [When(@"user is at Prepaid Charges Page")]
//        public void WhenUserIsAtPrepaidChargesPage()
//        {
//            UIActions.Click(PrepaidChargesLink);
//            UIActions.WebDriverWait(PcPrepaidChargesText, 60);
//            Thread.Sleep(5000);
//        }
        
//        [When(@"user enters input value for Flood Fee")]
//        public void WhenUserEntersInputValueForFloodFee()
//        {
//            UIActions.Clear(UIElements.PcFloodFee);
//            UIActions.GiveInput(UIElements.PcFloodFee,TridVariable.FloodFee);
//        }
        
//        [When(@"user enters input value for Loan Origination Fee")]
//        public void WhenUserEntersInputValueForLoanOriginationFee()
//        {
//            UIActions.Clear(UIElements.PcLoanOriginationFee);
//            UIActions.GiveInput(UIElements.PcLoanOriginationFee, TridVariable.LoanOriginationFee);
//        }
        
//        [When(@"user enters input value for Prepaid Daily Interest")]
//        public void WhenUserEntersInputValueForPrepaidDailyInterest()
//        {
//            UIActions.Clear(UIElements.PcPrepaidDailyInterest);
//            UIActions.GiveInput(UIElements.PcPrepaidDailyInterest, TridVariable.PrepaidDailyInterest);
//        }
        
//        [When(@"user enters input value for Title - Closing Fee")]
//        public void WhenUserEntersInputValueForTitle_ClosingFee()
//        {
//            UIActions.Clear(UIElements.PcTitleClosingFee);
//            UIActions.GiveInput(UIElements.PcTitleClosingFee, TridVariable.TitleClosingFee);
//        }
        
//        [When(@"user enters input value for Title - Closing protection letter")]
//        public void WhenUserEntersInputValueForTitle_ClosingProtectionLetter()
//        {
//            UIActions.Clear(UIElements.PcTitleClosingProtectionLetter);
//            UIActions.GiveInput(UIElements.PcTitleClosingProtectionLetter, TridVariable.TitleClosingProtectionLetter);
//        }

//        [When(@"click on Prepaid Charges Test Button")]
//        public void WhenClickOnPrepaidChargesTestButton()
//        {
//            UIActions.Click(LoanEstimateLink);
//            Thread.Sleep(3000);
//            UIActions.WebDriverWait(LeLoanDetailsText, 60);

//            UIActions.Click(PrepaidChargesLink);
//            Thread.Sleep(3000);
//            UIActions.WebDriverWait(PcPrepaidChargesText, 60);

//            UIActions.Click(PcTestButton);
//            Thread.Sleep(10000);
//        }


//        [When(@"user is at loan estimate page")]
//        public void GivenUserIsAtLoanEstimatePage()
//        {
//            UIActions.Click(LoanEstimateLink);
//            UIActions.WebDriverWait(CdLoanDetailsText, 60);
//        }

//        [When(@"user enters Loan Amount (.*)")]
//        public void GivenUserEntersLoanAmount(string loanAmount)
//        {
//            UIActions.Clear(UIElements.LeLoanAmount);
//            UIActions.GiveInput(UIElements.LeLoanAmount, loanAmount);
//        }

//        [When(@"user enters input value for prepaid custom fields")]
//        public void WhenUserEntersInputValueForPrepaidCustomFields()
//        {
//            UIActions.Clear(UIElements.PcCustomName);
//            UIActions.GiveInput(UIElements.PcCustomName, TridVariable.PrepaidCustomName);

//            UIActions.Clear(UIElements.PcCustomValue);
//            UIActions.GiveInput(UIElements.PcCustomValue, TridVariable.PrepaidCustomValue);

//            UIActions.Click(PcCustomFieldAddButton);
//            Thread.Sleep(10000);

//            ProjActions.PrepaidChargeGridValidation();
//        }

//        #endregion

//        #region Then

//        [Then(@"Prepaid Charges should recalculate and update with expected computed value")]
//        public void ThenPrepaidChargesShouldRecalculateAndUpdateWithExpectedComputedValue()
//        {
//            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PcPcComputedValue));

//            var actualCValue = Convert.ToDouble(TridVariable.PrepaidCharges);
//            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

//            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PcPcDisclosureValue));
//            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PcPcVarianceValue));

//            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

//            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");
//        }
        
//        [Then(@"Amount Fianced should recalculate and update with expected computed value")]
//        public void ThenAmountFiancedShouldRecalculateAndUpdateWithExpectedComputedValue()
//        {
//            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PcAfComputedValue));

//            var actualCValue = Convert.ToDouble(TridVariable.AmountFinanced);
//            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

//            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PcAfDisclosureValue));
//            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PcAfVarianceValue));

//            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

//            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");
//        }


//        [Then(@"Amount Fianced should recalculate and should be reduced with previous value")]
//        public void ThenAmountFiancedShouldRecalculateAndShouldBeReducedWithPreviousValue()
//        {
//            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PcAfComputedValue));

//            var actualCValue = Convert.ToDouble(TridVariable.AmountFinanced);
//            Assert.AreNotEqual(actualCValue, cValue, "Computed value does not match as expected");
//            Assert.IsTrue(cValue<actualCValue, "Computed value is not less than the previous value");

//            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PcAfDisclosureValue));
//            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PcAfVarianceValue));

//            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

//            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");
//        }


//        #endregion

//        [AfterScenario("PrepaidCharges")]
//        public void TearDown()
//        {
//            UIActions.Quit();
//        }
//    }
//}
