using System;
using System.Configuration;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TRID.ActionClasses;
using TRID.CommonUtils;
using TRID.ProjectLibs.Common;
using TRID.TestClasses;


namespace TRID.StepDefinitions
{
    [Binding]
    public class CardsValidationSteps : TridTest
    {
        private static string Url => ConfigurationManager.AppSettings["url"];
        readonly GetExcelData _getData = new GetExcelData();
        public static bool TestCaseStatus = true;
        public static int TestFailureCount;
        public static string CardsFailure = "";


        #region Given

       
        [Given(@"user is at TRID application homepage")]
        public void GivenUserIsAtTridApplicationHomepage()
        {
            UIActions.WindowMaximize();
            UIActions.GoToUrl(Url);
            UIActions.WebDriverWait(StartNewLoanText, 60, "StartNewLoanText");

            UIActions.Click(ResetButton);
        }           

        [Given(@"user have closing disclosure data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHaveClosingDisclosureDataFromExcelSheetForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }

        [Given(@"user have Mortgage Insurance data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHaveMortgageInsuranceDataFromExcelSheetForTheScenarioMortgageInsurance(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }

        [Given(@"user have variable loan data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHaveVariableLoanDataFromExcelSheetForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }

        [Given(@"user have Prepaid Charges data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHavePrepaidChargesDataFromExcelSheetPrepaidChargesForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }

        [Given(@"user have Escrow data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHaveEscrowDataFromExcelSheetForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }

        [Given(@"user have Export data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHaveExportDataFromExcelSheetExportForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }
      
        #endregion


        #region When

        [When(@"user navigate to Loan Inputs Page")]
        public void WhenUserNavigateToLoanInputsPage()
        {
            UIActions.Click(LoanInputsLink);
            UIActions.WebDriverWait(LoanDetailsText, 60, "LoanDetailsText");
        }

        [When(@"user navigate to Amortization Page")]
        public void WhenUserNavigateToAmortizationPage()
        {
            UIActions.Click(AmortizationLink);
            UIActions.WebDriverWait(AmortizationPaymentScheduleText, 60, "AmortizationPaymentScheduleText");
        }

        [When(@"user selects Calculation Method")]
        public void WhenUserSelectsCalculationMethodInClosingDisclosurePage()
        {
            LoanDetailsRadioButtonVariable();
            UIActions.WebDriverWait(CalculationMethod, 60, "CalculationMethod");
            UIActions.Click(CalculationMethod);         
        }

        [When(@"user selects loan type")]
        public void WhenUserSelectsLoanTypeInClosingDisclosurePage()
        {
            LoanDetailsRadioButtonVariable();
            UIActions.Click(LoanType);

            if (CalculationMethod.Equals("Variable"))
            {
                UIActions.Clear(FirstTermChange);
                UIActions.GiveInput(FirstTermChange, TridVariable.FirstTermChange);

                UIActions.Clear(SubsequentTermChange);
                UIActions.GiveInput(SubsequentTermChange, TridVariable.SubsequentTermChange);

                UIActions.Clear(DnRateCapFirstAdjustment);
                UIActions.GiveInput(DnRateCapFirstAdjustment, TridVariable.DnRateCapFirstAdjustment);

                UIActions.Clear(DnRateCapSubseqAdjustment);
                UIActions.GiveInput(DnRateCapSubseqAdjustment, TridVariable.DnRateCapsubsequentAdjustment);

                UIActions.Clear(UpRateCapFirstAdjustment);
                UIActions.GiveInput(UpRateCapFirstAdjustment, TridVariable.UpRateCapFirstAdjustment);

                UIActions.Clear(UpRateCapSubseqAdjustment);
                UIActions.GiveInput(UpRateCapSubseqAdjustment, TridVariable.UpRateCapsubsequentAdjustment);

                UIActions.Clear(FloorRate);
                UIActions.GiveInput(FloorRate, TridVariable.FloorRate);

                UIActions.Clear(MaxRateEver);
                UIActions.GiveInput(MaxRateEver, TridVariable.MaxRateEver);

                UIActions.Clear(Index);
                UIActions.GiveInput(Index, TridVariable.Index);

                UIActions.Clear(Margin);
                UIActions.GiveInput(Margin, TridVariable.Margin);

                UIActions.Clear(Index);
                UIActions.GiveInput(Index, TridVariable.RoundingFactor);
            }
        }

        [When(@"user selects Frequency of Payments")]
        public void WhenUserSelectsFrequencyOfPaymentsInClosingDisclosurePage()
        {
            LoanDetailsRadioButtonVariable();
            UIActions.Click(FrequencyOfPayments);
        }

        [When(@"user selects Loan Term")]
        public void WhenUserSelectsLoanTermInClosingDisclosurePage()
        {
            LoanDetailsRadioButtonVariable();
            UIActions.Click(LoanTerm);
        }

        [When(@"user selects Repayment Term Type")]
        public void WhenUserSelectsRepaymentTermTypeInClosingDisclosurePage()
        {
            LoanDetailsRadioButtonVariable();
            UIActions.Click(RepaymentTermType);
        }

        [When(@"user enters Loan detail input values for computation")]
        public void WhenUserEntersLoanDetailInputValuesForComputationforClosingDisclosurepage()
        {
            UIActions.Clear(FreqOfPmtValue);
            UIActions.GiveInput(FreqOfPmtValue, TridVariable.FrequencyOfPmtValue);

            UIActions.Clear(LoanTermValue);
            UIActions.GiveInput(LoanTermValue, TridVariable.LoanTermValue);

            UIActions.Clear(NumberOfPayments);
            UIActions.GiveInput(NumberOfPayments, TridVariable.NumberOfPayments);

            UIActions.Clear(BaseLoanAmount);
            UIActions.GiveInput(BaseLoanAmount, TridVariable.BaseLoanAmount);

            UIActions.Clear(UpfrontLoanFactor);
            UIActions.GiveInput(UpfrontLoanFactor, TridVariable.UpfrontLoanFactor);

            UIActions.Clear(RateOfInterest);
            UIActions.GiveInput(RateOfInterest, TridVariable.RateOfInterest);

            UIActions.Clear(UpfrontMip);
            UIActions.GiveInput(UpfrontMip, TridVariable.UpfrontMip);

            LoanDetailsRadioButtonVariable();
            UIActions.Click(UpfrontMipFinanced);

            UIActions.Clear(DateOfLoan);
            UIActions.GiveInput(DateOfLoan, ProjActions.GetDate(TridVariable.DateOfLoan));

            UIActions.Clear(DateOfInterestBegins);
            UIActions.GiveInput(DateOfInterestBegins, ProjActions.GetDate(TridVariable.DateInterestBeginToAccrue));

            UIActions.Clear(DateOfFirstPayment);
            UIActions.GiveInput(DateOfFirstPayment, ProjActions.GetDate(TridVariable.DateOfFirstPayment));

            UIActions.Clear(PeriodPayment);
            UIActions.GiveInput(PeriodPayment, TridVariable.PeriodPayment);

            UIActions.Click(OddDaysClick);
            UIActions.Click(OddDaysSelect);
        }

        [When(@"user enters all input values for Prepaid Charges")]
        public void WhenUserEntersAllInputValuesForPrepaidCharges()
        {       
            UIActions.Clear(OriginationChargePoints);
            UIActions.GiveInput(OriginationChargePoints, TridVariable.OriginationChargePoints);

            UIActions.Clear(OriginationChargeOther1);
            UIActions.GiveInput(OriginationChargeOther1, TridVariable.OriginationChargeOther1);

            UIActions.Clear(OriginationChargeOther2);
            UIActions.GiveInput(OriginationChargeOther2, TridVariable.OriginationChargeOther2);

            UIActions.Clear(Flood);
            UIActions.GiveInput(Flood, TridVariable.Flood);

            UIActions.Clear(FHAUSDA);
            UIActions.GiveInput(FHAUSDA, TridVariable.FHAUSDA);

            UIActions.Clear(TaxServicing);
            UIActions.GiveInput(TaxServicing, TridVariable.TaxServicing);

            UIActions.Clear(UpfrontPMIVAGuarantee);
            UIActions.GiveInput(UpfrontPMIVAGuarantee, TridVariable.UpfrontPMIVAGuarantee);

            UIActions.Clear(SectionBOther1);
            UIActions.GiveInput(SectionBOther1, TridVariable.SectionBOther1);

            UIActions.Clear(SectionBOther2);
            UIActions.GiveInput(SectionBOther2, TridVariable.SectionBOther2);

            UIActions.Clear(TitleClosingProtectionLetter);
            UIActions.GiveInput(TitleClosingProtectionLetter, TridVariable.TitleClosingProtectionLetter);

            UIActions.Clear(TitleClosingSettlement);
            UIActions.GiveInput(TitleClosingSettlement, TridVariable.TitleClosingSettlement);

            UIActions.Clear(TitleCourierOverNight);
            UIActions.GiveInput(TitleCourierOverNight, TridVariable.TitleCourierOverNight);

            UIActions.Clear(TitleWire);
            UIActions.GiveInput(TitleWire, TridVariable.TitleWire);

            UIActions.Clear(TitleOther1);
            UIActions.GiveInput(TitleOther1, TridVariable.TitleOther1);
       
            UIActions.Clear(TitleOther2);
            UIActions.GiveInput(TitleOther2, TridVariable.TitleOther2);
 
            UIActions.Clear(SectionCOther1);
            UIActions.GiveInput(SectionCOther1, TridVariable.SectionCOther1);

            UIActions.Clear(SectionCOther2);
            UIActions.GiveInput(SectionCOther2, TridVariable.SectionCOther2);

            UIActions.Clear(PrepaidDailyInterest);
            UIActions.GiveInput(PrepaidDailyInterest, TridVariable.PrepaidDailyInterest);

            UIActions.Clear(TotalMiInSectionFPrepaids);
            UIActions.GiveInput(TotalMiInSectionFPrepaids, TridVariable.TotalMiInSectionFPrepaids);

            UIActions.Clear(TotalMiInSectionGEscrow);
            UIActions.GiveInput(TotalMiInSectionGEscrow, TridVariable.TotalMiInSectionGEscrow);

            UIActions.Clear(LoanCostsSumABC);
            UIActions.GiveInput(LoanCostsSumABC, TridVariable.LoanCostsSumABC);
        }

        [When(@"user enters pmi rate values")]
        public void WhenUserEntersPmiRateValues()
        {
            ProjActions.AddPmiRateValues();
            ProjActions.PmiRatesGridValidation();
        }

        [When(@"user enters other pmi input values")]
        public void WhenUserEntersOtherPmiInputValues()
        {
            UIActions.Clear(NumberOfPeriodsofAdvanceInsCollected);
            UIActions.GiveInput(NumberOfPeriodsofAdvanceInsCollected, TridVariable.NumberOfPrdsOfAdvcInsurance);

            UIActions.Clear(LowerOfCostOrAppraisal);
            UIActions.GiveInput(LowerOfCostOrAppraisal, TridVariable.LowerOfCostOfAppraisal);
        }

        [When(@"user navigates to Disclosure Inputs Page")]
        public void WhenUserNavigatesToDisclosureInputsPage()
        {
            UIActions.Click(DisclosureInputsLink);
            UIActions.WebDriverWait(DisclosedValuesText, 60, "DisclosedValuesText");
        }

        [When(@"user enters disclosed input values for closing disclousre section")]
        public void WhenUserEntersDisclosedInputValuesForClosingDisclousreSection()
         {
            UIActions.Clear(DisclosedMonthlyPrincipalandInterest);
            UIActions.GiveInput(DisclosedMonthlyPrincipalandInterest, TridVariable.DisclosedMonthlyPrincipalAndInterest);

            UIActions.Clear(DisclosedMonthlyPmi);
            UIActions.GiveInput(DisclosedMonthlyPmi, TridVariable.DisclosedMonthlyPmi);

            UIActions.Clear(DisclosedTotalPeriodicPayment);
            UIActions.GiveInput(DisclosedTotalPeriodicPayment, TridVariable.DisclosedTotalPeiodicPayment);

            UIActions.Clear(DisclosedPmiTerminalDate);
            UIActions.GiveInput(DisclosedPmiTerminalDate, ProjActions.GetDate(TridVariable.DisclosedPmiTerminationDate));

            UIActions.Clear(DisclosedPmiCancelDate);
            UIActions.GiveInput(DisclosedPmiCancelDate, ProjActions.GetDate(TridVariable.DisclosedPmiCancelDate));

            UIActions.Clear(DisclosedFinalBalloonPayment);
            UIActions.GiveInput(DisclosedFinalBalloonPayment, TridVariable.DisclosedFinalBalloonPayment);

            UIActions.Clear(DisclosedTotalOfPayment);
            UIActions.GiveInput(DisclosedTotalOfPayment, TridVariable.DisclosedTotalOfPayment);
        }

        [When(@"user enters disclsoed input values for Loan Estimate")]
        public void WhenUserEntersDisclsoedInputValuesForLoanEstimate()
        {
            UIActions.Clear(DisclosedIn5Years);
            UIActions.GiveInput(DisclosedIn5Years, TridVariable.DiscLosedIn5Years);

            UIActions.Clear(DisclosedIn5YearsPrincipal);
            UIActions.GiveInput(DisclosedIn5YearsPrincipal, TridVariable.DiscLosedIn5YearsPrincipal);

            UIActions.Clear(DisclosedApr);
            UIActions.GiveInput(DisclosedApr, TridVariable.DisclosedApr);

            UIActions.Clear(DisclosedTip);
            UIActions.GiveInput(DisclosedTip, TridVariable.DisclosedTip);
        }

        [When(@"user enters disclosed input values for Prepaid Charges")]
        public void WhenUserEntersDisclosedInputValuesForPrepaidCharges()
        {
            UIActions.Clear(DisclosedFinanceCharge);
            UIActions.GiveInput(DisclosedFinanceCharge, TridVariable.DisclosedFinanceCharge);

            UIActions.Clear(DisclosedPrepaidCharge);
            UIActions.GiveInput(DisclosedPrepaidCharge, TridVariable.DisclosedPrepaidCharge);

            UIActions.Clear(DisclosedAmountFinanced);
            UIActions.GiveInput(DisclosedAmountFinanced, TridVariable.DisclosedAmountFinanced);
        }

        [When(@"user navigates to Closing Disclosure Cards Page")]
        public void WhenUserNavigatesToClosingDisclosureCardsPage()
        {
            UIActions.Click(ClosingDisclosureLink);
            UIActions.WebDriverWait(AprLabelText, 60, "AprLabelText");
        }

        [When(@"user navigates to Loan Estimate Cards Page")]
        public void WhenUserNavigatesToLoanEstimateCardsPage()
        {
            UIActions.Click(LoanEstimateLink);
            UIActions.WebDriverWait(LoanEstimateIn5YearsText, 60, "LoanEstimateIn5YearsText");
        }

        [When(@"user selects value for Is Ins Escrowed")]
        public void WhenUserSelectsValueForIsInsEscrowed()
        {
            EscrowRadioButtonVariable();
            UIActions.WebDriverWait(IsInsEscrowed, 60, "IsInsEscrowed");
            UIActions.ScrollUp();
            UIActions.Click(IsInsEscrowed);
        }

        [When(@"user selects value for Is Tax Escrowed")]
        public void WhenUserSelectsValueForIsTaxEscrowed()
        {
            EscrowRadioButtonVariable();
            UIActions.WebDriverWait(IsTaxEscrowed, 60, "IsTaxEscrowed");
            UIActions.Click(IsTaxEscrowed);
        }

        [When(@"user selects value for Is Other1 Escrowed")]
        public void WhenUserSelectsValueForIsOther1Escrowed()
        {
            EscrowRadioButtonVariable();
            UIActions.WebDriverWait(IsOther1Escrowed, 60, "IsOther1Escrowed");
            UIActions.Click(IsOther1Escrowed);
        }

        [When(@"user selects value for Is Other2 Escrowed")]
        public void WhenUserSelectsValueForIsOther2Escrowed()
        {
            EscrowRadioButtonVariable();
            UIActions.WebDriverWait(IsOther2Escrowed, 60, "IsOther2Escrowed");
            UIActions.Click(IsOther2Escrowed);
        }

        [When(@"user enters input values for Cushion Months")]
        public void WhenUserEntersInputValuesForCushionMonths()
        {
            UIActions.Clear(CushionMonthsForInsurance);
            UIActions.GiveInput(CushionMonthsForInsurance, TridVariable.CushionMonthsForInsurance);

            UIActions.Clear(CushionMonthsForTax);
            UIActions.GiveInput(CushionMonthsForTax, TridVariable.CushionMonthsForTax);

            UIActions.Clear(CushionMonthsForOther1);
            UIActions.GiveInput(CushionMonthsForOther1, TridVariable.CushionMonthsForOther1);

            UIActions.Clear(CushionMonthsForOther2);
            UIActions.GiveInput(CushionMonthsForOther2, TridVariable.CushionMonthsForOther2);
        }

        [When(@"user enters input value for Date Of First Monthly PMI Disbursement")]
        public void WhenUserEntersInputValueForDateOfFirstMonthlyPmiDisbursement()
        {
            UIActions.Clear(DateOfFirstMonthlyPmiDisbursement);
            UIActions.GiveInput(DateOfFirstMonthlyPmiDisbursement, ProjActions.GetDate(TridVariable.DateOfFirstMonthlyPmiDisbursement));
        }


        [When(@"user enters values for Escrow insurance Inputs")]
        public void WhenUserEntersValuesForEscrowInsuranceInputs()
        {
            if (TridVariable.InsuranceCostNumber!="0")
            {
                var insuranceGridRowCount = UIActions.Count(InsuranceGridRowCount);
                Assert.AreNotEqual(1, insuranceGridRowCount, "Escrow Installment Info Grid is not empty");

                UIActions.Clear(InsuranceCostNumber);
                UIActions.GiveInput(InsuranceCostNumber, TridVariable.InsuranceCostNumber);

                var dateForEscrowInsurance =
                    DateTime.FromOADate(Convert.ToDouble(TridVariable.DateInsurancePaidDisbursed)).ToString("MM/dd/yyyy");
                UIActions.Clear(DateInsurancePaidDisbursed);
                UIActions.GiveInput(DateInsurancePaidDisbursed, dateForEscrowInsurance);
                Thread.Sleep(500);

                UIActions.Clear(InsuranceAmount);
                UIActions.GiveInput(InsuranceAmount, TridVariable.InsuranceAmount);

                UIActions.Click(InsuranceCostAddButton);
                Thread.Sleep(500);

                Assert.AreEqual(TridVariable.InsuranceCostNumber,
                    UIActions.GetText(InsuranceGridNumber),
                    "Escrow Installment Info Number value does not matches as expected");
                Assert.AreEqual(dateForEscrowInsurance, UIActions.GetText(InsuranceGridDate),
                    "Escrow Installment Info Date value does not matches as expected");
                Assert.AreEqual(TridVariable.InsuranceAmount,
                    UIActions.GetText(InsuranceGridAmount),
                    "Escrow Installment Info Amount value does not matches as expected");
            }
        }

        [When(@"user enters values for Escrow Tax Calculations Inputs")]
        public void WhenUserEntersValuesForEscrowTaxCalculationsInputs()
        {
            if (TridVariable.TaxCostNumberFR!="0")
            {
                var taxGridRowCount = UIActions.Count(TaxGridRowCount);
                Assert.AreNotEqual(1, taxGridRowCount, "Escrow Installment Info Grid is not empty");

                UIActions.Clear(TaxCostNumber);
                UIActions.GiveInput(TaxCostNumber, TridVariable.TaxCostNumberFR);

                var escrowTaxCalculationsInputsDateFR =
                    DateTime.FromOADate(Convert.ToDouble(TridVariable.TaxCostDateFR))
                        .ToString("MM/dd/yyyy");
                UIActions.Clear(TaxCostDate);
                UIActions.GiveInput(TaxCostDate, escrowTaxCalculationsInputsDateFR);
                Thread.Sleep(500);

                UIActions.Clear(TaxCostAmount);
                UIActions.GiveInput(TaxCostAmount,
                    TridVariable.TaxCostInstallmentAmountFR);

                UIActions.Click(TaxCostAddButton);
                Thread.Sleep(500);

                Assert.AreEqual(TridVariable.TaxCostNumberFR,
                    UIActions.GetText(TaxGridNumberFR),
                    "Escrow Installment Info Number value does not matches as expected");
                Assert.AreEqual(escrowTaxCalculationsInputsDateFR, UIActions.GetText(TaxGridDateFR),
                    "Escrow Installment Info Number value does not matches as expected");
                Assert.AreEqual(TridVariable.TaxCostInstallmentAmountFR,
                    UIActions.GetText(TaxGridAmountFR),
                    "Escrow Installment Info Number value does not matches as expected");
            }

            if (TridVariable.TaxCostNumberSR!="0")
            {

                UIActions.Clear(TaxCostNumber);
                UIActions.GiveInput(TaxCostNumber, TridVariable.TaxCostNumberSR);

                var escrowTaxCalculationsInputsDateSR =
                    DateTime.FromOADate(Convert.ToDouble(TridVariable.TaxCostDateSR))
                        .ToString("MM/dd/yyyy");
                UIActions.Clear(TaxCostDate);
                UIActions.GiveInput(TaxCostDate, escrowTaxCalculationsInputsDateSR);
                Thread.Sleep(500);

                UIActions.Clear(TaxCostAmount);
                UIActions.GiveInput(TaxCostAmount,
                    TridVariable.TaxCostInstallmentAmountSR);

                UIActions.Click(TaxCostAddButton);
                Thread.Sleep(500);

                Assert.AreEqual(TridVariable.TaxCostNumberSR,
                    UIActions.GetText(TaxGridNumberSR),
                    "Escrow Installment Info Number value does not matches as expected");
                Assert.AreEqual(escrowTaxCalculationsInputsDateSR, UIActions.GetText(TaxGridDateSR),
                    "Escrow Installment Info Number value does not matches as expected");
                Assert.AreEqual(TridVariable.TaxCostInstallmentAmountSR,
                    UIActions.GetText(TaxGridAmountSR),
                    "Escrow Installment Info Number value does not matches as expected");
            }
        }


        [When(@"user enters values for Escrow Other1 Calculations Inputs")]
        public void WhenUserEntersValuesForEscrowOther1CalculationsInputs()
        {
            if (TridVariable.OtherCost1Number!="0")
            {
                var otherCost1GridRowCount = UIActions.Count(OtherCost1GridRowCount);
                Assert.AreNotEqual(1, otherCost1GridRowCount, "Escrow Installment Info Grid is not empty");

                UIActions.Clear(OtherCost1Number);
                UIActions.GiveInput(OtherCost1Number, TridVariable.OtherCost1Number);

                var dateForEscrowOther1 =
                    DateTime.FromOADate(Convert.ToDouble(TridVariable.OtherCost1Date)).ToString("MM/dd/yyyy");
                UIActions.Clear(OtherCost1Date);
                UIActions.GiveInput(OtherCost1Date, dateForEscrowOther1);
                Thread.Sleep(500);

                UIActions.Clear(OtherCost1Amount);
                UIActions.GiveInput(OtherCost1Amount, TridVariable.OtherCost1Amount);

                UIActions.Click(OtherCost1AddButton);
                Thread.Sleep(500);

                Assert.AreEqual(TridVariable.OtherCost1Number,
                    UIActions.GetText(OtherCost1GridNumber),
                    "Escrow Other1 Info Number value does not matches as expected");
                Assert.AreEqual(dateForEscrowOther1, UIActions.GetText(OtherCost1GridDate),
                    "Escrow Other1 Info Date value does not matches as expected");
                Assert.AreEqual(TridVariable.OtherCost1Amount,
                    UIActions.GetText(OtherCost1GridAmount),
                    "Escrow Other1 Info Amount value does not matches as expected");
            }
        }

        [When(@"user enters values for Escrow Other2 Calculations Inputs")]
        public void WhenUserEntersValuesForEscrowOther2CalculationsInputs()
        {
            if (TridVariable.OtherCost2Number!="0")
            {
                var otherCost2GridRowCount = UIActions.Count(OtherCost2GridRowCount);
                Assert.AreNotEqual(1, otherCost2GridRowCount, "Escrow Installment Info Grid is not empty");

                UIActions.Clear(OtherCost2Number);
                UIActions.GiveInput(OtherCost2Number, TridVariable.OtherCost2Number);

                var dateForEscrowOther2 =
                    DateTime.FromOADate(Convert.ToDouble(TridVariable.OtherCost2Date))
                        .ToString("MM/dd/yyyy");
                UIActions.Clear(OtherCost2Date);
                UIActions.GiveInput(OtherCost2Date, dateForEscrowOther2);
                Thread.Sleep(500);

                UIActions.Clear(OtherCost2Amount);
                UIActions.GiveInput(OtherCost2Amount, TridVariable.OtherCost2Amount);

                UIActions.Click(OtherCost2AddButton);
                Thread.Sleep(500);

                Assert.AreEqual(TridVariable.OtherCost2Number,
                    UIActions.GetText(OtherCost2GridNumber),
                    "Escrow Other2 Info Number value does not matches as expected");
                Assert.AreEqual(dateForEscrowOther2, UIActions.GetText(OtherCost2GridDate),
                    "Escrow Other2 Info Date value does not matches as expected");
                Assert.AreEqual(TridVariable.OtherCost2Amount,
                    UIActions.GetText(OtherCost2GridAmount),
                    "Escrow Other2 Info Amount value does not matches as expected");
            }
        }

        [When(@"user enters disclosed input values for Escrow Property")]
        public void WhenUserEntersDisclosedInputValuesForEscrowProperty()
        {
            UIActions.Clear(DisclosedEscrowPropertyOverOneYear11Months);
            UIActions.GiveInput(DisclosedEscrowPropertyOverOneYear11Months, TridVariable.DisclosedEscrowPropertyOverOneYear11Months);

            UIActions.Clear(DisclosedEscrowPropertyOverOneYear12Months);
            UIActions.GiveInput(DisclosedEscrowPropertyOverOneYear12Months, TridVariable.DisclosedEscrowPropertyOverOneYear12Months);

            UIActions.Clear(DisclosedNonEscrowPropertyOverOneYear);
            UIActions.GiveInput(DisclosedNonEscrowPropertyOverOneYear, TridVariable.DisclosedNonEscrowPropertyOverOneYear);

            UIActions.Clear(DisclosedEstimatedTaxesInsurnaceAssessments);
            UIActions.GiveInput(DisclosedEstimatedTaxesInsurnaceAssessments, TridVariable.DisclosedEstimatedTaxesInsuranceAssessments);

            UIActions.Clear(DisclosedInitialEscrowPayment);
            UIActions.GiveInput(DisclosedInitialEscrowPayment, TridVariable.DisclosedInitialEscrowPayment); ;

            UIActions.Clear(DisclosedPeriodEscrowPayment);
            UIActions.GiveInput(DisclosedPeriodEscrowPayment, TridVariable.DisclosedPeriodEscrowPayment);
        }

        [When(@"user navigates to Export Page")]
        public void WhenUserNavigatesToExportPage()
        {
            UIActions.Click(ExportLink);
            UIActions.WebDriverWait(ExportLoanInformationText, 60, "ExportLoanInformationText");
        }

        [When(@"user enters all input values for Export Page")]
        public void WhenUserEntersAllInputValuesForExportPage()
        {
            UIActions.Clear(LoanTitle);
            UIActions.GiveInput(LoanTitle, TridVariable.ScenarioNo);

            UIActions.Clear(LoanIdNumber);
            UIActions.GiveInput(LoanIdNumber, TridVariable.LoanIdNumber);

            UIActions.Clear(BorrowersNames);
            UIActions.GiveInput(BorrowersNames, TridVariable.BorrowersNames);

            UIActions.Clear(NameOfLender);
            UIActions.GiveInput(NameOfLender, TridVariable.NameOfLender);

            UIActions.Clear(PreparedBy);
            UIActions.GiveInput(PreparedBy, TridVariable.PreparedBy);

            UIActions.Clear(OriginalCreditor);
            UIActions.GiveInput(OriginalCreditor, TridVariable.OriginalCreditor);

            ExportRadioButtonVariable();
            UIActions.Click(LoanSecuredBy);

            ExportRadioButtonVariable();
            UIActions.Click(Export);
        }

        [When(@"user clicks on Export button to generate JSON file")]
        public void WhenUserClicksOnExportButtonToGenerateJsonFile()
        {
            var filePath = DriverSetup.DownloadDirectory + @"\" + TridVariable.ScenarioNo + ".json";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            UIActions.WebDriverWait(ExportButton,60, "ExportButton");
            UIActions.Click(ExportButton);
        }


        [When(@"user upload json file for the scenario")]
        public void WhenUserUploadJsonFileForTheScenario()
        {
            ProjActions.UploadJsonFile();
        }

        #endregion


        #region Then

        [Then(@"updated/computed Principal and Interest value should display on Closing Disclosure")]
        public void ThenUpdatedComputedPrincipalAndInterestValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(PiComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.PrincipalAndInt), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected with the difference of " + Math.Abs(expectedCValue - actualCValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PiDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedMonthlyPrincipalAndInterest), 2);
                Assert.AreEqual(expectedDValue,actualDValue, "Disclosed value does not match as expected with the difference of " + Math.Abs(expectedDValue - actualDValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :" + expectedDValue);
                Console.WriteLine("ActualDisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                Assert.AreEqual(actualDValue, actualCValue, "Disclosed value does not match with computed value with the difference of " + Math.Abs(actualCValue - actualDValue));

                var expectedVValue = Convert.ToDouble(TridVariable.VariancePrincipalAndInt);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PiVarianceValue));
                Assert.AreEqual(expectedVValue, actualVValue, "Variance does not match as expected with the difference of " + Math.Abs(actualVValue - expectedVValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :" + expectedVValue);
                Console.WriteLine("ActualVarianceValue :" + actualVValue);
                Console.WriteLine("============================================================");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| PrincipalAndInt ||";
            }
        }

        [Then(@"updated/computed Mortgage Insurance value should display on Closing Disclosure")]
        public void ThenUpdatedComputedMortgageInsuranceValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(MiComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.MortgageInsurance), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected with the difference of " + Math.Abs(expectedCValue - actualCValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(MiDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedMonthlyPmi), 2);
                Assert.AreEqual(expectedDValue, actualDValue, "Disclosed value does not match as expected with the difference of " + Math.Abs(expectedDValue - actualDValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :" + expectedDValue);
                Console.WriteLine("ActualDisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                Assert.AreEqual(actualDValue, actualCValue, "Disclosed value does not match with computed value with the difference of " + Math.Abs(actualCValue - actualDValue));

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceMortgageInsurance);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(MiVarianceValue));
                Assert.AreEqual(expectedVValue, actualVValue, "Variance does not match as expected with the difference of " + Math.Abs(actualVValue - expectedVValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :" + expectedVValue);
                Console.WriteLine("ActualVarianceValue :" + actualVValue);
                Console.WriteLine("============================================================");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| MortgageInsurance ||";
            }
        }

        [Then(@"updated/computed APR value should display on Closing Disclosure")]
        public void ThenUpdatedComputedAprValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AprComputedValue)), 3);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.Apr), 3);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected with the difference of " + Math.Abs(expectedCValue - actualCValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(AprDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedApr), 3);
                Assert.AreEqual(expectedDValue, actualDValue, "Disclosed value does not match as expected with the difference of " + Math.Abs(expectedDValue - actualDValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :" + expectedDValue);
                Console.WriteLine("ActualDisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                Assert.AreEqual(actualDValue, actualCValue, "Disclosed value does not match with computed value with the difference of " + Math.Abs(actualCValue - actualDValue));

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceApr);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(AprVarianceValue));
                Assert.AreEqual(expectedVValue, actualVValue, "Variance does not match as expected with the difference of " + Math.Abs(actualVValue - expectedVValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :" + expectedVValue);
                Console.WriteLine("ActualVarianceValue :" + actualVValue);
                Console.WriteLine("============================================================");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| APR ||";
            }
        }

        [Then(@"APRWIN info value should display on Closing Disclosure")]
        public void ThenAprwinInfoValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var expectedInfoValue = Math.Round(Convert.ToDouble(TridVariable.AprWin), 4);
                var actualInfoValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AprWinInfoValue)), 4);
                Assert.AreEqual(expectedInfoValue, actualInfoValue, "Apr Info value does not match as expected with the difference of " + Math.Abs(expectedInfoValue - actualInfoValue));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| APRWIN ||";
            }      
        }


        [Then(@"updated/computed Scheduled PMI Termination Date value should display on Closing Disclosure")]
        public void ThenUpdatedComputedScheduledPmiTerminationDateValueShouldDisplayOnClosingDisclosure()
        {
            if (TridVariable.ScheduledPmiTerminationDate.Equals("N/A"))
                ScheduledPmiTerminationDateNotApplicableValidation();
            else
                try
                {
                    var actualCValue = ProjActions.GetDatePart(SptdComputedValue);
                    var expectedCValue = Convert.ToDateTime(ProjActions.GetDate(TridVariable.ScheduledPmiTerminationDate));
                    Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected with the difference of " + (expectedCValue - actualCValue).TotalDays);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                    Console.WriteLine("ActualComputedValue :" + actualCValue);
                    Console.WriteLine("============================================================");

                    var actualDValue = ProjActions.GetDatePart(SptdDisclosureValue);
                    var expectedDValue = Convert.ToDateTime(ProjActions.GetDate(TridVariable.DisclosedPmiTerminationDate));
                    Assert.AreEqual(expectedDValue, actualDValue, "Disclosed value does not match as expected with the difference of " + (expectedDValue - actualDValue).TotalDays);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedDisclosedValue :" + expectedDValue);
                    Console.WriteLine("ActualDisclosedValue :" + actualDValue);
                    Console.WriteLine("============================================================");

                    Assert.AreEqual(actualDValue, actualCValue, "Disclosed value does not match with computed value with the difference of " + (actualDValue - actualCValue).TotalDays);

                    var expectedVValue = Convert.ToDouble(TridVariable.VarianceScheduledPmiTerminationDate);
                    var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(SptdVarianceValue));
                    Assert.AreEqual(expectedVValue, actualVValue, "Variance does not match as expected with the difference of " + (expectedVValue - actualVValue));

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedVarianceValue :" + expectedVValue);
                    Console.WriteLine("ActualVarianceValue :" + actualVValue);
                    Console.WriteLine("============================================================");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    TestCaseStatus = false;
                    TestFailureCount += 1;
                    CardsFailure += "|| ScheduledPMITerminationDate ||";
                }
        }

        public static void ScheduledPmiTerminationDateNotApplicableValidation()
        {
            try
            {
                var actualCValue = UIActions.GetText(SptdComputedValue);
                var expectedCValue = "(C): " + TridVariable.ScheduledPmiTerminationDate;
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = UIActions.GetText(SptdDisclosureValue);
                var expectedDValue = "(D): " + TridVariable.DisclosedPmiTerminationDate;

                Assert.AreEqual(expectedDValue, actualDValue, "Disclosed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :" + expectedDValue);
                Console.WriteLine("ActualDisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                var expectedVValue = "(V): N/A Days";
                var actualVValue = UIActions.GetText(SptdVarianceValue);

                Assert.AreEqual(expectedVValue, actualVValue, "Variance does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :" + expectedVValue);
                Console.WriteLine("ActualVarianceValue :" + actualVValue);
                Console.WriteLine("============================================================");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| ScheduledPmiTerminationDate ||";
            }
        }


        [Then(@"updated/computed Estimated Total Monthly Payment value should display on Closing Disclosure")]
        public void ThenUpdatedComputedEstimatedTotalMonthlyPaymentValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(EtmpComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.EstimatedTotalMonthlyPayment), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected with the difference of " + Math.Abs(expectedCValue - actualCValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(EtmpDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedTotalPeiodicPayment), 2);
                Assert.AreEqual(expectedDValue, actualDValue, "Disclosed value does not match as expected with the difference of " + Math.Abs(expectedDValue - actualDValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :" + expectedDValue);
                Console.WriteLine("ActualDisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                Assert.AreEqual(actualDValue, actualCValue, "Disclosed value does not match with computed value with the difference of " + Math.Abs(actualCValue - actualDValue));

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceEstimatedTotalMonthlyPayment);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(EtmpVarianceValue));
                Assert.AreEqual(expectedVValue, actualVValue, "Variance does not match as expected with the difference of " + Math.Abs(actualVValue - expectedVValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :" + expectedVValue);
                Console.WriteLine("ActualVarianceValue :" + actualVValue);
                Console.WriteLine("============================================================");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| EstimatedTotalMonthlyPayment ||";
            }
        }

        [Then(@"updated/computed Prepaid Charges value should display on Closing Disclosure")]
        public void ThenUpdatedComputedPrepaidChargesValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(PcComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.PrepaidCharges), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected with the difference of " + Math.Abs(expectedCValue - actualCValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PcDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedPrepaidCharge), 2);
                Assert.AreEqual(expectedDValue, actualDValue, "Disclosed value does not match as expected with the difference of " + Math.Abs(expectedDValue - actualDValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :" + expectedDValue);
                Console.WriteLine("ActualDisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                Assert.AreEqual(actualDValue, actualCValue, "Disclosed value does not match with computed value with the difference of " + Math.Abs(actualCValue - actualDValue));

                var expectedVValue = Convert.ToDouble(TridVariable.VariancePrepaidCharges);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PcVarianceValue));
                Assert.AreEqual(expectedVValue, actualVValue, "Variance does not match as expected with the difference of " + Math.Abs(actualVValue - expectedVValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :" + expectedVValue);
                Console.WriteLine("ActualVarianceValue :" + actualVValue);
                Console.WriteLine("============================================================");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| PrepaidCharges ||";
            }
        }

        [Then(@"updated/computed Amount Financed value should display on Closing Disclosure")]
        public void ThenUpdatedComputedAmountFinancedValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AfComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.AmountFinanced), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected with the difference of " + Math.Abs(expectedCValue - actualCValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(AfDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedAmountFinanced), 2);
                Assert.AreEqual(expectedDValue, actualDValue, "Disclosed value does not match as expected with the difference of " + Math.Abs(expectedDValue - actualDValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :" + expectedDValue);
                Console.WriteLine("ActualDisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                Assert.AreEqual(actualDValue, actualCValue, "Disclosed value does not match with computed value with the difference of " + Math.Abs(actualCValue - actualDValue));

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceAmountFinanced);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(AfVarianceValue));
                Assert.AreEqual(expectedVValue, actualVValue, "Variance does not match as expected with the difference of " + Math.Abs(actualVValue - expectedVValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :" + expectedVValue);
                Console.WriteLine("ActualVarianceValue :" + actualVValue);
                Console.WriteLine("============================================================");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| AmountFinanced ||";
            }
        }

        [Then(@"updated/computed Escrow Property Costs over one year 11 Months value should display on Closing Disclosure")]
        public void ThenUpdatedComputedEscrowPropertyCostsOverOneYear11MonthsValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(E1O11ComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.EscrowPropertyOver1Year11Months), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected with the difference of " + Math.Abs(expectedCValue - actualCValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(E1O11DisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedEscrowPropertyOverOneYear11Months), 2);
                Assert.AreEqual(expectedDValue, actualDValue, "Disclosed value does not match as expected with the difference of " + Math.Abs(expectedDValue - actualDValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :" + expectedDValue);
                Console.WriteLine("ActualDisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                Assert.AreEqual(actualDValue, actualCValue, "Disclosed value does not match with computed value with the difference of " + Math.Abs(actualCValue - actualDValue));

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceEscrowPropertyOver1Year11Months);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(E1O11VarianceValue));
                Assert.AreEqual(expectedVValue, actualVValue, "Variance does not match as expected with the difference of " + Math.Abs(actualVValue - expectedVValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :" + expectedVValue);
                Console.WriteLine("ActualVarianceValue :" + actualVValue);
                Console.WriteLine("============================================================");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| EscrowPropertyOver1Year11Months ||";
            }
        }

        [Then(@"updated/computed Escrow Property Costs over one year 12 Months value should display on Closing Disclosure")]
        public void ThenUpdatedComputedEscrowPropertyCostsOverOneYear12MonthsValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(E1O12ComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.EscrowPropertyOver1Year12Months), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected with the difference of " + Math.Abs(expectedCValue - actualCValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(E1O12DisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedEscrowPropertyOverOneYear12Months), 2);
                Assert.AreEqual(expectedDValue, actualDValue, "Disclosed value does not match as expected with the difference of " + Math.Abs(expectedDValue - actualDValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :" + expectedDValue);
                Console.WriteLine("ActualDisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                Assert.AreEqual(actualDValue, actualCValue, "Disclosed value does not match with computed value with the difference of " + Math.Abs(actualCValue - actualDValue));

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceEscrowPropertyOver1Year12Months);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(E1O12VarianceValue));
                Assert.AreEqual(expectedVValue, actualVValue, "Variance does not match as expected with the difference of " + Math.Abs(actualVValue - expectedVValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :" + expectedVValue);
                Console.WriteLine("ActualVarianceValue :" + actualVValue);
                Console.WriteLine("============================================================");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| EscrowPropertyOver1Year12Months ||";
            }
        }

        [Then(@"updated/computed Balloon Amount value should display on Closing Disclosure")]
        public void ThenUpdatedComputedBalloonAmountValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(BaComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.BalloonAmount), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected with the difference of " + Math.Abs(expectedCValue - actualCValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(BaDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedFinalBalloonPayment), 2);
                Assert.AreEqual(expectedDValue, actualDValue, "Disclosed value does not match as expected with the difference of " + Math.Abs(expectedDValue - actualDValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :" + expectedDValue);
                Console.WriteLine("ActualDisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                Assert.AreEqual(actualDValue, actualCValue, "Disclosed value does not match with computed value with the difference of " + Math.Abs(actualCValue - actualDValue));

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceBalloonAmount);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(BaVarianceValue));
                Assert.AreEqual(expectedVValue, actualVValue, "Variance does not match as expected with the difference of " + Math.Abs(actualVValue - expectedVValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :" + expectedVValue);
                Console.WriteLine("ActualVarianceValue :" + actualVValue);
                Console.WriteLine("============================================================");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| BalloonAmount ||";
            }
        }

        [Then(@"updated/computed Total of Payments value should display on Closing Disclosure")]
        public void ThenUpdatedComputedTotalOfPaymentsValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(TopComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.TotalOfPayments), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected with the difference of " + Math.Abs(expectedCValue - actualCValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TopDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedTotalOfPayment), 2);
                Assert.AreEqual(expectedDValue, actualDValue, "Disclosed value does not match as expected with the difference of " + Math.Abs(expectedDValue - actualDValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :" + expectedDValue);
                Console.WriteLine("ActualDisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                Assert.AreEqual(actualDValue, actualCValue, "Disclosed value does not match with computed value with the difference of " + Math.Abs(actualCValue - actualDValue));

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceTotalOfPayments);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TopVarianceValue));
                Assert.AreEqual(expectedVValue, actualVValue, "Variance does not match as expected with the difference of " + Math.Abs(actualVValue - expectedVValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :" + expectedVValue);
                Console.WriteLine("ActualVarianceValue :" + actualVValue);
                Console.WriteLine("============================================================");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| TotalOfPayments ||";
            }
        }

        [Then(@"updated/computed Finance Charge value should display on Closing Disclosure")]
        public void ThenUpdatedComputedFinanceChargeValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(FcComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.FinanceCharge), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected with the difference of " + Math.Abs(expectedCValue - actualCValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(FcDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedFinanceCharge), 2);
                Assert.AreEqual(expectedDValue, actualDValue, "Disclosed value does not match as expected with the difference of " + Math.Abs(expectedDValue - actualDValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :" + expectedDValue);
                Console.WriteLine("ActualDisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                Assert.AreEqual(actualDValue, actualCValue, "Disclosed value does not match with computed value with the difference of " + Math.Abs(actualCValue - actualDValue));

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceFinanceCharge);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(FcVarianceValue));
                Assert.AreEqual(expectedVValue, actualVValue, "Variance does not match as expected with the difference of " + Math.Abs(actualVValue - expectedVValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :" + expectedVValue);
                Console.WriteLine("ActualVarianceValue :" + actualVValue);
                Console.WriteLine("============================================================");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| FinanceCharge ||";
            }
        }

        [Then(@"updated/computed TIP value should display on Closing Disclosure")]
        public void ThenUpdatedComputedTipValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(TipComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.Tip), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected with the difference of " + Math.Abs(expectedCValue - actualCValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TipDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedTip), 2);
                Assert.AreEqual(expectedDValue, actualDValue, "Disclosed value does not match as expected with the difference of " + Math.Abs(expectedDValue - actualDValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :" + expectedDValue);
                Console.WriteLine("ActualDisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                Assert.AreEqual(actualDValue, actualCValue, "Disclosed value does not match with computed value with the difference of " + Math.Abs(actualCValue - actualDValue));

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceTip);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TipVarianceValue));
                Assert.AreEqual(expectedVValue, actualVValue, "Variance does not match as expected with the difference of " + Math.Abs(actualVValue - expectedVValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :" + expectedVValue);
                Console.WriteLine("ActualVarianceValue :" + actualVValue);
                Console.WriteLine("============================================================");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| TIP ||";
            }
        }

        [Then(@"updated/computed Initial Escrow Payment value should display on Closing Disclosure")]
        public void ThenUpdatedComputedInitialEscrowPaymentValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(IepComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.InitialEscrowPayment), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected with the difference of " + Math.Abs(expectedCValue - actualCValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(IepDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedInitialEscrowPayment), 2);
                Assert.AreEqual(expectedDValue, actualDValue, "Disclosed value does not match as expected with the difference of " + Math.Abs(expectedDValue - actualDValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :" + expectedDValue);
                Console.WriteLine("ActualDisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                Assert.AreEqual(actualDValue, actualCValue, "Disclosed value does not match with computed value with the difference of " + Math.Abs(actualCValue - actualDValue));

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceInitialEscrowPayment);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(IepVarianceValue));
                Assert.AreEqual(expectedVValue, actualVValue, "Variance does not match as expected with the difference of " + Math.Abs(actualVValue - expectedVValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :" + expectedVValue);
                Console.WriteLine("ActualVarianceValue :" + actualVValue);
                Console.WriteLine("============================================================");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| InitialEscrowPayment ||";
            }
        }


        [Then(@"updated/computed Non Escrow Property Costs over one year value should display on Closing Disclosure")]
        public void ThenUpdatedComputedNonEscrowPropertyCostsOverOneYearValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(Neo1YComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.NonEscrowPropertyOverOneYear), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected with the difference of " + Math.Abs(expectedCValue - actualCValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(Neo1YDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedNonEscrowPropertyOverOneYear), 2);
                Assert.AreEqual(expectedDValue, actualDValue, "Disclosed value does not match as expected with the difference of " + Math.Abs(expectedDValue - actualDValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :" + expectedDValue);
                Console.WriteLine("ActualDisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                Assert.AreEqual(actualDValue, actualCValue, "Disclosed value does not match with computed value with the difference of " + Math.Abs(actualCValue - actualDValue));

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceNonEscrowPropertyOverOneYear);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(Neo1YVarianceValue));
                Assert.AreEqual(expectedVValue, actualVValue, "Variance does not match as expected with the difference of " + Math.Abs(actualVValue - expectedVValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :" + expectedVValue);
                Console.WriteLine("ActualVarianceValue :" + actualVValue);
                Console.WriteLine("============================================================");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| NonEscrowPropertyOverOneYear ||";
            }
        }

        [Then(@"updated/computed Estimated Escrow value should display on Closing Disclosure")]
        public void ThenUpdatedComputedEstimatedEscrowValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(EeComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.EstimatedEscrow), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected with the difference of " + Math.Abs(expectedCValue - actualCValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(EeDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedPeriodEscrowPayment), 2);
                Assert.AreEqual(expectedDValue, actualDValue, "Disclosed value does not match as expected with the difference of " + Math.Abs(expectedDValue - actualDValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :" + expectedDValue);
                Console.WriteLine("ActualDisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                Assert.AreEqual(actualDValue, actualCValue, "Disclosed value does not match with computed value with the difference of " + Math.Abs(actualCValue - actualDValue));

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceEstimatedEscrow);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(EeVarianceValue));
                Assert.AreEqual(expectedVValue, actualVValue, "Variance does not match as expected with the difference of " + Math.Abs(actualVValue - expectedVValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :" + expectedVValue);
                Console.WriteLine("ActualVarianceValue :" + actualVValue);
                Console.WriteLine("============================================================");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| EstimatedEscrow ||";
            }
        }

        [Then(@"updated/computed Estimated Taxes, Insurance & Assessments value should display on Closing Disclosure")]
        public void ThenUpdatedComputedEstimatedTaxesInsuranceAssessmentsValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(EtiaComputedValue)), 2);
                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.EstimatedTaxesInsuranceAssessments), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected with the difference of " + Math.Abs(expectedCValue - actualCValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(EtiaDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DisclosedEstimatedTaxesInsuranceAssessments), 2);
                Assert.AreEqual(expectedDValue, actualDValue, "Disclosed value does not match as expected with the difference of " + Math.Abs(expectedDValue - actualDValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :" + expectedDValue);
                Console.WriteLine("ActualDisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                Assert.AreEqual(actualDValue, actualCValue, "Disclosed value does not match with computed value with the difference of " + Math.Abs(actualCValue - actualDValue));

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceEstimatedTaxesInsuranceAssessments);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(EtiaVarianceValue));
                Assert.AreEqual(expectedVValue, actualVValue, "Variance does not match as expected with the difference of " + Math.Abs(actualVValue - expectedVValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :" + expectedVValue);
                Console.WriteLine("ActualVarianceValue :" + actualVValue);
                Console.WriteLine("============================================================");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| EstimatedTaxesInsuranceAssessments ||";
            }
        }


        [Then(@"updated/computed in 5 Years value should display on Loan Estimate")]
        public void ThenUpdatedComputedIn5YearsValueShouldDisplayOnLoanEstimate()
        {
            try
            {
                var actualCValue = ProjActions.GetNumericValueFromString(UIActions.GetText(I5YComputedValue));
                var expectedCValue = Convert.ToDouble(TridVariable.In5Years);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected with the difference of " + Math.Abs(expectedCValue - actualCValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(I5YDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DiscLosedIn5Years), 2);
                Assert.AreEqual(expectedDValue, actualDValue, "Disclosed value does not match as expected with the difference of " + Math.Abs(expectedDValue - actualDValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :" + expectedDValue);
                Console.WriteLine("ActualDisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                Assert.AreEqual(actualDValue, actualCValue, "Disclosed value does not match with computed value with the difference of " + Math.Abs(actualCValue - actualDValue));

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceIn5Years);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(I5YVarianceValue));
                Assert.AreEqual(expectedVValue, actualVValue, "Variance does not match as expected with the difference of " + Math.Abs(actualVValue - expectedVValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :" + expectedVValue);
                Console.WriteLine("ActualVarianceValue :" + actualVValue);
                Console.WriteLine("============================================================");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| In5Years ||";
            }
        }

        [Then(@"updated/computed in 5 Years principal value should display on Loan Estimate")]
        public void ThenUpdatedComputedIn5YearsPrincipalValueShouldDisplayOnLoanEstimate()
        {
            try
            {
                var actualCValue = ProjActions.GetNumericValueFromString(UIActions.GetText(I5YpComputedValue));
                var expectedCValue = Convert.ToDouble(TridVariable.In5YearsPrincipal);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected with the difference of " + Math.Abs(expectedCValue - actualCValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(I5YpDisclosureValue));
                var expectedDValue = Math.Round(Convert.ToDouble(TridVariable.DiscLosedIn5YearsPrincipal), 2);
                Assert.AreEqual(expectedDValue, actualDValue, "Disclosed value does not match as expected with the difference of " + Math.Abs(expectedDValue - actualDValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedDisclosedValue :" + expectedDValue);
                Console.WriteLine("ActualDisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                Assert.AreEqual(actualDValue, actualCValue, "Disclosed value does not match with computed value with the difference of " + Math.Abs(actualCValue - actualDValue));

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceIn5YearsPrincipal);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(I5YpVarianceValue));
                Assert.AreEqual(expectedVValue, actualVValue, "Variance does not match as expected with the difference of " + Math.Abs(actualVValue - expectedVValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :" + expectedVValue);
                Console.WriteLine("ActualVarianceValue :" + actualVValue);
                Console.WriteLine("============================================================");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
                TestFailureCount += 1;
                CardsFailure += "|| In5YearsPrincipal ||";
            }
        }

        #endregion


        [AfterTestRun]
        public static void TearDown()
        {
            UIActions.Quit();
            if (!TestCaseStatus)
            {
                Console.WriteLine("The total number of cards Failue: " +TestFailureCount);
                Console.WriteLine("Name of cards Failed: " +CardsFailure);
                throw new Exception("Test Case failed");
            }
        }
    }
}
