using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;
using TRID.ActionClasses;
using TRID.CommonUtils;
using TRID.GlobalParam;
using TRID.ProjectLibs.Common;
using TRID.TestClasses;

namespace TRID.StepDefinitions
{
    [Binding]
    public class LoanEstimateValidationSteps : TridTest
    {
        readonly GetExcelData _getData = new GetExcelData();

        #region Given 


        [Given(@"user opens TRID application with Prepaid Charges as homepage")]
        public void GivenUserOpensTridApplicationWithPrepaidChargesAsHomepage()
        {
            UIActions.WebDriverWait(PcPrepaidChargesText, 60);
            Thread.Sleep(2000);
        }
        
        [Given(@"all the input and custom fields have zero values")]
        public void GivenAllTheInputAndCustomFieldsHaveZeroValues()
        {
            ProjActions.AddPrepaidChargesDefaultValues();
            ProjActions.PrepaidChargesGridEmptyValidation();
        }
        
        [Given(@"user have Prepaid Charges data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHavePrepaidChargesDataFromExcelSheetForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }
        
        [Given(@"user have Loan Estimate data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHaveLoanEstimateDataFromExcelSheetForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }

        #endregion


        #region When


        [When(@"user navigates to Loan Estimate Page")]
        public void WhenUserNavigatesToLoanEstimatePage()
        {
            UIActions.Click(LoanEstimateLink);
            UIActions.WebDriverWait(LeLoanDetailsText, 60);
        }

        [When(@"select Calculation Method as Actual Over 365")]
        public void WhenSelectCalculationMethodAsActualOver365()
        {
            UIActions.Click(LeCalMtdActOver365);
        }

        [When(@"select Calculation Method as Actual Over (.*) And Leap Years")]
        public void WhenSelectCalculationMethodAsActualOverAndLeapYears(int p0)
        {
            UIActions.Click(LeCalMtdActOver365LeapYear);
        }

        [When(@"select Frequency of Payment as Monthly")]
        public void WhenSelectFrequencyOfPaymentAsMonthly()
        {
            UIActions.Click(LeFreqOfPaymentMonthly);
        }


        [When(@"select repayment type as Regular P and I - Final Balloon Payment")]
        public void WhenSelectRepaymentTypeAsRegularPAndI_FinalBalloonPayment()
        {
            UIActions.Click(CdRepaymentTermTypeFinalBalloon);
        }
        
        [When(@"user enters input value for Loan Amount")]
        public void WhenUserEntersInputValueForLoanAmount()
        {
            var loanAmount = TridVariable.LoanAmount;
            UIActions.Clear(CdLoanAmount);
            UIActions.GiveInput(CdLoanAmount, loanAmount);
        }

        [When(@"user enters input value for Date of loan")]
        public void WhenUserEntersInputValueForDateOfLoan()
        {
            var dateOfLoan = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateOfLoan)).ToString("d/M/yyyy");
            UIActions.Clear(LeDateOfLoan);
            UIActions.GiveInput(LeDateOfLoan, dateOfLoan);           
        }

        [When(@"user enters input value for Date Interest Begins to Accrue")]
        public void WhenUserEntersInputValueForDateInterestBeginsToAccrue()
        {
            var dateOfInterestBegins = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateInterestBeginToAccrue)).ToString("d/M/yyyy");
            UIActions.Clear(LeDateOfInterestBegins);
            UIActions.GiveInput(LeDateOfInterestBegins, dateOfInterestBegins);
        }

