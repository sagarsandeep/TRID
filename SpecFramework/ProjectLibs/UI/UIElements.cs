using OpenQA.Selenium;
using TRID.CommonUtils;

namespace TRID.ProjectLibs.UI
{
    public class UIElements : PageBase

    {
        #region HeaderBar

        public static By PrepaidChargesLink = By.LinkText("Prepaid Charges");
        public static By LoanEstimateLink = By.LinkText("Loan Estimate");
        public static By ClosingDisclosureLink = By.LinkText("Closing Disclosure");
        public static By MortgageInsuranceLink = By.LinkText("Mortgage Insurance");
        public static By EscrowLink = By.LinkText("EscrowLink");
        public static By ExportLink = By.LinkText("ExportLink");

        #endregion

        #region Closing DisclosurePage

        public static By CdCalMtdActOver365 = By.Id("radio_29");
        public static By CdCalMtdActOver365LeapYear = By.Id("radio_30");
        public static By CalMtdActOver360 = By.Id("radio_31");
        public static By CdCalMtd30Over360 = By.Id("radio_32");

        public static By CdLoanTypeFixed = By.Id("radio_33");
        public static By CdLoanTypeVariable = By.Id("radio_34");

        public static By CdFreqOfPaymentMonthly = By.Id("radio_35");
        public static By CdFreqOfPaymentMultipleOfMonth = By.Id("radio_36");
        public static By CdFreqOfPaymentBiWeekly = By.Id("radio_37");
        public static By CdFreqOfPaymentSemiMonthly = By.Id("radio_38");
        public static By CdFreqOfPaymentActualDays = By.Id("radio_39");

        public static By CdLoanTermYears = By.Id("radio_40");
        public static By CdLoanTermMonths = By.Id("radio_41");
        public static By CdLoanTermDays = By.Id("radio_42");

        public static By CdFreqOfPmtValue = By.Id("input_43");
        public static By CdLoanTermValue = By.Id("input_44");

        public static By CdAdvanceTypeSingle = By.Id("radio_45");
        public static By CdAdvanceTypeMultiWithKnownDates = By.Id("radio_46");
        public static By CdAdvanceTypeMultiWithUnknownDates = By.Id("radio_47");

        public static By CdRepaymentTermTypeWhole = By.Id("radio_48");
        public static By CdRepaymentTermTypeFinal = By.Id("radio_49");
        
        public static By CdLoanAmount = By.Id("input_50");
        public static By CdRateOfInterest = By.Id("input_51");
        public static By CdDateOfLoan = By.Id("input_53");
        public static By CdDateOfInterestBegins = By.Id("input_55");
        public static By CdDateOfFirstPayment = By.Id("input_57");
        public static By CdPeriodPayment = By.Id("input_58");
        public static By CdLoanCostsForDisclosure = By.Id("input_59");
        public static By CdFinalBalloonPayment = By.Id("input_60");
        //public static By OddDays =
        public static By CdLoanDetailsEstimatedEscrow = By.Id("input_64");


        public static By CdMonthlyPrincipalandInterest = By.Id("input_65");
        public static By CdMonthlyPmi = By.Id("input_66");
        public static By CdTotalMonthlyPayment = By.Id("input_67");
        public static By CdPmiTerminalDate = By.Id("input_68");
        public static By CdPmiCancelDate = By.Id("input_69");
        public static By CdDisclosedEstimatedEscrow = By.Id("input_70");
        public static By CdEscrowPropertyOverOneYear = By.Id("input_71");
        public static By CdNonEscrowPropertyOverOneYear = By.Id("input_72");
        public static By CdInitialEscrowPayment = By.Id("input_73");
        public static By CdMonthlyEscrowPayment = By.Id("input_74");
        public static By CdTotalOfPayment = By.Id("input_75");

        public static By CdLoanDetailsTest = By.XPath("//div[@id='LoanInformationInput']/form/div/div[1]//wipfli-button/button");
        public static By CdLoanDetailsReset = By.XPath("//div[@id='LoanInformationInput']//div[2]/div/wipfli-button/button");
        public static By CdDisclosedTest = By.XPath("//div[@id='DisclosureInput']//button");
        public static By CdLoanDetailsText = By.XPath("//div[@id='LoanInformationInput']//div[@class='md-toolbar-tools ng-binding']");

