namespace TRID.ProjectLibs.Common
{
    public class TridVariable
    {
        #region Assiging Variables 

        public static string CalculationMethod = "";
        public static string LoanType = "";
        public static string FrequencyOfPayments = "";
        public static string LoanTerm = "";
        public static string AdvanceType = "";
        public static string RepaymentTermType = "";
        public static string FrequencyOfPmtValue = "";
        public static string LoanTermValue = "";
        public static string LoanAmount = "";
        public static string RateOfInterest = "";
        public static string DateOfLoan = "";
        public static string DateInterestBeginToAccrue = "";
        public static string DateOfFirstPayment = "";
        public static string PeriodPayment = "";
        public static string LoanCosts = "";
        public static string FinalBalloonPayment = "";
        public static string OddDaysInterestCollected = "";
        public static string LoanDetailsEstimatedEscrow = "";
        public static string MonthlyPrincipalAndInterest = "";
        public static string MonthlyPmi = "";
        public static string TotalMonhtlyPayment = "";
        public static string PmiTerminationDate = "";
        public static string PmiCancelDate = "";
        public static string DisclosedEstimatedEscrow = "";
        public static string EscrowPropertyOverOneYear = "";
        public static string NonEscrowPropertyOverOneYear = "";
        public static string InitialEscrowPayment = "";
        public static string MonthlyEscrowPayments = "";
        public static string MonthlyEscrowPayment = "";
        public static string PrincipalAndInt = "";
        public static string Pmi = "";
        public static string TotalPeriodPayment = "";
        public static string DropOffYearsForPmi = "";
        public static string PeriodEscrowPayment = "";
        public static string FinanceCharge = "";
        public static string PrepaidCharges = "";
        public static string AmountFinanced = "";
        public static string Apr = "";
        public static string Tip = "";
        public static string DiscLosedIn5Years = "";
        public static string DiscLosedIn5YearsPrincipal = "";
        public static string DisclosedApr = "";
        public static string DisclosedTip = "";
        public static string In5Years = "";
        public static string In5YearsPrincipal = "";
        public static string FirstAddNumber = "";
        public static string FirstAddBeginPeriod = "";
        public static string FirstAddEndPeriod = "";
        public static string FirstAddPmiRate = "";
        public static string SecondAddNumber = "";
        public static string SecondAddBeginPeriod = "";
        public static string SecondAddEndPeriod = "";
        public static string SecondAddPmiRate = "";
        public static string ThirdAddNumber = "";
        public static string ThirdAddBeginPeriod = "";
        public static string ThirdAddEndPeriod = "";
        public static string ThirdAddPmiRate = "";
        public static string NoOfPrdsOfAdvcInsurance = "";
        public static string LowerOfCostOfAppraisal = "";
        public static string FhaVaUsdaUpfrontPmiFree = "";
        public static string FloodFee = "";
        public static string InspectionFee = "";
        public static string LoanOriginationFee = "";
        public static string OtherFees = "";
        public static string PmiEscrowed = "";
        public static string PrepaidDailyInterest = "";
        public static string TaxServicing = "";
        public static string TitleClosingFee = "";
        public static string TitleClosingProtectionLetter = "";
        public static string TitleCourierFee = "";
        public static string TitleDrawFee = "";
        public static string TitleWireFee = "";
        public static string UnderWriting = "";
        public static string DisclosedFinanceCharge = "";
        public static string DisclosedPrepaidCharge = "";
        public static string DisclosedAmountFinanced ="";
        public static string PrepaidCharge = "";

        #endregion

