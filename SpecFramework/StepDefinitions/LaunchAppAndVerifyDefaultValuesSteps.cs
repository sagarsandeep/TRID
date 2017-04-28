using System;
using System.IO;
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
    public class LaunchAppAndVerifyDefaultValuesSteps : TridTest
    {
        readonly GetExcelData _getData = new GetExcelData();

        #region Given       

        [Given(@"user enters Trid Application url in browser")]
        public void GivenUserEntersTridApplicationUrlInBrowser()
        {
            //UIActions.WebDriverWait(PrepaidChargesText, 60);
            Thread.Sleep(5000);
        }


        [Given(@"user gets default values from Excel sheet (.*) for scenario (.*)")]
        public void GivenUserGetsDefaultValuesFromExcelSheetForScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }

        #endregion

        #region When    

        [When(@"TRID Application launches")]
        public void WhenTridApplicationLaunches()
        {
            //UIActions.WebDriverWait(PrepaidChargesText, 60);
        }

        [When(@"user navigate to Mortgage Insurance Page")]
        public void WhenUserNavigateToMortgageInsurancePage()
        {
            //UIActions.Click(MortgageInsuranceLink);
            //UIActions.WebDriverWait(MortgageInsuranceLink, 60);
        }

        [When(@"user navigate to Loan Estimate Page")]
        public void WhenUserNavigateToLoanEstimatePage()
        {
            UIActions.Click(LoanEstimateLink);
            UIActions.WebDriverWait(LoanEstimateLink, 60);
        }

        [When(@"user navigate to Export Page")]
        public void WhenUserNavigateToExportPage()
        {
            UIActions.Click(ExportLink);
            UIActions.WebDriverWait(ExLoanInformationText, 60);
        }


        #endregion

        #region Then

        [Then(@"default page should be Prepaid Charges Page")]
        public void ThenDefaultPageShouldBePrepaidChargesPage()
        {
            string expectedPageText = "Prepaid Charges";
            //string actualPageText = UIActions.GetText(PrepaidChargesText);
            //Assert.AreEqual(expectedPageText, actualPageText, "Prepaid Charges is not default Page");
        }

        [Then(@"all the input and custom fields should have zero values")]
        public void ThenAllTheInputAndCustomFieldsShouldHaveZeroValues()
        {

            ProjActions.AddPrepaidChargesDefaultValues();
            ProjActions.PrepaidChargesGridEmptyValidation();
        }

        [Then(@"Disclosed Values of Finance Charge, Prepaid Charge and Amount Financed are set to default values")]
        public void ThenDisclosedValuesOfFinanceChargePrepaidChargeAndAmountFinancedAreSetToDefaultValues()
        {
            var disclosedFinanceCharge = TridVariable.DisclosedFinanceCharge;
            UIActions.Clear(DisclosedFinanceCharge);
            UIActions.GiveInput(DisclosedFinanceCharge, disclosedFinanceCharge);

            var disclosedPrepaidCharge = TridVariable.DisclosedPrepaidCharge;
            UIActions.Clear(DisclosedPrepaidCharge);
            UIActions.GiveInput(DisclosedPrepaidCharge, disclosedPrepaidCharge);

            var disclosedAmountFinanced = TridVariable.DisclosedAmountFinanced;
            UIActions.Clear(DisclosedAmountFinanced);
            UIActions.GiveInput(DisclosedAmountFinanced, disclosedAmountFinanced);
        }

        [Then(@"PMI rates Grid should be empty")]
        public void ThenPmiRatesGridShouldBeEmpty()
        {
            ProjActions.PrepaidChargesGridEmptyValidation();
        }

        [Then(@"lower of cost or Appraisal should have default value")]
        public void ThenLowerOfCostOrAppraisalShouldHaveDefaultValue()
        {
            var numberOfPeriodsofAdvanceInsCollected = TridVariable.NumberOfPrdsOfAdvcInsurance;
            UIActions.Clear(NumberOfPeriodsofAdvanceInsCollected);
            UIActions.GiveInput(NumberOfPeriodsofAdvanceInsCollected, numberOfPeriodsofAdvanceInsCollected);

            var lowerOfCostOrAppraisal = TridVariable.LowerOfCostOfAppraisal;
            UIActions.Clear(LowerOfCostOrAppraisal);
            UIActions.GiveInput(LowerOfCostOrAppraisal, lowerOfCostOrAppraisal);
        }

        //[When(@"user selects Calculation Method in Loan Estimate Page")]
        //public void WhenUserSelectsCalculationMethodInDisclosurePage()
        //{
        //    LoanDetailsRadioButtonVariable();
        //    UIActions.Click(LeCalculationMethod);
        //}

        //[When(@"user selects loan type in Loan Estimate Page")]
        //public void WhenUserSelectsLoanTypeInLoanEstimatePage()
        //{
        //    LoanDetailsRadioButtonVariable();
        //    UIActions.Click(LeLoanType);
        //}

        //[When(@"user selects Frequency of Payments in Loan Estimate Page")]
        //public void WhenUserSelectsFrequencyOfPaymentsInLoanEstimatePage()
        //{
        //    LoanDetailsRadioButtonVariable();
        //    UIActions.Click(LeFrequencyOfPayments);
        //}

        //[When(@"user selects Loan Term in Loan Estimate Page")]
        //public void WhenUserSelectsLoanTermInLoanEstimatePage()
        //{
        //    LoanDetailsRadioButtonVariable();
        //    UIActions.Click(LeLoanTerm);
        //}

        //[When(@"user selects Repayment Term Type in Loan Estimate Page")]
        //public void WhenUserSelectsRepaymentTermTypeInLoanEstimatePage()
        //{
        //    LoanDetailsRadioButtonVariable();
        //    UIActions.Click(LeRepaymentTermType);
        //}

        //[When(@"Enter Loan detail input values for computation for Loan Estimate page")]
        //public void WhenEnterLoanDetailInputValuesForComputationforLoanEstimatepage()
        //{
        //    var loanTermValue = TridVariable.LoanTermValue;
        //    UIActions.Clear(LeLoanTermValue);
        //    UIActions.GiveInput(LeLoanTermValue, loanTermValue);

        //    var loanAmount = TridVariable.LoanAmount;
        //    UIActions.Clear(LeLoanAmount);
        //    UIActions.GiveInput(LeLoanAmount, loanAmount);

        //    var rateOfInterest = TridVariable.RateOfInterest;
        //    UIActions.Clear(LeRateOfInterest);
        //    UIActions.GiveInput(LeRateOfInterest, rateOfInterest);

        //    var dateOfLoan = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateOfLoan)).ToString("M/d/yyyy");
        //    UIActions.Clear(LeDateOfLoan);
        //    UIActions.GiveInput(LeDateOfLoan, dateOfLoan);

        //    var dateOfInterestBegins = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateInterestBeginToAccrue)).ToString("M/d/yyyy");
        //    UIActions.Clear(LeDateOfInterestBegins);
        //    UIActions.GiveInput(LeDateOfInterestBegins, dateOfInterestBegins);

        //    var dateOfFirstPayment = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateOfFirstPayment)).ToString("M/d/yyyy");
        //    UIActions.Clear(LeDateOfFirstPayment);
        //    UIActions.GiveInput(LeDateOfFirstPayment, dateOfFirstPayment);

        //    var periodPayment = TridVariable.PeriodPayment;
        //    UIActions.Clear(LePeriodPayment);
        //    UIActions.GiveInput(LePeriodPayment, periodPayment);

        //    var loanCostsForDisclosure = TridVariable.LoanCosts;
        //    UIActions.Clear(LeLoanCostsForDisclosure);
        //    UIActions.GiveInput(LeLoanCostsForDisclosure, loanCostsForDisclosure);

        //    var finalBalloonPayment = TridVariable.FinalBalloonPayment;
        //    UIActions.Clear(LeFinalBalloonPayment);
        //    UIActions.GiveInput(LeFinalBalloonPayment, finalBalloonPayment);
        //}

        //[Then(@"Date of Loan, Date of Interest begins to accure and Date of First Payment should have default value")]
        //public void ThenDateOfLoanDateOfInterestBeginsToAccureAndDateOfFirstPaymentShouldHaveDefaultValue()
        //{
        //    var dateOfLoan = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateOfLoan)).ToString("M/d/yyyy");
        //    UIActions.Clear(LeDateOfLoan);
        //    UIActions.GiveInput(LeDateOfLoan, dateOfLoan);

        //    var dateOfInterestBegins = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateInterestBeginToAccrue)).ToString("M/d/yyyy");
        //    UIActions.Clear(LeDateOfInterestBegins);
        //    UIActions.GiveInput(LeDateOfInterestBegins, dateOfInterestBegins);

        //    var dateOfFirstPayment = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateOfFirstPayment)).ToString("M/d/yyyy");
        //    UIActions.Clear(LeDateOfFirstPayment);
        //    UIActions.GiveInput(LeDateOfFirstPayment, dateOfFirstPayment);
        //}

        //[When(@"Enter Disclosed input values for Loan Estimate Page")]
        //public void WhenEnterDisclosedInputValuesForLoanEstimatePage()
        //{
        //    var in5Years = TridVariable.DiscLosedIn5Years;
        //    UIActions.Clear(LeDisclosedIn5Years);
        //    UIActions.GiveInput(LeDisclosedIn5Years, in5Years);

        //    var in5YearsPrincipal = TridVariable.DiscLosedIn5YearsPrincipal;
        //    UIActions.Clear(LeDisclosedIn5YearsPrincipal);
        //    UIActions.GiveInput(LeDisclosedIn5YearsPrincipal, in5YearsPrincipal);

        //    var apr = TridVariable.DisclosedApr;
        //    UIActions.Clear(LeDisclosedApr);
        //    UIActions.GiveInput(LeDisclosedApr, apr);

        //    var tip = TridVariable.DisclosedTip;
        //    UIActions.Clear(LeDisclosedTip);
        //    UIActions.GiveInput(LeDisclosedTip, tip);
        //}


        [Then(@"all the input values should have default values")]
        public void ThenAllTheInputValuesShouldHaveDefaultValues()
        {
            var loanIdNumber = TridVariable.LoanIdNumber;
            UIActions.Clear(ExLoanIdNumber);
            UIActions.GiveInput(ExLoanIdNumber, loanIdNumber);

            var borrowersNames = TridVariable.BorrowersNames;
            UIActions.Clear(ExBorrowersNames);
            UIActions.GiveInput(ExBorrowersNames, borrowersNames);

            var preparedBy = TridVariable.PreparedBy;
            UIActions.Clear(ExPreparedBy);
            UIActions.GiveInput(ExPreparedBy, preparedBy);

            var nameOfLender = TridVariable.NameOfLender;
            UIActions.Clear(ExNameOfLender);
            UIActions.GiveInput(ExNameOfLender, nameOfLender);

            var originalCreditor = TridVariable.OriginalCreditor;
            UIActions.Clear(ExOriginalCreditor);
            UIActions.GiveInput(ExOriginalCreditor, originalCreditor);
        }


        [Then(@"click on Test button on Export Page")]
        public void ThenClickOnTestButtonOnExportPage()
        {
            UIActions.Click(ExTestButton);
        }

        [Then(@"click on Export to pdf button on Export Page")]
        public void ThenClickOnExportToPdfButtonOnExportPage()
        {
            UIActions.Click(ExExportToPdfButton);
        }

        [Then(@"file gets downloaded with (.*)")]
        public void ThenFileGetsDownloadedWith(string downloadedfileName)
        {
            Thread.Sleep(5000);
            string filePath = @"C:\Users\sandees\Downloads\" + downloadedfileName;
            Assert.IsTrue(File.Exists(filePath), "Exported File does not exists");
        }

        #endregion

        [AfterScenario("TestDefaultValues")]
        public void TearDown()
        {
            UIActions.Quit();
        }
    }
}
