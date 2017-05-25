using System;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
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
    public class CardsValidationSteps : TridTest
    {
        private static string Url => ConfigurationManager.AppSettings["url"];
        private static string Url1 => ConfigurationManager.AppSettings["url1"];
        readonly GetExcelData _getData = new GetExcelData();
        public static bool TestCaseStatus = true;
        public static int TestFailureCount;
        public static string CardsFailure = "";


        #region Given

       
        [Given(@"user is at TRID application homepage")]
        public void GivenUserIsAtTridApplicationHomepage()
        {
            UIActions.WindowMaximize();
            UIActions.GoToUrl(Url + "&" + Url1);
            UIActions.WebDriverWait(SnlStartNewLoanText, 60);

            UIActions.Click(SnlResetButton);
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

        [Given(@"user navigate to Loan Estimate Page")]
        public void GivenUserNavigateToLoanEstimatePage()
        {
            UIActions.Click(LoanEstimateLink);
            UIActions.WebDriverWait(LoanDetailsText, 60);
        }

        [Given(@"PMI Rates Grid is empty")]
        public void GivenPmiRatesGridIsEmpty()
        {
            ProjActions.PmiRatesGridEmptyValidation();
        }

        #endregion


        #region When

        [When(@"user navigate to Loan Inputs Page")]
        public void WhenUserNavigateToLoanInputsPage()
        {
            UIActions.Click(LoanInputsLink);
            UIActions.WebDriverWait(LoanDetailsText, 60);

            UIActions.ScrollDown();
            Thread.Sleep(2000);
            UIActions.ScrollUp();
        }

        [When(@"user navigate to Amortization Page")]
        public void WhenUserNavigateToAmortizationPage()
        {
            UIActions.Click(AmortizationLink);
            UIActions.WebDriverWait(AmortizationPaymentScheduleText, 60);
        }



        [When(@"user navigate to Closing Disclosure Page")]
        public void GivenUserNavigateToClosingClosingDisclosurePage()
        {
            
            UIActions.Click(ClosingDisclosureLink);
            UIActions.WebDriverWait(LoanDetailsText, 60);            
        }

        [When(@"user selects Calculation Method")]
        public void WhenUserSelectsCalculationMethodInClosingDisclosurePage()
        {
            LoanDetailsRadioButtonVariable();
            UIActions.WebDriverWait(CalculationMethod,60);
            UIActions.Click(CalculationMethod);         
        }

        [When(@"user selects loan type")]
        public void WhenUserSelectsLoanTypeInClosingDisclosurePage()
        {
            LoanDetailsRadioButtonVariable();
            UIActions.Click(LoanType);

            if (CalculationMethod.Equals("Variable"))
            {
                var firstTermChange = TridVariable.FirstTermChange;
                UIActions.Clear(FirstTermChange);
                UIActions.GiveInput(FirstTermChange, firstTermChange);

                var subsequentTermChange = TridVariable.SubsequentTermChange;
                UIActions.Clear(SubsequentTermChange);
                UIActions.GiveInput(SubsequentTermChange, subsequentTermChange);

                var dnRateCapFirstAdjustment = TridVariable.DnRateCapFirstAdjustment;
                UIActions.Clear(DnRateCapFirstAdjustment);
                UIActions.GiveInput(DnRateCapFirstAdjustment, dnRateCapFirstAdjustment);

                var dnRateCapsubsequentAdjustment = TridVariable.DnRateCapsubsequentAdjustment;
                UIActions.Clear(DnRateCapSubseqAdjustment);
                UIActions.GiveInput(DnRateCapSubseqAdjustment, dnRateCapsubsequentAdjustment);

                var upRateCapFirstAdjustment = TridVariable.UpRateCapFirstAdjustment;
                UIActions.Clear(UpRateCapFirstAdjustment);
                UIActions.GiveInput(UpRateCapFirstAdjustment, upRateCapFirstAdjustment);

                var upRateCapsubsequentAdjustment = TridVariable.UpRateCapsubsequentAdjustment;
                UIActions.Clear(UpRateCapSubseqAdjustment);
                UIActions.GiveInput(UpRateCapSubseqAdjustment, upRateCapsubsequentAdjustment);

                var floorRate = TridVariable.FloorRate;
                UIActions.Clear(FloorRate);
                UIActions.GiveInput(FloorRate, floorRate);

                var maxRateEver = TridVariable.MaxRateEver;
                UIActions.Clear(MaxRateEver);
                UIActions.GiveInput(MaxRateEver, maxRateEver);

                var index = TridVariable.Index;
                UIActions.Clear(Index);
                UIActions.GiveInput(Index, index);

                var margin = TridVariable.Margin;
                UIActions.Clear(Margin);
                UIActions.GiveInput(Margin, margin);

                var indexRate = TridVariable.RoundingFactor;
                UIActions.Clear(Index);
                UIActions.GiveInput(Index, indexRate);
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

        [When(@"Enter Loan detail input values for computation")]
        public void WhenEnterLoanDetailInputValuesForComputationforClosingDisclosurepage()
        {
            var frequencyOfPmtValue = TridVariable.FrequencyOfPmtValue;
            UIActions.Clear(FreqOfPmtValue);
            UIActions.GiveInput(FreqOfPmtValue, frequencyOfPmtValue);

            var loanTermValue = TridVariable.LoanTermValue;
            UIActions.Clear(LoanTermValue);
            UIActions.GiveInput(LoanTermValue, loanTermValue);


            var numberOfPayments = TridVariable.NumberOfPayments;
            UIActions.Clear(NumberOfPayments);
            UIActions.GiveInput(NumberOfPayments, numberOfPayments);

            var baseLoanAmount = TridVariable.BaseLoanAmount;
            UIActions.Clear(BaseLoanAmount);
            UIActions.GiveInput(BaseLoanAmount, baseLoanAmount);

            var upfrontLoanFactor = TridVariable.UpfrontLoanFactor;
            UIActions.Clear(UpfrontLoanFactor);
            UIActions.GiveInput(UpfrontLoanFactor, upfrontLoanFactor);

            var rateOfInterest = TridVariable.RateOfInterest;
            UIActions.Clear(RateOfInterest);
            UIActions.GiveInput(RateOfInterest, rateOfInterest);

            var upfrontMip = TridVariable.UpfrontMip;
            UIActions.Clear(UpfrontMip);
            UIActions.GiveInput(UpfrontMip, upfrontMip);

            LoanDetailsRadioButtonVariable();
            UIActions.Click(UpfrontMipFinanced);

            var dateOfLoan = ProjActions.GetDate(TridVariable.DateOfLoan);
            UIActions.Clear(DateOfLoan);
            UIActions.GiveInput(DateOfLoan, dateOfLoan);

            var dateOfInterestBegins = ProjActions.GetDate(TridVariable.DateInterestBeginToAccrue);
            UIActions.Clear(DateOfInterestBegins);
            UIActions.GiveInput(DateOfInterestBegins, dateOfInterestBegins);

            var dateOfFirstPayment = ProjActions.GetDate(TridVariable.DateOfFirstPayment);
            UIActions.Clear(DateOfFirstPayment);
            UIActions.GiveInput(DateOfFirstPayment, dateOfFirstPayment);

            var periodPayment = TridVariable.PeriodPayment;
            UIActions.Clear(PeriodPayment);
            UIActions.GiveInput(PeriodPayment, periodPayment);

            var loanCostsForDisclosure = TridVariable.LoanCosts;
            UIActions.Clear(LoanCostsForDisclosure);
            UIActions.GiveInput(LoanCostsForDisclosure, loanCostsForDisclosure);

            UIActions.Click(OddDaysClick);
            UIActions.Click(OddDaysSelect);
        }

        [When(@"user enters all input values for Prepaid Charges")]
        public void WhenUserEntersAllInputValuesForPrepaidCharges()
        {
            var fhaVaUsdaUpfrontPmiFree = TridVariable.FhaVaUsdaUpfrontPmiFree;
            UIActions.Clear(FhaVaUsdaUpfrontPmiFree);
            UIActions.GiveInput(FhaVaUsdaUpfrontPmiFree, fhaVaUsdaUpfrontPmiFree);

            var floodFee = TridVariable.FloodFee;
            UIActions.Clear(FloodFee);
            UIActions.GiveInput(FloodFee, floodFee);

            var inspectionFee = TridVariable.InspectionFee;
            UIActions.Clear(InspectionFee);
            UIActions.GiveInput(InspectionFee, inspectionFee);

            var loanOriginationFee = TridVariable.LoanOriginationFee;
            UIActions.Clear(LoanOriginationFee);
            UIActions.GiveInput(LoanOriginationFee, loanOriginationFee);

            var otherFees = TridVariable.OtherFees;
            UIActions.Clear(OtherFees);
            UIActions.GiveInput(OtherFees, otherFees);

            var prepaidDailyInterest = TridVariable.PrepaidDailyInterest;
            UIActions.Clear(PrepaidDailyInterest);
            UIActions.GiveInput(PrepaidDailyInterest, prepaidDailyInterest);

            var taxServicing = TridVariable.TaxServicing;
            UIActions.Clear(TaxServicing);
            UIActions.GiveInput(TaxServicing, taxServicing);

            var titleClosingFee = TridVariable.TitleClosingFee;
            UIActions.Clear(TitleClosingFee);
            UIActions.GiveInput(TitleClosingFee, titleClosingFee);

            var titleClosingProtectionLetter = TridVariable.TitleClosingProtectionLetter;
            UIActions.Clear(TitleClosingProtectionLetter);
            UIActions.GiveInput(TitleClosingProtectionLetter, titleClosingProtectionLetter);

            var titleCourierFee = TridVariable.TitleCourierFee;
            UIActions.Clear(TitleCourierFee);
            UIActions.GiveInput(TitleCourierFee, titleCourierFee);

            var titleDrawFee = TridVariable.TitleDrawFee;
            UIActions.Clear(TitleDrawFee);
            UIActions.GiveInput(TitleDrawFee, titleDrawFee);

            var titleWireFee = TridVariable.TitleWireFee;
            UIActions.Clear(TitleWireFee);
            UIActions.GiveInput(TitleWireFee, titleWireFee);

            var underWriting = TridVariable.UnderWriting;
            UIActions.Clear(UnderWriting);
            UIActions.GiveInput(UnderWriting, underWriting);

            var totalMiInSectionFPrepaids = TridVariable.TotalMiInSectionFPrepaids;
            UIActions.Clear(TotalMiInSectionFPrepaids);
            UIActions.GiveInput(TotalMiInSectionFPrepaids, totalMiInSectionFPrepaids);

            var totalMiInSectionGEscrow = TridVariable.TotalMiInSectionGEscrow;
            UIActions.Clear(TotalMiInSectionGEscrow);
            UIActions.GiveInput(TotalMiInSectionGEscrow, totalMiInSectionGEscrow);
        }

        [When(@"user enters pmi rate values")]
        public void WhenUserEntersPmiRateValues()
        {
            ProjActions.AddPmiRateValues();
            Thread.Sleep(3000);
            ProjActions.PmiRatesGridValidation();
        }

        [When(@"user enters other pmi input values")]
        public void WhenUserEntersOtherPmiInputValues()
        {
            var numberOfPrdsOfAdvcInsurance = TridVariable.NumberOfPrdsOfAdvcInsurance;
            UIActions.Clear(NumberOfPeriodsofAdvanceInsCollected);
            UIActions.GiveInput(NumberOfPeriodsofAdvanceInsCollected, numberOfPrdsOfAdvcInsurance);

            var lowerOfCostOfAppraisal = TridVariable.LowerOfCostOfAppraisal;
            UIActions.Clear(LowerOfCostOrAppraisal);
            UIActions.GiveInput(LowerOfCostOrAppraisal, lowerOfCostOfAppraisal);
        }

        [When(@"Enter Disclosed input values for Closing Disclosure page")]
        public void WhenEnterDisclosedInputValuesForClosingDisclosurePage()
        {
            var monthlyPrincipalAndInterest = TridVariable.MonthlyPrincipalAndInterest;
            UIActions.Clear(DisclosedMonthlyPrincipalandInterest);
            UIActions.GiveInput(DisclosedMonthlyPrincipalandInterest, monthlyPrincipalAndInterest);

            var monthlyPmi = TridVariable.MonthlyPmi;
            UIActions.Clear(DisclosedMonthlyPmi);
            UIActions.GiveInput(DisclosedMonthlyPmi, monthlyPmi);

            var totalMonhtlyPayment = TridVariable.TotalPeiodicPayment;
            UIActions.Clear(DisclosedTotalPeriodicPayment);
            UIActions.GiveInput(DisclosedTotalPeriodicPayment, totalMonhtlyPayment);

            var pmiTerminationDate = ProjActions.GetDate(TridVariable.PmiTerminationDate);
            UIActions.Clear(DisclosedPmiTerminalDate);
            UIActions.GiveInput(DisclosedPmiTerminalDate, pmiTerminationDate);

            var pmiCancelDate = ProjActions.GetDate(TridVariable.PmiCancelDate);
            UIActions.Clear(DisclosedPmiCancelDate);
            UIActions.GiveInput(DisclosedPmiCancelDate, pmiCancelDate);

            var disclosedFinalBalloonPayment = TridVariable.DisclosedFinalBalloonPayment;
            UIActions.Clear(DisclosedFinalBalloonPayment);
            UIActions.GiveInput(DisclosedFinalBalloonPayment, disclosedFinalBalloonPayment);

            var disclosedTotalOfPayment = TridVariable.DisclosedTotalOfPayment;
            UIActions.Clear(DisclosedTotalOfPayment);
            UIActions.GiveInput(DisclosedTotalOfPayment, disclosedTotalOfPayment);
        }


        [When(@"user navigates to Disclosure Inputs Page")]
        public void WhenUserNavigatesToDisclosureInputsPage()
        {
            UIActions.Click(DisclosureInputsLink);
            UIActions.WebDriverWait(DisclosedValuesText, 60);
        }

        [When(@"user enters disclosed input values for closing disclousre section")]
        public void WhenUserEntersDisclosedInputValuesForClosingDisclousreSection()
        {
            var monthlyPrincipalAndInterest = TridVariable.MonthlyPrincipalAndInterest;
            UIActions.Clear(DisclosedMonthlyPrincipalandInterest);
            UIActions.GiveInput(DisclosedMonthlyPrincipalandInterest, monthlyPrincipalAndInterest);

            var monthlyPmi = TridVariable.MonthlyPmi;
            UIActions.Clear(DisclosedMonthlyPmi);
            UIActions.GiveInput(DisclosedMonthlyPmi, monthlyPmi);

            var totalMonhtlyPayment = TridVariable.TotalPeiodicPayment;
            UIActions.Clear(DisclosedTotalPeriodicPayment);
            UIActions.GiveInput(DisclosedTotalPeriodicPayment, totalMonhtlyPayment);

            var pmiTerminationDate = ProjActions.GetDate(TridVariable.PmiTerminationDate);
            UIActions.Clear(DisclosedPmiTerminalDate);
            UIActions.GiveInput(DisclosedPmiTerminalDate, pmiTerminationDate);

            var pmiCancelDate = ProjActions.GetDate(TridVariable.PmiCancelDate);
            UIActions.Clear(DisclosedPmiCancelDate);
            UIActions.GiveInput(DisclosedPmiCancelDate, pmiCancelDate);

            var disclosedFinalBalloonPayment = TridVariable.DisclosedFinalBalloonPayment;
            UIActions.Clear(DisclosedFinalBalloonPayment);
            UIActions.GiveInput(DisclosedFinalBalloonPayment, disclosedFinalBalloonPayment);

            var disclosedTotalOfPayment = TridVariable.DisclosedTotalOfPayment;
            UIActions.Clear(DisclosedTotalOfPayment);
            UIActions.GiveInput(DisclosedTotalOfPayment, disclosedTotalOfPayment);
        }

        [When(@"user enters disclsoed input values for Loan Estimate")]
        public void WhenUserEntersDisclsoedInputValuesForLoanEstimate()
        {
            var in5Years = TridVariable.DiscLosedIn5Years;
            UIActions.Clear(DisclosedIn5Years);
            UIActions.GiveInput(DisclosedIn5Years, in5Years);

            var in5YearsPrincipal = TridVariable.DiscLosedIn5YearsPrincipal;
            UIActions.Clear(DisclosedIn5YearsPrincipal);
            UIActions.GiveInput(DisclosedIn5YearsPrincipal, in5YearsPrincipal);

            var apr = TridVariable.DisclosedApr;
            UIActions.Clear(DisclosedApr);
            UIActions.GiveInput(DisclosedApr, apr);

            var tip = TridVariable.DisclosedTip;
            UIActions.Clear(DisclosedTip);
            UIActions.GiveInput(DisclosedTip, tip);
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
            UIActions.WebDriverWait(AprLabelText, 60);

            UIActions.ScrollDown();
            Thread.Sleep(2000);
            UIActions.ScrollUp();
        }

        [When(@"user navigates to Loan Estimate Cards Page")]
        public void WhenUserNavigatesToLoanEstimateCardsPage()
        {
            UIActions.Click(LoanEstimateLink);
            UIActions.WebDriverWait(LoanEstimateIn5YearsText, 60);
        }

        [When(@"user selects value for Is Ins Escrowed")]
        public void WhenUserSelectsValueForIsInsEscrowed()
        {
            UIActions.ScrollUp();
            EscrowRadioButtonVariable();
            UIActions.WebDriverWait(IsInsEscrowed, 60);
            UIActions.Click(IsInsEscrowed);
        }

        [When(@"user selects value for Is Tax Escrowed")]
        public void WhenUserSelectsValueForIsTaxEscrowed()
        {
            EscrowRadioButtonVariable();
            UIActions.WebDriverWait(IsTaxEscrowed, 60);
            UIActions.Click(IsTaxEscrowed);
        }

        [When(@"user selects value for Is Other1 Escrowed")]
        public void WhenUserSelectsValueForIsOther1Escrowed()
        {
            EscrowRadioButtonVariable();
            UIActions.WebDriverWait(IsOther1Escrowed, 60);
            UIActions.Click(IsOther1Escrowed);
        }

        [When(@"user selects value for Is Other2 Escrowed")]
        public void WhenUserSelectsValueForIsOther2Escrowed()
        {
            EscrowRadioButtonVariable();
            UIActions.WebDriverWait(IsOther2Escrowed, 60);
            UIActions.Click(IsOther2Escrowed);
        }

        [When(@"user enters input values for Cushion Months")]
        public void WhenUserEntersInputValuesForCushionMonths()
        {
            UIActions.Clear(CushionMonthsForInsurance);
            UIActions.GiveInput(CushionMonthsForInsurance, TridVariable.CushionMonthsForInsurance);

            UIActions.Clear(CushionMonthsForTax);
            UIActions.GiveInput(CushionMonthsForTax, TridVariable.CushionMonthsForTax);
        }

        [When(@"user enters values for Escrow insurance Inputs")]
        public void WhenUserEntersValuesForEscrowInsuranceInputs()
        {
            if (TridVariable.EscrowInstallmentInputsNumber!="0")
            {
                Assert.AreNotEqual(1, EscrowInstallmentInfoGridRowCount, "Escrow Installment Info Grid is not empty");

                UIActions.Clear(EscrowInstallmentInputsNumber);
                UIActions.GiveInput(EscrowInstallmentInputsNumber, TridVariable.EscrowInstallmentInputsNumber);

                var dateForEscrowInsurance =
                    DateTime.FromOADate(Convert.ToDouble(TridVariable.DateForEscrowInsurance)).ToString("MM/dd/yyyy");
                UIActions.Clear(DateForEscrowInsurance);
                UIActions.GiveInput(DateForEscrowInsurance, dateForEscrowInsurance);
                Thread.Sleep(500);

                UIActions.Clear(InsuranceInstallmentAmount);
                UIActions.GiveInput(InsuranceInstallmentAmount, TridVariable.InsuranceInstallmentAmount);

                UIActions.Click(EscrowInstallmentInputsAddButton);
                Thread.Sleep(1000);

                Assert.AreEqual(TridVariable.EscrowInstallmentInputsNumber,
                    UIActions.GetText(EscrowInstallmentInfoGridNumber),
                    "Escrow Installment Info Number value does not matches as expected");
                Assert.AreEqual(dateForEscrowInsurance, UIActions.GetText(EscrowInstallmentInfoGridInstallmentDate),
                    "Escrow Installment Info Date value does not matches as expected");
                Assert.AreEqual(TridVariable.InsuranceInstallmentAmount,
                    UIActions.GetText(EscrowInstallmentInfoGridInstallmentAmount),
                    "Escrow Installment Info Amount value does not matches as expected");
            }
        }

        [When(@"user enters values for Escrow Tax Calculations Inputs")]
        public void WhenUserEntersValuesForEscrowTaxCalculationsInputs()
        {
            if (TridVariable.EscrowTaxCalculationsInputsNumberFR!="0")
            {
                Assert.AreNotEqual(1, EscrowTaxInfoGridRowCount, "Escrow Installment Info Grid is not empty");

                UIActions.Clear(EscrowTaxCalculationsInputsNumber);
                UIActions.GiveInput(EscrowTaxCalculationsInputsNumber, TridVariable.EscrowTaxCalculationsInputsNumberFR);

                var escrowTaxCalculationsInputsDateFR =
                    DateTime.FromOADate(Convert.ToDouble(TridVariable.EscrowTaxCalculationsInputsDateFR))
                        .ToString("MM/dd/yyyy");
                UIActions.Clear(EscrowTaxCalculationsInputsDate);
                UIActions.GiveInput(EscrowTaxCalculationsInputsDate, escrowTaxCalculationsInputsDateFR);
                Thread.Sleep(500);

                UIActions.Clear(EscrowTaxCalculationsInputsTaxInstallmentAmount);
                UIActions.GiveInput(EscrowTaxCalculationsInputsTaxInstallmentAmount,
                    TridVariable.EscrowTaxCalculationsInputsTaxInstallmentAmountFR);

                UIActions.Click(EscrowTaxCalculationsInputsAddButton);
                Thread.Sleep(1000);

                Assert.AreEqual(TridVariable.EscrowTaxCalculationsInputsNumberFR,
                    UIActions.GetText(EscrowTaxInfoGridNumberFR),
                    "Escrow Installment Info Number value does not matches as expected");
                Assert.AreEqual(escrowTaxCalculationsInputsDateFR, UIActions.GetText(EscrowTaxInfoGridInstallmentDateFR),
                    "Escrow Installment Info Number value does not matches as expected");
                Assert.AreEqual(TridVariable.EscrowTaxCalculationsInputsTaxInstallmentAmountFR,
                    UIActions.GetText(EscrowTaxInfoGridTaxInstallmentAmountFR),
                    "Escrow Installment Info Number value does not matches as expected");
            }

            if (TridVariable.EscrowTaxCalculationsInputsNumberSR!="0")
            {

                UIActions.Clear(EscrowTaxCalculationsInputsNumber);
                UIActions.GiveInput(EscrowTaxCalculationsInputsNumber, TridVariable.EscrowTaxCalculationsInputsNumberSR);


                var escrowTaxCalculationsInputsDateSR =
                    DateTime.FromOADate(Convert.ToDouble(TridVariable.EscrowTaxCalculationsInputsDateSR))
                        .ToString("MM/dd/yyyy");
                UIActions.Clear(EscrowTaxCalculationsInputsDate);
                UIActions.GiveInput(EscrowTaxCalculationsInputsDate, escrowTaxCalculationsInputsDateSR);
                Thread.Sleep(500);

                UIActions.Clear(EscrowTaxCalculationsInputsTaxInstallmentAmount);
                UIActions.GiveInput(EscrowTaxCalculationsInputsTaxInstallmentAmount,
                    TridVariable.EscrowTaxCalculationsInputsTaxInstallmentAmountSR);

                UIActions.Click(EscrowTaxCalculationsInputsAddButton);
                Thread.Sleep(1000);

                Assert.AreEqual(TridVariable.EscrowTaxCalculationsInputsNumberSR,
                    UIActions.GetText(EscrowTaxInfoGridNumberSR),
                    "Escrow Installment Info Number value does not matches as expected");
                Assert.AreEqual(escrowTaxCalculationsInputsDateSR, UIActions.GetText(EscrowTaxInfoGridInstallmentDateSR),
                    "Escrow Installment Info Number value does not matches as expected");
                Assert.AreEqual(TridVariable.EscrowTaxCalculationsInputsTaxInstallmentAmountSR,
                    UIActions.GetText(EscrowTaxInfoGridTaxInstallmentAmountSR),
                    "Escrow Installment Info Number value does not matches as expected");
            }
        }


        [When(@"user enters values for Escrow Other1 Calculations Inputs")]
        public void WhenUserEntersValuesForEscrowOther1CalculationsInputs()
        {
            if (TridVariable.EscrowOther1CalculationsInputsNumber!="0")
            {
                Assert.AreNotEqual(1, EscrowOther1InfoGridRowCount, "Escrow Installment Info Grid is not empty");

                UIActions.Clear(EscrowOther1InputsNumber);
                UIActions.GiveInput(EscrowOther1InputsNumber, TridVariable.EscrowOther1CalculationsInputsNumber);

                var dateForEscrowOther1 =
                    DateTime.FromOADate(Convert.ToDouble(TridVariable.EscrowOther1CalculationsInputsDate)).ToString("MM/dd/yyyy");
                UIActions.Clear(DateForEscrowOther1);
                UIActions.GiveInput(DateForEscrowOther1, dateForEscrowOther1);
                Thread.Sleep(500);

                UIActions.Clear(Other1InstallmentAmount);
                UIActions.GiveInput(Other1InstallmentAmount, TridVariable.EscrowOther1CalculationsInputsAmount);

                UIActions.Click(EscrowOther1InputsAddButton);
                Thread.Sleep(1000);

                Assert.AreEqual(TridVariable.EscrowOther1CalculationsInputsNumber,
                    UIActions.GetText(EscrowOther1InfoGridNumber),
                    "Escrow Other1 Info Number value does not matches as expected");
                Assert.AreEqual(dateForEscrowOther1, UIActions.GetText(EscrowOther1InfoGridInstallmentDate),
                    "Escrow Other1 Info Date value does not matches as expected");
                Assert.AreEqual(TridVariable.EscrowOther1CalculationsInputsAmount,
                    UIActions.GetText(EscrowOther1InfoGridInstallmentAmount),
                    "Escrow Other1 Info Amount value does not matches as expected");
            }
        }

        [When(@"user enters values for Escrow Other2 Calculations Inputs")]
        public void WhenUserEntersValuesForEscrowOther2CalculationsInputs()
        {
            if (TridVariable.EscrowOther2CalculationsInputsNumber!="0")
            {
                Assert.AreNotEqual(1, EscrowOther2InfoGridRowCount, "Escrow Installment Info Grid is not empty");

                UIActions.Clear(EscrowOther2InputsNumber);
                UIActions.GiveInput(EscrowOther2InputsNumber, TridVariable.EscrowOther2CalculationsInputsNumber);

                var dateForEscrowOther2 =
                    DateTime.FromOADate(Convert.ToDouble(TridVariable.EscrowOther2CalculationsInputsDate))
                        .ToString("MM/dd/yyyy");
                UIActions.Clear(DateForEscrowOther2);
                UIActions.GiveInput(DateForEscrowOther2, dateForEscrowOther2);
                Thread.Sleep(500);

                UIActions.Clear(Other2InstallmentAmount);
                UIActions.GiveInput(Other2InstallmentAmount, TridVariable.EscrowOther2CalculationsInputsAmount);

                UIActions.Click(EscrowOther2InputsAddButton);
                Thread.Sleep(1000);

                Assert.AreEqual(TridVariable.EscrowOther2CalculationsInputsNumber,
                    UIActions.GetText(EscrowOther2InfoGridNumber),
                    "Escrow Other2 Info Number value does not matches as expected");
                Assert.AreEqual(dateForEscrowOther2, UIActions.GetText(EscrowOther2InfoGridInstallmentDate),
                    "Escrow Other2 Info Date value does not matches as expected");
                Assert.AreEqual(TridVariable.EscrowOther2CalculationsInputsAmount,
                    UIActions.GetText(EscrowOther2InfoGridInstallmentAmount),
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

        #endregion


        #region Then

        [Then(@"updated/computed Principal and Interest value should display on Closing Disclosure")]
        public void ThenUpdatedComputedPrincipalAndInterestValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(PiComputedValue)), 2);

                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.PrincipalAndInt), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PiDisclosureValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("DisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                var expectedVValue = Convert.ToDouble(TridVariable.VariancePrincipalAndInt);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PiVarianceValue));

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
                CardsFailure += "|| PrincipalAndInt ||";
            }
        }

        [Then(@"updated/computed Mortgage Insurance value should display on Closing Disclosure")]
        public void ThenUpdatedComputedMortgageInsuranceValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(MiComputedValue)), 2);

                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.MortgageInsurance), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(MiDisclosureValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("DisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceMortgageInsurance);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(MiVarianceValue));

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
                CardsFailure += "|| MortgageInsurance ||";
            }
        }

        [Then(@"updated/computed APR value should display on Closing Disclosure")]
        public void ThenUpdatedComputedAprValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(AprComputedValue)), 3);

                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.Apr), 3);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(AprDisclosureValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("DisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceApr);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(AprVarianceValue));

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
                CardsFailure += "|| APR ||";
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
                    Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                    Console.WriteLine("ActualComputedValue :" + actualCValue);
                    Console.WriteLine("============================================================");

                    var actualDValue = ProjActions.GetDatePart(SptdDisclosureValue);

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("DisclosedValue :" + actualDValue);
                    Console.WriteLine("============================================================");

                    var expectedVValue = Convert.ToDouble(TridVariable.VarianceScheduledPmiTerminationDate);
                    var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(SptdVarianceValue));

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

                Console.WriteLine("===========================================================");
                Console.WriteLine("DisclosedValue :" + actualDValue);
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
                CardsFailure += "|| DropOffYearsForPmi ||";
            }
        }


        [Then(@"updated/computed Estimated Total Monthly Payment value should display on Closing Disclosure")]
        public void ThenUpdatedComputedEstimatedTotalMonthlyPaymentValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(EtmpComputedValue)), 2);

                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.EstimatedTotalMonthlyPayment), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(EtmpDisclosureValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("DisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceEstimatedTotalMonthlyPayment);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(EtmpVarianceValue));

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
                CardsFailure += "|| EstimatedTotalMonthlyPayment ||";
            }
        }

        [Then(@"updated/computed Prepaid Charges value should display on Closing Disclosure")]
        public void ThenUpdatedComputedPrepaidChargesValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(PcComputedValue)), 2);

                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.PrepaidCharges), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PcDisclosureValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("DisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                var expectedVValue = Convert.ToDouble(TridVariable.VariancePrepaidCharges);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PcVarianceValue));

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
                CardsFailure += "|| PrepaidCharges ||";
            }
        }

        [Then(@"updated/computed Amount Financed value should display on Closing Disclosure")]
        public void ThenUpdatedComputedAmountFinancedValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(AfComputedValue)), 2);

                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.AmountFinanced), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(AfDisclosureValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("DisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceAmountFinanced);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(AfVarianceValue));

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
                CardsFailure += "|| AmountFinanced ||";
            }
        }

        [Then(@"updated/computed Escrow Property Costs over one year 11 Months value should display on Closing Disclosure")]
        public void ThenUpdatedComputedEscrowPropertyCostsOverOneYear11MonthsValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue =
                    Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(E1O11ComputedValue)), 2);

                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.EscrowPropertyOver1Year11Months), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(E1O11DisclosureValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("DisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceEscrowPropertyOver1Year11Months);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(E1O11VarianceValue));

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
                CardsFailure += "|| EscrowPropertyOver1Year11Months ||";
            }
        }

        [Then(@"updated/computed Escrow Property Costs over one year 12 Months value should display on Closing Disclosure")]
        public void ThenUpdatedComputedEscrowPropertyCostsOverOneYear12MonthsValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue =
                    Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(E1O12ComputedValue)), 2);

                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.EscrowPropertyOver1Year12Months), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(E1O12DisclosureValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("DisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceEscrowPropertyOver1Year12Months);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(E1O12VarianceValue));

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
                CardsFailure += "|| EscrowPropertyOver1Year12Months ||";
            }
        }




        [Then(@"updated/computed Balloon Amount value should display on Closing Disclosure")]
        public void ThenUpdatedComputedBalloonAmountValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(BaComputedValue)), 2);

                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.BalloonAmount), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(BaDisclosureValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("DisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceBalloonAmount);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(BaVarianceValue));

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
                CardsFailure += "|| BalloonAmount ||";
            }
        }

        [Then(@"updated/computed Total of Payments value should display on Closing Disclosure")]
        public void ThenUpdatedComputedTotalOfPaymentsValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(TopComputedValue)), 2);

                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.TotalOfPayments), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TopDisclosureValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("DisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceTotalOfPayments);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TopVarianceValue));

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
                CardsFailure += "|| TotalOfPayments ||";
            }
        }

        [Then(@"updated/computed Finance Charge value should display on Closing Disclosure")]
        public void ThenUpdatedComputedFinanceChargeValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(FcComputedValue)), 2);

                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.FinanceCharge), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(FcDisclosureValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("DisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceFinanceCharge);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(FcVarianceValue));

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
                CardsFailure += "|| FinanceCharge ||";
            }
        }

        [Then(@"updated/computed TIP value should display on Closing Disclosure")]
        public void ThenUpdatedComputedTipValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(TipComputedValue)), 2);

                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.Tip), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TipDisclosureValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("DisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceTip);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TipVarianceValue));

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
                CardsFailure += "|| TIP ||";
            }
        }

        [Then(@"updated/computed Initial Escrow Payment value should display on Closing Disclosure")]
        public void ThenUpdatedComputedInitialEscrowPaymentValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(IepComputedValue)), 2);

                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.InitialEscrowPayment), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(IepDisclosureValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("DisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceInitialEscrowPayment);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(IepVarianceValue));

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
                CardsFailure += "|| InitialEscrowPayment ||";
            }
        }


        [Then(@"updated/computed Non Escrow Property Costs over one year value should display on Closing Disclosure")]
        public void ThenUpdatedComputedNonEscrowPropertyCostsOverOneYearValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue =
                    Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(Neo1YComputedValue)), 2);

                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.NonEscrowPropertyOverOneYear), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(Neo1YDisclosureValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("DisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceNonEscrowPropertyOverOneYear);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(Neo1YVarianceValue));

                Assert.AreEqual(actualVValue, expectedVValue, "Variance does not match as expected");

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
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(EeComputedValue)), 2);

                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.EstimatedEscrow), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(EeDisclosureValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("DisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceEstimatedEscrow);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(EeVarianceValue));

                Assert.AreEqual(actualVValue, expectedVValue, "Variance does not match as expected");

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
                var actualCValue = Math.Round(
                    ProjActions.GetNumericValueFromString(UIActions.GetText(EtiaComputedValue)), 2);

                var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.EstimatedTaxesInsuranceAssessments), 2);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(EtiaDisclosureValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("DisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceEstimatedTaxesInsuranceAssessments);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(EtiaVarianceValue));

                Assert.AreEqual(actualVValue, expectedVValue, "Variance does not match as expected");

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
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(I5YDisclosureValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("DisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceIn5Years);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(I5YVarianceValue));

                Assert.AreEqual(actualVValue, expectedVValue, "Variance does not match as expected");

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
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(I5YpDisclosureValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("DisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceIn5YearsPrincipal);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(I5YpVarianceValue));

                Assert.AreEqual(actualVValue, expectedVValue, "Variance does not match as expected");

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
