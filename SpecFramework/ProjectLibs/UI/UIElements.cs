using OpenQA.Selenium;
using TRID.CommonUtils;
using TRID.ProjectLibs.Common;

namespace TRID.ProjectLibs.UI
{
    public class UIElements : PageBase
    {
        #region HeaderBar

        public static By StartNewLoanLink = By.LinkText("Start New Loan");
        public static By LoanInputsLink = By.LinkText("Loan Inputs");
        public static By DisclosureInputsLink = By.LinkText("Disclosure Inputs");
        public static By LoanEstimateLink = By.LinkText("Loan Estimate");
        public static By ClosingDisclosureLink = By.LinkText("Closing Disclosure");
        public static By EscrowLink = By.LinkText("Escrow");
        public static By AmortizationLink = By.LinkText("Amortization");
        public static By VariableAmortizationLink = By.LinkText("Variable Amortization");        
        public static By ExportLink = By.LinkText("Export");
        public static By EscrowGrid = By.LinkText("EscrowGrid");


        #endregion

        #region Start New Loan

        public static By SnlStartNewLoanText = By.XPath("//div[@id='StartNewLoan']/md-toolbar");
        public static By SnlResetButton = By.XPath("//div[@id='StartNewLoan']//button");

        #endregion

        #region Closing Disclosure Page

        //public static By CdCalculationMethod;
        //public static By CdLoanType;
        //public static By CdFrequencyOfPayments;
        //public static By CdLoanTerm;
        //public static By CdRepaymentTermType;
        //public static void ClosingDisclosureRadioButtonVariable()
        //{
        //    CdCalculationMethod = By.XPath("//md-radio-button[@aria-label='" + TridVariable.CalculationMethod + "']");
        //    CdLoanType = By.XPath("//md-radio-button[@aria-label='" + TridVariable.LoanType + "']");
        //    CdFrequencyOfPayments = By.XPath("//md-radio-button[@aria-label='" + TridVariable.FrequencyOfPayments + "']");
        //    CdLoanTerm = By.XPath("//md-radio-button[@aria-label='" + TridVariable.LoanTerm + "']");
        //    CdRepaymentTermType = By.XPath("//md-radio-button[@aria-label='" + TridVariable.RepaymentTermType + "']");
        //}

        //public static By CdFreqOfPmtValue = By.XPath("//div[@title='Frequency Of Pmt Value']//input");
        //public static By CdLoanTermValue = By.XPath("//div[@title='Loan Term Value']//input");

        //public static By CdLoanAmount = By.XPath("//div[@title='Loan Amount']//input");
        //public static By CdRateOfInterest = By.XPath("//div[@title='Rate Of Interest']//input");
        //public static By CdDateOfLoan = By.XPath("//div[@title='Date of loan']//input");
        //public static By CdDateOfInterestBegins = By.XPath("//div[@title='Date Interest Begins To Accrue']//input");
        //public static By CdDateOfFirstPayment = By.XPath("//div[@title='Date Of First Payment']//input");
        //public static By CdPeriodPayment = By.XPath("//div[@title='Period Payment']//input");
        //public static By CdLoanCostsForDisclosure = By.XPath("//div[@title='Loan Costs For Disclosure(Sum of Section A, B, C )']//input");
        ////public static By CdFinalBalloonPayment = By.XPath("//div[@title='Final Balloon Payment']//input");
        ////public static By CdOddDays = 
        ////public static By CdLoanDetailsEstimatedEscrow = By.Id("input_64");

        //public static By CdMonthlyPrincipalandInterest = By.XPath("//div[@title='Monthly Principal And Interest']//input");
        //public static By CdMonthlyPmi = By.XPath("//div[@title='Monthly PMI']//input");
        //public static By CdTotalMonthlyPayment = By.XPath("//div[@title='Total Monthly Payment']//input");
        //public static By CdPmiTerminalDate = By.XPath("//div[@title='PMI Termination Date (78%)']//input");
        //public static By CdPmiCancelDate = By.XPath("//div[@title='PMI Cancel Date (80%)']//input");
        //public static By CdDisclosedEstimatedEscrow = By.XPath("//div[@title='Estimated Escrow']//input");
        //public static By CdDisclosedFinalBalloonPayment = By.XPath("//div[@title='Dscl Final Balloon Payment']//input");
        //public static By CdDisclosedTotalOfPayment = By.XPath("//div[@title='Total Of Payment']//input");

        public static By CdLoanDetailsTest = By.XPath("//div[@id='LoanInformationInput']/form/div/div[1]//wipfli-button/button");
        public static By CdLoanDetailsReset = By.XPath("//div[@id='LoanInformationInput']//div[2]/div/wipfli-button/button");
        public static By CdDisclosedTest = By.XPath("//div[@id='DisclosureInput']//button");
        public static By CdLoanDetailsText = By.XPath("//div[@id='LoanInformationInput']//div[@class='md-toolbar-tools ng-binding']");

