using OpenQA.Selenium;
using TRID.CommonUtils;

namespace TRID.ProjectLibs.UI
{
    public class LoanEstimateCardsUiElements : PageBase
    {
        //In 5 years
        public static By I5YComputedValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[1]/div[1]//div[1]/p[1]");
        public static By I5YDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[1]/div[1]//div[1]/p[2]");
        public static By I5YVarianceValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[1]/div[1]//div[1]/p[3]");

        //In 5 Years Principal
        public static By I5YpComputedValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[1]/div[2]//div[1]/p[1]");
        public static By I5YpDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[1]/div[2]//div[1]/p[2]");
        public static By I5YpVarianceValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[1]/div[2]//div[1]/p[3]");
    }
}
