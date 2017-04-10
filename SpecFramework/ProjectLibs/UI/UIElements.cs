using System;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium;
using TRID.ActionClasses;
using TRID.CommonUtils;
using TRID.ProjectLibs.Common;

namespace TRID.ProjectLibs.UI
{
    public class UIElements : PageBase
    {
        #region HeaderBar

        public static By PrepaidChargesLink = By.LinkText("Prepaid Charges");
        public static By LoanEstimateLink = By.LinkText("Loan Estimate");
        public static By ClosingDisclosureLink = By.LinkText("Closing Disclosure");
        public static By MortgageInsuranceLink = By.LinkText("Mortgage Insurance");
        public static By EscrowLink = By.LinkText("Escrow");
        public static By ExportLink = By.LinkText("Export");

        #endregion


        #region Closing DisclosurePage

        public static By CdCalculationMethod;
        public static By CdLoanType;
        public static By CdFrequencyOfPayments;
        public static By CdLoanTerm;
        public static By CdRepaymentTermType;
        public static void ClosingDisclosureRadioButtonVariable()
        {
            CdCalculationMethod = By.XPath("//md-radio-button[@aria-label='" + TridVariable.CalculationMethod + "']");
            CdLoanType = By.XPath("//md-radio-button[@aria-label='" + TridVariable.LoanType + "']");
            CdFrequencyOfPayments = By.XPath("//md-radio-button[@aria-label='" + TridVariable.FrequencyOfPayments + "']");
            CdLoanTerm = By.XPath("//md-radio-button[@aria-label='" + TridVariable.LoanTerm + "']");
            CdRepaymentTermType = By.XPath("//md-radio-button[@aria-label='" + TridVariable.RepaymentTermType + "']");
        }

        public static By CdFreqOfPmtValue = By.XPath("//div[@title='Frequency Of Pmt Value']//input");
        public static By CdLoanTermValue = By.XPath("//div[@title='Loan Term Value']//input");

        public static By CdLoanAmount = By.XPath("//div[@title='Loan Amount']//input");
        public static By CdRateOfInterest = By.XPath("//div[@title='Rate Of Interest']//input");
        public static By CdDateOfLoan = By.XPath("//div[@title='Date of loan']//input");
        public static By CdDateOfInterestBegins = By.XPath("//div[@title='Date Interest Begins To Accrue']//input");
        public static By CdDateOfFirstPayment = By.XPath("//div[@title='Date Of First Payment']//input");
        public static By CdPeriodPayment = By.XPath("//div[@title='Period Payment']//input");
        public static By CdLoanCostsForDisclosure = By.XPath("//div[@title='Loan Costs For Disclosure(Sum of Section A, B, C )']//input");
        public static By CdFinalBalloonPayment = By.XPath("//div[@title='Final Balloon Payment']//input");
        //public static By CdOddDays = 
        //public static By CdLoanDetailsEstimatedEscrow = By.Id("input_64");

        public static By CdMonthlyPrincipalandInterest = By.XPath("//div[@title='Monthly Principal And Interest']//input");
        public static By CdMonthlyPmi = By.XPath("//div[@title='Monthly PMI']//input");
        public static By CdTotalMonthlyPayment = By.XPath("//div[@title='Total Monthly Payment']//input");
        public static By CdPmiTerminalDate = By.XPath("//div[@title='PMI Termination Date (78%)']//input");
        public static By CdPmiCancelDate = By.XPath("//div[@title='PMI Cancel Date (80%)']//input");
        public static By CdDisclosedEstimatedEscrow = By.XPath("//div[@title='Estimated Escrow']//input");
        public static By CdDisclosedFinalBalloonPayment = By.XPath("//div[@title='Dscl Final Balloon Payment']//input");
        public static By CdDisclosedTotalOfPayment = By.XPath("//div[@title='Total Of Payment']//input");

        public static By CdLoanDetailsTest = By.XPath("//div[@id='LoanInformationInput']/form/div/div[1]//wipfli-button/button");
        public static By CdLoanDetailsReset = By.XPath("//div[@id='LoanInformationInput']//div[2]/div/wipfli-button/button");
        public static By CdDisclosedTest = By.XPath("//div[@id='DisclosureInput']//button");
        public static By CdLoanDetailsText = By.XPath("//div[@id='LoanInformationInput']//div[@class='md-toolbar-tools ng-binding']");

