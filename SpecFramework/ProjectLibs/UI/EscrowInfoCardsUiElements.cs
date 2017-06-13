using OpenQA.Selenium;
using TRID.CommonUtils;

namespace TRID.ProjectLibs.UI
{
    public class EscrowInfoCardsUiElements : PageBase
    {
        public static By EscrowInfoInsuranceLabelText = By.Id("EscrowInsuranceInfo");

        //Insurance
        public static By InsInitialDeposit = By.XPath("//div[@id='EscrowInsuranceInfoInitialDeposit']//span");
        public static By InsPeriodDeposit = By.XPath("//div[@id='EscrowInsuranceInfoPeriodDeposit']//span");
        public static By InsLowBalance = By.XPath("//div[@id='EscrowInsuranceInfoLowBalance']//span");
        public static By InsCushion = By.XPath("//div[@id='EscrowInsuranceInfoCushion']//span");
        public static By InsTotalAnnualDisbursed = By.XPath("//div[@id='EscrowInsuranceInfoTotalAnnualDisbursed']//span");

        //Tax
        public static By TaxInitialDeposit = By.XPath("//div[@id='EscrowTaxInfoInitialDeposit']//span");
        public static By TaxPeriodDeposit = By.XPath("//div[@id='EscrowTaxInfoPeriodDeposit']//span");
        public static By TaxLowBalance = By.XPath("//div[@id='EscrowTaxInfoLowBalance']//span");
        public static By TaxCushion = By.XPath("//div[@id='EscrowTaxInfoCushion']//span");
        public static By TaxTotalAnnualDisbursed = By.XPath("//div[@id='EscrowTaxInfoTotalAnnualDisbursed']//span");

        //PMI
        public static By PmiInitialDeposit = By.XPath("//div[@id='EscrowPmiInfoInitialDeposit']//span");
        public static By PmiPeriodDeposit = By.XPath("//div[@id='EscrowPmiInfoPeriodDeposit']//span");
        public static By PmiLowBalance = By.XPath("//div[@id='EscrowPmiInfoLowBalance']//span");
        public static By PmiCushion = By.XPath("//div[@id='EscrowPmiInfoCushion']//span");
        public static By PmiTotalAnnualDisbursed = By.XPath("//div[@id='EscrowPmiInfoTotalAnnualDisbursed']//span");

        //Other1
        public static By Other1InitialDeposit = By.XPath("//div[@id='EscrowOther1InfoInitialDeposit']//span");
        public static By Other1PeriodDeposit = By.XPath("//div[@id='EscrowOther1InfoPeriodDeposit']//span");
        public static By Other1LowBalance = By.XPath("//div[@id='EscrowOther1InfoLowBalance']//span");
        public static By Other1Cushion = By.XPath("//div[@id='EscrowOther1InfoCushion']//span");
        public static By Other1TotalAnnualDisbursed = By.XPath("//div[@id='EscrowOther1InfoTotalAnnualDisbursed']//span");

        //Other2
        public static By Other2InitialDeposit = By.XPath("//div[@id='EscrowOther2InfoInitialDeposit']//span");
        public static By Other2PeriodDeposit = By.XPath("//div[@id='EscrowOther2InfoPeriodDeposit']//span");
        public static By Other2LowBalance = By.XPath("//div[@id='EscrowOther2InfoLowBalance']//span");
        public static By Other2Cushion = By.XPath("//div[@id='EscrowOther2InfoCushion']//span");
        public static By Other2TotalAnnualDisbursed = By.XPath("//div[@id='EscrowOther2InfoTotalAnnualDisbursed']//span");

        //Aggregate
        public static By AggregateInitialDeposit = By.XPath("//div[@id='EscrowAggregateInfoInitialDeposit']//span");
        public static By AggregatePeriodDeposit = By.XPath("//div[@id='EscrowAggregateInfoPeriodDeposit']//span");
        public static By AggregateLowBalance = By.XPath("//div[@id='EscrowAggregateInfoLowBalance']//span");
        public static By AggregateCushion = By.XPath("//div[@id='EscrowAggregateInfoCushion']//span");
        public static By AggregateTotalAnnualDisbursed = By.XPath("//div[@id='EscrowAggregateInfoAggregateAdjustment']//span");
    }
}
