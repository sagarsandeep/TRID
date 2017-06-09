using OpenQA.Selenium;
using TRID.CommonUtils;

namespace TRID.ProjectLibs.UI
{
    public class AmortizationUiElements : PageBase
    {
        public static By PaymentScheduleLabelText = By.XPath("//section[@id='PaymentScheduleOutput']//md-toolbar/div");
        public static By PaymentStreamNumber;
        public static By PaymentScheduleNumberOfPayments;
        public static By PaymentAmount;
        public static By MonthlyPayment;
        public static By MonthlyPmi;
        public static By InsEscrowedAmount;
        public static By TaxEscrowedAmount;

        public static void PaymentScheduleGridElements(int rowIndex)
        {
            PaymentStreamNumber = By.XPath("//section[@id='PaymentScheduleOutput']//tr["+rowIndex+"]/td[1]");
            PaymentScheduleNumberOfPayments = By.XPath("//section[@id='PaymentScheduleOutput']//tr[" + rowIndex + "]/td[2]");
            PaymentAmount = By.XPath("//section[@id='PaymentScheduleOutput']//tr[" + rowIndex + "]/td[3]");
            MonthlyPayment = By.XPath("//section[@id='PaymentScheduleOutput']//tr[" + rowIndex + "]/td[4]");
            MonthlyPmi = By.XPath("//section[@id='PaymentScheduleOutput']//tr[" + rowIndex + "]/td[5]");
            InsEscrowedAmount = By.XPath("//section[@id='PaymentScheduleOutput']//tr[" + rowIndex + "]/td[6]");
            TaxEscrowedAmount = By.XPath("//section[@id='PaymentScheduleOutput']//tr[" + rowIndex + "]/td[7]");
        }

    }
}