        //Princpal & Interest
        public static By CdPiComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[1]/ng-include//div[1]/p[1]");
        public static By CdPiDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[1]/ng-include//div[1]/p[2]");
        public static By CdPiVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[1]/ng-include//div[1]/p[3]");

        //PMI
        public static By CdPmiComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[1]/ng-include//div[1]/p[1]");
        public static By CdPmiDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[1]/ng-include//div[1]/p[2]");
        public static By CdPmiVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[1]/ng-include//div[1]/p[3]");

        //Drop off years for PMI
        public static By CdDoyfpComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[2]/ng-include//div[1]/p[1]");
        public static By CdDoyfpDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[2]/ng-include//div[1]/p[2]");
        public static By CdDoyfpVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[2]/ng-include//div[1]/p[3]");

        //Total Period Pymt
        public static By CdTppComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[2]/ng-include//div[1]/p[1]");
        public static By CdTppDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[2]/ng-include//div[1]/p[2]");
        public static By CdTppVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[2]/ng-include//div[1]/p[3]");

        //APR
        public static By CdAprComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[3]/ng-include//div[1]/p[1]");
        public static By CdAprDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[3]/ng-include//div[1]/p[2]");
        public static By CdAprVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[3]/ng-include//div[1]/p[3]");

        //Ballon Amount
        public static By CdBaComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[3]/ng-include//div[1]/p[1]");
        public static By CdBaDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[3]/ng-include//div[1]/p[2]");
        public static By CdBaVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[3]/ng-include//div[1]/p[3]");

        //Total Of Pymts
        public static By CdTopComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[4]/ng-include//div[1]/p[1]");
        public static By CdTopDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[4]/ng-include//div[1]/p[2]");
        public static By CdTopVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[4]/ng-include//div[1]/p[3]");

        //Finance Charge
        public static By CdFcComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[4]/ng-include//div[1]/p[1]");
        public static By CdFcDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[4]/ng-include//div[1]/p[2]");
        public static By CdFcVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[4]/ng-include//div[1]/p[3]");

        //Prepaid Charges
        public static By CdPcComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[5]/ng-include//div[1]/p[1]");
        public static By CdPcDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[5]/ng-include//div[1]/p[2]");
        public static By CdPcVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[5]/ng-include//div[1]/p[3]");

        //Amount Financed
        public static By CdAfComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[5]/ng-include//div[1]/p[1]");
        public static By CdAfDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[5]/ng-include//div[1]/p[2]");
        public static By CdAfVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[5]/ng-include//div[1]/p[3]");

        //Ecrw Prop Costs > 1 Yr 1
        public static By CdEpcooyComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[6]/ng-include//div[1]/p[1]");
        public static By CdEpcooyDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[6]/ng-include//div[1]/p[2]");
        public static By CdEpcooyVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[6]/ng-include//div[1]/p[3]");

        //TIP
        public static By CdTipComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[6]/ng-include//div[1]/p[1]");
        public static By CdTipDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[6]/ng-include//div[1]/p[2]");
        public static By CdTipVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[6]/ng-include//div[1]/p[3]");

        //Initial Escrow Pymt
        public static By CdIepComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[7]/ng-include//div[1]/p[1]");
        public static By CdIepDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[7]/ng-include//div[1]/p[2]");
        public static By CdIepVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[7]/ng-include//div[1]/p[3]");

        //Non Ecrw Prop Costs > 1 Yr 1
        public static By CdNepcooyComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[7]/ng-include//div[1]/p[1]");
        public static By CdNepcooyDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[7]/ng-include//div[1]/p[2]");
        public static By CdNepcooyVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[7]/ng-include//div[1]/p[3]");

        //Period Escrow Pymt
        public static By CdPepComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[8]/ng-include//div[1]/p[1]");
        public static By CdPepDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[8]/ng-include//div[1]/p[2]");
        public static By CdPepVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[8]/ng-include//div[1]/p[3]");