        //Princpal & Interest
        public static By CdPiComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[1]/ng-include//div[1]/p[1]");
        public static By CdPiDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[1]/ng-include//div[1]/p[2]");
        public static By CdPiVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[1]/ng-include//div[1]/p[3]");

        //PMI
        public static By CdPmiComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[1]/ng-include//div[1]/p[1]");
        public static By CdPmiDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[1]/ng-include//div[1]/p[2]");
        public static By CdPmiVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[1]/ng-include//div[1]/p[3]");


        //Total Period Pymt
        public static By CdTppComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[2]/ng-include//div[1]/p[1]");
        public static By CdTppDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[2]/ng-include//div[1]/p[2]");
        public static By CdTppVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[2]/ng-include//div[1]/p[3]");

        //Prepaid Charges
        public static By CdPcComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[6]/ng-include//div[1]/p[1]");
        public static By CdPcDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[6]/ng-include//div[1]/p[2]");
        public static By CdPcVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[6]/ng-include//div[1]/p[3]");

        //APR
        public static By CdAprComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[7]/ng-include//div[1]/p[1]");
        public static By CdAprDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[7]/ng-include//div[1]/p[2]");
        public static By CdAprVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[1]/div[7]/ng-include//div[1]/p[3]");

        //Finance Charge
        public static By CdFcComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[6]/ng-include//div[1]/p[1]");
        public static By CdFcDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[6]/ng-include//div[1]/p[2]");
        public static By CdFcVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[6]/ng-include//div[1]/p[3]");

        //Amount Financed
        public static By CdAfComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[7]/ng-include//div[1]/p[1]");
        public static By CdAfDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[7]/ng-include//div[1]/p[2]");
        public static By CdAfVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[7]/ng-include//div[1]/p[3]");

        //TIP
        public static By CdTipComputedValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[8]/ng-include//div[1]/p[1]");
        public static By CdTipDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[8]/ng-include//div[1]/p[2]");
        public static By CdTipVarianceValue = By.XPath("//div[@id='viewCompositionContainer']//div[2]/div[8]/ng-include//div[1]/p[3]");



        #endregion


        #region Loan Estimate

        public static By LeCalMtdActOver365 = By.Id("radio_29");
        public static By LeCalMtdActOver365LeapYear = By.Id("radio_30");
        public static By LelMtdActOver360 = By.Id("radio_31");
        public static By LeCalMtd30Over360 = By.Id("radio_32");

        public static By LeLoanTypeFixed = By.Id("radio_33");
        public static By LeLoanTypeVariable = By.Id("radio_34");

        public static By LeFreqOfPaymentMonthly = By.Id("radio_35");
        public static By LeFreqOfPaymentMultipleOfMonth = By.Id("radio_36");
        public static By LeFreqOfPaymentBiWeekly = By.Id("radio_37");
        public static By LeFreqOfPaymentSemiMonthly = By.Id("radio_38");
        public static By LeFreqOfPaymentActualDays = By.Id("radio_39");

        public static By LeLoanTermYears = By.Id("radio_40");
        public static By LeLoanTermMonths = By.Id("radio_41");
        public static By LeLoanTermDays = By.Id("radio_42");

        public static By LeFreqOfPmtValue = By.Id("input_43");
        public static By LeLoanTermValue = By.Id("input_44");

        public static By LeAdvanceTypeSingle = By.Id("radio_45");
        public static By LeAdvanceTypeMultiWithKnownDates = By.Id("radio_46");
        public static By LeAdvanceTypeMultiWithUnknownDates = By.Id("radio_47");

        public static By LeRepaymentTermTypeWhole = By.Id("radio_48");
        public static By LeRepaymentTermTypeFinal = By.Id("radio_49");

        public static By LeLoanAmount = By.Id("input_50");
        public static By LeRateOfInterest = By.Id("input_51");
        public static By LeDateOfLoan = By.Id("input_53");
        public static By LeDateOfInterestBegins = By.Id("input_55");
        public static By LeDateOfFirstPayment = By.Id("input_57");
        public static By LePeriodPayment = By.Id("input_58");
        public static By LeLoanCostsForDisclosure = By.Id("input_59");
        public static By LeFinalBalloonPayment = By.Id("input_60");
        //public static By OddDays =
        public static By LedLoanDetailsEstimatedEscrow = By.Id("input_64");