        ////Princpal & Interest
        //public static By CdPiComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[1]/ng-include//div[1]/p[1]");
        //public static By CdPiDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[1]/ng-include//div[1]/p[2]");
        //public static By CdPiVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[1]/ng-include//div[1]/p[3]");

        ////TIP
        //public static By CdTipComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[1]/ng-include//div[1]/p[1]");
        //public static By CdTipDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[1]/ng-include//div[1]/p[2]");
        //public static By CdTipVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[1]/ng-include//div[1]/p[3]");

        ////PMI
        //public static By CdPmiComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[1]/ng-include//div[1]/p[1]");
        //public static By CdPmiDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[3/div[1]/ng-include//div[1]/p[2]");
        //public static By CdPmiVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[1]/ng-include//div[1]/p[3]");

        ////Ballon Amount
        //public static By CdBaComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[2]/ng-include//div[1]/p[1]");
        //public static By CdBaDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[2]/ng-include//div[1]/p[2]");
        //public static By CdBaVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[2]/ng-include//div[1]/p[3]");

        ////APR
        //public static By CdAprComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[2]/ng-include//div[1]/p[1]");
        //public static By CdAprDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[2]/ng-include//div[1]/p[2]");
        //public static By CdAprVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[2]/ng-include//div[1]/p[3]");

        ////Finance Charge
        //public static By CdFcComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[2]/ng-include//div[1]/p[1]");
        //public static By CdFcDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[2]/ng-include//div[1]/p[2]");
        //public static By CdFcVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[2]/ng-include//div[1]/p[3]");

        ////Drop off years for PMI
        //public static By CdDoyfpComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[4]/ng-include//div[1]/p[1]");
        //public static By CdDoyfpDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[4]/ng-include//div[1]/p[2]");
        //public static By CdDoyfpVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[4]/ng-include//div[1]/p[3]");

        ////Total Period Pymt
        //public static By CdTppComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[4]/ng-include//div[1]/p[1]");
        //public static By CdTppDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[4]/ng-include//div[1]/p[2]");
        //public static By CdTppVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[4]/ng-include//div[1]/p[3]");
             
        ////Total Of Pymts
        //public static By CdTopComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[3]/ng-include//div[1]/p[1]");
        //public static By CdTopDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[3]/ng-include//div[1]/p[2]");
        //public static By CdTopVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[3]/ng-include//div[1]/p[3]");
        
        ////Prepaid Charges
        //public static By CdPcComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[4]/ng-include//div[1]/p[1]");
        //public static By CdPcDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[4]/ng-include//div[1]/p[2]");
        //public static By CdPcVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[4]/ng-include//div[1]/p[3]");

        ////Amount Financed
        //public static By CdAfComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[3]/ng-include//div[1]/p[1]");
        //public static By CdAfDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[3]/ng-include//div[1]/p[2]");
        //public static By CdAfVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[3]/ng-include//div[1]/p[3]");

        //Ecrw Prop Costs > 1 Yr 1
        public static By CdEpcooyComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[6]/ng-include//div[1]/p[1]");
        public static By CdEpcooyDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[6]/ng-include//div[1]/p[2]");
        public static By CdEpcooyVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[6]/ng-include//div[1]/p[3]");
       
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


        #region All Input Values

        public static By LoanDetailsText = By.XPath("//div[@id='LoanInformationInput']/md-toolbar");
        //Loan Details
        public static By CalculationMethod;
        public static By LoanType;
        public static By FrequencyOfPayments;
        public static By LoanTerm;
        public static By RepaymentTermType;
        public static void LoanDetailsRadioButtonVariable()
        {
            CalculationMethod = By.XPath("//md-radio-button[@aria-label='" + TridVariable.CalculationMethod + "']");
            LoanType = By.XPath("//md-radio-button[@aria-label='" + TridVariable.LoanType + "']");
            FrequencyOfPayments = By.XPath("//md-radio-button[@aria-label='" + TridVariable.FrequencyOfPayments + "']");
            LoanTerm = By.XPath("//md-radio-button[@aria-label='" + TridVariable.LoanTerm + "']");
            RepaymentTermType = By.XPath("//md-radio-button[@aria-label='" + TridVariable.RepaymentTermType + "']");
        }
        public static By FreqOfPmtValue = By.XPath("//div[@title='Frequency Of Pmt Value']//input");
        public static By LoanTermValue = By.XPath("//div[@title='Loan Term Value']//input");
        public static By LoanAmount = By.XPath("//div[@title='Loan Amount']//input");
        public static By RateOfInterest = By.XPath("//div[@title='Rate Of Interest']//input");
        public static By DateOfLoan = By.XPath("//div[@title='Date of loan']//input");
        public static By DateOfInterestBegins = By.XPath("//div[@title='Date Interest Begins To Accrue']//input");
        public static By DateOfFirstPayment = By.XPath("//div[@title='Date Of First Payment']//input");
        public static By PeriodPayment = By.XPath("//div[@title='Period Payment']//input");
        public static By LoanCostsForDisclosure = By.XPath("//div[@title='Loan Costs For Disclosure(Sum of Section A, B, C )']//input");
        //public static By OddDays = 