        #endregion


        #region Loan Estimate

        public static By LeLoanDetailsText = By.XPath("//div[@id='LoanInformationInput']//div[@class='md-toolbar-tools ng-binding']");
        public static By LePaymentScheduleText = By.XPath("//section[@id='PaymentScheduleOutput']//md-toolbar/div");

        public static By LeCalculationMethod;
        public static By LeLoanType;
        public static By LeFrequencyOfPayments;
        public static By LeLoanTerm;
        public static By LeRepaymentTermType;
        public static void LoanEstimateRadioButtonVariable()
        {
            LeCalculationMethod = By.XPath("//md-radio-button[@aria-label='" + TridVariable.CalculationMethod + "']");
            LeLoanType = By.XPath("//md-radio-button[@aria-label='" + TridVariable.LoanType + "']");
            LeFrequencyOfPayments = By.XPath("//md-radio-button[@aria-label='" + TridVariable.FrequencyOfPayment + "']");
            LeLoanTerm = By.XPath("//md-radio-button[@aria-label='" + TridVariable.LoanTerm + "']");
            LeRepaymentTermType = By.XPath("//md-radio-button[@aria-label='" + TridVariable.RepaymentTermType + "']");
        }

        public static By LeFreqOfPmtValue = By.Id("input_43");
        public static By LeLoanTermValue = By.Id("input_44");

        public static By LeLoanAmount = By.Id("input_50");
        public static By LeRateOfInterest = By.Id("input_51");
        public static By LeDateOfLoan = By.Id("input_53");
        public static By LeDateOfInterestBegins = By.Id("input_55");
        public static By LeDateOfFirstPayment = By.Id("input_57");
        public static By LePeriodPayment = By.Id("input_58");
        public static By LeLoanCostsForDisclosure = By.Id("input_59");
        public static By LeFinalBalloonPayment = By.Id("input_60");
        //public static By OddDays =
        //public static By LedLoanDetailsEstimatedEscrow = By.Id("input_64");

        public static By LeDisclosedIn5Years = By.Id("input_64");
        public static By LeDisclosedIn5YearsPrincipal = By.Id("input_64");
        public static By LeDisclosedApr = By.Id("input_64");
        public static By LeDisclosedTip = By.Id("input_64");

        public static By LeLoanDetailsTest = By.XPath("//div[@id='LoanInformationInput']//div[1]/div/wipfli-button/button");
        public static By LeLoanDetailsReset = By.XPath("//*[@id='LoanInformationInput']//div[2]/div/wipfli-button/button");
        public static By LeDisclosedTest = By.XPath("//div[@id='EstimationInput']//button");
        public static By LeLoanDetails = By.XPath("//div[@id='LoanInformationInput']//div[@class='md-toolbar-tools ng-binding']");

        //In 5 years
        public static By LeI5YComputedValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[1]/div[1]//div[1]/p[1]");
        public static By LeI5YDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[1]/div[1]//div[1]/p[2]");
        public static By LeI5YVarianceValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[1]/div[1]//div[1]/p[3]");

        //In 5 Years Principal
        public static By LeI5YpComputedValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[1]/div[2]//div[1]/p[1]");
        public static By LeI5YpDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[1]/div[2]//div[1]/p[2]");
        public static By LeI5YpVarianceValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[1]/div[2]//div[1]/p[3]");

        //APR
        public static By LeAprComputedValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[2]/div[1]//div[1]/p[1]");
        public static By LeAprDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[2]/div[1]//div[1]/p[2]");
        public static By LeAprVarianceValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[2]/div[1]//div[1]/p[3]");


        //TIP
        public static By LeTipComputedValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[2]/div[2]//div[1]/p[1]");
        public static By LeTipDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[2]/div[2]//div[1]/p[2]");
        public static By LeTipVarianceValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[2]/div[2]//div[1]/p[3]");

        //Payment Schedule
        public static By LeNumberOfPayments = By.XPath("//section[@id='PaymentScheduleOutput']//td[2]//span");

