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
    public class EscrowInfoCardsValidationSteps : TridTest
    {
        readonly GetExcelData _getData = new GetExcelData();
        public static bool TestCaseStatus = true;
        public static int TestFailureCount;
        public static double ValueDifference;
        public static string CardsFailure = "";

        #region Given

        [Given(@"user have Escrow Info data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHaveEscrowInfoDataFromExcelSheetForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
            ProjActions.GetSheetName(sheetName);
        }

        #endregion

        #region When

        [When(@"user navigates to Escrow Info Cards Page")]
        public void WhenUserNavigatesToEscrowInfoCardsPage()
        {
            UIActions.Click(EscrowInfoLink);
            UIActions.WebDriverWait(EscrowInfoInsuranceLabelText, 60, "Escrow Info Insurance Label Text");
        }

        #endregion

        
        #region Then
    
        [Then(@"updated/computed Insurance Initial Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedInsuranceInitialDepositValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.InsInitialDeposit), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(InsInitialDeposit)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Insurance Initial Deposit value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| InsuranceInitialDeposit || : " + e + " \n ====================================================================================\n";
            }
        }
        
        [Then(@"updated/computed Insurance Period Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedInsurancePeriodDepositValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.InsPeriodDeposit), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(InsPeriodDeposit)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Insurance Period Deposit value does not match as expected with the difference of {0}", ValueDifference);

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| InsurancePeriodDeposit || : " + e + " \n ====================================================================================\n";
            }
        }
        
        [Then(@"updated/computed Insurance Low Balance value should display on Escrow Info")]
        public void ThenUpdatedComputedInsuranceLowBalanceValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.InsLowBalance), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(InsLowBalance)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Insurance Low Balance value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| InsuranceLowBalance || : " + e + " \n ====================================================================================\n";
            }
        }
        
        [Then(@"updated/computed Insurance Cushion value should display on Escrow Info")]
        public void ThenUpdatedComputedInsuranceCushionValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.InsCushion), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(InsCushion)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Insurance Cushion value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| InsuranceCushion || : " + e + " \n ====================================================================================\n";
            }
        }
        
        [Then(@"updated/computed Insurance Total Annual Disbursed value should display on Escrow Info")]
        public void ThenUpdatedComputedInsuranceTotalAnnualDisbursedValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.InsTotalAnnualDisbursed), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(InsTotalAnnualDisbursed)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Insurance Total Annual Disbursed value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| InsuranceTotalAnnualDisbursed || : " + e + " \n ====================================================================================\n";
            }
        }
        
        [Then(@"updated/computed Tax Initial Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedTaxInitialDepositValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.TaxInitialDeposit), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(TaxInitialDeposit)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Tax Initial Deposit value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| TaxInitialDeposit || : " + e + " \n ====================================================================================\n";
            }
        }
        
        [Then(@"updated/computed Tax Period Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedTaxPeriodDepositValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.TaxPeriodDeposit), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(TaxPeriodDeposit)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Tax Period Deposit value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| TaxPeriodDeposit || : " + e + " \n ====================================================================================\n";
            }
        }
        
        [Then(@"updated/computed Tax Low Balance value should display on Escrow Info")]
        public void ThenUpdatedComputedTaxLowBalanceValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.TaxLowBalance), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(TaxLowBalance)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Tax Low Balance value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| TaxLowBalance || : " + e + " \n ====================================================================================\n";
            }
        }
        
        [Then(@"updated/computed Tax Cushion value should display on Escrow Info")]
        public void ThenUpdatedComputedTaxCushionValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.TaxCushion), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(TaxCushion)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Tax Cushion value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| TaxCushion || : " + e + " \n ====================================================================================\n";
            }
        }
        
        [Then(@"updated/computed Tax Total Annual Disbursed value should display on Escrow Info")]
        public void ThenUpdatedComputedTaxTotalAnnualDisbursedValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.TaxTotalAnnualDisbursed), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(TaxTotalAnnualDisbursed)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Tax Total Annual Disbursed value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| TaxTotalAnnualDisbursed || : " + e + " \n ====================================================================================\n";
            }
        }
        
        [Then(@"updated/computed PMI Initial Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedPmiInitialDepositValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.PmiInitialDeposit), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(PmiInitialDeposit)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "PMI Initial Deposit value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| PMIInitialDeposit || : " + e + " \n ====================================================================================\n";
            }
        }
        
        [Then(@"updated/computed PMI Period Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedPmiPeriodDepositValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.PmiPeriodDeposit), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(PmiPeriodDeposit)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "PMI Period Deposit value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| PMIPeriodDeposit || : " + e + " \n ====================================================================================\n";
            }
        }
        
        [Then(@"updated/computed PMI Low Balance value should display on Escrow Info")]
        public void ThenUpdatedComputedPmiLowBalanceValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.PmiLowBalance), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(PmiLowBalance)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "PMI Low Balance value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| PMILowBalance || : " + e + " \n ====================================================================================\n";
            }
        }
        
        [Then(@"updated/computed PMI Cushion value should display on Escrow Info")]
        public void ThenUpdatedComputedPmiCushionValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.PmiCushion), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(PmiCushion)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "PMI Cushion value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| PMICushion || : " + e + " \n ====================================================================================\n";
            }
        }
        
        [Then(@"updated/computed PMI Total Annual Disbursed value should display on Escrow Info")]
        public void ThenUpdatedComputedPmiTotalAnnualDisbursedValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.PmiTotalAnnualDisbursed), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(PmiTotalAnnualDisbursed)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "PMI Total Annual Disbursed value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| PMITotalAnnualDisbursed || : " + e + " \n ====================================================================================\n";
            }
        }
        
        [Then(@"updated/computed Other1 Initial Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedOther1InitialDepositValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.Other1InitialDeposit), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(Other1InitialDeposit)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Other1 Initial Deposit value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| Other1InitialDeposit || : " + e + " \n ====================================================================================\n";
            }
        }
        
        [Then(@"updated/computed Other1 Period Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedOther1PeriodDepositValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.Other1PeriodDeposit), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(Other1PeriodDeposit)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Other1 Period Deposit value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| Other1PeriodDeposit || : " + e + " \n ====================================================================================\n";
            }
        }
        
        [Then(@"updated/computed Other1 Low Balance value should display on Escrow Info")]
        public void ThenUpdatedComputedOther1LowBalanceValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.Other1LowBalance), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(Other1LowBalance)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Other1 Low Balance value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| Other1LowBalance || : " + e + " \n ====================================================================================\n";
            }
        }
        
        [Then(@"updated/computed Other1 Cushion value should display on Escrow Info")]
        public void ThenUpdatedComputedOther1CushionValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.Other1Cushion), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(Other1Cushion)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Other1 Cushion value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| Other1Cushion || : " + e + " \n ====================================================================================\n";
            }
        }
        
        [Then(@"updated/computed Other1 Total Annual Disbursed value should display on Escrow Info")]
        public void ThenUpdatedComputedOther1TotalAnnualDisbursedValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.Other1TotalAnnualDisbursed), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(Other1TotalAnnualDisbursed)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Other1 Total Annual Disbursed value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| Other1TotalAnnualDisbursed || : " + e + " \n ====================================================================================\n";
            }
        }

        [Then(@"updated/computed Other2 Initial Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedOther2InitialDepositValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.Other2InitialDeposit), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(Other2InitialDeposit)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Other2 Initial Deposit value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| Other2InitialDeposit || : " + e + " \n ====================================================================================\n";
            }
        }

        [Then(@"updated/computed Other2 Period Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedOther2PeriodDepositValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.Other2PeriodDeposit), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(Other2PeriodDeposit)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Other2 Period Deposit value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| Other2PeriodDeposit || : " + e + " \n ====================================================================================\n";
            }
        }

        [Then(@"updated/computed Other2 Low Balance value should display on Escrow Info")]
        public void ThenUpdatedComputedOther2LowBalanceValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.Other2LowBalance), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(Other2LowBalance)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Other2 Low Balance value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| Other2LowBalance || : " + e + " \n ====================================================================================\n";
            }
        }

        [Then(@"updated/computed Other2 Cushion value should display on Escrow Info")]
        public void ThenUpdatedComputedOther2CushionValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.Other2Cushion), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(Other2Cushion)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Other2 Cushion value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| Other2Cushion || : " + e + " \n ====================================================================================\n";
            }
        }

        [Then(@"updated/computed Other2 Total Annual Disbursed value should display on Escrow Info")]
        public void ThenUpdatedComputedOther2TotalAnnualDisbursedValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.Other2TotalAnnualDisbursed), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(Other2TotalAnnualDisbursed)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Other2 Total Annual Disbursed value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| Other2TotalAnnualDisbursed || : " + e + " \n ====================================================================================\n";
            }
        }

        [Then(@"updated/computed Aggregate Initial Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedAggregateInitialDepositValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.AggregateInitialDeposit), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AggregateInitialDeposit)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Aggregate Initial Deposit value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| AggregateInitialDeposit || : " + e + " \n ====================================================================================\n";
            }
        }
        
        [Then(@"updated/computed Aggregate Period Deposit value should display on Escrow Info")]
        public void ThenUpdatedComputedAggregatePeriodDepositValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.AggregatePeriodDeposit), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AggregatePeriodDeposit)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Aggregate Period Deposit value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| AggregatePeriodDeposit || : " + e + " \n ====================================================================================\n";
            }
        }
        
        [Then(@"updated/computed Aggregate Low Balance value should display on Escrow Info")]
        public void ThenUpdatedComputedAggregateLowBalanceValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.AggregateLowBalance), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AggregateLowBalance)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Aggregate Low Balance value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| AggregateLowBalance || : " + e + " \n ====================================================================================\n";
            }
        }
        
        [Then(@"updated/computed Aggregate Cushion value should display on Escrow Info")]
        public void ThenUpdatedComputedAggregateCushionValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.AggregateCushion), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AggregateCushion)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Aggregate Cushion value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| AggregateCushion || : " + e + " \n ====================================================================================\n";
            }
        }
        
        [Then(@"updated/computed Aggregate Total Annual Disbursed value should display on Escrow Info")]
        public void ThenUpdatedComputedAggregateTotalAnnualDisbursedValueShouldDisplayOnEscrowInfo()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.AggregateTotalAnnualDisbursed), 2);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AggregateTotalAnnualDisbursed)), 2);
                ValueDifference = Math.Abs(expectedInfoValue - actualInfoValue);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Aggregate Total Annual Disbursed value does not match as expected with the difference of {0}", ValueDifference);
                
                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedInfoValue :{0}", expectedInfoValue);
                Console.WriteLine("ActualInfoValue :{0}", actualInfoValue);
                Console.WriteLine("============================================================");

                ProjActions.CreateCsvFile(ValueDifference.ToString());
            }
            catch (Exception e)
            {
                ProjActions.CreateCsvFile(ValueDifference.ToString());
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| AggregateTotalAnnualDisbursed || : " + e + " \n ====================================================================================\n";
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