        public static By LeDisclosedIn5Years = By.Id("input_64");
        public static By LeDisclosedIn5YearsPrincipal = By.Id("input_64");
        public static By LeDisclosedApr = By.Id("input_64");
        public static By LeDisclosedTip = By.Id("input_64");

        public static By LeLoanDetailsTest = By.XPath("//div[@id='LoanInformationInput']//div[1]/div/wipfli-button/button");
        public static By LeLoanDetailsReset = By.XPath("//*[@id='LoanInformationInput']//div[2]/div/wipfli-button/button");
        public static By LeDisclosedTest = By.XPath("//div[@id='EstimationInput']//button");
        public static By LeLoanDetails = By.XPath("//div[@id='LoanInformationInput']//div[@class='md-toolbar-tools ng-binding']");

        //In 5 years
        public static By LeI5YComputedValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[1]/div[1]//div[1]/p[1]");
        public static By LeI5YDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[1]/div[1]//div[1]/p[2]");
        public static By LeI5YVarianceValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[1]/div[1]//div[1]/p[3]");

        //In 5 Years Principal
        public static By LeI5YpComputedValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[1]/div[2]//div[1]/p[1]");
        public static By LeI5YpDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[1]/div[2]//div[1]/p[2]");
        public static By LeI5YpVarianceValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[1]/div[2]//div[1]/p[3]");

        //APR
        public static By LeAprComputedValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[2]/div[1]//div[1]/p[1]");
        public static By LeAprDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[2]/div[1]//div[1]/p[2]");
        public static By LeAprVarianceValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[2]/div[1]//div[1]/p[3]");


        //TIP
        public static By LeTipComputedValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[2]/div[2]//div[1]/p[1]");
        public static By LeTipDisclosureValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[2]/div[2]//div[1]/p[2]");
        public static By LeTipVarianceValue = By.XPath("//div[@id='viewCompositionContainer']/div/div[2]/div[2]//div[1]/p[3]");

        #endregion


        #region Mortgage Insurance

        public static By MiAddNumber = By.Id("input_29");
        public static By MiAddBeginPeriod = By.Id("input_30");
        public static By MiAddEndPeriod = By.Id("input_31");
        public static By MiAddPmiRate = By.Id("input_32");

        public static By MiAddButton = By.XPath("//div[@id='MortgageInput']//button");

        public static By MiPmiRatesGridBlankRow = By.XPath("//section[@id='MortgageGrid']//tbody/tr");

        public static By MiNumberOfPeriodsofAdvanceInsCollected = By.Id("input_33");
        public static By MiLowerOfCostOrAppraisal = By.Id("input_34");

        #endregion


        #region Prepaid Charges

        public static By PcPrepaidChargesText = By.XPath("//div[@id='PrepaidChargesInput']/md-toolbar/div");

        //public static By PcFhaVaUsdaUpfrontPmiFree = By.Id("radio_6");
        public static By PcFhaVaUsdaUpfrontPmiFree = By.Id("input_6");
        public static By PcFloodFee = By.Id("input_7");
        public static By PcInspectionFee = By.Id("input_8");
        public static By PcLoanOriginationFee = By.Id("input_8");
        public static By PcOtherFees = By.Id("input_10");
        public static By PcPmiEscrowed = By.Id("input_11");
        public static By PcPrepaidDailyInterest = By.Id("input_12");
        public static By PcTaxServicing = By.Id("input_13");
        public static By PcTitleClosingFee = By.Id("input_14");
        public static By PcTitleClosingProtectionLetter = By.Id("input_15");
        public static By PcTitleCourierFee = By.Id("input_16");
        public static By PcTitleDrawFee = By.Id("input_17");
        public static By PcTitleWireFee = By.Id("input_18");
        public static By PcUnderWriting = By.Id("input_19");

        public static By PcPrepaidChargeGridBlankRow = By.XPath("//section[@id='PrepaidChargeGrid']//tbody/tr");
        

        public static By PcDisclosedFinanceCharge = By.Id("input_22");
        public static By PcDisclosedPrepaidCharge = By.Id("input_23");
        public static By PcDisclosedAmountFinanced = By.Id("input_24");





        #endregion
    }
}
