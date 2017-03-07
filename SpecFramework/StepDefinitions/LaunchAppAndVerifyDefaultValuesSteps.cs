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
            UIActions.WebDriverWait(PcPrepaidChargesText, 60);
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
            UIActions.WebDriverWait(PcPrepaidChargesText, 60);
        }

        [When(@"user navigate to Mortgage Insurance Page")]
        public void WhenUserNavigateToMortgageInsurancePage()
        {
            UIActions.Click(MortgageInsuranceLink);
            UIActions.WebDriverWait(MortgageInsuranceLink, 60);
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
            string actualPageText = UIActions.GetText(PcPrepaidChargesText);
            Assert.AreEqual(expectedPageText,actualPageText,"Prepaid Charges is not default Page");
        }

        [Then(@"all the input and custom fields should have zero values")]
        public void ThenAllTheInputAndCustomFieldsShouldHaveZeroValues()
        {

            ProjActions.AddPrepaidChargesDefaultValues();
            var isRowExists = false;
            try
            {
                UIActions.GetText(PcPrepaidChargeGridCount);
                isRowExists = true;
            }
            catch (Exception)
            {
                // ignored
            }
            if (isRowExists)
                throw new Exception("Grid is not empty");
        }
        
        [Then(@"Disclosed Values of Finance Charge, Prepaid Charge and Amount Financed are set to default values")]
        public void ThenDisclosedValuesOfFinanceChargePrepaidChargeAndAmountFinancedAreSetToDefaultValues()
        {
            var disclosedFinanceCharge = TridVariable.DisclosedFinanceCharge;
            UIActions.Clear(PcDisclosedFinanceCharge);
            UIActions.GiveInput(PcDisclosedFinanceCharge, disclosedFinanceCharge);

            var disclosedPrepaidCharge = TridVariable.DisclosedPrepaidCharge;
            UIActions.Clear(PcDisclosedPrepaidCharge);
            UIActions.GiveInput(PcDisclosedPrepaidCharge, disclosedPrepaidCharge);

            var disclosedAmountFinanced = TridVariable.DisclosedAmountFinanced;
            UIActions.Clear(PcDisclosedAmountFinanced);
            UIActions.GiveInput(PcDisclosedAmountFinanced, disclosedAmountFinanced);
        }
        
        [Then(@"PMI rates Grid should be empty")]
        public void ThenPmiRatesGridShouldBeEmpty()
        {
            var isRowExists = false;
            try
            {
                UIActions.GetText(MiPmiRatesGridRowsCount);
                isRowExists = true;
            }
            catch (Exception)
            {
                // ignored
            }
            if (isRowExists)
                throw new Exception("Grid is not empty");
        }
        
        [Then(@"lower of cost or Appraisal should have default value")]
        public void ThenLowerOfCostOrAppraisalShouldHaveDefaultValue()
        {
            var numberOfPeriodsofAdvanceInsCollected = TridVariable.NoOfPrdsOfAdvcInsurance;
            UIActions.Clear(MiNumberOfPeriodsofAdvanceInsCollected);
            UIActions.GiveInput(MiNumberOfPeriodsofAdvanceInsCollected, numberOfPeriodsofAdvanceInsCollected);

            var lowerOfCostOrAppraisal = TridVariable.LowerOfCostOfAppraisal;
            UIActions.Clear(MiLowerOfCostOrAppraisal);
            UIActions.GiveInput(MiLowerOfCostOrAppraisal, lowerOfCostOrAppraisal);
        }
        
        [Then(@"calculation Method should have default value")]
        public void ThenCalculationMethodShouldHaveDefaultValue()
        {
            UIActions.Click(CdCalMtd30Over360);
        }

        [Then(@"Loan Type should have default value")]
        public void ThenLoanTypeShouldHaveDefaultValue()
        {
            UIActions.Click(CdLoanTypeFixed);
        }

        [Then(@"Frequency of Payments should have default value")]
        public void ThenFrequencyOfPaymentsShouldHaveDefaultValue()
        {
            UIActions.Click(CdFreqOfPaymentMonthly);
        }
        
        [Then(@"Loan Term should have default value")]
        public void ThenLoanTermShouldHaveDefaultValue()
        {
            UIActions.Click(CdLoanTermMonths);
            var loanTermValue = TridVariable.LoanTermValue;
            UIActions.Clear(CdLoanTermValue);
            UIActions.GiveInput(CdLoanTermValue, loanTermValue);
        }
        
        [Then(@"Repayment Term Type should have default value")]
        public void ThenRepaymentTermTypeShouldHaveDefaultValue()
        {
            UIActions.Click(CdRepaymentTermTypeWhole);
        }
        
        [Then(@"Date of Loan, Date of Interest begins to accure and Date of First Payment should have default value")]
        public void ThenDateOfLoanDateOfInterestBeginsToAccureAndDateOfFirstPaymentShouldHaveDefaultValue()
        {
            var dateOfLoan = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateOfLoan)).ToString("d/M/yyyy");
            UIActions.Clear(LeDateOfLoan);
            UIActions.GiveInput(LeDateOfLoan, dateOfLoan);

            var dateOfInterestBegins = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateInterestBeginToAccrue)).ToString("d/M/yyyy");
            UIActions.Clear(LeDateOfInterestBegins);
            UIActions.GiveInput(LeDateOfInterestBegins, dateOfInterestBegins);

            var dateOfFirstPayment = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateOfFirstPayment)).ToString("d/M/yyyy");
            UIActions.Clear(LeDateOfFirstPayment);
            UIActions.GiveInput(LeDateOfFirstPayment, dateOfFirstPayment);
        }
        
        [Then(@"Disclosed values should have default values")]
        public void ThenDisclosedValuesShouldHaveDefaultValues()
        {
            var in5Years = TridVariable.DiscLosedIn5Years;
            UIActions.Clear(LeDisclosedIn5Years);
            UIActions.GiveInput(LeDisclosedIn5Years, in5Years);

            var in5YearsPrincipal = TridVariable.DiscLosedIn5YearsPrincipal;
            UIActions.Clear(LeDisclosedIn5YearsPrincipal);
            UIActions.GiveInput(LeDisclosedIn5YearsPrincipal, in5YearsPrincipal);

            var apr = TridVariable.DisclosedApr;
            UIActions.Clear(LeDisclosedApr);
            UIActions.GiveInput(LeDisclosedApr, apr);

            var tip = TridVariable.DisclosedTip;
            UIActions.Clear(LeDisclosedTip);
            UIActions.GiveInput(LeDisclosedTip, tip);
        }


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
            Assert.IsTrue(File.Exists(filePath),"Exported File does not exists");
        }

        #endregion

        [AfterScenario("TestDefaultValues")]
        public void TearDown()
        {
            UIActions.Quit();
        }
    }
}
