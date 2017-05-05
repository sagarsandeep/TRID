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
        public static By SnlStartNewLoanText = By.XPath("//div[@id='StartNewLoan']/md-toolbar");
        public static By SnlResetButton = By.XPath("//div[@id='StartNewLoan']//button");
    }
}
