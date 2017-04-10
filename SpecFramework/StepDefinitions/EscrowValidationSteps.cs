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
            UIActions.WebDriverWait(EscEscrowCalcInputsText, 60);
        }
        
        [When(@"user selects value for Is Ins Escrowed")]
        public void WhenUserSelectsValueForIsInsEscrowed()
        {
            EscrowRadioButtonVariable();
            UIActions.Click(EscIsInsEscrowed);
        }
        
        [When(@"user selects value for Is Tax Escrowed")]
        public void WhenUserSelectsValueForIsTaxEscrowed()
        {
            EscrowRadioButtonVariable();
            UIActions.Click(EscIsTaxEscrowed);
        }
        
        [When(@"user selects value for Is PMI Escrowed")]
        public void WhenUserSelectsValueForIsPmiEscrowed()
        {
            EscrowRadioButtonVariable();
            UIActions.Click(EscIsPmiEscrowed);
        }
        
        [When(@"user enters values for Escrow Calculations start period Date")]
        public void WhenUserEntersValuesForEscrowCalculationsStartPeriodDate()
        {
            UIActions.Clear(EscEscrowCalculationStartPeriodDate);
            UIActions.GiveInput(EscEscrowCalculationStartPeriodDate, TridVariable.EscrowCalculationStartPeriodDate);
        }
        
        [When(@"user enters values for Cushion Months for Insurance")]
        public void WhenUserEntersValuesForCushionMonthsForInsurance()
        {
            UIActions.Clear(EscCushionMonthsForInsurance);
            UIActions.GiveInput(EscCushionMonthsForInsurance, TridVariable.CushionMonthsForInsurance);
        }
        
        [When(@"user enters values for Cushion Months for Tax")]
        public void WhenUserEntersValuesForCushionMonthsForTax()
        {
            UIActions.Clear(EscCushionMonthsForTax);
            UIActions.GiveInput(EscCushionMonthsForTax, TridVariable.CushionMonthsForTax);
        }
        
        //[When(@"user enters values for Cushion Months for PMI")]
        //public void WhenUserEntersValuesForCushionMonthsForPMI()
        //{
        //    UIActions.Clear(EscEscrowCalculationStartPeriodDate);
        //    UIActions.GiveInput(EscEscrowCalculationStartPeriodDate, TridVariable.EscrowCalculationStartPeriodDate);
        //}
        
        [When(@"user enters values for Escrow insurance Inputs")]
        public void WhenUserEntersValuesForEscrowInsuranceInputs()
        {
            Assert.AreNotEqual(1, EscrowInstallmentInfoGridRowCount, "Escrow Installment Info Grid is not empty");

            UIActions.Clear(EscEscrowInstallmentInputsNumber);
            UIActions.GiveInput(EscEscrowInstallmentInputsNumber, TridVariable.EscrowInstallmentInputsNumber);

            UIActions.Clear(EscDateForEscrowInsurance);
            UIActions.GiveInput(EscDateForEscrowInsurance, TridVariable.DateForEscrowInsurance);

            UIActions.Clear(EscInsuranceInstallmentAmount);
            UIActions.GiveInput(EscInsuranceInstallmentAmount, TridVariable.InsuranceInstallmentAmount);

            UIActions.Click(EscEscrowInstallmentInputsAddButton);
            Thread.Sleep(3000);

            Assert.AreEqual(TridVariable.EscrowInstallmentInputsNumber, UIActions.GetText(EscrowInstallmentInfoGridNumber), "Escrow Installment Info Number value does not matches as expected");
            Assert.AreEqual(TridVariable.DateForEscrowInsurance, UIActions.GetText(EscrowInstallmentInfoGridInstallmentDate), "Escrow Installment Info Number value does not matches as expected");
            Assert.AreEqual(TridVariable.InsuranceInstallmentAmount, UIActions.GetText(EscrowInstallmentInfoGridInstallmentAmount), "Escrow Installment Info Number value does not matches as expected");
        }
        
        [When(@"user enters values for Escrow Tax Calculations Inputs")]
        public void WhenUserEntersValuesForEscrowTaxCalculationsInputs()
        {
            Assert.AreNotEqual(1, EscrowTaxInfoGridRowCount, "Escrow Installment Info Grid is not empty");

            UIActions.Clear(EscEscrowTaxCalculationsInputsNumber);
            UIActions.GiveInput(EscEscrowTaxCalculationsInputsNumber, TridVariable.EscrowTaxCalculationsInputsNumber);

            UIActions.Clear(EscEscrowTaxCalculationsInputsDate);
            UIActions.GiveInput(EscEscrowTaxCalculationsInputsDate, TridVariable.EscrowTaxCalculationsInputsDate);

            UIActions.Clear(EscEscrowTaxCalculationsInputsTaxInstallmentAmount);
            UIActions.GiveInput(EscEscrowTaxCalculationsInputsTaxInstallmentAmount, TridVariable.EscrowTaxCalculationsInputsTaxInstallmentAmount);

            UIActions.Click(EscEscrowTaxCalculationsInputsAddButton);
            Thread.Sleep(3000);

            Assert.AreEqual(TridVariable.EscrowTaxCalculationsInputsNumber, UIActions.GetText(EscrowTaxInfoGridNumber), "Escrow Installment Info Number value does not matches as expected");
            Assert.AreEqual(TridVariable.EscrowTaxCalculationsInputsDate, UIActions.GetText(EscrowTaxInfoGridInstallmentDate), "Escrow Installment Info Number value does not matches as expected");
            Assert.AreEqual(TridVariable.EscrowTaxCalculationsInputsTaxInstallmentAmount, UIActions.GetText(EscrowTaxInfoGridTaxInstallmentAmount), "Escrow Installment Info Number value does not matches as expected");
        }
        
        [When(@"user enters values for Escrow PMI Calculations Inputs")]
        public void WhenUserEntersValuesForEscrowPmiCalculationsInputs()
        {
            UIActions.Clear(EscEscrowInputForPmiCalculationEscrowPmiDate);
            UIActions.GiveInput(EscEscrowInputForPmiCalculationEscrowPmiDate, TridVariable.EscrowInputForPmiCalculationEscrowPmiDate);
        }


        [When(@"user clicks on Escrow Calculation Input Test Button")]
        public void WhenUserClicksOnEscrowCalculationInputTestButton()
        {
            UIActions.Click(EscEscrowCalculationInputTestButton);
            Thread.Sleep(5000);
        }

        [When(@"user enters all other input values in Escrow Page")]
        public void WhenUserEntersAllOtherInputValuesInEscrowPage()
        {
            UIActions.Clear(EscEscrowPropertyOverOneYear);
            UIActions.GiveInput(EscEscrowPropertyOverOneYear, TridVariable.EscrowPropertyOverOneYear);

            UIActions.Clear(EscNonEscrowPropertyOverOneYear);
            UIActions.GiveInput(EscNonEscrowPropertyOverOneYear, TridVariable.NonEscrowPropertyOverOneYear);

            UIActions.Clear(EscInitialEscrowPayment);
            UIActions.GiveInput(EscInitialEscrowPayment, TridVariable.InitialEscrowPayment);

            UIActions.Clear(EscDisclosedEscrowPropertyOverOneYear);
            UIActions.GiveInput(EscDisclosedEscrowPropertyOverOneYear, TridVariable.DisclosedEscrowPropertyOverOneYear);

            UIActions.Clear(EscDisclosedNonEscrowPropertyOverOneYear);
            UIActions.GiveInput(EscDisclosedNonEscrowPropertyOverOneYear, TridVariable.DisclosedNonEscrowPropertyOverOneYear);

            UIActions.Clear(EscDisclosedInitialEscrowPayment);
            UIActions.GiveInput(EscDisclosedInitialEscrowPayment, TridVariable.DisclosedInitialEscrowPayment);

            UIActions.Clear(EscDisclosedMonthlyEscrowPayment);
            UIActions.GiveInput(EscDisclosedMonthlyEscrowPayment, TridVariable.DisclosedMonthlyEscrowPayment);

            UIActions.Clear(EscDisclosedEscrowPayment);
            UIActions.GiveInput(EscDisclosedEscrowPayment, TridVariable.DisclosedEstimatedEscrow);
        }

        [When(@"user clicks on Disclosure For Escrow Test Button")]
        public void WhenUserClicksOnDisclosureForEscrowTestButton()
        {
            UIActions.Click(EscDisclosureForEscrowTestButton);
            Thread.Sleep(5000);
        }

    }
}
