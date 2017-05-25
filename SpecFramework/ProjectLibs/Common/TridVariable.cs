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
        public static string NumberOfPayments = "";
        public static string BaseLoanAmount = "";
        public static string UpfrontLoanFactor = "";
        public static string RateOfInterest = "";
        public static string UpfrontMip = "";
        public static string UpfrontMipFinanced = "";
        public static string DateOfLoan = "";
        public static string DateInterestBeginToAccrue = "";
        public static string DateOfFirstPayment = "";
        public static string PeriodPayment = "";
        public static string LoanCosts = "";
        public static string OddDaysInterestCollected = "";
        public static string LoanDetailsEstimatedEscrow = "";
        public static string MonthlyPrincipalAndInterest = "";
        public static string MonthlyPmi = "";
        public static string TotalPeiodicPayment = "";
        public static string PmiTerminationDate = "";
        public static string PmiCancelDate = "";
        public static string DisclosedEstimatedEscrow = "";
        public static string DisclosedFinalBalloonPayment = "";
        public static string DisclosedTotalOfPayment = "";
        public static string BalloonAmount = "";
        public static string EscrowPropertyOver1Year11Months = "";
        public static string EscrowPropertyOver1Year12Months = "";
        public static string NonEscrowPropertyOverOneYear = "";
        public static string InitialEscrowPayment = "";
        public static string MonthlyEscrowPayment = "";
        public static string PrincipalAndInt = "";
        public static string MortgageInsurance = "";
        public static string EstimatedTotalMonthlyPayment = "";
        public static string ScheduledPmiTerminationDate = "";
        public static string EstimatedEscrow = "";
        public static string FinanceCharge = "";
        public static string PrepaidCharges = "";
        public static string AmountFinanced = "";
        public static string Apr = "";
        public static string Tip = "";
        public static string EstimatedTaxesInsuranceAssessments = "";
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
        public static string NumberOfPrdsOfAdvcInsurance = "";
        public static string LowerOfCostOfAppraisal = "";
        public static string TotalMiInSectionFPrepaids = "";
        public static string TotalMiInSectionGEscrow = "";
        public static string FhaVaUsdaUpfrontPmiFree = "";
        public static string FloodFee = "";
        public static string InspectionFee = "";
        public static string LoanOriginationFee = "";
        public static string OtherFees = "";
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
        public static string IsInsEscrowed = "";
        public static string IsTaxEscrowed = "";
        public static string IsOther1Escrowed = "";
        public static string IsOther2Escrowed = "";
        public static string FrequencyOfPayment	=	"";
        public static string EscrowCalculationStartPeriodDate	= "";
        public static string CushionMonthsForInsurance	=	"";
        public static string CushionMonthsForTax	= "";
        public static string CushionMonthsForOther1 = "";
        public static string CushionMonthsForOther2 = "";
        public static string EscrowInstallmentInputsNumber	= "";
        public static string DateForEscrowInsurance	=	"";
        public static string InsuranceInstallmentAmount	=	"";
        public static string EscrowTaxCalculationsInputsNumberFR	= "";
        public static string EscrowTaxCalculationsInputsDateFR	= "";
        public static string EscrowTaxCalculationsInputsTaxInstallmentAmountFR	= "";
        public static string EscrowTaxCalculationsInputsNumberSR = "";
        public static string EscrowTaxCalculationsInputsDateSR = "";
        public static string EscrowTaxCalculationsInputsTaxInstallmentAmountSR = "";
        public static string EscrowOther1CalculationsInputsNumber = "";
        public static string EscrowOther1CalculationsInputsDate = "";
        public static string EscrowOther1CalculationsInputsAmount = "";
        public static string EscrowOther2CalculationsInputsNumber = "";
        public static string EscrowOther2CalculationsInputsDate = "";
        public static string EscrowOther2CalculationsInputsAmount = "";

        public static string DisclosedEscrowPropertyOverOneYear11Months =	"";
        public static string DisclosedEscrowPropertyOverOneYear12Months =	"";
        public static string DisclosedNonEscrowPropertyOverOneYear	=	"";
        public static string DisclosedInitialEscrowPayment	=	"";
        public static string DisclosedPeriodEscrowPayment	=	"";
        public static string DisclosedEstimatedTaxesInsuranceAssessments =	"";
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
        public static string PmiInfoAdjustmentBalance	=	"";
        public static string PmiInfoMinimumAmount	=	"";
        public static string PmInfoCushionAmount	=	"";
        public static string PmiTotalInfoPeriodOmiAmount	=	"";
        public static string PmiTotalInfoInputTaxAmount	=	"";
        public static string AggregateInfoAdjustmentBalance	=	"";
        public static string AggregateInfoMinimumAmount	=	"";
        public static string AggregateInfoCushionAmount	=	"";
        public static string AggregateTotalInfoAgregatePayment	=	"";
        public static string AggregateTotalInfoAggregateDeposit	=	"";
        public static string TotalOfPayments = "";
        public static string FirstTermChange = "";
        public static string SubsequentTermChange = "";
        public static string DnRateCapFirstAdjustment = "";
        public static string DnRateCapsubsequentAdjustment = "";
        public static string UpRateCapFirstAdjustment = "";
        public static string UpRateCapsubsequentAdjustment = "";
        public static string FloorRate = "";
        public static string MaxRateEver = "";
        public static string Index = "";
        public static string Margin = "";
        public static string RoundingFactor = "";
        public static string VariancePrincipalAndInt = "";
        public static string VarianceMortgageInsurance = "";
        public static string VarianceScheduledPmiTerminationDate = "";
        public static string VarianceEstimatedTotalMonthlyPayment = "";
        public static string VarianceFinanceCharge = "";
        public static string VariancePrepaidCharges = "";
        public static string VarianceAmountFinanced = "";
        public static string VarianceApr = "";
        public static string VarianceTip = "";
        public static string VarianceIn5Years = "";
        public static string VarianceIn5YearsPrincipal = "";
        public static string VarianceBalloonAmount = "";
        public static string VarianceEscrowPropertyOver1Year11Months = "";
        public static string VarianceEscrowPropertyOver1Year12Months = "";
        public static string VarianceNonEscrowPropertyOverOneYear = "";
        public static string VarianceInitialEscrowPayment = "";
        public static string VarianceEstimatedEscrow = "";
        public static string VarianceEstimatedTaxesInsuranceAssessments = "";
        public static string VarianceTotalOfPayments = "";



        #endregion

        public void GetVariableNameAndSetValues(int row, int col, string stringValue, string sheetName)
        {

            #region Prepaid Charges

            if (sheetName == "PrepaidCharges")
            {
                if (col == 3) FhaVaUsdaUpfrontPmiFree = stringValue;
                if (col == 4) FloodFee = stringValue;
                if (col == 5) InspectionFee = stringValue;
                if (col == 6) LoanOriginationFee = stringValue;
                if (col == 7) OtherFees = stringValue;
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
                if (col == 18) TotalMiInSectionFPrepaids = stringValue;
                if (col == 19) TotalMiInSectionGEscrow = stringValue;
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

                if (col == 5) NumberOfPrdsOfAdvcInsurance = stringValue;
                if (col == 6) LowerOfCostOfAppraisal = stringValue;            
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

            #region Variable Loan Details

            if (sheetName == "Variable Loan Details")
            {
                if (col == 3)  FirstTermChange = stringValue;
                if (col == 4)  SubsequentTermChange = stringValue;
                if (col == 5)  DnRateCapFirstAdjustment = stringValue;
                if (col == 6)  DnRateCapsubsequentAdjustment = stringValue;
                if (col == 7)  UpRateCapFirstAdjustment = stringValue;
                if (col == 8)  UpRateCapsubsequentAdjustment = stringValue;
                if (col == 9)  FloorRate = stringValue;
                if (col == 10)  MaxRateEver = stringValue;
                if (col == 11) Index = stringValue;
                if (col == 12) Margin = stringValue;
                if (col == 13) RoundingFactor = stringValue;
            }

            #endregion      

            //#region Tim Closing Disclosure Scenarios

            //if (sheetName == "ClosingDisclosure")
            //{
            //    if (col == 4) CalculationMethod = stringValue;
            //    if (col == 5) LoanType = stringValue;
            //    if (col == 6) FrequencyOfPayments = stringValue;
            //    if (col == 7) LoanTerm = stringValue;
            //    if (col == 8) AdvanceType = stringValue;
            //    if (col == 9) RepaymentTermType = stringValue;
            //    if (col == 10) FrequencyOfPmtValue = stringValue;
            //    if (col == 11) LoanTermValue = stringValue;
            //    if (col == 12) NumberOfPayments = stringValue;
            //    if (col == 13) BaseLoanAmount = stringValue;
            //    if (col == 14) UpfrontLoanFactor = stringValue;
            //    if (col == 15) RateOfInterest = stringValue;
            //    if (col == 16) UpfrontMip = stringValue;
            //    if (col == 17) UpfrontMipFinanced = stringValue;
            //    if (col == 18) DateOfLoan = stringValue;
            //    if (col == 19) DateInterestBeginToAccrue = stringValue;
            //    if (col == 20) DateOfFirstPayment = stringValue;
            //    if (col == 21) PeriodPayment = stringValue;
            //    if (col == 22) LoanCosts = stringValue;
            //    if (col == 23) OddDaysInterestCollected = stringValue;
            //    if (col == 24) MonthlyPrincipalAndInterest = stringValue;
            //    if (col == 25) MonthlyPmi = stringValue;
            //    if (col == 27) TotalPeiodicPayment = stringValue;
            //    if (col == 28) PmiTerminationDate = stringValue;
            //    if (col == 29) PmiCancelDate = stringValue;
            //    if (col == 30) DisclosedFinalBalloonPayment = stringValue;
            //    if (col == 31) DisclosedTotalOfPayment = stringValue;
            //    if (col == 32) DisclosedFinanceCharge = stringValue;
            //    if (col == 33) DisclosedPrepaidCharge = stringValue;
            //    if (col == 34) DisclosedAmountFinanced = stringValue;
            //    if (col == 35) DiscLosedIn5Years = stringValue;
            //    if (col == 36) DiscLosedIn5YearsPrincipal = stringValue;
            //    if (col == 37) DisclosedApr = stringValue;
            //    if (col == 38) DisclosedTip = stringValue;
            //    if (col == 39) IsInsEscrowed = stringValue;
            //    if (col == 40) IsTaxEscrowed = stringValue;
            //    if (col == 41) IsPmiEscrowed = stringValue;
            //    if (col == 42) CushionMonthsForInsurance = stringValue;
            //    if (col == 43) CushionMonthsForTax = stringValue;
            //    if (col == 44) EscrowInstallmentInputsNumber = stringValue;
            //    if (col == 45) DateForEscrowInsurance = stringValue;
            //    if (col == 46) InsuranceInstallmentAmount = stringValue;
            //    if (col == 47) EscrowTaxCalculationsInputsNumberFR = stringValue;
            //    if (col == 48) EscrowTaxCalculationsInputsDateFR = stringValue;
            //    if (col == 49) EscrowTaxCalculationsInputsTaxInstallmentAmountFR = stringValue;
            //    if (col == 50) EscrowTaxCalculationsInputsNumberSR = stringValue;
            //    if (col == 51) EscrowTaxCalculationsInputsDateSR = stringValue;
            //    if (col == 52) EscrowTaxCalculationsInputsTaxInstallmentAmountSR = stringValue;
            //    if (col == 53) EscrowPropertyOverOneYear = stringValue;
            //    if (col == 54) NonEscrowPropertyOverOneYear = stringValue;
            //    if (col == 55) InitialEscrowPayment = stringValue;
            //    if (col == 56) MonthlyEscrowPayment = stringValue;
            //    if (col == 57) DisclosedEscrowPropertyOverOneYear = stringValue;
            //    if (col == 58) DisclosedNonEscrowPropertyOverOneYear = stringValue;
            //    if (col == 59) DisclosedInitialEscrowPayment = stringValue;
            //    if (col == 60) DisclosedMonthlyEscrowPayment = stringValue;
            //    if (col == 61) DisclosedEstimatedEscrow = stringValue;
            //    if (col == 62) PrincipalAndInt = stringValue;
            //    if (col == 63) Pmi = stringValue;
            //    if (col == 64) DropOffYearsForPmi = stringValue;
            //    if (col == 65) TotalPeriodPayment = stringValue;
            //    if (col == 66) Apr = stringValue;
            //    if (col == 67) BalloonAmount = stringValue;
            //    if (col == 68) TotalOfPayments = stringValue;
            //    if (col == 69) FinanceCharge = stringValue;
            //    if (col == 70) PrepaidCharges = stringValue;
            //    if (col == 71) AmountFinanced = stringValue;
            //    if (col == 72) Tip = stringValue;
            //    if (col == 73) EscrowPropertyOverOneYear = stringValue;
            //    if (col == 74) InitialEscrowPayment = stringValue;
            //    if (col == 75) NonEscrowPropertyOverOneYear = stringValue;
            //    if (col == 76) PeriodEscrowPayment = stringValue;
            //    if (col == 77) In5Years = stringValue;
            //    if (col == 78) In5YearsPrincipal = stringValue;
            //    if (col == 79) VariancePrincipalAndInt = stringValue;
            //    if (col == 80) VariancePmi = stringValue;
            //    if (col == 81) VarianceDropOffYearsForPmi = stringValue;
            //    if (col == 82) VarianceTotalPeriodPayment = stringValue;
            //    if (col == 83) VarianceApr = stringValue;
            //    if (col == 84) VarianceBalloonAmount = stringValue;
            //    if (col == 85) VarianceTotalOfPayments = stringValue;
            //    if (col == 86) VarianceFinanceCharge = stringValue;
            //    if (col == 87) VariancePrepaidCharges = stringValue;
            //    if (col == 88) VarianceAmountFinanced = stringValue;
            //    if (col == 89) VarianceTip = stringValue;
            //    if (col == 90) VarianceEscrowPropertyOverOneYear = stringValue;
            //    if (col == 91) VarianceInitialEscrowPayment = stringValue;
            //    if (col == 92) VarianceNonEscrowPropertyOverOneYear = stringValue;
            //    if (col == 93) VariancePeriodEscrowPayment = stringValue;
            //    if (col == 94) VarianceIn5Years = stringValue;
            //    if (col == 95) VarianceIn5YearsPrincipal = stringValue;

            //    #endregion

                #region Tim Closing Disclosure Scenarios

                if (sheetName == "ClosingDisclosure")
                {
                    if (col == 4) CalculationMethod = stringValue;
                    if (col == 5) LoanType = stringValue;
                    if (col == 6) FrequencyOfPayments = stringValue;
                    if (col == 7) LoanTerm = stringValue;
                    if (col == 8) AdvanceType = stringValue;
                    if (col == 9) RepaymentTermType = stringValue;
                    if (col == 10) FrequencyOfPmtValue = stringValue;
                    if (col == 11) LoanTermValue = stringValue;
                    if (col == 12) NumberOfPayments = stringValue;
                    if (col == 13) BaseLoanAmount = stringValue;
                    if (col == 14) UpfrontLoanFactor = stringValue;
                    if (col == 15) RateOfInterest = stringValue;
                    if (col == 16) UpfrontMip = stringValue;
                    if (col == 17) UpfrontMipFinanced = stringValue;
                    if (col == 18) DateOfLoan = stringValue;
                    if (col == 19) DateInterestBeginToAccrue = stringValue;
                    if (col == 20) DateOfFirstPayment = stringValue;
                    if (col == 21) PeriodPayment = stringValue;
                    if (col == 22) LoanCosts = stringValue;
                    if (col == 23) OddDaysInterestCollected = stringValue;
                    if (col == 24) MonthlyPrincipalAndInterest = stringValue;
                    if (col == 25) MonthlyPmi = stringValue;
                    if (col == 27) TotalPeiodicPayment = stringValue;
                    if (col == 28) PmiTerminationDate = stringValue;
                    if (col == 29) PmiCancelDate = stringValue;
                    if (col == 30) DisclosedFinalBalloonPayment = stringValue;
                    if (col == 31) DisclosedTotalOfPayment = stringValue;
                    if (col == 32) DisclosedFinanceCharge = stringValue;
                    if (col == 33) DisclosedPrepaidCharge = stringValue;
                    if (col == 34) DisclosedAmountFinanced = stringValue;
                    if (col == 35) DiscLosedIn5Years = stringValue;
                    if (col == 36) DiscLosedIn5YearsPrincipal = stringValue;
                    if (col == 37) DisclosedApr = stringValue;
                    if (col == 38) DisclosedTip = stringValue;
                    if (col == 39) IsInsEscrowed = stringValue;
                    if (col == 40) IsTaxEscrowed = stringValue;
                    if (col == 41) IsOther1Escrowed = stringValue;
                    if (col == 42) IsOther2Escrowed = stringValue;
                    if (col == 43) CushionMonthsForInsurance = stringValue;
                    if (col == 44) CushionMonthsForTax = stringValue;
                    if (col == 45) CushionMonthsForOther1 = stringValue;
                    if (col == 46) CushionMonthsForOther2 = stringValue;
                    if (col == 47) EscrowInstallmentInputsNumber = stringValue;
                    if (col == 48) DateForEscrowInsurance = stringValue;
                    if (col == 49) InsuranceInstallmentAmount = stringValue;
                    if (col == 50) EscrowTaxCalculationsInputsNumberFR = stringValue;
                    if (col == 51) EscrowTaxCalculationsInputsDateFR = stringValue;
                    if (col == 52) EscrowTaxCalculationsInputsTaxInstallmentAmountFR = stringValue;
                    if (col == 53) EscrowTaxCalculationsInputsNumberSR = stringValue;
                    if (col == 54) EscrowTaxCalculationsInputsDateSR = stringValue;
                    if (col == 55) EscrowTaxCalculationsInputsTaxInstallmentAmountSR = stringValue;
                    if (col == 56) EscrowOther1CalculationsInputsNumber = stringValue;
                    if (col == 57) EscrowOther1CalculationsInputsDate = stringValue;
                    if (col == 58) EscrowOther1CalculationsInputsAmount = stringValue;
                    if (col == 59) EscrowOther2CalculationsInputsNumber = stringValue;
                    if (col == 60) EscrowOther2CalculationsInputsDate = stringValue;
                    if (col == 61) EscrowOther2CalculationsInputsAmount = stringValue;
                    if (col == 62) DisclosedEscrowPropertyOverOneYear11Months = stringValue;
                    if (col == 63) DisclosedEscrowPropertyOverOneYear12Months = stringValue;
                    if (col == 64) DisclosedNonEscrowPropertyOverOneYear = stringValue;
                    if (col == 65) DisclosedInitialEscrowPayment = stringValue;
                    if (col == 66) DisclosedPeriodEscrowPayment = stringValue;
                    if (col == 67) DisclosedEstimatedTaxesInsuranceAssessments = stringValue;
                    if (col == 68) PrincipalAndInt = stringValue;
                    if (col == 69) MortgageInsurance = stringValue;
                    if (col == 70) ScheduledPmiTerminationDate = stringValue;
                    if (col == 71) EstimatedTotalMonthlyPayment = stringValue;
                    if (col == 72) Apr = stringValue;
                    if (col == 73) BalloonAmount = stringValue;
                    if (col == 74) TotalOfPayments = stringValue;
                    if (col == 75) FinanceCharge = stringValue;
                    if (col == 76) PrepaidCharges = stringValue;
                    if (col == 77) AmountFinanced = stringValue;
                    if (col == 78) Tip = stringValue;
                    if (col == 79) EscrowPropertyOver1Year11Months = stringValue;
                    if (col == 80) EscrowPropertyOver1Year12Months = stringValue;
                    if (col == 81) InitialEscrowPayment = stringValue;
                    if (col == 82) NonEscrowPropertyOverOneYear = stringValue;
                    if (col == 83) EstimatedEscrow = stringValue;
                    if (col == 84) EstimatedTaxesInsuranceAssessments = stringValue;
                    if (col == 85) In5Years = stringValue;
                    if (col == 86) In5YearsPrincipal = stringValue;
                    if (col == 87) VariancePrincipalAndInt = stringValue;
                    if (col == 88) VarianceMortgageInsurance = stringValue;
                    if (col == 89) VarianceScheduledPmiTerminationDate = stringValue;
                    if (col == 90) VarianceEstimatedTotalMonthlyPayment = stringValue;
                    if (col == 91) VarianceApr = stringValue;
                    if (col == 92) VarianceBalloonAmount = stringValue;
                    if (col == 93) VarianceTotalOfPayments = stringValue;
                    if (col == 94) VarianceFinanceCharge = stringValue;
                    if (col == 95) VariancePrepaidCharges = stringValue;
                    if (col == 96) VarianceAmountFinanced = stringValue;
                    if (col == 97) VarianceTip = stringValue;
                    if (col == 98) VarianceEscrowPropertyOver1Year11Months = stringValue;
                    if (col == 99) VarianceEscrowPropertyOver1Year12Months = stringValue;
                    if (col == 100) VarianceInitialEscrowPayment = stringValue;
                    if (col == 101) VarianceNonEscrowPropertyOverOneYear = stringValue;
                    if (col == 102) VarianceEstimatedEscrow = stringValue;
                    if (col == 103) VarianceEstimatedTaxesInsuranceAssessments = stringValue;
                    if (col == 104) VarianceIn5Years = stringValue;
                    if (col == 105) VarianceIn5YearsPrincipal = stringValue;

                    #endregion
                }
            }
    }
}