        //Varibale Loan Details
        public static By FirstTermChange = By.XPath("//div[@title='First Term Change']//input");
        public static By SubsequentTermChange = By.XPath("//div[@title='Subsequent Term Change']//input");
        public static By DnRateCapFirstAdjustment = By.XPath("//div[@title='DN Rate Cap First Adjustment']//input");
        public static By DnRateCapSubseqAdjustment = By.XPath("//div[@title='DN Rate Caps Subseq Adjustment']//input");
        public static By UpRateCapFirstAdjustment = By.XPath("//div[@title='UP Rate Cap First Adjustment']//input");
        public static By UpRateCapSubseqAdjustment = By.XPath("//div[@title='UP Rate Caps Subseq Adjustment']//input");
        public static By FloorRate = By.XPath("//div[@title='Floor Rate']//input");
        public static By MaxRateEver = By.XPath("//div[@title='Max Rate Ever']//input");
        public static By Index = By.XPath("//div[@title='Index']//input");
        public static By Margin = By.XPath("//div[@title='Margin']//input");
        public static By RoundingFactor = By.XPath("//div[@title='Rounding Factor']//input");

        //Mortgage Insurance
        public static By AddNumber = By.XPath("//div[@title='Number']//input");
        public static By AddBeginPeriod = By.XPath("//div[@title='Begin Period']//input");
        public static By AddEndPeriod = By.XPath("//div[@title='End Period']//input");
        public static By AddPmiRate = By.XPath("//div[@title='PMI Rate(%)']//input");
        public static By AddButton = By.XPath("//div[@id='MortgageInput']//button");
        public static By PmiRatesGridRowsCount = By.XPath("//section[@id='MortgageGrid']//tbody/tr");
        public static By NumberOfPeriodsofAdvanceInsCollected = By.XPath("//div[@title='Number of Periods of Advance Insurance Collected']//input");
        public static By LowerOfCostOrAppraisal = By.XPath("//div[@title='Lower Of Cost Or Appraisal']//input");
        public static By TotalMiInSectionFPrepaids = By.XPath("//div[@title='Total MI In Section F (Prepaids)']//input");
        public static By TotalMiInSectionGEscrow = By.XPath("//div[@title='Total MI In Section G (Escrow)']//input");

        //Escrow
        public static By EscrowCalcInputsText = By.XPath("//div[@id='EscrowCalculationsInput']/md-toolbar");
        public static By IsInsEscrowed;
        public static By IsTaxEscrowed;
        public static By IsPmiEscrowed;
        public static void EscrowRadioButtonVariable()
        {
            IsInsEscrowed = By.XPath("//div[@title='Is INS Escrowed']//md-radio-button[@aria-label='" + TridVariable.IsInsEscrowed + "']");
            IsTaxEscrowed = By.XPath("//div[@title='Is Tax Escrowed']//md-radio-button[@aria-label='" + TridVariable.IsTaxEscrowed + "']");
            IsPmiEscrowed = By.XPath("//div[@title='Is PMI Escrowed']//md-radio-button[@aria-label='" + TridVariable.IsPmiEscrowed + "']");
        }
        public static By CushionMonthsForInsurance = By.XPath("//div[@title='Cushion Months For Insurance']//input");
        public static By CushionMonthsForTax = By.XPath("//div[@title='Cushion Months For Tax']//input");
        public static By EscrowInstallmentInputsNumber = By.XPath("//div[@id='EscrowInsuranceGridInputs']//div[@title='Number']//input");
        public static By DateForEscrowInsurance = By.XPath("//div[@title='Date For Escrow Insurance']//input");
        public static By InsuranceInstallmentAmount = By.XPath("//div[@title='Insuarnce Installment Amount']//input");
        public static By EscrowInstallmentInputsAddButton = By.XPath("//div[@id='EscrowInsuranceGridInputs']//div[4]//button");
        public static By EscrowInstallmentInfoGridRowCount = By.XPath("//section[@id='EscrowInsuranceGrid']//tbody/tr");
        public static By EscrowInstallmentInfoGridNumber = By.XPath("//section[@id='EscrowInsuranceGrid']//tbody/tr/td[1]//span");
        public static By EscrowInstallmentInfoGridInstallmentDate = By.XPath("//section[@id='EscrowInsuranceGrid']//tbody/tr/td[2]//span");
        public static By EscrowInstallmentInfoGridInstallmentAmount = By.XPath("//section[@id='EscrowInsuranceGrid']//tbody/tr/td[3]//span");
        public static By EscrowTaxCalculationsInputsNumber = By.XPath("//div[@id='EscrowTaxCalculationsGridInputs']//div[@title='Number']//input");
        public static By EscrowTaxCalculationsInputsDate = By.XPath("//div[@title='Date']//input");
        public static By EscrowTaxCalculationsInputsTaxInstallmentAmount = By.XPath("//div[@title='Tax Installment Amount']//input");
        public static By EscrowTaxCalculationsInputsAddButton = By.XPath("//div[@id='EscrowTaxCalculationsGridInputs']//div[4]//button");
        public static By EscrowTaxInfoGridRowCount = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr");
        public static By EscrowTaxInfoGridNumberFR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[1]/td[1]//span");
        public static By EscrowTaxInfoGridInstallmentDateFR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[1]/td[2]//span");
        public static By EscrowTaxInfoGridTaxInstallmentAmountFR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[1]/td[3]//span");                    
        public static By EscrowTaxInfoGridNumberSR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[2]/td[1]//span");
        public static By EscrowTaxInfoGridInstallmentDateSR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[2]/td[2]//span");
        public static By EscrowTaxInfoGridTaxInstallmentAmountSR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[2]/td[3]//span");


