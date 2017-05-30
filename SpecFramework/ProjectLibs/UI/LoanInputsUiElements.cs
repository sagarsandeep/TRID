using OpenQA.Selenium;
using TRID.ProjectLibs.Common;

namespace TRID.ProjectLibs.UI
{
    public class LoanInputsUiElements : DisclosureInputsUiElements
    {
        public static By LoanDetailsText = By.XPath("//div[@id='LoanInformationInput']/md-toolbar");
        public static By CalculationMethod;
        public static By LoanType;
        public static By FrequencyOfPayments;
        public static By LoanTerm;
        public static By RepaymentTermType;
        public static By OddDaysSelect;
        public static By UpfrontMipFinanced;
        public static void LoanDetailsRadioButtonVariable()
        {
            CalculationMethod = By.XPath("//md-radio-button[@aria-label='" + TridVariable.CalculationMethod + "']");
            LoanType = By.XPath("//md-radio-button[@aria-label='" + TridVariable.LoanType + "']");
            FrequencyOfPayments = By.XPath("//md-radio-button[@aria-label='" + TridVariable.FrequencyOfPayments + "']");
            LoanTerm = By.XPath("//md-radio-button[@aria-label='" + TridVariable.LoanTerm + "']");
            RepaymentTermType = By.XPath("//md-radio-button[@aria-label='" + TridVariable.RepaymentTermType + "']");
            OddDaysSelect = By.XPath("//md-option[@value='" + TridVariable.OddDaysInterestCollected + "']");
            UpfrontMipFinanced = By.XPath("//div[@title='Upfront MIP Financed']//md-radio-button[@value='" + TridVariable.UpfrontMipFinanced + "']");
        }
        public static By FreqOfPmtValue = By.XPath("//div[@title='Frequency Of Pmt Value']//input");
        public static By LoanTermValue = By.XPath("//div[@title='Loan Term Value']//input");
        public static By NumberOfPayments = By.XPath("//div[@title='Number Of Payments']//input");
        public static By BaseLoanAmount = By.XPath("//div[@title='Base Loan Amount']//input");
        public static By UpfrontLoanFactor = By.XPath("//div[@title='Upfornt Loan Factor']//input");
        public static By LoanAmount = By.XPath("//div[@title='Loan Amount']//input");
        public static By RateOfInterest = By.XPath("//div[@title='Rate Of Interest']//input");
        public static By UpfrontMip = By.XPath("//div[@title='Upfront MIP']//input");
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

        //Escrow
        public static By EscrowCalcInputsText = By.XPath("//div[@id='EscrowCalculationsInput']/md-toolbar");
        public static By IsInsEscrowed;
        public static By IsTaxEscrowed;
        public static By IsOther1Escrowed;
        public static By IsOther2Escrowed;
        public static void EscrowRadioButtonVariable()
        {
            IsInsEscrowed = By.XPath("//div[@title='Is INS Escrowed']//md-radio-button[@aria-label='" + TridVariable.IsInsEscrowed + "']");
            IsTaxEscrowed = By.XPath("//div[@title='Is Tax Escrowed']//md-radio-button[@aria-label='" + TridVariable.IsTaxEscrowed + "']");
            IsOther1Escrowed = By.XPath("//div[@title='Is Other1 Escrowed']//md-radio-button[@aria-label='" + TridVariable.IsOther1Escrowed + "']");
            IsOther2Escrowed = By.XPath("//div[@title='Is Other2 Escrowed']//md-radio-button[@aria-label='" + TridVariable.IsOther2Escrowed + "']");
        }
        public static By CushionMonthsForInsurance = By.XPath("//div[@title='Cushion Months For Insurance']//input");
        public static By CushionMonthsForTax = By.XPath("//div[@title='Cushion Months For Tax']//input");
        public static By CushionMonthsForOther1 = By.XPath("//div[@title='Cushion Months For Other1']//input");
        public static By CushionMonthsForOther2 = By.XPath("//div[@title='Cushion Months For Other2']//input");
        public static By DateOfFirstMonthlyPmiDisbursement = By.XPath("//div[@title='Date Of First Monthly PMI Disbursement']//input");
        public static By InsuranceCostNumber = By.XPath("//div[@id='EscrowInsuranceGridInputs']//div[@title='Number']//input");
        public static By DateInsurancePaidDisbursed = By.XPath("//div[@title='Date Insurance Paid / Disbursed']//input");
        public static By InsuranceAmount = By.XPath("//div[@title='Insurance Amount']//input");
        public static By InsuranceCostAddButton = By.XPath("//div[@id='EscrowInsuranceGridInputs']//div[4]//button");
        public static By InsuranceGridRowCount = By.XPath("//section[@id='EscrowInsuranceGrid']//tbody/tr");
        public static By InsuranceGridNumber = By.XPath("//section[@id='EscrowInsuranceGrid']//tbody/tr/td[1]//span");
        public static By InsuranceGridDate = By.XPath("//section[@id='EscrowInsuranceGrid']//tbody/tr/td[3]//span");
        public static By InsuranceGridAmount = By.XPath("//section[@id='EscrowInsuranceGrid']//tbody/tr/td[4]//span");
        public static By TaxCostNumber = By.XPath("//div[@id='EscrowTaxCalculationsGridInputs']//div[@title='Number']//input");
        public static By TaxCostDate = By.XPath("//div[@id='EscrowTaxCalculationsGridInputs']//div[@title='Date']//input");
        public static By TaxCostAmount = By.XPath("//div[@title='Tax Installment Amount']//input");
        public static By TaxCostAddButton = By.XPath("//div[@id='EscrowTaxCalculationsGridInputs']//div[4]//button");
        public static By TaxGridRowCount = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr");
        public static By TaxGridNumberFR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[1]/td[1]//span");
        public static By TaxGridDateFR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[1]/td[3]//span");
        public static By TaxGridAmountFR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[1]/td[4]//span");
        public static By TaxGridNumberSR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[2]/td[1]//span");
        public static By TaxGridDateSR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[2]/td[3]//span");
        public static By TaxGridAmountSR = By.XPath("//section[@id='EscrowTaxGrid']//tbody/tr[2]/td[4]//span");