        [When(@"user enters input value for Date of first Payment")]
        public void WhenUserEntersInputValueForDateOfFirstPayment()
        {
            var dateOfFirstPayment = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateOfFirstPayment)).ToString("d/M/yyyy");
            UIActions.Clear(LeDateOfFirstPayment);
            UIActions.GiveInput(LeDateOfFirstPayment, dateOfFirstPayment);
        }

        [When(@"user enters input value for Final Balloon Payment")]
        public void WhenUserEntersInputValueForFinalBalloonPayment()
        {
            var finalBalloonPayment = TridVariable.FinalBalloonPayment;
            UIActions.Clear(LeFinalBalloonPayment);
            UIActions.GiveInput(LeFinalBalloonPayment, finalBalloonPayment);
        }
        

        [When(@"Click on Test button under loan details")]
        public void WhenClickOnTestButtonUnderLoanDetails()
        {
            UIActions.MoveToElement(LeLoanDetailsText);
            UIActions.Click(LeLoanDetailsTest);
            Thread.Sleep(5000);
        }

        [When(@"select Frequency of Payment as Multiple of Months")]
        public void WhenSelectFrequencyOfPaymentAsMultipleOfMonths()
        {
            UIActions.Click(LeFreqOfPaymentMultipleOfMonth);
        }
        
        [When(@"user enters input value under frequency of Pmt Value")]
        public void WhenUserEntersInputValueUnderFrequencyOfPmtValue()
        {
            var frequencyOfPaymentValue = TridVariable.FrequencyOfPmtValue;
            UIActions.Clear(LeFreqOfPmtValue);
            UIActions.GiveInput(LeFreqOfPmtValue,frequencyOfPaymentValue);
        }
        
        [When(@"user enters the input value for Period Payment")]
        public void WhenUserEntersTheInputValueForPeriodPayment()
        {
            var periodPayment = TridVariable.PeriodPayment;
            UIActions.Clear(LePeriodPayment);
            UIActions.GiveInput(LePeriodPayment, periodPayment);
        }
        
        [When(@"select Frequency of Payment as Bi-Weekly")]
        public void WhenSelectFrequencyOfPaymentAsBi_Weekly()
        {
            UIActions.Click(LeFreqOfPaymentBiWeekly);
        }
        
        [When(@"frequency of Pmt Value should be empty")]
        public void WhenFrequencyOfPmtValueShouldBeEmpty()
        {
            UIActions.Clear(LeFreqOfPmtValue);
        }

        [When(@"select Frequency of Payment as semi Monthly")]
        public void WhenSelectFrequencyOfPaymentAsSemiMonthly()
        {
            UIActions.Click(LeFreqOfPaymentSemiMonthly);
        }


        #endregion


        #region Then


        [Then(@"Amortization Schedule should recalculate and last row balance should be zero")]
        public void ThenAmortizationScheduleShouldRecalculateAndLastRowBalanceShouldBeZero()
        {

            var numberOfPayments = Convert.ToInt32(UIActions.GetText(LeNumberOfPayments));
            var amortizationScheduleCount = Convert.ToInt32(UIActions.Count(LeAmortizationScheduleCount));
            
            Assert.IsTrue(numberOfPayments == amortizationScheduleCount, "Number of Amortization Schedule is not as expected");


            var expectedLastAmortizationRowValue = "$0.00 = $0.00 + $0.00 + $0.00";
            var actualLastAmortizationRowValue = UIActions.GetText(By.XPath("//div[@id='Mortagagedetails']/md-list/md-list-item["+ numberOfPayments + "]//h4"));

            Assert.AreEqual(expectedLastAmortizationRowValue,actualLastAmortizationRowValue, "Actual Amortization Last Balance Amount does not matches with expected amount");
        }
        
        [Then(@"Payment Date should be of two month period")]
        public void ThenPaymentDateShouldBeOfTwoMonthPeriod()
        {
            var firstAmortizationDay = Convert.ToDateTime(UIActions.GetText(LeFirstAmortizationDate)).Day;
            var secondAmortizationDay = Convert.ToDateTime(UIActions.GetText(LeSecondAmortizationDate)).Day;

            var firstAmortizationMonth = Convert.ToDateTime(UIActions.GetText(LeFirstAmortizationDate)).Month;
            var secondAmortizationMonth = Convert.ToDateTime(UIActions.GetText(LeSecondAmortizationDate)).Month;

            var dayDifference = secondAmortizationDay - firstAmortizationDay;
            var monthDifference = secondAmortizationMonth - firstAmortizationMonth;

            Assert.AreEqual(0, dayDifference, "The Day of Payment Date is not on 1st of every month");
            Assert.AreEqual(2, monthDifference, "The period bewteen Payment Date is not 2 Months");
        }
        
        [Then(@"Payment Date should be increment of 14 days")]
        public void ThenPaymentDateShouldBeIncrementOf14Days()
        {
            var numberOfPayments = Convert.ToInt32(UIActions.GetText(LeNumberOfPayments));
            for (int i = 1; i < numberOfPayments; i++)
            {
                var firstAmortizationDay = Convert.ToDateTime(UIActions.GetText(By.XPath("//div[@id='Mortagagedetails']//md-list-item[" + i + "]//p"))).Day;
                var secondAmortizationDay = Convert.ToDateTime(UIActions.GetText(By.XPath("//div[@id='Mortagagedetails']//md-list-item[" + ++i + "]//p"))).Day;

                var dayDifference = secondAmortizationDay - firstAmortizationDay;

                Assert.AreEqual(14, dayDifference, "The Day of Payment Date is not on 1st of every month");
            }
        }
        
        [Then(@"Payment Schedule should recalculate 780 number of payments")]
        public void ThenPaymentScheduleShouldRecalculate780NumberOfPayments()
        {
            var numberOfPayments = Convert.ToInt32(UIActions.GetText(LeNumberOfPayments));

            Assert.AreEqual(780, numberOfPayments, "Number of Payment schedule is not 780");
        }


        [Then(@"Payment Schedule should recalculate 720 number of payments")]
        public void ThenPaymentScheduleShouldRecalculate720NumberOfPayments()
        {
            var numberOfPayments = Convert.ToInt32(UIActions.GetText(LeNumberOfPayments));

            Assert.AreEqual(720, numberOfPayments, "Number of Payment schedule is not 720");
        }

        [Then(@"Payment Date should be on 1st and 16th of every month")]
        public void ThenPaymentDateShouldBeOn1StAnd16ThOfEveryMonth()
        {
            var numberOfPayments = Convert.ToInt32(UIActions.GetText(LeNumberOfPayments));
            for (int i = 1; i <= numberOfPayments; i++)
            {
                if (i % 2 == 0)
                {
                    var amortizationDay = Convert.ToDateTime(UIActions.GetText(By.XPath("//div[@id='Mortagagedetails']//md-list-item[" + i + "]//p"))).Day;
                    Assert.AreEqual(16, amortizationDay);
                }
                else
                {
                    var amortizationDay = Convert.ToDateTime(UIActions.GetText(By.XPath("//div[@id='Mortagagedetails']//md-list-item[" + i + "]//p"))).Day;
                    Assert.AreEqual(1, amortizationDay);
                }
            }
        }


        #endregion


        [AfterScenario("LoanEstimate")]
        public void TearDown()
        {
           
            UIActions.Quit();
           
        }
    }
}