        //Prepaid Charges
        public static By FhaVaUsdaUpfrontPmiFree = By.XPath("//div[@title='FHA/VA/USDA/Upfront PMI fee']//input");
        public static By FloodFee = By.XPath("//div[@title='Flood Fee']//input");
        public static By InspectionFee = By.XPath("//div[@title='Inspection Fee']//input");
        public static By LoanOriginationFee = By.XPath("//div[@title='Loan Origination Fee']//input");
        public static By OtherFees = By.XPath("//div[@title='Other Fees']//input");
        public static By PmiEscrowed = By.XPath("//div[@title='PMI escrowed']//input");
        public static By PrepaidDailyInterest = By.XPath("//div[@title='Prepaid Daily Interest']//input");
        public static By TaxServicing = By.XPath("//div[@title='Tax Servicing']//input");
        public static By TitleClosingFee = By.XPath("//div[@title='Title - Closing Fee']//input");
        public static By TitleClosingProtectionLetter = By.XPath("//div[@title='Title - Closing protection letter']//input");
        public static By TitleCourierFee = By.XPath("//div[@title='Title - Courier Fee']//input");
        public static By TitleDrawFee = By.XPath("//div[@title='Title - Draw Fee']//input");
        public static By TitleWireFee = By.XPath("//div[@title='Title - Wire Fee']//input");
        public static By UnderWriting = By.XPath("//div[@title='Underwriting']//input");
        public static By CustomName = By.XPath("//div[@title='Number']//input");
        public static By CustomValue = By.XPath("//div[@title='Number']//input");
        public static By CustomFieldAddButton = By.XPath("//div[@id='PrepaidChargeGridInput']//button");
        public static By PrepaidChargeGridCount = By.XPath("//section[@id='PrepaidChargeGrid']//tbody/tr");
        public static By PrepaidChargeGridCustomName = By.XPath("//section[@id='PrepaidChargeGrid']//tbody/tr/td[1]//span");
        public static By PrepaidChargeGridCustomValue = By.XPath("//section[@id='PrepaidChargeGrid']//tbody/tr/td[2]//span");

        #endregion


        #region Disclosed Inputs

        public static By DisclosedValuesText = By.XPath("//div[@id='DisclosureInput']/md-toolbar");

        //Closing Disclosure
        public static By DisclosedMonthlyPrincipalandInterest = By.XPath("//div[@title='Dscl Monthly Principal And Interest']//input");
        public static By DisclosedMonthlyPmi = By.XPath("//div[@title='Dscl Monthly PMI']//input");
        public static By DisclosedTotalPeriodicPayment = By.XPath("//div[@title='Dscl Total Periodic Payment ']//input");
        public static By DisclosedPmiTerminalDate = By.XPath("//div[@title='Dscl PMI Termination Date (78%)']//input");
        public static By DisclosedPmiCancelDate = By.XPath("//div[@title='Dscl PMI Cancel Date (80%)']//input");
        public static By DisclosedFinalBalloonPayment = By.XPath("//div[@title='Dscl Final Balloon Payment']//input");
        public static By DisclosedTotalOfPayment = By.XPath("//div[@title='Dscl Total Of Payment']//input");


        //Loan Estimate
        public static By DisclosedIn5Years = By.XPath("//div[@title='Dscl In 5 Years']//input");
        public static By DisclosedIn5YearsPrincipal = By.XPath("//div[@title='Dscl In 5 Years Principal']//input");
        public static By DisclosedApr = By.XPath("//div[@title='Dscl APR']//input");
        public static By DisclosedTip = By.XPath("//div[@title='Dscl Total Interest Percentage']//input");

        //Escrow
        public static By EscrowPropertyOverOneYear = By.XPath("//div[@title='Escrow Property Over One Year']//input");
        public static By NonEscrowPropertyOverOneYear = By.XPath("//div[@title='Non Escrow Property Over One Year']//input");
        public static By InitialEscrowPayment = By.XPath("//div[@title='Initial Escrow Payment']//input");
        //public static By MonthlyEscrowPayment = By.XPath("//div[@title='Monthly Escrow Payment']//input");
        public static By DisclosedEscrowPropertyOverOneYear = By.XPath("//div[@title='Dscl Escrow Property Over One Year']//input");
        public static By DisclosedNonEscrowPropertyOverOneYear = By.XPath("//div[@title='Dscl Non Escrow Property Over One Year']//input");
        public static By DisclosedInitialEscrowPayment = By.XPath("//div[@title='Dscl Initial Escrow Payment']//input");
        public static By DisclosedMonthlyEscrowPayment = By.XPath("//div[@title='Dscl Monthly Escrow Payment']//input");
        public static By DisclosedEstimatedEscrow = By.XPath("//div[@title=' Dscl Estimated Escrow']//input");


