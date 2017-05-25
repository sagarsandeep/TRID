using OpenQA.Selenium;
using TRID.CommonUtils;

namespace TRID.ProjectLibs.UI
{
    public class ClosingDisclosureCardsUiElements : LoanEstimateCardsUiElements
    {
        public static By AprLabelText = By.XPath("//div[@id='viewCompositionContainer']/div/div[2]/div[1]//md-toolbar");

        //Princpal & Interest
        public static By PiComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[1]/ng-include//div[1]/p[1]");
        public static By PiDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[1]/ng-include//div[1]/p[2]");
        public static By PiVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[1]/ng-include//div[1]/p[3]");

        //APR
        public static By AprComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[1]/ng-include//div[1]/p[1]");
        public static By AprDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[1]/ng-include//div[1]/p[2]");
        public static By AprVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[1]/ng-include//div[1]/p[3]");

        //Tip
        public static By TipComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[1]/ng-include//div[1]/p[1]");
        public static By TipDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[1]/ng-include//div[1]/p[2]");
        public static By TipVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[1]/ng-include//div[1]/p[3]");

        //Escrow Prop Costs Over 1 Year 11 Months
        public static By E1O11ComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[4]/div[1]/ng-include//div[1]/p[1]");
        public static By E1O11DisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[4]/div[1]/ng-include//div[1]/p[2]");
        public static By E1O11VarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[4]/div[1]/ng-include//div[1]/p[3]");

        //Mortgage Insurance
        public static By MiComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[2]/ng-include//div[1]/p[1]");
        public static By MiDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[2]/ng-include//div[1]/p[2]");
        public static By MiVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[2]/ng-include//div[1]/p[3]");

        //Finance Charge
        public static By FcComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[2]/ng-include//div[1]/p[1]");
        public static By FcDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[2]/ng-include//div[1]/p[2]");
        public static By FcVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[2]/ng-include//div[1]/p[3]");

        //Balloon Amount
        public static By BaComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[2]/ng-include//div[1]/p[1]");
        public static By BaDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[2]/ng-include//div[1]/p[2]");
        public static By BaVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[2]/ng-include//div[1]/p[3]");

        //Escrow Prop Costs Over 1 Year 12 Months
        public static By E1O12ComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[4]/div[2]/ng-include//div[1]/p[1]");
        public static By E1O12DisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[4]/div[2]/ng-include//div[1]/p[2]");
        public static By E1O12VarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[4]/div[2]/ng-include//div[1]/p[3]");

        //Estimated Escrow
        public static By EeComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[3]/ng-include//div[1]/p[1]");
        public static By EeDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[3]/ng-include//div[1]/p[2]");
        public static By EeVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[3]/ng-include//div[1]/p[3]");

        //Amount Financed
        public static By AfComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[3]/ng-include//div[1]/p[1]");
        public static By AfDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[3]/ng-include//div[1]/p[2]");
        public static By AfVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[3]/ng-include//div[1]/p[3]");

        //Scheduled PMI Termination Date 
        public static By SptdComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[3]/ng-include//div[1]/p[1]");
        public static By SptdDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[3]/ng-include//div[1]/p[2]");
        public static By SptdVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[3]/ng-include//div[1]/p[3]");

        //Non Escrw Prop Costs Over 1 Year 
        public static By Neo1YComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[4]/div[3]/ng-include//div[1]/p[1]");
        public static By Neo1YDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[4]/div[3]/ng-include//div[1]/p[2]");
        public static By Neo1YVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[4]/div[3]/ng-include//div[1]/p[3]");

        //Estimated Total Monthly Payment 
        public static By EtmpComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[4]/ng-include//div[1]/p[1]");
        public static By EtmpDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[4]/ng-include//div[1]/p[2]");
        public static By EtmpVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[4]/ng-include//div[1]/p[3]");

        //Total Of Pymts 
        public static By TopComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[4]/ng-include//div[1]/p[1]");
        public static By TopDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[4]/ng-include//div[1]/p[2]");
        public static By TopVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[4]/ng-include//div[1]/p[3]");

        //Prepaid Charges
        public static By PcComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[4]/ng-include//div[1]/p[1]");
        public static By PcDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[4]/ng-include//div[1]/p[2]");
        public static By PcVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[3]/div[4]/ng-include//div[1]/p[3]");

        //Initial Escrow Pymt 
        public static By IepComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[4]/div[4]/ng-include//div[1]/p[1]");
        public static By IepDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[4]/div[4]/ng-include//div[1]/p[2]");
        public static By IepVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[4]/div[4]/ng-include//div[1]/p[3]");

        //Estimated Taxes, Insurance & Assessments
        public static By EtiaComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[5]/ng-include//div[1]/p[1]");
        public static By EtiaDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[5]/ng-include//div[1]/p[2]");
        public static By EtiaVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[5]/ng-include//div[1]/p[3]");

    }
}