        public static By OtherCost1Number = By.XPath("//div[@id='EscrowOther1GridInputs']//div[@title='Number']//input");
        public static By OtherCost1Date = By.XPath("//div[@id='EscrowOther1GridInputs']//div[@title='Date']//input");
        public static By OtherCost1Amount = By.XPath("//div[@title='Other1 Installment Amount']//input");
        public static By OtherCost1AddButton = By.XPath("//div[@id='EscrowOther1GridInputs']//div[4]//button");
        public static By OtherCost1GridRowCount = By.XPath("//section[@id='EscrowOther1Grid']//tbody/tr");
        public static By OtherCost1GridNumber = By.XPath("//section[@id='EscrowOther1Grid']//tbody/tr/td[1]//span");
        public static By OtherCost1GridDate = By.XPath("//section[@id='EscrowOther1Grid']//tbody/tr/td[3]//span");
        public static By OtherCost1GridAmount = By.XPath("//section[@id='EscrowOther1Grid']//tbody/tr/td[4]//span");

        public static By OtherCost2Number = By.XPath("//div[@id='EscrowOther2GridInputs']//div[@title='Number']//input");
        public static By OtherCost2Date = By.XPath("//div[@id='EscrowOther2GridInputs']//div[@title='Date']//input");
        public static By OtherCost2Amount = By.XPath("//div[@title='Other2 Installment Amount']//input");
        public static By OtherCost2AddButton = By.XPath("//div[@id='EscrowOther2GridInputs']//div[4]//button");
        public static By OtherCost2GridRowCount = By.XPath("//section[@id='EscrowOther2Grid']//tbody/tr");
        public static By OtherCost2GridNumber = By.XPath("//section[@id='EscrowOther2Grid']//tbody/tr/td[1]//span");
        public static By OtherCost2GridDate = By.XPath("//section[@id='EscrowOther2Grid']//tbody/tr/td[3]//span");
        public static By OtherCost2GridAmount = By.XPath("//section[@id='EscrowOther2Grid']//tbody/tr/td[4]//span");


        //Prepaid Charges
        public static By OriginationChargePoints = By.XPath("//div[@title='Origination Charge - Points']//input");
        public static By OriginationChargeOther1 = By.XPath("//div[@title='Origination Charge Other 1']//input");
        public static By OriginationChargeOther2 = By.XPath("//div[@title='Origination Charge Other 2']//input");
        public static By Flood = By.XPath("//div[@title='Flood']//input");
        public static By FHAUSDA = By.XPath("//div[@title='FHA/USDA']//input");
        public static By TaxServicing = By.XPath("//div[@title='Tax Servicing']//input");
        public static By UpfrontPMIVAGuarantee = By.XPath("//div[@title='Upfront PMI/VA Guarantee']//input");
        public static By SectionBOther1 = By.XPath("//div[@title='Section B - Other 1']//input");
        public static By SectionBOther2 = By.XPath("//div[@title='Section B - Other 2']//input");
        public static By TitleClosingProtectionLetter = By.XPath("//div[@title='Title - Closing protection letter']//input");
        public static By TitleClosingSettlement = By.XPath("//div[@title=' Title – Closing/Settlement']//input");
        public static By TitleCourierOverNight = By.XPath("//div[@title='Title – Courier/Overnight']//input");
        public static By TitleWire = By.XPath("//div[@title='Title - Wire']//input");
        public static By TitleOther1 = By.XPath("//div[@title='Title – Other 1']//input");
        public static By TitleOther2 = By.XPath("//div[@title='Title – Other 2']//input");
        public static By SectionCOther1 = By.XPath("//div[@title='Section C - Other 1']//input");
        public static By SectionCOther2 = By.XPath("//div[@title='Section C - Other 2']//input");
        public static By PrepaidDailyInterest = By.XPath("//div[@title='Prepaid Daily Interest']//input");
        public static By TotalMiInSectionFPrepaids = By.XPath("//div[@title='Total MI In Section F (Prepaids)']//input");
        public static By TotalMiInSectionGEscrow = By.XPath("//div[@title='Total MI In Section G (Escrow)']//input");
        public static By LoanCostsSumABC = By.XPath("//div[@title='Loan Costs (Section A+B+C)']//input");
        public static By CustomName = By.XPath("//div[@title='Number']//input");
        public static By CustomValue = By.XPath("//div[@title='Number']//input");
        public static By CustomFieldAddButton = By.XPath("//div[@id='PrepaidChargeGridInput']//button");
        public static By PrepaidChargeGridCount = By.XPath("//section[@id='PrepaidChargeGrid']//tbody/tr");
        public static By PrepaidChargeGridCustomName = By.XPath("//section[@id='PrepaidChargeGrid']//tbody/tr/td[1]//span");
        public static By PrepaidChargeGridCustomValue = By.XPath("//section[@id='PrepaidChargeGrid']//tbody/tr/td[2]//span");

    }
}
