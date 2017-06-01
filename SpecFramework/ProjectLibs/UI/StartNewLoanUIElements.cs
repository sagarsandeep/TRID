using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TRID.ProjectLibs.UI
{
    public class StartNewLoanUiElements : LoanInputsUiElements
    {
        public static By StartNewLoanText = By.XPath("//div[@id='StartNewLoan']/md-toolbar");
        public static By ResetButton = By.XPath("//div[@id='StartNewLoan']//button");
        public static By BrowseButton = By.XPath("//section[@id='RestoreViewParametersFromFile']//input");
        public static By UploadButton = By.XPath("//section[@id='RestoreViewParametersFromFile']//button");
    }
}
