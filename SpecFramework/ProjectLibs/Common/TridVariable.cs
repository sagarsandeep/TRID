using TechTalk.SpecRun.Helper;
using TRID.CommonUtils;

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
        public static string DisclosedFinalBalloonPayment = "";
        public static string DisclosedTotalOfPayment = "";
        public static string BalloonAmount = "";
        public static string EscrowPropertyOverOneYear = "";
        public static string NonEscrowPropertyOverOneYear = "";
        public static string InitialEscrowPayment = "";
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
        public static string FirstRow = "";
        public static string SecondRow = "";
        public static string ThirdRow = "";
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
        public static string LoanIdNumber = "";
        public static string BorrowersNames = "";
        public static string PreparedBy = "";
        public static string NameOfLender = "";
        public static string OriginalCreditor = "";
        public static string PrepaidCustomName = "";
        public static string PrepaidCustomValue = "";
        public static string IsINSEscrowed	=	"";
        public static string IsTaxEscrowed	=	"";
        public static string FrequencyOfPayment	=	"";
        public static string EscrowCalculationStartPeriodDate	=	"";
        public static string CushionMonthsForInsurance	=	"";
        public static string CushionMonthsForTax	=	"";
        public static string CushionMonthsForPMI	=	"";
        public static string EscrowInstallmentInputsNumber	=	"";
        public static string DateForEscrowInsurance	=	"";
        public static string InsuranceInstallmentAmount	=	"";
        public static string EscrowTaxCalculationsInputsNumber	=	"";
        public static string EscrowTaxCalculationsInputsDate	=	"";
        public static string EscrowTaxCalculationsInputsTaxInstallmentAmount	=	"";
        public static string EscrowInputForPMICalculationEscrowPMIDate	=	"";
        public static string EscrowInputForPMICalculationEscrowPMIAmount	=	"";

        public static string DisclosedEscrowPropertyOverOneYear	=	"";
        public static string DisclosedNonEscrowPropertyOverOneYear	=	"";
        public static string DisclosedInitialEscrowPayment	=	"";
        public static string DisclosedMonthlyEscrowPayment	=	"";
        public static string InsuranceInfoAdjustmentBalance	=	"";
        public static string InsuranceInfoMinimumAmount	=	"";
        public static string InsuranceInfoCushionAmount	=	"";
        public static string InsuranceTotalInfoPeriodInsuranceAmount	=	"";
        public static string InsuranceTotalInfoInputInsuranceAmount	=	"";
        public static string TaxInfoAdjustmentBalance	=	"";
        public static string TaxInfoMinimumAmount	=	"";
        public static string TaxInfoCushionAmounts	=	"";
        public static string TaxTotalInfoPeriodTaxAmount	=	"";
        public static string TaxTotalInfoInputTaxAmount	=	"";
        public static string PMIInfoAdjustmentBalance	=	"";
        public static string PMIInfoMinimumAmount	=	"";
        public static string PMInfoCushionAmount	=	"";
        public static string PMITotalInfoPeriodOMIAmount	=	"";
        public static string PMITotalInfoInputTaxAmount	=	"";
        public static string AggregateInfoAdjustmentBalance	=	"";
        public static string AggregateInfoMinimumAmount	=	"";
        public static string AggregateInfoCushionAmount	=	"";
        public static string AggregateTotalInfoAgregatePayment	=	"";
        public static string AggregateTotalInfoAggregateDeposit	=	"";
        //public static string EscrowPropertyOverOneYear	=	"";
        //public static string NonEscrowPropertyOverOneYear	=	"";
        //public static string InitialEscrowPayment	=	"";
        //public static string PeriodEscrowPayment =	"";
        public static string TotalOfPayments = "";


        #endregion

        public void GetVariableNameAndSetValues(int row, int col, string stringValue, string sheetName)
        {

            #region Prepaid Charges

            if (sheetName == "PrepaidCharges")
            {
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
                if (col == 16) PrepaidCustomName = stringValue;
                if (col == 17) PrepaidCustomValue = stringValue;
                if (col == 18) DisclosedFinanceCharge = stringValue;
                if (col == 19) DisclosedPrepaidCharge = stringValue;
                if (col == 20) DisclosedAmountFinanced = stringValue;
                if (col == 21) FinanceCharge = stringValue;
                if (col == 22) PrepaidCharges = stringValue;
                if (col == 23) AmountFinanced = stringValue;
            }

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
                if (col == 26) DisclosedFinalBalloonPayment = stringValue;
                if (col == 27) DisclosedTotalOfPayment = stringValue;
                if (col == 28) PrincipalAndInt = stringValue;
                if (col == 29) Pmi = stringValue;
                if (col == 30) DropOffYearsForPmi = stringValue;
                if (col == 31) TotalPeriodPayment = stringValue;
                if (col == 32) Apr = stringValue;
                if (col == 33) BalloonAmount = stringValue;
                if (col == 34) TotalOfPayments = stringValue;
                if (col == 35) FinanceCharge = stringValue;
                if (col == 36) PrepaidCharges = stringValue;
                if (col == 37) AmountFinanced = stringValue;
                if (col == 38) EscrowPropertyOverOneYear = stringValue;
                if (col == 39) Tip = stringValue;
                if (col == 40) InitialEscrowPayment = stringValue;
                if (col == 41) NonEscrowPropertyOverOneYear = stringValue;
                if (col == 42) PeriodEscrowPayment = stringValue;    
            }

            #endregion


            #region Mortgage Insurance

            if (sheetName == "MortgageInsurance")
            {               
                if (col == 2)
                {
                    FirstRow = stringValue;
                    var splitString = FirstRow.Split(',');
                    FirstAddNumber = splitString[0];
                    FirstAddBeginPeriod = splitString[1];
                    FirstAddEndPeriod = splitString[2];
                    FirstAddPmiRate = splitString[3];
                }
                if (col == 3)
                {
                    SecondRow = stringValue;
                    var splitString = SecondRow.Split(',');
                    SecondAddNumber = splitString[0];
                    SecondAddBeginPeriod = splitString[1];
                    SecondAddEndPeriod = splitString[2];
                    SecondAddPmiRate = splitString[3];
                }
                if (col == 4)
                {
                    ThirdRow = stringValue;
                    var splitString = ThirdRow.Split(',');
                    ThirdAddNumber = splitString[0];
                    ThirdAddBeginPeriod = splitString[1];
                    ThirdAddEndPeriod = splitString[2];
                    ThirdAddPmiRate = splitString[3];
                }         

                if (col == 5) NoOfPrdsOfAdvcInsurance = stringValue;
                if (col == 6) LowerOfCostOfAppraisal = stringValue;
                if (col == 7) Pmi = stringValue;
                if (col == 8) DropOffYearsForPmi = stringValue;
                if (col == 9) TotalPeriodPayment = stringValue;
                if (col == 10) TotalOfPayments = stringValue;
                if (col == 11) AmountFinanced = stringValue;
                if (col == 12) Apr = stringValue;
            }

            #endregion


            #region Export

            if (sheetName == "Export")
            {
                if (col == 2) LoanIdNumber = stringValue;
                if (col == 3) BorrowersNames = stringValue;
                if (col == 4) PreparedBy = stringValue;
                if (col == 5) NameOfLender = stringValue;
                if (col == 6) OriginalCreditor = stringValue;
            }

            #endregion



            #region Escrow

            if (sheetName == "Escrow")
            {
                if (col == 2) IsINSEscrowed = stringValue;
                if (col == 3) IsTaxEscrowed = stringValue;
                if (col == 4) FrequencyOfPayment = stringValue;
                if (col == 5) EscrowCalculationStartPeriodDate = stringValue;
                if (col == 6) CushionMonthsForInsurance = stringValue;
                if (col == 7) CushionMonthsForTax = stringValue;
                if (col == 8) CushionMonthsForPMI = stringValue;
                if (col == 9) EscrowInstallmentInputsNumber = stringValue;
                if (col == 10) DateForEscrowInsurance = stringValue;
                if (col == 11) InsuranceInstallmentAmount = stringValue;
                if (col == 12) EscrowTaxCalculationsInputsNumber = stringValue;
                if (col == 13) EscrowTaxCalculationsInputsDate = stringValue;
                if (col == 14) EscrowTaxCalculationsInputsTaxInstallmentAmount = stringValue;
                if (col == 15) EscrowInputForPMICalculationEscrowPMIDate = stringValue;
                if (col == 16) EscrowInputForPMICalculationEscrowPMIAmount = stringValue;
                if (col == 17) EscrowPropertyOverOneYear = stringValue;
                if (col == 18) NonEscrowPropertyOverOneYear = stringValue;
                if (col == 19) InitialEscrowPayment = stringValue;
                if (col == 20) MonthlyEscrowPayment = stringValue;
                if (col == 21) DisclosedEscrowPropertyOverOneYear = stringValue;
                if (col == 22) DisclosedNonEscrowPropertyOverOneYear = stringValue;
                if (col == 23) DisclosedInitialEscrowPayment = stringValue;
                if (col == 24) DisclosedMonthlyEscrowPayment = stringValue;
                if (col == 25) InsuranceInfoAdjustmentBalance = stringValue;
                if (col == 26) InsuranceInfoMinimumAmount = stringValue;
                if (col == 27) InsuranceInfoCushionAmount = stringValue;
                if (col == 28) InsuranceTotalInfoPeriodInsuranceAmount = stringValue;
                if (col == 29) InsuranceTotalInfoInputInsuranceAmount = stringValue;
                if (col == 30) TaxInfoAdjustmentBalance = stringValue;
                if (col == 31) TaxInfoMinimumAmount = stringValue;
                if (col == 32) TaxInfoCushionAmounts = stringValue;
                if (col == 33) TaxTotalInfoPeriodTaxAmount = stringValue;
                if (col == 34) TaxTotalInfoInputTaxAmount = stringValue;
                if (col == 35) PMIInfoAdjustmentBalance = stringValue;
                if (col == 36) PMIInfoMinimumAmount = stringValue;
                if (col == 37) PMInfoCushionAmount = stringValue;
                if (col == 38) PMITotalInfoPeriodOMIAmount = stringValue;
                if (col == 39) PMITotalInfoInputTaxAmount = stringValue;
                if (col == 40) AggregateInfoAdjustmentBalance = stringValue;
                if (col == 41) AggregateInfoMinimumAmount = stringValue;
                if (col == 42) AggregateInfoCushionAmount = stringValue;
                if (col == 43) AggregateTotalInfoAgregatePayment = stringValue;
                if (col == 44) AggregateTotalInfoAggregateDeposit = stringValue;
                if (col == 45) EscrowPropertyOverOneYear = stringValue;
                if (col == 46) NonEscrowPropertyOverOneYear = stringValue;
                if (col == 47) InitialEscrowPayment = stringValue;
                if (col == 48) PeriodEscrowPayment = stringValue;
            }

            #endregion

        }
    }
}