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


        //[Given(@"user opens TRID application with Prepaid Charges as homepage")]
        //public void GivenUserOpensTridApplicationWithPrepaidChargesAsHomepage()
        //{
        //    UIActions.WebDriverWait(PcPrepaidChargesText, 60);
        //    Thread.Sleep(2000);
        //}
        
        [Given(@"all the input and custom fields for prepaid charges have zero values")]
        public void GivenAllTheInputAndCustomFieldsforprepaidchargesHaveZeroValues()
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


        [When(@"user selects Calculation Method in Loan Estimate Page")]
        public void WhenUserSelectsCalculationMethodInDisclosurePage()
        {
            ClosingDisclosureRadioButtonVariable();
            UIActions.Click(LeCalculationMethod);
        }

        [When(@"user selects loan type in Loan Estimate Page")]
        public void WhenUserSelectsLoanTypeInLoanEstimatePage()
        {
            ClosingDisclosureRadioButtonVariable();
            UIActions.Click(LeLoanType);
        }

        [When(@"user selects Frequency of Payments in Loan Estimate Page")]
        public void WhenUserSelectsFrequencyOfPaymentsInLoanEstimatePage()
        {
            ClosingDisclosureRadioButtonVariable();
            UIActions.Click(LeFrequencyOfPayments);
        }

        [When(@"user selects Loan Term in Loan Estimate Page")]
        public void WhenUserSelectsLoanTermInLoanEstimatePage()
        {
            ClosingDisclosureRadioButtonVariable();
            UIActions.Click(LeLoanTerm);
        }

        [When(@"user selects Repayment Term Type in Loan Estimate Page")]
        public void WhenUserSelectsRepaymentTermTypeInLoanEstimatePage()
        {
            ClosingDisclosureRadioButtonVariable();
            UIActions.Click(LeRepaymentTermType);
        }

        [When(@"Enter Loan detail input values for computation for Loan Estimate page")]
        public void WhenEnterLoanDetailInputValuesForComputationforLoanEstimatepage()
        {
            var loanTermValue = TridVariable.LoanTermValue;
            UIActions.Clear(LeLoanTermValue);
            UIActions.GiveInput(LeLoanTermValue, loanTermValue);

            var loanAmount = TridVariable.LoanAmount;
            UIActions.Clear(LeLoanAmount);
            UIActions.GiveInput(LeLoanAmount, loanAmount);

            var rateOfInterest = TridVariable.RateOfInterest;
            UIActions.Clear(LeRateOfInterest);
            UIActions.GiveInput(LeRateOfInterest, rateOfInterest);

            var dateOfLoan = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateOfLoan)).ToString("M/d/yyyy");
            UIActions.Clear(LeDateOfLoan);
            UIActions.GiveInput(LeDateOfLoan, dateOfLoan);

            var dateOfInterestBegins = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateInterestBeginToAccrue)).ToString("M/d/yyyy");
            UIActions.Clear(LeDateOfInterestBegins);
            UIActions.GiveInput(LeDateOfInterestBegins, dateOfInterestBegins);

            var dateOfFirstPayment = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateOfFirstPayment)).ToString("M/d/yyyy");
            UIActions.Clear(LeDateOfFirstPayment);
            UIActions.GiveInput(LeDateOfFirstPayment, dateOfFirstPayment);

            var periodPayment = TridVariable.PeriodPayment;
            UIActions.Clear(LePeriodPayment);
            UIActions.GiveInput(LePeriodPayment, periodPayment);

            var loanCostsForDisclosure = TridVariable.LoanCosts;
            UIActions.Clear(LeLoanCostsForDisclosure);
            UIActions.GiveInput(LeLoanCostsForDisclosure, loanCostsForDisclosure);

            var finalBalloonPayment = TridVariable.FinalBalloonPayment;
            UIActions.Clear(LeFinalBalloonPayment);
            UIActions.GiveInput(LeFinalBalloonPayment, finalBalloonPayment);
        }

        [When(@"Enter Disclosed input values for Loan Estimate Page")]
        public void WhenEnterDisclosedInputValuesForLoanEstimatePage()
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

        //[When(@"user enters input value for Loan Amount")]
        //public void WhenUserEntersInputValueForLoanAmount()
        //{
        //    var loanAmount = TridVariable.LoanAmount;
        //    UIActions.Clear(CdLoanAmount);
        //    UIActions.GiveInput(CdLoanAmount, loanAmount);
        //}

        //[When(@"user enters input value for Date of loan")]
        //public void WhenUserEntersInputValueForDateOfLoan()
        //{
        //    var dateOfLoan = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateOfLoan)).ToString("d/M/yyyy");
        //    UIActions.Clear(LeDateOfLoan);
        //    UIActions.GiveInput(LeDateOfLoan, dateOfLoan);
        //}

        //[When(@"user enters input value for Date Interest Begins to Accrue")]
        //public void WhenUserEntersInputValueForDateInterestBeginsToAccrue()
        //{
        //    var dateOfInterestBegins = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateInterestBeginToAccrue)).ToString("d/M/yyyy");
        //    UIActions.Clear(LeDateOfInterestBegins);
        //    UIActions.GiveInput(LeDateOfInterestBegins, dateOfInterestBegins);
        //}

        //[When(@"user enters input value for Date of first Payment")]
        //public void WhenUserEntersInputValueForDateOfFirstPayment()
        //{
        //    var dateOfFirstPayment = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateOfFirstPayment)).ToString("d/M/yyyy");
        //    UIActions.Clear(LeDateOfFirstPayment);
        //    UIActions.GiveInput(LeDateOfFirstPayment, dateOfFirstPayment);
        //    Thread.Sleep(3000);
        //}

        //[When(@"user enters input value for Final Balloon Payment")]
        //public void WhenUserEntersInputValueForFinalBalloonPayment()
        //{
        //    var finalBalloonPayment = TridVariable.FinalBalloonPayment;
        //    UIActions.Clear(LeFinalBalloonPayment);
        //    UIActions.GiveInput(LeFinalBalloonPayment, finalBalloonPayment);
        //}


        [When(@"Click on Test button under loan details")]
        public void WhenClickOnTestButtonUnderLoanDetails()
        {
            UIActions.Click(ClosingDisclosureLink);
            Thread.Sleep(3000);
            UIActions.WebDriverWait(CdLoanDetailsText, 60);


            UIActions.Click(LoanEstimateLink);
            Thread.Sleep(3000);
            UIActions.WebDriverWait(LeLoanDetailsText, 60);

            UIActions.Click(LeLoanDetailsTest);
            Thread.Sleep(5000);
        }

        //[When(@"select Frequency of Payment as Multiple of Months")]
        //public void WhenSelectFrequencyOfPaymentAsMultipleOfMonths()
        //{
        //    UIActions.Click(LeFreqOfPaymentMultipleOfMonth);
        //}

        //[When(@"user enters input value under frequency of Pmt Value")]
        //public void WhenUserEntersInputValueUnderFrequencyOfPmtValue()
        //{
        //    var frequencyOfPaymentValue = TridVariable.FrequencyOfPmtValue;
        //    UIActions.Clear(LeFreqOfPmtValue);
        //    UIActions.GiveInput(LeFreqOfPmtValue, frequencyOfPaymentValue);
        //}

        //[When(@"user enters the input value for Period Payment")]
        //public void WhenUserEntersTheInputValueForPeriodPayment()
        //{
        //    var periodPayment = TridVariable.PeriodPayment;
        //    UIActions.Clear(LePeriodPayment);
        //    UIActions.GiveInput(LePeriodPayment, periodPayment);
        //}

        //[When(@"select Frequency of Payment as Bi-Weekly")]
        //public void WhenSelectFrequencyOfPaymentAsBi_Weekly()
        //{
        //    UIActions.Click(LeFreqOfPaymentBiWeekly);
        //}

        //[When(@"frequency of Pmt Value should be empty")]
        //public void WhenFrequencyOfPmtValueShouldBeEmpty()
        //{
        //    UIActions.Clear(LeFreqOfPmtValue);
        //}

        //[When(@"select Frequency of Payment as semi Monthly")]
        //public void WhenSelectFrequencyOfPaymentAsSemiMonthly()
        //{
        //    UIActions.Click(LeFreqOfPaymentSemiMonthly);
        //}


        [Then(@"Amortization schedule should be calculated as expected for Feb 2017")]
        public void ThenAmortizationScheduleShouldBeCalculatedAsExpectedForFeb()
        {
            var ExpectedAmortizationFeb2017Amount = "$606.68 = $197.71 + $408.97 + $0.00";
            var actualAmortizationFeb2017Amount = UIActions.GetText(LeAmortizationFeb2017Amount);

            Assert.AreEqual(ExpectedAmortizationFeb2017Amount, actualAmortizationFeb2017Amount, "Amortization Caluclation for Feb 2017 does not matches as expected");
        }

        [Then(@"Amortization schedule should recaulcuate for Feb 2017")]
        public void ThenAmortizationScheduleShouldRecaulcuateForFeb()
        {
            var ExpectedAmortizationFeb2017Amount = "$606.68 = $197.75 + $408.93 + $0.00";
            var actualAmortizationFeb2017Amount = UIActions.GetText(LeAmortizationFeb2017Amount);

            Assert.AreEqual(ExpectedAmortizationFeb2017Amount, actualAmortizationFeb2017Amount, "Amortization Caluclation for Feb 2017 does not matches as expected");
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
            var actualLastAmortizationRowValue = UIActions.GetText(By.XPath("//div[@id='Mortagagedetails']/md-list/md-list-item[" + numberOfPayments + "]//h4"));

            Assert.AreEqual(expectedLastAmortizationRowValue, actualLastAmortizationRowValue, "Actual Amortization Last Balance Amount does not matches with expected amount");
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
                var firstAmortizationDay = Convert.ToDateTime(UIActions.GetText(By.XPath("//div[@id='Mortagagedetails']//md-list-item[" + i + "]//p"))).Date;
                var secondAmortizationDay = Convert.ToDateTime(UIActions.GetText(By.XPath("//div[@id='Mortagagedetails']//md-list-item[" + ++i + "]//p"))).Date;

                var dayDifference = (secondAmortizationDay - firstAmortizationDay).TotalDays;

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
                    Assert.AreEqual(16, amortizationDay, "The Payment date is not on 16th of month");
                }
                else
                {
                    var amortizationDay = Convert.ToDateTime(UIActions.GetText(By.XPath("//div[@id='Mortagagedetails']//md-list-item[" + i + "]//p"))).Day;
                    Assert.AreEqual(1, amortizationDay, "The Payment date is not on 1st of month");
                }
            }
        }


        [Then(@"updated/computed TIP value should display on Loan Estimate")]
        public void ThenUpdatedComputedTipValueShouldDisplayOnLoanEstimate()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(LeTipComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.Tip);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(LeTipDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(LeTipVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }


        [Then(@"updated/computed in 5 Years value should display on Loan Estimate")]
        public void ThenUpdatedComputedIn5YearsValueShouldDisplayOnLoanEstimate()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(LeI5YComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.In5Years);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(LeI5YDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(LeI5YVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed in 5 Years principal value should display on Loan Estimate")]
        public void ThenUpdatedComputedIn5YearsPrincipalValueShouldDisplayOnLoanEstimate()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(LeI5YpComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.In5YearsPrincipal);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(LeI5YpDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(LeI5YpVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }


        [Then(@"updated/computed APR value should display on Loan Estimate")]
        public void ThenUpdatedComputedAprValueShouldDisplayOnLoanEstimate()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(LeAprComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.Apr);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(LeAprDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(LeAprVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        #endregion


        [AfterScenario("LoanEstimate")]
        public void TearDown()
        {
            UIActions.Quit();
        }
    }
}
