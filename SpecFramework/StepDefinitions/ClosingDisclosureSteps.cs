using System;
using System.Configuration;
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
    public class ClosingDisclosureSteps : TridTest
    {
        private static string Url => ConfigurationManager.AppSettings["url"];
        readonly GetExcelData _getData = new GetExcelData();

        #region Given

        [Given(@"user is at Prepaid Charges page")]
        public void GivenUserIsAtPrepaidChargesPage()
        {
            Thread.Sleep(3000);
            UIActions.Click(PrepaidChargesLink);
            UIActions.WebDriverWait(PcPrepaidChargesText, 60);
        }


        [Given(@"user is at TRID application homepage")]
        public void GivenUserIsAtTridApplicationHomepage()
        {
            //UIActions.WindowMaximize();
            UIActions.GoToUrl(Url + "?tKey=EB535076-2140-4106-8CAE-B230F6E2D082&aKey=TRID");
            Thread.Sleep(5000);
            //Thread.Sleep(3000);
            //UIActions.Click(PrepaidChargesLink);
            UIActions.WebDriverWait(PcPrepaidChargesText, 60);
            Thread.Sleep(5000);
        }
       
        [Given(@"user have all the input values from Excel sheet (.*) for scenario (.*)")]
        public void GivenUserHaveAllTheInputValuesFromExcelSheetForScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }

        [Given(@"user navigate to Loan Estimate Page")]
        public void GivenUserNavigateToLoanEstimatePage()
        {
            UIActions.Click(LoanEstimateLink);
            UIActions.WebDriverWait(CdLoanDetailsText, 60);
        }

        [Given(@"user is at Mortgage Insurance Page")]
        public void GivenUserIsAtMortgageInsurancePage()
        {
            UIActions.Click(MortgageInsuranceLink);
            UIActions.WebDriverWait(MortgageInsuranceLink, 60);
        }

        [Given(@"PMI Rates Grid is empty")]
        public void GivenPmiRatesGridIsEmpty()
        {
            ProjActions.PmiRatesGridEmptyValidation();
        }


        #endregion


        #region When

        [When(@"user navigate to Closing Disclosure Page")]
        public void GivenUserNavigateToClosingClosingDisclosurePage()
        {
            UIActions.Click(ClosingDisclosureLink);
            UIActions.WebDriverWait(CdLoanDetailsText, 60);
        }

        [When(@"user selects Calculation Method in Closing Disclosure Page")]
        public void WhenUserSelectsCalculationMethodInClosingDisclosurePage()
        {
            ClosingDisclosureRadioButtonVariable();
            UIActions.Click(CdCalculationMethod);
        }

        [When(@"user selects loan type in Closing Disclosure Page")]
        public void WhenUserSelectsLoanTypeInClosingDisclosurePage()
        {
            ClosingDisclosureRadioButtonVariable();
            UIActions.Click(CdLoanType);
        }

        [When(@"user selects Frequency of Payments in Closing Disclosure Page")]
        public void WhenUserSelectsFrequencyOfPaymentsInClosingDisclosurePage()
        {
            ClosingDisclosureRadioButtonVariable();
            UIActions.Click(CdFrequencyOfPayments);
        }

        [When(@"user selects Loan Term in Closing Disclosure Page")]
        public void WhenUserSelectsLoanTermInClosingDisclosurePage()
        {
            ClosingDisclosureRadioButtonVariable();
            UIActions.Click(CdLoanTerm);
        }

        [When(@"user selects Repayment Term Type in Closing Disclosure Page")]
        public void WhenUserSelectsRepaymentTermTypeInClosingDisclosurePage()
        {
            ClosingDisclosureRadioButtonVariable();
            UIActions.Click(CdRepaymentTermType);
        }

        [When(@"Enter Loan detail input values for computation for Closing Disclosure page")]
        public void WhenEnterLoanDetailInputValuesForComputationforClosingDisclosurepage()
        {
            var loanTermValue = TridVariable.LoanTermValue;
            UIActions.Clear(CdLoanTermValue);
            UIActions.GiveInput(CdLoanTermValue, loanTermValue);

            var loanAmount = TridVariable.LoanAmount;
            UIActions.Clear(CdLoanAmount);
            UIActions.GiveInput(CdLoanAmount, loanAmount);

            var rateOfInterest = TridVariable.RateOfInterest;
            UIActions.Clear(CdRateOfInterest);
            UIActions.GiveInput(CdRateOfInterest, rateOfInterest);

            var dateOfLoan = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateOfLoan)).ToString("M/d/yyyy");
            UIActions.Clear(CdDateOfLoan);
            UIActions.GiveInput(CdDateOfLoan, dateOfLoan);

            var dateOfInterestBegins = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateInterestBeginToAccrue)).ToString("M/d/yyyy");
            UIActions.Clear(CdDateOfInterestBegins);
            UIActions.GiveInput(CdDateOfInterestBegins, dateOfInterestBegins);

            var dateOfFirstPayment = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateOfFirstPayment)).ToString("M/d/yyyy");
            UIActions.Clear(CdDateOfFirstPayment);
            UIActions.GiveInput(CdDateOfFirstPayment, dateOfFirstPayment);

            var periodPayment = TridVariable.PeriodPayment;
            UIActions.Clear(CdPeriodPayment);
            UIActions.GiveInput(CdPeriodPayment, periodPayment);

            var loanCostsForDisclosure = TridVariable.LoanCosts;
            UIActions.Clear(CdLoanCostsForDisclosure);
            UIActions.GiveInput(CdLoanCostsForDisclosure, loanCostsForDisclosure);

            var finalBalloonPayment = TridVariable.FinalBalloonPayment;
            UIActions.Clear(CdFinalBalloonPayment);
            UIActions.GiveInput(CdFinalBalloonPayment, finalBalloonPayment);
        }

        [When(@"Enter Disclosed input values for Closing Disclosure page")]
        public void WhenEnterDisclosedInputValuesForClosingDisclosurePage()
        {
            var monthlyPrincipalAndInterest = TridVariable.MonthlyPrincipalAndInterest;
            UIActions.Clear(CdMonthlyPrincipalandInterest);
            UIActions.GiveInput(CdMonthlyPrincipalandInterest, monthlyPrincipalAndInterest);

            var monthlyPmi = TridVariable.MonthlyPmi;
            UIActions.Clear(CdMonthlyPmi);
            UIActions.GiveInput(CdMonthlyPmi, monthlyPmi);

            var totalMonhtlyPayment = TridVariable.TotalMonhtlyPayment;
            UIActions.Clear(CdTotalMonthlyPayment);
            UIActions.GiveInput(CdTotalMonthlyPayment, totalMonhtlyPayment);

            var pmiTerminationDate = DateTime.FromOADate(Convert.ToDouble(TridVariable.PmiTerminationDate)).ToString("M/d/yyyy");
            UIActions.Clear(CdPmiTerminalDate);
            UIActions.GiveInput(CdPmiTerminalDate, pmiTerminationDate);

            var pmiCancelDate = DateTime.FromOADate(Convert.ToDouble(TridVariable.PmiCancelDate)).ToString("M/d/yyyy");
            UIActions.Clear(CdPmiCancelDate);
            UIActions.GiveInput(CdPmiCancelDate, pmiCancelDate);

            var disclosedFinalBalloonPayment = TridVariable.DisclosedFinalBalloonPayment;
            UIActions.Clear(CdDisclosedFinalBalloonPayment);
            UIActions.GiveInput(CdDisclosedFinalBalloonPayment, disclosedFinalBalloonPayment);

            var disclosedTotalOfPayment = TridVariable.DisclosedTotalOfPayment;
            UIActions.Clear(CdDisclosedTotalOfPayment);
            UIActions.GiveInput(CdDisclosedTotalOfPayment, disclosedTotalOfPayment);
        }


        [When(@"click on Loan Details TEST on Closing Disclosure page")]
        public void WhenClickOnLoanDetailsTestOnClosingDisclosurePage()
        {
            Thread.Sleep(3000);
            UIActions.Click(LoanEstimateLink);
            Thread.Sleep(3000);
            UIActions.WebDriverWait(LeLoanDetailsText, 60);

            UIActions.Click(ClosingDisclosureLink);
            Thread.Sleep(3000);
            UIActions.WebDriverWait(CdLoanDetailsText, 60);
        }


        [When(@"click on Disclosure TEST on Closing Disclosure page")]
        public void WhenClickOnDisclosureTestOnClosingDisclosurePage()
        {
            UIActions.Click(CdDisclosedTest);
        }


        [When(@"click on Loan Details TEST on Loan Estimate Page")]
        public void WhenClickOnLoanDetailsTestOnLoanEstimatePage()
        {
            Thread.Sleep(3000);
            UIActions.Click(ClosingDisclosureLink);
            Thread.Sleep(3000);
            UIActions.WebDriverWait(CdLoanDetailsText, 60);


            UIActions.Click(LoanEstimateLink);
            Thread.Sleep(3000);
            UIActions.WebDriverWait(LeLoanDetailsText, 60);

            UIActions.Click(LeLoanDetailsTest);
            Thread.Sleep(5000);
        }

        [When(@"click on Disclosure TEST on Loan Estimate Page")]
        public void WhenClickOnDisclosureTestOnLoanEstimatePage()
        {
            UIActions.Click(LeDisclosedTest);
        }
       
        #endregion


        #region Then


        [Then(@"updated/computed Principal and Interest value should display on Closing Disclosure")]
        public void ThenUpdatedComputedPrincipalAndInterestValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPiComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.PrincipalAndInt);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPiDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPiVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed pmi value should display on Closing Disclosure")]
        public void ThenUpdatedComputedPmiValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPmiComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.Pmi);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPmiDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPmiVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed Drop off years for PMI value should display on Closing Disclosure")]
        public void ThenUpdatedComputedDropOffYearsForPmiValueShouldDisplayOnClosingDisclosure()
        {
            //var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdDoyfpComputedValue));

            //var actualCValue = Convert.ToDouble(TridVariable.DropOffYearsForPmi);
            //Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            //var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdDoyfpDisclosureValue));
            //var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdDoyfpVarianceValue));

            //var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            //Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");
            //var ss = UIActions.GetText(CdDoyfpComputedValue);
            //var cValue = new DateTime();

            //if (UIActions.GetText(CdDoyfpComputedValue) != "(C): N/A")
            var cValue = ProjActions.GetDatePart(CdDoyfpComputedValue);
            //else
            //{
            //    cValue = nullda
            //}


            var actualCValue = Convert.ToDateTime(DateTime.FromOADate(Convert.ToDouble(TridVariable.DropOffYearsForPmi)).ToString("M/d/yyyy"));
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetDatePart(CdDoyfpDisclosureValue);
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdDoyfpVarianceValue));

            var actualVarianceValue = (cValue - dValue).TotalDays;

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }


        [Then(@"updated/computed Total Period Payment value should display on Closing Disclosure")]
        public void ThenUpdatedComputedTotalPeriodPaymentValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdTppComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.TotalPeriodPayment);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdTppDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdTppVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed Prepaid Charges value should display on Closing Disclosure")]
        public void ThenUpdatedComputedPrepaidChargesValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPcComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.PrepaidCharges);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPcDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPcVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed Amount Financed value should display on Closing Disclosure")]
        public void ThenUpdatedComputedAmountFinancedValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdAfComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.AmountFinanced);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdAfDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdAfVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed Escrow Property Costs over one year value should display on Closing Disclosure")]
        public void ThenUpdatedComputedEscrowPropertyCostsOverOneYearValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdEpcooyComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.EscrowPropertyOverOneYear);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdEpcooyDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdEpcooyVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }


        [Then(@"updated/computed APR value should display on Closing Disclosure")]
        public void ThenUpdatedComputedAprValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdAprComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.Apr);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdAprDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdAprVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed Balloon Amount value should display on Closing Disclosure")]
        public void ThenUpdatedComputedBalloonAmountValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdBaComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.FinalBalloonPayment);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdBaDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdBaVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed Total of Payments value should display on Closing Disclosure")]
        public void ThenUpdatedComputedTotalOfPaymentsValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdTopComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.TotalOfPayments);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdTopDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdTopVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed Finance Charge value should display on Closing Disclosure")]
        public void ThenUpdatedComputedFinanceChargeValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdFcComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.FinanceCharge);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdFcDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdFcVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed TIP value should display on Closing Disclosure")]
        public void ThenUpdatedComputedTipValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdTipComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.Tip);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdTipDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdTipVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed Initial Escrow Payment value should display on Closing Disclosure")]
        public void ThenUpdatedComputedInitialEscrowPaymentValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdIepComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.InitialEscrowPayment);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdIepDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdIepVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }


        [Then(@"updated/computed Non Escrow Property Costs over one year value should display on Closing Disclosure")]
        public void ThenUpdatedComputedNonEscrowPropertyCostsOverOneYearValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdNepcooyComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.NonEscrowPropertyOverOneYear);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdNepcooyDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdNepcooyVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed Period Escrow Payment value should display on Closing Disclosure")]
        public void ThenUpdatedComputedPeriodEscrowPaymentValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPepComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.Tip);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPepDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPepVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        #endregion

        [AfterTestRun]
        public static void TearDown()
        {
            UIActions.Quit();
        }
    }
}
