using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TRID.ActionClasses;
using TRID.CommonUtils;
using TRID.ProjectLibs.Common;
using TRID.TestClasses;

namespace TRID.StepDefinitions
{
    [Binding]
    public class AmortizationValidationSteps : TridTest
    {

        readonly GetExcelData _getData = new GetExcelData();
        public static bool TestCaseStatus = true;
        public static int TestFailureCount;
        public static double ValueDifference;
        public static string CardsFailure = "";

        #region Given

        [Given(@"user have Payment Schedule data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHavePaymentScheduleDataFromExcelSheetForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }

        #endregion

        #region When

        [When(@"user navigates to Amortization Page")]
        public void WhenUserNavigatesToAmortizationPage()
        {
            UIActions.Click(AmortizationLink);
            UIActions.WebDriverWait(PaymentScheduleLabelText, 60, "PaymentScheduleLabelText");
        }

        #endregion

  
        #region Then
       
        [Then(@"updated/computed Payment Stream Number value should display on Payment Schedule Grid")]
        public void ThenUpdatedComputedPaymentStreamNumberValueShouldDisplayOnPaymentScheduleGrid()
        {
            for (var rowIndex = 0; rowIndex < TridVariable.PaymentStreamNo.Count; rowIndex++)
            {
                PaymentScheduleGridElements(rowIndex + 1);
                try
                {
                    var actualValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(PaymentStreamNumber)), 2);
                    var expectedValue = Math.Round(Convert.ToDouble(TridVariable.PaymentStreamNo[rowIndex]), 2);
                    ValueDifference = Math.Abs(expectedValue - actualValue);
                    Assert.AreEqual(expectedValue, actualValue, "Actual value does not match as expected for the row {0} with the difference of {1}", rowIndex + 1, ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedValue Row {0} :{1}", rowIndex + 1, expectedValue);
                    Console.WriteLine("ActualValue Row {0} :{1}", rowIndex + 1, actualValue);
                    Console.WriteLine("============================================================");
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| PaymentStreamNo["+ (rowIndex+1) +"] || : " + e + " \n ====================================================================================\n";
                }
            }
        }
        
        [Then(@"updated/computed Number of Payments value should display on Payment Schedule Grid")]
        public void ThenUpdatedComputedNumberOfPaymentsValueShouldDisplayOnPaymentScheduleGrid()
        {
            for (var rowIndex = 0; rowIndex < TridVariable.PaymentScheduleNumberOfPayments.Count; rowIndex++)
            {
                PaymentScheduleGridElements(rowIndex + 1);
                try
                {
                    var actualValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(PaymentScheduleNumberOfPayments)), 2);
                    var expectedValue = Math.Round(Convert.ToDouble(TridVariable.PaymentScheduleNumberOfPayments[rowIndex]), 2);
                    ValueDifference = Math.Abs(expectedValue - actualValue);
                    Assert.AreEqual(expectedValue, actualValue, "Actual value does not match as expected for the row {0} with the difference of {1}", rowIndex + 1, ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedValue Row {0} :{1}", rowIndex + 1, expectedValue);
                    Console.WriteLine("ActualValue Row {0} :{1}", rowIndex + 1, actualValue);
                    Console.WriteLine("============================================================");
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| PaymentScheduleNumberOfPayments[" + rowIndex + "] || : " + e + " \n ====================================================================================\n";
                }
            }
        }
        
        [Then(@"updated/computed Payment Amount value should display on Payment Schedule Grid")]
        public void ThenUpdatedComputedPaymentAmountValueShouldDisplayOnPaymentScheduleGrid()
        {
            for (var rowIndex = 0; rowIndex < TridVariable.PaymentAmount.Count; rowIndex++)
            {
                PaymentScheduleGridElements(rowIndex + 1);
                try
                {
                    var actualValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(PaymentAmount)), 2);
                    var expectedValue = Math.Round(Convert.ToDouble(TridVariable.PaymentAmount[rowIndex]), 2);
                    ValueDifference = Math.Abs(expectedValue - actualValue);
                    Assert.AreEqual(expectedValue, actualValue, "Actual value does not match as expected for the row {0} with the difference of {1}", rowIndex + 1, ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedValue Row {0} :{1}", rowIndex + 1, expectedValue);
                    Console.WriteLine("ActualValue Row {0} :{1}", rowIndex + 1, actualValue);
                    Console.WriteLine("============================================================");
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| PaymentAmount[" + rowIndex + "] || : " + e + " \n ====================================================================================\n";
                }
            }
        }
        