        //Prepaid Charges
        public static By DisclosedFinanceCharge = By.XPath("//div[@title='Dscl Finance Charge']//input");
        public static By DisclosedPrepaidCharge = By.XPath("//div[@title='Dscl Prepaid Charge']//input");
        public static By DisclosedAmountFinanced = By.XPath("//div[@title='Dscl Amount Financed']//input");

        #endregion


        #region Closing Disclosure Cards

        public static By MonthlyPrincipalAndInterestText = By.XPath("//div[@id='viewCompositionContainer']/div/div[1]/div[1]//md-toolbar");

        //Princpal & Interest
        public static By PiComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[1]/ng-include//div[1]/p[1]");
        public static By PiDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[1]/ng-include//div[1]/p[2]");
        public static By PiVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[1]/ng-include//div[1]/p[3]");

        //TIP
        public static By TipComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[1]/ng-include//div[1]/p[1]");
        public static By TipDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[1]/ng-include//div[1]/p[2]");
        public static By TipVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[1]/ng-include//div[1]/p[3]");

        //PMI
        public static By PmiComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[1]/ng-include//div[1]/p[1]");
        public static By PmiDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[1]/ng-include//div[1]/p[2]");
        public static By PmiVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[1]/ng-include//div[1]/p[3]");

        //Ballon Amount
        public static By BaComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[2]/ng-include//div[1]/p[1]");
        public static By BaDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[2]/ng-include//div[1]/p[2]");
        public static By BaVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[2]/ng-include//div[1]/p[3]");

        //APR
        public static By AprComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[2]/ng-include//div[1]/p[1]");
        public static By AprDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[2]/ng-include//div[1]/p[2]");
        public static By AprVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[2]/ng-include//div[1]/p[3]");

        //Finance Charge
        public static By FcComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[2]/ng-include//div[1]/p[1]");
        public static By FcDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[2]/ng-include//div[1]/p[2]");
        public static By FcVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[2]/ng-include//div[1]/p[3]");

        //Drop off years for PMI
        public static By DoyfpComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[4]/ng-include//div[1]/p[1]");
        public static By DoyfpDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[4]/ng-include//div[1]/p[2]");
        public static By DoyfpVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[4]/ng-include//div[1]/p[3]");

        //Total Period Pymt
        public static By TppComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[4]/ng-include//div[1]/p[1]");
        public static By TppDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[4]/ng-include//div[1]/p[2]");
        public static By TppVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[4]/ng-include//div[1]/p[3]");

        //Total Of Pymts
        public static By TopComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[3]/ng-include//div[1]/p[1]");
        public static By TopDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[3]/ng-include//div[1]/p[2]");
        public static By TopVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[3]/ng-include//div[1]/p[3]");

        //Prepaid Charges
        public static By PcComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[4]/ng-include//div[1]/p[1]");
        public static By PcDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[4]/ng-include//div[1]/p[2]");
        public static By PcVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[4]/ng-include//div[1]/p[3]");

        //Amount Financed
        public static By AfComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[3]/ng-include//div[1]/p[1]");
        public static By AfDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[3]/ng-include//div[1]/p[2]");
        public static By AfVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[3]/ng-include//div[1]/p[3]");

        #endregion


        #region Loan Estimate

        //public static By LeLoanDetailsText = By.XPath("//div[@id='LoanInformationInput']//div[@class='md-toolbar-tools ng-binding']");
        //public static By LePaymentScheduleText = By.XPath("//section[@id='PaymentScheduleOutput']//md-toolbar/div");

        //public static By LeCalculationMethod;
        //public static By LeLoanType;
        //public static By LeFrequencyOfPayments;
        //public static By LeLoanTerm;
        //public static By LeRepaymentTermType;
        //public static void LoanEstimateRadioButtonVariable()
        //{
        //    LeCalculationMethod = By.XPath("//md-radio-button[@aria-label='" + TridVariable.CalculationMethod + "']");
        //    LeLoanType = By.XPath("//md-radio-button[@aria-label='" + TridVariable.LoanType + "']");
        //    LeFrequencyOfPayments = By.XPath("//md-radio-button[@aria-label='" + TridVariable.FrequencyOfPayment + "']");
        //    LeLoanTerm = By.XPath("//md-radio-button[@aria-label='" + TridVariable.LoanTerm + "']");
        //    LeRepaymentTermType = By.XPath("//md-radio-button[@aria-label='" + TridVariable.RepaymentTermType + "']");
        //}

        //public static By LeFreqOfPmtValue = By.Id("input_43");
        //public static By LeLoanTermValue = By.Id("input_44");