        //Amortization Schedule
        public static By LeAmortizationScheduleCount = By.XPath("//div[@id='Mortagagedetails']//md-list-item");
        public static By LeFirstAmortizationDate = By.XPath("//div[@id='Mortagagedetails']//md-list-item[1]//p");
        public static By LeSecondAmortizationDate = By.XPath("//div[@id='Mortagagedetails']//md-list-item[2]//p");
        public static By LeAmortizationFeb2017Amount = By.XPath("//div[@id='Mortagagedetails']//md-list-item[14]//h4");



        #endregion


        #region Mortgage Insurance

        public static By MiAddNumber = By.XPath("//div[@title='Number']//input");
        //public static By MiAddNumber = By.ClassName("md-input ng-valid ng-valid-required ng-touched");
        public static By MiAddBeginPeriod = By.XPath("//div[@title='Begin Period']//input");
        public static By MiAddEndPeriod = By.XPath("//div[@title='End Period']//input");
        public static By MiAddPmiRate = By.XPath("//div[@title='PMI Rate(%)']//input");

        public static By MiAddButton = By.XPath("//div[@id='MortgageInput']//button");

        public static By MiPmiRatesGridRowsCount = By.XPath("//section[@id='MortgageGrid']//tbody/tr");

        public static By MiNumberOfPeriodsofAdvanceInsCollected = By.XPath("//div[@title='Number of Periods of Advance Insurance Collected']//input");
        public static By MiLowerOfCostOrAppraisal = By.XPath("//div[@title='Lower Of Cost Or Appraisal']//input");

        public static By MiTestButton = By.XPath("//div[@id='PrivateMortgageInsuranceInput']//button");

        //PMI
        public static By MiPmiComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[1]/ng-include//div[1]/p[1]");
        public static By MiPmiDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[1]/ng-include//div[1]/p[2]");
        public static By MiPmiVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[1]/ng-include//div[1]/p[3]");

        //Drop off years for PMI
        public static By MiDoyfpComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[1]/ng-include//div[1]/p[1]");
        public static By MiDoyfpDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[1]/ng-include//div[1]/p[2]");
        public static By MiDoyfpVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[1]/ng-include//div[1]/p[3]");

        //Total Period Pymt
        public static By MiTppComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[2]/ng-include//div[1]/p[1]");
        public static By MiTppDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[2]/ng-include//div[1]/p[2]");
        public static By MiTppVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[2]/ng-include//div[1]/p[3]");

        //Total Of Pymts
        public static By MiTopComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[2]/ng-include//div[1]/p[1]");
        public static By MiTopDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[2]/ng-include//div[1]/p[2]");
        public static By MiTopVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[2]/ng-include//div[1]/p[3]");

        //Amount Financed
        public static By MiAfComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[3]/ng-include//div[1]/p[1]");
        public static By MiAfDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[3]/ng-include//div[1]/p[2]");
        public static By MiAfVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[3]/ng-include//div[1]/p[3]");

        //APR
        public static By MiAprComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[3]/ng-include//div[1]/p[1]");
        public static By MiAprDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[3]/ng-include//div[1]/p[2]");
        public static By MiAprVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[3]/ng-include//div[1]/p[3]");
       
        #endregion


        #region Prepaid Charges

        public static By PcPrepaidChargesText = By.XPath("//div[@id='PrepaidChargesInput']/md-toolbar/div");

        public static By PcFhaVaUsdaUpfrontPmiFree = By.XPath("//div[@title='FHA/VA/USDA/Upfront PMI fee']//input");
        public static By PcFloodFee = By.XPath("//div[@title='Flood Fee']//input");
        public static By PcInspectionFee = By.XPath("//div[@title='Inspection Fee']//input");
        public static By PcLoanOriginationFee = By.XPath("//div[@title='Loan Origination Fee']//input");
        public static By PcOtherFees = By.XPath("//div[@title='Other Fees']//input");
        public static By PcPmiEscrowed = By.XPath("//div[@title='PMI escrowed']//input");
        public static By PcPrepaidDailyInterest = By.XPath("//div[@title='Prepaid Daily Interest']//input");
        public static By PcTaxServicing = By.XPath("//div[@title='Tax Servicing']//input");
        public static By PcTitleClosingFee = By.XPath("//div[@title='Title - Closing Fee']//input");
        public static By PcTitleClosingProtectionLetter = By.XPath("//div[@title='Title - Closing protection letter']//input");
        public static By PcTitleCourierFee = By.XPath("//div[@title='Title - Courier Fee']//input");
        public static By PcTitleDrawFee = By.XPath("//div[@title='Title - Draw Fee']//input");
        public static By PcTitleWireFee = By.XPath("//div[@title='Title - Wire Fee']//input");
        public static By PcUnderWriting = By.XPath("//div[@title='Underwriting']//input");

