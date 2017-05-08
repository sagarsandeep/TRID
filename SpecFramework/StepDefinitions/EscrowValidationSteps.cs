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
    public class EscrowValidationSteps : TridTest
    {
        readonly GetExcelData _getData = new GetExcelData();

        [Given(@"user have Escrow data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHaveEscrowDataFromExcelSheetForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }


        [When(@"user navigate to Escrow Page")]
        public void WhenUserNavigateToEscrowPage()
        {
            UIActions.Click(EscrowLink);
            UIActions.WebDriverWait(EscrowCalcInputsText, 60);
        }
        
        [When(@"user selects value for Is Ins Escrowed")]
        public void WhenUserSelectsValueForIsInsEscrowed()
        {  
            UIActions.ScrollUp();
            EscrowRadioButtonVariable();
            UIActions.Click(IsInsEscrowed);
        }
        
        [When(@"user selects value for Is Tax Escrowed")]
        public void WhenUserSelectsValueForIsTaxEscrowed()
        {
            EscrowRadioButtonVariable();
            UIActions.Click(IsTaxEscrowed);
        }
        
        [When(@"user selects value for Is PMI Escrowed")]
        public void WhenUserSelectsValueForIsPmiEscrowed()
        {
            EscrowRadioButtonVariable();
            UIActions.Click(IsPmiEscrowed);
        }
        
        [When(@"user enters values for Escrow Calculations start period Date")]
        public void WhenUserEntersValuesForEscrowCalculationsStartPeriodDate()
        {
            //var escrowCalculationStartPeriodDate = DateTime.FromOADate(Convert.ToDouble(TridVariable.EscrowCalculationStartPeriodDate)).ToString("MM/dd/yyyy");
            //UIActions.Clear(EscrowCalculationStartPeriodDate);
            //UIActions.GiveInput(EscrowCalculationStartPeriodDate, escrowCalculationStartPeriodDate);
        }
        
        [When(@"user enters values for Cushion Months for Insurance")]
        public void WhenUserEntersValuesForCushionMonthsForInsurance()
        {
            UIActions.Clear(CushionMonthsForInsurance);
            UIActions.GiveInput(CushionMonthsForInsurance, TridVariable.CushionMonthsForInsurance);
        }
        
        [When(@"user enters values for Cushion Months for Tax")]
        public void WhenUserEntersValuesForCushionMonthsForTax()
        {
            UIActions.Clear(CushionMonthsForTax);
            UIActions.GiveInput(CushionMonthsForTax, TridVariable.CushionMonthsForTax);
        }
        
        //[When(@"user enters values for Cushion Months for PMI")]
        //public void WhenUserEntersValuesForCushionMonthsForPMI()
        //{
        //    UIActions.Clear(EscrowCalculationStartPeriodDate);
        //    UIActions.GiveInput(EscrowCalculationStartPeriodDate, TridVariable.EscrowCalculationStartPeriodDate);
        //}
        
        [When(@"user enters values for Escrow insurance Inputs")]
        public void WhenUserEntersValuesForEscrowInsuranceInputs()
        {
            Assert.AreNotEqual(1, EscrowInstallmentInfoGridRowCount, "Escrow Installment Info Grid is not empty");

            UIActions.Clear(EscrowInstallmentInputsNumber);
            UIActions.GiveInput(EscrowInstallmentInputsNumber, TridVariable.EscrowInstallmentInputsNumber);

            Thread.Sleep(3000);
            var dateForEscrowInsurance = DateTime.FromOADate(Convert.ToDouble(TridVariable.DateForEscrowInsurance)).ToString("MM/dd/yyyy");
            UIActions.Clear(DateForEscrowInsurance);
            UIActions.GiveInput(DateForEscrowInsurance, dateForEscrowInsurance);
            Thread.Sleep(3000);

            UIActions.Clear(InsuranceInstallmentAmount);
            UIActions.GiveInput(InsuranceInstallmentAmount, TridVariable.InsuranceInstallmentAmount);

            UIActions.Click(EscrowInstallmentInputsAddButton);
            Thread.Sleep(3000);

            Assert.AreEqual(TridVariable.EscrowInstallmentInputsNumber, UIActions.GetText(EscrowInstallmentInfoGridNumber), "Escrow Installment Info Number value does not matches as expected");
            Thread.Sleep(3000);
            Assert.AreEqual(dateForEscrowInsurance, UIActions.GetText(EscrowInstallmentInfoGridInstallmentDate), "Escrow Installment Info Date value does not matches as expected");
            Thread.Sleep(3000);
            Assert.AreEqual(TridVariable.InsuranceInstallmentAmount, UIActions.GetText(EscrowInstallmentInfoGridInstallmentAmount), "Escrow Installment Info Amount value does not matches as expected");
        }
        
        [When(@"user enters values for Escrow Tax Calculations Inputs")]
        public void WhenUserEntersValuesForEscrowTaxCalculationsInputs()
        {
            Assert.AreNotEqual(1, EscrowTaxInfoGridRowCount, "Escrow Installment Info Grid is not empty");

            UIActions.Clear(EscrowTaxCalculationsInputsNumber);
            UIActions.GiveInput(EscrowTaxCalculationsInputsNumber, TridVariable.EscrowTaxCalculationsInputsNumberFR);

            Thread.Sleep(3000);
            var escrowTaxCalculationsInputsDateFR = DateTime.FromOADate(Convert.ToDouble(TridVariable.EscrowTaxCalculationsInputsDateFR)).ToString("MM/dd/yyyy");
            UIActions.Clear(EscrowTaxCalculationsInputsDate);
            UIActions.GiveInput(EscrowTaxCalculationsInputsDate, escrowTaxCalculationsInputsDateFR);
            Thread.Sleep(3000);

            UIActions.Clear(EscrowTaxCalculationsInputsTaxInstallmentAmount);
            UIActions.GiveInput(EscrowTaxCalculationsInputsTaxInstallmentAmount, TridVariable.EscrowTaxCalculationsInputsTaxInstallmentAmountFR);

            UIActions.Click(EscrowTaxCalculationsInputsAddButton);
            Thread.Sleep(3000);

            UIActions.Clear(EscrowTaxCalculationsInputsNumber);
            UIActions.GiveInput(EscrowTaxCalculationsInputsNumber, TridVariable.EscrowTaxCalculationsInputsNumberSR);

            Thread.Sleep(3000);
            var escrowTaxCalculationsInputsDateSR = DateTime.FromOADate(Convert.ToDouble(TridVariable.EscrowTaxCalculationsInputsDateSR)).ToString("MM/dd/yyyy");
            UIActions.Clear(EscrowTaxCalculationsInputsDate);
            UIActions.GiveInput(EscrowTaxCalculationsInputsDate, escrowTaxCalculationsInputsDateSR);
            Thread.Sleep(3000);

            UIActions.Clear(EscrowTaxCalculationsInputsTaxInstallmentAmount);
            UIActions.GiveInput(EscrowTaxCalculationsInputsTaxInstallmentAmount, TridVariable.EscrowTaxCalculationsInputsTaxInstallmentAmountSR);

            UIActions.Click(EscrowTaxCalculationsInputsAddButton);
            Thread.Sleep(3000);

            Assert.AreEqual(TridVariable.EscrowTaxCalculationsInputsNumberFR, UIActions.GetText(EscrowTaxInfoGridNumberFR), "Escrow Installment Info Number value does not matches as expected");
            Assert.AreEqual(escrowTaxCalculationsInputsDateFR, UIActions.GetText(EscrowTaxInfoGridInstallmentDateFR), "Escrow Installment Info Number value does not matches as expected");
            Assert.AreEqual(TridVariable.EscrowTaxCalculationsInputsTaxInstallmentAmountFR, UIActions.GetText(EscrowTaxInfoGridTaxInstallmentAmountFR), "Escrow Installment Info Number value does not matches as expected");

            Assert.AreEqual(TridVariable.EscrowTaxCalculationsInputsNumberSR, UIActions.GetText(EscrowTaxInfoGridNumberSR), "Escrow Installment Info Number value does not matches as expected");
            Assert.AreEqual(escrowTaxCalculationsInputsDateSR, UIActions.GetText(EscrowTaxInfoGridInstallmentDateSR), "Escrow Installment Info Number value does not matches as expected");
            Assert.AreEqual(TridVariable.EscrowTaxCalculationsInputsTaxInstallmentAmountSR, UIActions.GetText(EscrowTaxInfoGridTaxInstallmentAmountSR), "Escrow Installment Info Number value does not matches as expected");
        }


        //[When(@"user enters all input values for Prepaid Charges")]
        //public void WhenUserEntersAllInputValuesForPrepaidCharges()
        //{
        //    var fhaVaUsdaUpfrontPmiFree = TridVariable.FhaVaUsdaUpfrontPmiFree;
        //    UIActions.Clear(FhaVaUsdaUpfrontPmiFree);
        //    UIActions.GiveInput(FhaVaUsdaUpfrontPmiFree, fhaVaUsdaUpfrontPmiFree);

        //    var floodFee = TridVariable.FloodFee;
        //    UIActions.Clear(FloodFee);
        //    UIActions.GiveInput(FloodFee, floodFee);

        //    var inspectionFee = TridVariable.InspectionFee;
        //    UIActions.Clear(InspectionFee);
        //    UIActions.GiveInput(InspectionFee, inspectionFee);

        //    var loanOriginationFee = TridVariable.LoanOriginationFee;
        //    UIActions.Clear(LoanOriginationFee);
        //    UIActions.GiveInput(LoanOriginationFee, loanOriginationFee);

        //    var otherFees = TridVariable.OtherFees;
        //    UIActions.Clear(OtherFees);
        //    UIActions.GiveInput(OtherFees, otherFees);

        //    var pmiEscrowed = TridVariable.PmiEscrowed;
        //    UIActions.Clear(PmiEscrowed);
        //    UIActions.GiveInput(PmiEscrowed, pmiEscrowed);

        //    var prepaidDailyInterest = TridVariable.PrepaidDailyInterest;
        //    UIActions.Clear(PrepaidDailyInterest);
        //    UIActions.GiveInput(PrepaidDailyInterest, prepaidDailyInterest);

        //    var taxServicing = TridVariable.TaxServicing;
        //    UIActions.Clear(TaxServicing);
        //    UIActions.GiveInput(TaxServicing, taxServicing);

        //    var titleClosingFee = TridVariable.TitleClosingFee;
        //    UIActions.Clear(TitleClosingFee);
        //    UIActions.GiveInput(TitleClosingFee, titleClosingFee);

        //    var titleClosingProtectionLetter = TridVariable.TitleClosingProtectionLetter;
        //    UIActions.Clear(TitleClosingProtectionLetter);
        //    UIActions.GiveInput(TitleClosingProtectionLetter, titleClosingProtectionLetter);

        //    var titleCourierFee = TridVariable.TitleCourierFee;
        //    UIActions.Clear(TitleCourierFee);
        //    UIActions.GiveInput(TitleCourierFee, titleCourierFee);

        //    var titleDrawFee = TridVariable.TitleDrawFee;
        //    UIActions.Clear(TitleDrawFee);
        //    UIActions.GiveInput(TitleDrawFee, titleDrawFee);

        //    var titleWireFee = TridVariable.TitleWireFee;
        //    UIActions.Clear(TitleWireFee);
        //    UIActions.GiveInput(TitleWireFee, titleWireFee);

        //    var underWriting = TridVariable.UnderWriting;
        //    UIActions.Clear(UnderWriting);
        //    UIActions.GiveInput(UnderWriting, underWriting);
        //}


        [When(@"user enters values for Escrow PMI Calculations Inputs")]
        public void WhenUserEntersValuesForEscrowPmiCalculationsInputs()
        {
            //var ecrowInputForPmiCalculationEscrowPmiDate = DateTime.FromOADate(Convert.ToDouble(TridVariable.EscrowInputForPmiCalculationEscrowPmiDate)).ToString("M/d/yyyy");
            //UIActions.Clear(EscrowInputForPmiCalculationEscrowPmiDate);
            //UIActions.GiveInput(EscrowInputForPmiCalculationEscrowPmiDate, ecrowInputForPmiCalculationEscrowPmiDate);
        }


        [When(@"user clicks on Escrow Calculation Input Test Button")]
        public void WhenUserClicksOnEscrowCalculationInputTestButton()
        {

            UIActions.MouseHoverOver(EscrowCalcInputsText);
            Thread.Sleep(3000);
            EscrowRadioButtonVariable();
            UIActions.Click(IsInsEscrowed);
            //UIActions.Click(EscrowCalculationInputTestButton);
            Thread.Sleep(5000);
        }


        [When(@"user enters disclosed input values for Escrow Property")]
        public void WhenUserEntersDisclosedInputValuesForEscrowProperty()
        {
            UIActions.Clear(EscrowPropertyOverOneYear);
            UIActions.GiveInput(EscrowPropertyOverOneYear, TridVariable.EscrowPropertyOverOneYear);

            UIActions.Clear(NonEscrowPropertyOverOneYear);
            UIActions.GiveInput(NonEscrowPropertyOverOneYear, TridVariable.NonEscrowPropertyOverOneYear);

            UIActions.Clear(InitialEscrowPayment);
            UIActions.GiveInput(InitialEscrowPayment, TridVariable.InitialEscrowPayment);

            UIActions.Clear(DisclosedEscrowPropertyOverOneYear);
            UIActions.GiveInput(DisclosedEscrowPropertyOverOneYear, TridVariable.DisclosedEscrowPropertyOverOneYear);

            UIActions.Clear(DisclosedNonEscrowPropertyOverOneYear);
            UIActions.GiveInput(DisclosedNonEscrowPropertyOverOneYear, TridVariable.DisclosedNonEscrowPropertyOverOneYear);

            UIActions.Clear(DisclosedInitialEscrowPayment);
            UIActions.GiveInput(DisclosedInitialEscrowPayment, TridVariable.DisclosedInitialEscrowPayment);

            UIActions.Clear(DisclosedMonthlyEscrowPayment);
            UIActions.GiveInput(DisclosedMonthlyEscrowPayment, TridVariable.DisclosedMonthlyEscrowPayment);

            UIActions.Clear(DisclosedEstimatedEscrow);
            UIActions.GiveInput(DisclosedEstimatedEscrow, TridVariable.DisclosedEstimatedEscrow);
        }

        [When(@"user clicks on Disclosure For Escrow Test Button")]
        public void WhenUserClicksOnDisclosureForEscrowTestButton()
        {
            //UIActions.Click(DisclosureForEscrowTestButton);
            Thread.Sleep(5000);
        }

    }
}
