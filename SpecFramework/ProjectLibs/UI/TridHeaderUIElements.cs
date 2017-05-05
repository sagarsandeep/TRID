using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TRID.ProjectLibs.UI
{
    public class TridHeaderUiElements : StartNewLoanUiElements
    {
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
    }
}