        [Then(@"updated/computed Monthly Payment value should display on Payment Schedule Grid")]
        public void ThenUpdatedComputedMonthlyPaymentValueShouldDisplayOnPaymentScheduleGrid()
        {
            for (var rowIndex = 0; rowIndex < TridVariable.MonthlyPayment.Count; rowIndex++)
            {
                PaymentScheduleGridElements(rowIndex + 1);
                try
                {
                    var actualValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(MonthlyPayment)), 2);
                    var expectedValue = Math.Round(Convert.ToDouble(TridVariable.MonthlyPayment[rowIndex]), 2);
                    ValueDifference = Math.Abs(expectedValue - actualValue);
                    Assert.AreEqual(expectedValue, actualValue, "Actual value does not match as expected for the row {0} with the difference of {1}", rowIndex + 1, ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedValue Row {0} :{1}", rowIndex + 1, expectedValue);
                    Console.WriteLine("ActualValue Row {0} :{1}", rowIndex + 1, actualValue);
                    Console.WriteLine("============================================================");
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| MonthlyPayment[" + rowIndex + "] || : " + e + " \n ====================================================================================\n";
                }
            }
        }

        [Then(@"updated/computed Monthly PMI value should display on Payment Schedule Grid")]
        public void ThenUpdatedComputedMonthlyPmiValueShouldDisplayOnPaymentScheduleGrid()
        {
            for (var rowIndex = 0; rowIndex < TridVariable.MonthlyPmi.Count; rowIndex++)
            {
                PaymentScheduleGridElements(rowIndex + 1);
                try
                {
                    var actualValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(MonthlyPmi)), 2);
                    var expectedValue = Math.Round(Convert.ToDouble(TridVariable.MonthlyPmi[rowIndex]), 2);
                    ValueDifference = Math.Abs(expectedValue - actualValue);
                    Assert.AreEqual(expectedValue, actualValue, "Actual value does not match as expected for the row {0} with the difference of {1}", rowIndex + 1, ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedValue Row {0} :{1}", rowIndex + 1, expectedValue);
                    Console.WriteLine("ActualValue Row {0} :{1}", rowIndex + 1, actualValue);
                    Console.WriteLine("============================================================");
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| MonthlyPmi[" + rowIndex + "] || : " + e + " \n ====================================================================================\n";
                }
            }
        }

        [Then(@"updated/computed Ins Escrowed Amount value should display on Payment Schedule Grid")]
        public void ThenUpdatedComputedInsEscrowedAmountValueShouldDisplayOnPaymentScheduleGrid()
        {
            for (var rowIndex = 0; rowIndex < TridVariable.InsEscrowedAmount.Count; rowIndex++)
            {
                PaymentScheduleGridElements(rowIndex + 1);
                try
                {
                    var actualValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(InsEscrowedAmount)), 2);
                    var expectedValue = Math.Round(Convert.ToDouble(TridVariable.InsEscrowedAmount[rowIndex]), 2);
                    ValueDifference = Math.Abs(expectedValue - actualValue);
                    Assert.AreEqual(expectedValue, actualValue, "Actual value does not match as expected for the row {0} with the difference of {1}", rowIndex + 1, ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedValue Row {0} :{1}", rowIndex + 1, expectedValue);
                    Console.WriteLine("ActualValue Row {0} :{1}", rowIndex + 1, actualValue);
                    Console.WriteLine("============================================================");
                }
                catch (Exception e)
                {
                    ProjActions.CreateCsvFile(ValueDifference.ToString());
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| InsEscrowedAmount[" + rowIndex + "] || : " + e + " \n ====================================================================================\n";
                }
            }
        }

        [Then(@"updated/computed Tax Escrowed Amount value should display on Payment Schedule Grid")]
        public void ThenUpdatedComputedTaxEscrowedAmountValueShouldDisplayOnPaymentScheduleGrid()
        {
            for (var rowIndex = 0; rowIndex < TridVariable.TaxEscrowedAmount.Count; rowIndex++)
            {
                PaymentScheduleGridElements(rowIndex + 1);
                try
                {
                    var actualValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(TaxEscrowedAmount)), 2);
                    var expectedValue = Math.Round(Convert.ToDouble(TridVariable.TaxEscrowedAmount[rowIndex]), 2);
                    ValueDifference = Math.Abs(expectedValue - actualValue);
                    Assert.AreEqual(expectedValue, actualValue, "Actual value does not match as expected for the row {0} with the difference of {1}", rowIndex + 1, ValueDifference);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedValue Row {0} :{1}", rowIndex + 1, expectedValue);
                    Console.WriteLine("ActualValue Row {0} :{1}", rowIndex + 1, actualValue);
                    Console.WriteLine("============================================================");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| TaxEscrowedAmount[" + rowIndex + "] || : " + e + " \n ====================================================================================\n";
                }
            }
        }

        #endregion

        [AfterTestRun]
        public static void TearDown()
        {
            UIActions.Quit();
            if (!TestCaseStatus)
            {
                Console.WriteLine("####################################################################################");
                Console.WriteLine("====================================================================================");
                Console.WriteLine("Scenario Number : {0}", TridVariable.ScenarioNo);
                Console.WriteLine("The total number of cards Failue: {0}", TestFailureCount);
                Console.WriteLine("Name of cards Failed: {0}", CardsFailure);
                Console.WriteLine("====================================================================================");
                Console.WriteLine("####################################################################################");
                throw new Exception("Test Case failed");
            }
        }
    }
}