        public static By PcTestButton = By.XPath("//div[@id='PrepaidChargesInput']//button");

        public static By PcCustomName = By.XPath("//div[@title='Number']//input");
        public static By PcCustomValue = By.XPath("//div[@title='Number']//input");
        public static By PcCustomFieldAddButton = By.XPath("//div[@id='PrepaidChargeGridInput']//button");
        

        public static By PcPrepaidChargeGridCount = By.XPath("//section[@id='PrepaidChargeGrid']//tbody/tr");
        public static By PcPrepaidChargeGridCustomName = By.XPath("//section[@id='PrepaidChargeGrid']//tbody/tr/td[1]//span");
        public static By PcPrepaidChargeGridCustomValue = By.XPath("//section[@id='PrepaidChargeGrid']//tbody/tr/td[2]//span");
        

        public static By PcDisclosedFinanceCharge = By.XPath("//div[@title='Finance Charge']//input");
        public static By PcDisclosedPrepaidCharge = By.XPath("//div[@title='Prepaid Charge']//input");
        public static By PcDisclosedAmountFinanced = By.XPath("//div[@title='Amount Financed']//input");

        //Finance Charge
        public static By PcFcComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[1]/ng-include//div[1]/p[1]");
        public static By PcFcDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[1]/ng-include//div[1]/p[2]");
        public static By PcFcVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[1]/ng-include//div[1]/p[3]");

        //Amount Financed
        public static By PcAfComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[1]/ng-include//div[1]/p[1]");
        public static By PcAfDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[1]/ng-include//div[1]/p[2]");
        public static By PcAfVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[1]/ng-include//div[1]/p[3]");

        //Prepaid Charges
        public static By PcPcComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[2]/ng-include//div[1]/p[1]");
        public static By PcPcDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[2]/ng-include//div[1]/p[2]");
        public static By PcPcVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[2]/ng-include//div[1]/p[3]");

        #endregion


        #region Export

        public static By ExLoanInformationText = By.XPath("//div[@id='LoanAccountInformationInput']/md-toolbar/div");
        public static By ExTestButton = By.XPath("//div[@id='LoanAccountInformationInput']//div[1]/div/wipfli-button/button");

        public static By ExLoanIdNumber = By.Id("input_27");
        public static By ExBorrowersNames = By.Id("input_28");
        public static By ExPreparedBy = By.Id("input_29");
        public static By ExNameOfLender = By.Id("input_30");
        public static By ExOriginalCreditor = By.Id("input_31");
        public static By ExLoanSecuredBy = By.Id("radio_32");

        public static By ExExportToPdfButton = By.XPath("//div[@id='LoanAccountInformationInput']//div[8]//button");

        #endregion


        #region Escrow

        public static By EscEscrowCalcInputsText = By.XPath("//div[@id='EscrowCalculationsInput']/md-toolbar");

        public static By EscIsInsEscrowed;
        public static By EscIsTaxEscrowed;
        public static By EscIsPmiEscrowed;
        public static By EscFrequencyOfPayments;
        public static void EscrowRadioButtonVariable()
        {
            EscIsInsEscrowed = By.XPath("//div[@title='Is INS Escrowed']//md-radio-button[@aria-label='"+TridVariable.IsInsEscrowed+"']");
            EscIsTaxEscrowed = By.XPath("//div[@title='Is Tax Escrowed']//md-radio-button[@aria-label='" + TridVariable.IsTaxEscrowed + "']");
            EscIsPmiEscrowed = By.XPath("//div[@title='Is PMI Escrowed']//md-radio-button[@aria-label='" + TridVariable.IsPmiEscrowed + "']");
            EscFrequencyOfPayments = By.XPath("//div[@title='Frequency Of Payments']//md-radio-button[@aria-label='" + TridVariable.FrequencyOfPayments + "']");
        }