        //public static By LeLoanAmount = By.Id("input_50");
        //public static By LeRateOfInterest = By.Id("input_51");
        //public static By LeDateOfLoan = By.Id("input_53");
        //public static By LeDateOfInterestBegins = By.Id("input_55");
        //public static By LeDateOfFirstPayment = By.Id("input_57");
        //public static By LePeriodPayment = By.Id("input_58");
        //public static By LeLoanCostsForDisclosure = By.Id("input_59");
        //public static By LeFinalBalloonPayment = By.Id("input_60");
        ////public static By OddDays =
        ////public static By LedLoanDetailsEstimatedEscrow = By.Id("input_64");

        //public static By LeDisclosedIn5Years = By.Id("input_64");
        //public static By LeDisclosedIn5YearsPrincipal = By.Id("input_64");
        //public static By LeDisclosedApr = By.Id("input_64");
        //public static By LeDisclosedTip = By.Id("input_64");

        //public static By LeLoanDetailsTest = By.XPath("//div[@id='LoanInformationInput']//div[1]/div/wipfli-button/button");
        //public static By LeLoanDetailsReset = By.XPath("//*[@id='LoanInformationInput']//div[2]/div/wipfli-button/button");
        //public static By LeDisclosedTest = By.XPath("//div[@id='EstimationInput']//button");
        //public static By LeLoanDetails = By.XPath("//div[@id='LoanInformationInput']//div[@class='md-toolbar-tools ng-binding']");

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

        //public static By MiAddNumber = By.XPath("//div[@title='Number']//input");
        //public static By MiAddBeginPeriod = By.XPath("//div[@title='Begin Period']//input");
        //public static By MiAddEndPeriod = By.XPath("//div[@title='End Period']//input");
        //public static By MiAddPmiRate = By.XPath("//div[@title='PMI Rate(%)']//input");

        //public static By MiAddButton = By.XPath("//div[@id='MortgageInput']//button");

        //public static By MiPmiRatesGridRowsCount = By.XPath("//section[@id='MortgageGrid']//tbody/tr");

        //public static By MiNumberOfPeriodsofAdvanceInsCollected = By.XPath("//div[@title='Number of Periods of Advance Insurance Collected']//input");
        //public static By MiLowerOfCostOrAppraisal = By.XPath("//div[@title='Lower Of Cost Or Appraisal']//input");

        //public static By MiTestButton = By.XPath("//div[@id='PrivateMortgageInsuranceInput']//button");

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

        //public static By PcPrepaidChargesText = By.XPath("//div[@id='PrepaidChargesInput']/md-toolbar/div");

        //public static By PcFhaVaUsdaUpfrontPmiFree = By.XPath("//div[@title='FHA/VA/USDA/Upfront PMI fee']//input");
        //public static By PcFloodFee = By.XPath("//div[@title='Flood Fee']//input");
        //public static By PcInspectionFee = By.XPath("//div[@title='Inspection Fee']//input");
        //public static By PcLoanOriginationFee = By.XPath("//div[@title='Loan Origination Fee']//input");
        //public static By PcOtherFees = By.XPath("//div[@title='Other Fees']//input");
        //public static By PcPmiEscrowed = By.XPath("//div[@title='PMI escrowed']//input");
        //public static By PcPrepaidDailyInterest = By.XPath("//div[@title='Prepaid Daily Interest']//input");
        //public static By PcTaxServicing = By.XPath("//div[@title='Tax Servicing']//input");
        //public static By PcTitleClosingFee = By.XPath("//div[@title='Title - Closing Fee']//input");
        //public static By PcTitleClosingProtectionLetter = By.XPath("//div[@title='Title - Closing protection letter']//input");
        //public static By PcTitleCourierFee = By.XPath("//div[@title='Title - Courier Fee']//input");
        //public static By PcTitleDrawFee = By.XPath("//div[@title='Title - Draw Fee']//input");
        //public static By PcTitleWireFee = By.XPath("//div[@title='Title - Wire Fee']//input");
        //public static By PcUnderWriting = By.XPath("//div[@title='Underwriting']//input");

        //public static By PcTestButton = By.XPath("//div[@id='PrepaidChargesInput']//button");

        //public static By PcCustomName = By.XPath("//div[@title='Number']//input");
        //public static By PcCustomValue = By.XPath("//div[@title='Number']//input");
        //public static By PcCustomFieldAddButton = By.XPath("//div[@id='PrepaidChargeGridInput']//button");


        //public static By PcPrepaidChargeGridCount = By.XPath("//section[@id='PrepaidChargeGrid']//tbody/tr");
        //public static By PcPrepaidChargeGridCustomName = By.XPath("//section[@id='PrepaidChargeGrid']//tbody/tr/td[1]//span");
        //public static By PcPrepaidChargeGridCustomValue = By.XPath("//section[@id='PrepaidChargeGrid']//tbody/tr/td[2]//span");