        public void GetVariableNameAndSetValues(int row, int col, string stringValue, string sheetName)
        {

            #region Prepaid Charges

            if (col == 2) FhaVaUsdaUpfrontPmiFree = stringValue;
            if (col == 3) FloodFee = stringValue;
            if (col == 4) InspectionFee = stringValue;
            if (col == 5) LoanOriginationFee = stringValue;
            if (col == 6) OtherFees = stringValue;
            if (col == 7) PmiEscrowed = stringValue;
            if (col == 8) PrepaidDailyInterest = stringValue;
            if (col == 9) TaxServicing = stringValue;
            if (col == 10) TitleClosingFee = stringValue;
            if (col == 11) TitleClosingProtectionLetter = stringValue;
            if (col == 12) TitleCourierFee = stringValue;
            if (col == 13) TitleDrawFee = stringValue;
            if (col == 14) TitleWireFee = stringValue;
            if (col == 15) UnderWriting = stringValue;
            if (col == 16) DisclosedFinanceCharge = stringValue;
            if (col == 17) DisclosedPrepaidCharge = stringValue;
            if (col == 18) DisclosedAmountFinanced = stringValue;
            if (col == 19) FinanceCharge = stringValue;
            if (col == 20) PrepaidCharge = stringValue;
            if (col == 21) AmountFinanced = stringValue;

            #endregion


            #region Loan Estimate

            if (sheetName == "LoanEstimate")
            {
                if (col == 2) CalculationMethod = stringValue;
                if (col == 3) LoanType = stringValue;
                if (col == 4) FrequencyOfPayments = stringValue;
                if (col == 5) LoanTerm = stringValue;
                if (col == 6) AdvanceType = stringValue;
                if (col == 7) RepaymentTermType = stringValue;
                if (col == 8) FrequencyOfPmtValue = stringValue;
                if (col == 9) LoanTermValue = stringValue;
                if (col == 10) LoanAmount = stringValue;
                if (col == 11) RateOfInterest = stringValue;
                if (col == 12) DateOfLoan = stringValue;
                if (col == 13) DateInterestBeginToAccrue = stringValue;
                if (col == 14) DateOfFirstPayment = stringValue;
                if (col == 15) PeriodPayment = stringValue;
                if (col == 16) LoanCosts = stringValue;
                if (col == 17) FinalBalloonPayment = stringValue;
                if (col == 18) OddDaysInterestCollected = stringValue;
                if (col == 19) LoanDetailsEstimatedEscrow = stringValue;
                if (col == 20) DiscLosedIn5Years = stringValue;
                if (col == 21) DiscLosedIn5YearsPrincipal = stringValue;
                if (col == 22) DisclosedApr = stringValue;
                if (col == 23) DisclosedTip = stringValue;
                if (col == 24) In5Years = stringValue;
                if (col == 25) In5YearsPrincipal = stringValue;
                if (col == 26) Apr = stringValue;
                if (col == 27) Tip = stringValue;
            }

            #endregion


            #region Closing Disclosure

            if (sheetName == "ClosingDisclosure")
            {
                if (col == 2) CalculationMethod = stringValue;
                if (col == 3) LoanType = stringValue;
                if (col == 4) FrequencyOfPayments = stringValue;
                if (col == 5) LoanTerm = stringValue;
                if (col == 6) AdvanceType = stringValue;
                if (col == 7) RepaymentTermType = stringValue;
                if (col == 8) FrequencyOfPmtValue = stringValue;
                if (col == 9) LoanTermValue = stringValue;
                if (col == 10) LoanAmount = stringValue;
                if (col == 11) RateOfInterest = stringValue;
                if (col == 12) DateOfLoan = stringValue;
                if (col == 13) DateInterestBeginToAccrue = stringValue;
                if (col == 14) DateOfFirstPayment = stringValue;
                if (col == 15) PeriodPayment = stringValue;
                if (col == 16) LoanCosts = stringValue;
                if (col == 17) FinalBalloonPayment = stringValue;
                if (col == 18) OddDaysInterestCollected = stringValue;
                if (col == 19) LoanDetailsEstimatedEscrow = stringValue;
                if (col == 20) MonthlyPrincipalAndInterest = stringValue;
                if (col == 21) MonthlyPmi = stringValue;
                if (col == 22) TotalMonhtlyPayment = stringValue;
                if (col == 23) PmiTerminationDate = stringValue;
                if (col == 24) PmiCancelDate = stringValue;
                if (col == 25) DisclosedEstimatedEscrow = stringValue;
                if (col == 26) EscrowPropertyOverOneYear = stringValue;
                if (col == 27) NonEscrowPropertyOverOneYear = stringValue;
                if (col == 28) InitialEscrowPayment = stringValue;
                if (col == 29) MonthlyEscrowPayments = stringValue;
                if (col == 30) MonthlyEscrowPayment = stringValue;
                if (col == 31) PrincipalAndInt = stringValue;
                if (col == 32) Pmi = stringValue;
                if (col == 33) TotalPeriodPayment = stringValue;
                if (col == 34) DropOffYearsForPmi = stringValue;
                if (col == 35) PeriodEscrowPayment = stringValue;
                if (col == 36) FinanceCharge = stringValue;
                if (col == 37) PrepaidCharges = stringValue;
                if (col == 38) AmountFinanced = stringValue;
                if (col == 39) Apr = stringValue;
                if (col == 40) Tip = stringValue;
            }

            #endregion


            #region Mortgage Insurance

            if (sheetName == "MortgageInsurance")
            {
                if (row == 2)
                {
                    if (col == 2) FirstAddNumber = stringValue;
                    if (col == 3) FirstAddBeginPeriod = stringValue;
                    if (col == 4) FirstAddEndPeriod = stringValue;
                    if (col == 5) FirstAddPmiRate = stringValue;
                }

                if (row == 3)
                {
                    if (col == 2) SecondAddNumber = stringValue;
                    if (col == 3) SecondAddBeginPeriod = stringValue;
                    if (col == 4) SecondAddEndPeriod = stringValue;
                    if (col == 5) SecondAddPmiRate = stringValue;
                }

                if (row == 4)
                {
                    if (col == 2) ThirdAddNumber = stringValue;
                    if (col == 3) ThirdAddBeginPeriod = stringValue;
                    if (col == 4) ThirdAddEndPeriod = stringValue;
                    if (col == 5) ThirdAddPmiRate = stringValue;
                }

                if (col == 4) NoOfPrdsOfAdvcInsurance = stringValue;
                if (col == 5) LowerOfCostOfAppraisal = stringValue;
            }

            #endregion


        }
    }
}