        public static By EscEscrowCalculationStartPeriodDate = By.XPath("//div[@title='Escrow Calculation Start Period Date']//input");
        public static By EscCushionMonthsForInsurance = By.XPath("//div[@title='Cushion Months For Insurance']//input");
        public static By EscCushionMonthsForTax = By.XPath("//div[@title='Cushion Months For Tax']//input");
        public static By EscCushionMonthsForPmi = By.XPath("//div[@title='Cushion Months For PMI']//input");

        public static By EscEscrowInstallmentInputsNumber = By.XPath("//div[@id='EscrowInsuranceGridInputs']//div[@title='Number']//input");
        public static By EscDateForEscrowInsurance = By.XPath("//div[@title='Date For Escrow Insurance']//input");
        public static By EscInsuranceInstallmentAmount = By.XPath("//div[@title='Insuarnce Installment Amount']//input");

        public static By EscrowInstallmentInfoGridRowCount = By.XPath("//section[@id='EscrowInsuranceGrid']//tbody/tr");
        public static By EscrowInstallmentInfoGridNumber = By.XPath("//section[@id='EscrowInsuranceGrid']//tbody/tr/td[1]//span");
        public static By EscrowInstallmentInfoGridInstallmentDate = By.XPath("//section[@id='EscrowInsuranceGrid']//tbody/tr/td[2]//span");
        public static By EscrowInstallmentInfoGridInstallmentAmount = By.XPath("//section[@id='EscrowInsuranceGrid']//tbody/tr/td[3]//span");

        public static By EscEscrowInstallmentInputsAddButton = By.XPath("//div[@id='EscrowInsuranceGridInputs']//div[4]//button");

        public static By EscEscrowTaxCalculationsInputsNumber = By.XPath("//div[@id='EscrowTaxCalculationsGridInputs']//div[@title='Number']//input");
        public static By EscEscrowTaxCalculationsInputsDate = By.XPath("//div[@title='Date']//input");
        public static By EscEscrowTaxCalculationsInputsTaxInstallmentAmount = By.XPath("//div[@title='Tax Installment Amount']//input");

        public static By EscrowTaxInfoGridRowCount = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr");
        public static By EscrowTaxInfoGridNumber = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr/td[1]//span");
        public static By EscrowTaxInfoGridInstallmentDate = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr/td[2]//span");
        public static By EscrowTaxInfoGridTaxInstallmentAmount = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr/td[3]//span");

        public static By EscEscrowTaxCalculationsInputsAddButton = By.XPath("//div[@id='EscrowTaxCalculationsGridInputs']//div[4]//button");

        public static By EscEscrowInputForPmiCalculationEscrowPmiDate = By.XPath("//div[@title='DateForPMICalc']//input");
        public static By EscEscrowInputForPmiCalculationEscrowPmiAmount = By.XPath("//div[@title='PMI Amount']//input");

        public static By EscEscrowPropertyOverOneYear = By.XPath("//div[@title='Escrow Property Over One Year']//input");
        public static By EscNonEscrowPropertyOverOneYear = By.XPath("//div[@title='Non Escrow Property Over One Year']//input");
        public static By EscInitialEscrowPayment = By.XPath("//div[@title='Initial Escrow Payment']//input");
        public static By EscMonthlyEscrowPayment = By.XPath("//div[@title='Monthly Escrow Payment']//input");
        public static By EscDisclosedEscrowPropertyOverOneYear = By.XPath("//div[@title='Dscl Escrow Property Over One Year']//input");
        public static By EscDisclosedNonEscrowPropertyOverOneYear = By.XPath("//div[@title='Dscl Non Escrow Property Over One Year']//input");
        public static By EscDisclosedInitialEscrowPayment = By.XPath("//div[@title='Dscl Initial Escrow Payment']//input");
        public static By EscDisclosedMonthlyEscrowPayment = By.XPath("//div[@title='Dscl Monthly Escrow Payment']//input");
        public static By EscDisclosedEscrowPayment = By.XPath("//div[@title=' Dscl Estimated Escrow']//input");

