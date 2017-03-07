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
    public class ClosingDisclosureSteps : TridTest
    {
        readonly GetExcelData _getData = new GetExcelData();

        #region Given


        [Given(@"user is at TRID application homepage")]
        public void GivenUserIsAtTridApplicationHomepage()
        {
            UIActions.WebDriverWait(PcPrepaidChargesText, 60);
            Thread.Sleep(5000);
        }

        [Given(@"user navigate to Closing Disclosure Page")]
        public void GivenUserNavigateToClosingDisclosurePage()
        {
            UIActions.Click(ClosingDisclosureLink);
            UIActions.WebDriverWait(CdLoanDetailsText, 60);
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

        [Given(@"user navigate to Mortgage Insruance page")]
        public void GivenUserNavigateToMortgageInsruancePage()
        {
            UIActions.Click(MortgageInsuranceLink);
            //UIActions.WebDriverWait(CdLoanDetailsText, 60);
        }





        #endregion


        #region When


        [When(@"Calculation Method is 30 Over 360")]
        public void WhenCalculationMethodIs30Over360()
        {
            string calculationMethod = TridVariable.CalculationMethod;
            UIActions.Click(CdCalMtd30Over360);
        }

        [When(@"loan type is fixed")]
        public void WhenLoanTypeIsFixed()
        {
            UIActions.Click(CdLoanTypeFixed);
        }

        [When(@"Frequency of Payments is Monthly")]
        public void WhenFrequencyOfPaymentsIsMonthly()
        {
            UIActions.Click(CdFreqOfPaymentMonthly);
        }

        [When(@"Loan Term is Months")]
        public void WhenLoanTermIsMonths()
        {
            UIActions.Click(CdLoanTermMonths);
        }

        [When(@"Repayment Term Type is Regular P And I - Whole Term")]
        public void WhenRepaymentTermTypeIsRegularPAndI_WholeTerm()
        {
            UIActions.Click(CdRepaymentTermTypeWhole);
        }

        [When(@"Enter Loan detail input values for computation")]
        public void WhenEnterLoanDetailInputValuesForComputation()
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

            var dateOfLoan = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateOfLoan)).ToString("d/M/yyyy");
            UIActions.Clear(CdDateOfLoan);
            UIActions.GiveInput(CdDateOfLoan, dateOfLoan);

            var dateOfInterestBegins = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateInterestBeginToAccrue)).ToString("d/M/yyyy");
            UIActions.Clear(CdDateOfInterestBegins);
            UIActions.GiveInput(CdDateOfInterestBegins, dateOfInterestBegins);

            var dateOfFirstPayment = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateOfFirstPayment)).ToString("d/M/yyyy");
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

            var estimatedEscrow = TridVariable.LoanDetailsEstimatedEscrow;
            UIActions.Clear(CdLoanDetailsEstimatedEscrow);
            UIActions.GiveInput(CdLoanDetailsEstimatedEscrow, estimatedEscrow);
        }

        [When(@"click on Loan Details TEST on Closing Disclosure page")]
        public void WhenClickOnLoanDetailsTestOnClosingDisclosurePage()
        {
            UIActions.MoveToElement(CdLoanDetailsText);
            UIActions.Click(CdLoanDetailsTest);
        }


        [When(@"click on Disclosure TEST on Closing Disclosure page")]
        public void WhenClickOnDisclosureTestOnClosingDisclosurePage()
        {
            UIActions.Click(CdDisclosedTest);
        }


        [When(@"click on Loan Details TEST on Loan Estimate Page")]
        public void WhenClickOnLoanDetailsTestOnLoanEstimatePage()
        {
            UIActions.MoveToElement(CdLoanDetailsText);
            UIActions.Click(LeLoanDetailsTest);
        }

        [When(@"click on Disclosure TEST on Loan Estimate Page")]
        public void WhenClickOnDisclosureTestOnLoanEstimatePage()
        {
            UIActions.Click(LeDisclosedTest);
        }

        [When(@"Add Pmi Rate")]
        public void WhenAddPmiRate()
        {
            ProjActions.AddPmiRate();
        }



        #endregion


        #region Then


        [Then(@"Updated Principal and Interest value should display")]
        public void ThenUpdatedPrincipalAndInterestValueShouldDisplay()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPiComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.PrincipalAndInt);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPiDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPiVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");
        }

        [Then(@"Updated PMI value should display")]
        public void ThenUpdatedPmiValueShouldDisplay()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPmiComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.Pmi);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPmiDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPmiVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");
        }

        [Then(@"updated Total Period Payment should display")]
        public void ThenUpdatedTotalPeriodPaymentShouldDisplay()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdTppComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.TotalPeriodPayment);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdTppDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdTppVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");
        }

        [Then(@"Updated Finance Charge should display")]
        public void ThenUpdatedFinanceChargeShouldDisplay()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdFcComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.FinanceCharge);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdFcDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdFcVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");
        }

        [Then(@"Updated Prepaid Charges should display")]
        public void ThenUpdatedPrepaidChargesShouldDisplay()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPcComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.PrepaidCharges);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPcDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPcVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");
        }

        [Then(@"Updated Amount Financed should display")]
        public void ThenUpdatedAmountFinancedShouldDisplay()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdAfComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.AmountFinanced);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdAfDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdAfVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");
        }

        [Then(@"updated APR value should display")]
        public void ThenUpdatedAprValueShouldDisplay()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdAprComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.Apr);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdAprDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdAprVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");
        }

        [Then(@"Updated TIP value should display")]
        public void ThenUpdatedTipValueShouldDisplay()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdTipComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.Tip);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdTipDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdTipVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");
        }

        [Then(@"Updated in 5 Years value should display")]
        public void ThenUpdatedIn5YearsValueShouldDisplay()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(LeI5YComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.In5Years);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(LeI5YDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(LeI5YVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");
        }

        [Then(@"Updated in 5 Years principal should display")]
        public void ThenUpdatedIn5YearsPrincipalShouldDisplay()
        {
            var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(LeI5YpComputedValue));

            var actualCValue = Convert.ToDouble(TridVariable.In5YearsPrincipal);
            Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(LeI5YpDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(LeI5YpVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");
        }



        #endregion

        [AfterScenario("LoanDetails")]
        public void TearDown()
        {
            UIActions.Quit();
        }


    }
}
