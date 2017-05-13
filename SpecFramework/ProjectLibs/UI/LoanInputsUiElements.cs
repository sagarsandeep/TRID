using OpenQA.Selenium;
using TRID.ProjectLibs.Common;

namespace TRID.ProjectLibs.UI
{
    public class LoanInputsUiElements : DisclosureInputsUiElements
    {
        public static By LoanDetailsText = By.XPath("//div[@id='LoanInformationInput']/md-toolbar");
        //Loan Details
        public static By CalculationMethod;
        public static By LoanType;
        public static By FrequencyOfPayments;
        public static By LoanTerm;
        public static By RepaymentTermType;
        public static By OddDaysSelect;
        public static void LoanDetailsRadioButtonVariable()
        {
            CalculationMethod = By.XPath("//md-radio-button[@aria-label='" + TridVariable.CalculationMethod + "']");
            LoanType = By.XPath("//md-radio-button[@aria-label='" + TridVariable.LoanType + "']");
            FrequencyOfPayments = By.XPath("//md-radio-button[@aria-label='" + TridVariable.FrequencyOfPayments + "']");
            LoanTerm = By.XPath("//md-radio-button[@aria-label='" + TridVariable.LoanTerm + "']");
            RepaymentTermType = By.XPath("//md-radio-button[@aria-label='" + TridVariable.RepaymentTermType + "']");
            OddDaysSelect = By.XPath("//md-option[@value='" + TridVariable.OddDaysInterestCollected + "']");
        }
        public static By FreqOfPmtValue = By.XPath("//div[@title='Frequency Of Pmt Value']//input");
        public static By LoanTermValue = By.XPath("//div[@title='Loan Term Value']//input");
        public static By BaseLoanAmount = By.XPath("//div[@title='Base Loan Amount']//input");
        public static By UpfrontLoanFactor = By.XPath("//div[@title='Upfornt Loan Factor']//input");
        public static By LoanAmount = By.XPath("//div[@title='Loan Amount']//input");
        public static By RateOfInterest = By.XPath("//div[@title='Rate Of Interest']//input");
        public static By DateOfLoan = By.XPath("//div[@title='Date of loan']//input");
        public static By DateOfInterestBegins = By.XPath("//div[@title='Date Interest Begins To Accrue']//input");
        public static By DateOfFirstPayment = By.XPath("//div[@title='Date Of First Payment']//input");
        public static By PeriodPayment = By.XPath("//div[@title='Period Payment']//input");
        public static By LoanCostsForDisclosure = By.XPath("//div[@title='Loan Costs For Disclosure(Sum of Section A, B, C )']//input");
        public static By OddDaysClick = By.ClassName("md-select-value");

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
        public static By EscrowInstallmentInfoGridInstallmentDate = By.XPath("//section[@id='EscrowInsuranceGrid']//tbody/tr/td[3]//span");
        public static By EscrowInstallmentInfoGridInstallmentAmount = By.XPath("//section[@id='EscrowInsuranceGrid']//tbody/tr/td[4]//span");
        public static By EscrowTaxCalculationsInputsNumber = By.XPath("//div[@id='EscrowTaxCalculationsGridInputs']//div[@title='Number']//input");
        public static By EscrowTaxCalculationsInputsDate = By.XPath("//div[@title='Date']//input");
        public static By EscrowTaxCalculationsInputsTaxInstallmentAmount = By.XPath("//div[@title='Tax Installment Amount']//input");
        public static By EscrowTaxCalculationsInputsAddButton = By.XPath("//div[@id='EscrowTaxCalculationsGridInputs']//div[4]//button");
        public static By EscrowTaxInfoGridRowCount = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr");
        public static By EscrowTaxInfoGridNumberFR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[1]/td[1]//span");
        public static By EscrowTaxInfoGridInstallmentDateFR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[1]/td[3]//span");
        public static By EscrowTaxInfoGridTaxInstallmentAmountFR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[1]/td[4]//span");
        public static By EscrowTaxInfoGridNumberSR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[2]/td[1]//span");
        public static By EscrowTaxInfoGridInstallmentDateSR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[2]/td[3]//span");
        public static By EscrowTaxInfoGridTaxInstallmentAmountSR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[2]/td[4]//span");


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
    }
}