        public static By EscEscrowCalculationInputTestButton = By.XPath("//div[@id='EscrowCalculationsInput']//wipfli-button/button");
        public static By EscDisclosureForEscrowTestButton = By.XPath("//div[@id='LoanDisclosureForEscrow']//wipfli-button/button");

        ////Insurance Info
        //public static By EscInsuranceInfoAdjustmentBalance = ;
        //public static By EscInsuranceInfoMinimumAmount = ;
        //public static By EscInsuranceInfoCushionAmount = ;

        ////Insurance Total Info
        //public static By EscInsuranceTotalInfoPeriodInsuranceAmount = ;
        //public static By EscInsuranceTotalInfoInputInsuranceAmount = ;

        ////Tax Info
        //public static By EscTaxInfoAdjustmentBalance = ;
        //public static By EscTaxInfoMinimumAmount = ;
        //public static By EscTaxInfoCushionAmounts = ;

        ////Tax Total Info
        //public static By EscTaxTotalInfoPeriodTaxAmount = ;
        //public static By EscTaxTotalInfoInputTaxAmount = ;

        ////PMI Info
        //public static By EscPMIInfoAdjustmentBalance = ;
        //public static By EscPMIInfoMinimumAmount = ;
        //public static By EscPMInfoCushionAmount = ;

        ////PMI Total Info
        //public static By EscPMITotalInfoPeriodOMIAmount = ;
        //public static By EscPMITotalInfoInputTaxAmount = ;

        ////Aggregate Info
        //public static By EscAggregateInfoAdjustmentBalance = ;
        //public static By EscAggregateInfoMinimumAmount = ;
        //public static By EscAggregateInfoCushionAmount = ;

        ////Aggregate Total Info
        //public static By EscAggregateTotalInfoAgregatePayment = ;
        //public static By EscAggregateTotalInfoAggregateDeposit = ;

        ////Ecrw Prop Costs > 1 Yr 1
        //public static By EscEscrowPropertyOverOneYearCard = ;

        ////Non Ecrw Prop Costs > 1 Yr 1
        //public static By EscNonEscrowPropertyOverOneYearCard = ;

        ////Initial Escrow Pymt
        //public static By EscInitialEscrowPaymentCard = ;

        ////Period Escrow Pymt
        //public static By EscPeriodEscrowPaymentCard = ;

        #endregion


        #region Variable Loan Details

        public static By VldLoanAmount = By.XPath("//div[@title='Loan Amount']//input");
        public static By VldRateOfInterest = By.XPath("//div[@title='Rate Of Interest']//input");
        public static By VldFirstTermChange = By.XPath("//div[@title='First Term Change']//input");
        public static By VldSubsequentTermChange = By.XPath("//div[@title='Subsequent Term Change']//input");
        public static By VldDnRateCapFirstAdjustment = By.XPath("//div[@title='DN Rate Cap First Adjustment']//input");
        public static By VldDnRateCapSubseqAdjustment = By.XPath("//div[@title='DN Rate Caps Subseq Adjustment']//input");
        public static By VldUpRateCapFirstAdjustment = By.XPath("//div[@title='UP Rate Cap First Adjustment']//input");
        public static By VldUpRateCapSubseqAdjustment = By.XPath("//div[@title='UP Rate Caps Subseq Adjustment']//input");
        public static By VldFloorRate = By.XPath("//div[@title='Floor Rate']//input");
        public static By VldMaxRateEver = By.XPath("//div[@title='Max Rate Ever']//input");
        public static By VldIndex = By.XPath("//div[@title='Index']//input");
        public static By VldMargin = By.XPath("//div[@title='Margin']//input");

        public static By PaymentScheduleAprRowCount = By.XPath("//section[@id='PaymentScheduleOutputAPR']//tbody/tr");
        public static By PaymentScheduleDownRowCount = By.XPath("//section[@id='PaymentScheduleOutputDN']//tbody/tr");
        public static By PaymentScheduleUpRowCount = By.XPath("//section[@id='PaymentScheduleOutputUP']//tbody/tr");

        #endregion
    }
}