        //public static By PcDisclosedFinanceCharge = By.XPath("//div[@title='Finance Charge']//input");
        //public static By PcDisclosedPrepaidCharge = By.XPath("//div[@title='Prepaid Charge']//input");
        //public static By PcDisclosedAmountFinanced = By.XPath("//div[@title='Amount Financed']//input");

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


        //#region Escrow

        //public static By EscEscrowCalcInputsText = By.XPath("//div[@id='EscrowCalculationsInput']/md-toolbar");

        //public static By EscIsInsEscrowed;
        //public static By EscIsTaxEscrowed;
        //public static By EscIsPmiEscrowed;
        //public static By EscFrequencyOfPayments;
        //public static void EscrowRadioButtonVariable()
        //{
        //    EscIsInsEscrowed = By.XPath("//div[@title='Is INS Escrowed']//md-radio-button[@aria-label='"+TridVariable.IsInsEscrowed+"']");
        //    EscIsTaxEscrowed = By.XPath("//div[@title='Is Tax Escrowed']//md-radio-button[@aria-label='" + TridVariable.IsTaxEscrowed + "']");
        //    EscIsPmiEscrowed = By.XPath("//div[@title='Is PMI Escrowed']//md-radio-button[@aria-label='" + TridVariable.IsPmiEscrowed + "']");
        //    EscFrequencyOfPayments = By.XPath("//div[@title='Frequency Of Payments']//md-radio-button[@aria-label='" + TridVariable.FrequencyOfPayments + "']");
        //}


        //public static By EscEscrowCalculationStartPeriodDate = By.XPath("//div[@title='Escrow Calculation Start Period Date']//input");
        //public static By EscCushionMonthsForInsurance = By.XPath("//div[@title='Cushion Months For Insurance']//input");
        //public static By EscCushionMonthsForTax = By.XPath("//div[@title='Cushion Months For Tax']//input");
        //public static By EscCushionMonthsForPmi = By.XPath("//div[@title='Cushion Months For PMI']//input");

        //public static By EscEscrowInstallmentInputsNumber = By.XPath("//div[@id='EscrowInsuranceGridInputs']//div[@title='Number']//input");
        //public static By EscDateForEscrowInsurance = By.XPath("//div[@title='Date For Escrow Insurance']//input");
        //public static By EscInsuranceInstallmentAmount = By.XPath("//div[@title='Insuarnce Installment Amount']//input");

        //public static By EscrowInstallmentInfoGridRowCount = By.XPath("//section[@id='EscrowInsuranceGrid']//tbody/tr");
        //public static By EscrowInstallmentInfoGridNumber = By.XPath("//section[@id='EscrowInsuranceGrid']//tbody/tr/td[1]//span");
        //public static By EscrowInstallmentInfoGridInstallmentDate = By.XPath("//section[@id='EscrowInsuranceGrid']//tbody/tr/td[2]//span");
        //public static By EscrowInstallmentInfoGridInstallmentAmount = By.XPath("//section[@id='EscrowInsuranceGrid']//tbody/tr/td[3]//span");

        //public static By EscEscrowInstallmentInputsAddButton = By.XPath("//div[@id='EscrowInsuranceGridInputs']//div[4]//button");

        //public static By EscEscrowTaxCalculationsInputsNumber = By.XPath("//div[@id='EscrowTaxCalculationsGridInputs']//div[@title='Number']//input");
        //public static By EscEscrowTaxCalculationsInputsDate = By.XPath("//div[@title='Date']//input");
        //public static By EscEscrowTaxCalculationsInputsTaxInstallmentAmount = By.XPath("//div[@title='Tax Installment Amount']//input");

        //public static By EscEscrowTaxInfoGridRowCount = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr");
        //public static By EscEscrowTaxInfoGridNumberFR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[1]/td[1]//span");
        //public static By EscEscrowTaxInfoGridInstallmentDateFR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[1]/td[2]//span");
        //public static By EscEscrowTaxInfoGridTaxInstallmentAmountFR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[1]/td[3]//span");

        //public static By EscEscrowTaxInfoGridNumberSR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[2]/td[1]//span");
        //public static By EscEscrowTaxInfoGridInstallmentDateSR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[2]/td[2]//span");
        //public static By EscEscrowTaxInfoGridTaxInstallmentAmountSR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[2]/td[3]//span");

        //public static By EscEscrowTaxCalculationsInputsAddButton = By.XPath("//div[@id='EscrowTaxCalculationsGridInputs']//div[4]//button");

        //public static By EscEscrowInputForPmiCalculationEscrowPmiDate = By.XPath("//div[@title='DateForPMICalc']//input");
        //public static By EscEscrowInputForPmiCalculationEscrowPmiAmount = By.XPath("//div[@title='PMI Amount']//input");

