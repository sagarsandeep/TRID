using OpenQA.Selenium;
using TRID.CommonUtils;

namespace TRID.ProjectLibs.UI
{
    public class ClosingDisclosureCardsUiElements : PageBase
    {
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

        //Ecrw Prop Costs > 1 Yr 1
        public static By EpcooyComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[6]/ng-include//div[1]/p[1]");
        public static By EpcooyDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[6]/ng-include//div[1]/p[2]");
        public static By EpcooyVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[6]/ng-include//div[1]/p[3]");

        //Initial Escrow Pymt
        public static By IepComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[7]/ng-include//div[1]/p[1]");
        public static By IepDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[7]/ng-include//div[1]/p[2]");
        public static By IepVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[7]/ng-include//div[1]/p[3]");

        //Non Ecrw Prop Costs > 1 Yr 1
        public static By NepcooyComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[7]/ng-include//div[1]/p[1]");
        public static By NepcooyDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[7]/ng-include//div[1]/p[2]");
        public static By NepcooyVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[7]/ng-include//div[1]/p[3]");

        //Period Escrow Pymt
        public static By PepComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[8]/ng-include//div[1]/p[1]");
        public static By PepDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[8]/ng-include//div[1]/p[2]");
        public static By PepVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[8]/ng-include//div[1]/p[3]");
    }
}