        //public static By EscEscrowPropertyOverOneYear = By.XPath("//div[@title='Escrow Property Over One Year']//input");
        //public static By EscNonEscrowPropertyOverOneYear = By.XPath("//div[@title='Non Escrow Property Over One Year']//input");
        //public static By EscInitialEscrowPayment = By.XPath("//div[@title='Initial Escrow Payment']//input");
        //public static By EscMonthlyEscrowPayment = By.XPath("//div[@title='Monthly Escrow Payment']//input");
        //public static By EscDisclosedEscrowPropertyOverOneYear = By.XPath("//div[@title='Dscl Escrow Property Over One Year']//input");
        //public static By EscDisclosedNonEscrowPropertyOverOneYear = By.XPath("//div[@title='Dscl Non Escrow Property Over One Year']//input");
        //public static By EscDisclosedInitialEscrowPayment = By.XPath("//div[@title='Dscl Initial Escrow Payment']//input");
        //public static By EscDisclosedMonthlyEscrowPayment = By.XPath("//div[@title='Dscl Monthly Escrow Payment']//input");
        //public static By EscDisclosedEscrowPayment = By.XPath("//div[@title=' Dscl Estimated Escrow']//input");

        //public static By EscEscrowCalculationInputTestButton = By.XPath("//div[@id='EscrowCalculationsInput']//wipfli-button/button");
        //public static By EscDisclosureForEscrowTestButton = By.XPath("//div[@id='LoanDisclosureForEscrow']//wipfli-button/button");

        //////Insurance Info
        ////public static By EscInsuranceInfoAdjustmentBalance = ;
        ////public static By EscInsuranceInfoMinimumAmount = ;
        ////public static By EscInsuranceInfoCushionAmount = ;

        //////Insurance Total Info
        ////public static By EscInsuranceTotalInfoPeriodInsuranceAmount = ;
        ////public static By EscInsuranceTotalInfoInputInsuranceAmount = ;

        //////Tax Info
        ////public static By EscTaxInfoAdjustmentBalance = ;
        ////public static By EscTaxInfoMinimumAmount = ;
        ////public static By EscTaxInfoCushionAmounts = ;

        //////Tax Total Info
        ////public static By EscTaxTotalInfoPeriodTaxAmount = ;
        ////public static By EscTaxTotalInfoInputTaxAmount = ;

        //////PMI Info
        ////public static By EscPMIInfoAdjustmentBalance = ;
        ////public static By EscPMIInfoMinimumAmount = ;
        ////public static By EscPMInfoCushionAmount = ;

        //////PMI Total Info
        ////public static By EscPMITotalInfoPeriodOMIAmount = ;
        ////public static By EscPMITotalInfoInputTaxAmount = ;

        //////Aggregate Info
        ////public static By EscAggregateInfoAdjustmentBalance = ;
        ////public static By EscAggregateInfoMinimumAmount = ;
        ////public static By EscAggregateInfoCushionAmount = ;

        //////Aggregate Total Info
        ////public static By EscAggregateTotalInfoAgregatePayment = ;
        ////public static By EscAggregateTotalInfoAggregateDeposit = ;

        //////Ecrw Prop Costs > 1 Yr 1
        ////public static By EscEscrowPropertyOverOneYearCard = ;

        //////Non Ecrw Prop Costs > 1 Yr 1
        ////public static By EscNonEscrowPropertyOverOneYearCard = ;

        //////Initial Escrow Pymt
        ////public static By EscInitialEscrowPaymentCard = ;

        //////Period Escrow Pymt
        ////public static By EscPeriodEscrowPaymentCard = ;

        //#endregion


        //#region Variable Loan Details

        //public static By VldLoanAmount = By.XPath("//div[@title='Loan Amount']//input");
        //public static By VldRateOfInterest = By.XPath("//div[@title='Rate Of Interest']//input");
        //public static By VldFirstTermChange = By.XPath("//div[@title='First Term Change']//input");
        //public static By VldSubsequentTermChange = By.XPath("//div[@title='Subsequent Term Change']//input");
        //public static By VldDnRateCapFirstAdjustment = By.XPath("//div[@title='DN Rate Cap First Adjustment']//input");
        //public static By VldDnRateCapSubseqAdjustment = By.XPath("//div[@title='DN Rate Caps Subseq Adjustment']//input");
        //public static By VldUpRateCapFirstAdjustment = By.XPath("//div[@title='UP Rate Cap First Adjustment']//input");
        //public static By VldUpRateCapSubseqAdjustment = By.XPath("//div[@title='UP Rate Caps Subseq Adjustment']//input");
        //public static By VldFloorRate = By.XPath("//div[@title='Floor Rate']//input");
        //public static By VldMaxRateEver = By.XPath("//div[@title='Max Rate Ever']//input");
        //public static By VldIndex = By.XPath("//div[@title='Index']//input");
        //public static By VldMargin = By.XPath("//div[@title='Margin']//input");

        //public static By PaymentScheduleAprRowCount = By.XPath("//section[@id='PaymentScheduleOutputAPR']//tbody/tr");
        //public static By PaymentScheduleDownRowCount = By.XPath("//section[@id='PaymentScheduleOutputDN']//tbody/tr");
        //public static By PaymentScheduleUpRowCount = By.XPath("//section[@id='PaymentScheduleOutputUP']//tbody/tr");

        //#endregion
    }
}
