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
        public static string NumberOfPrdsOfAdvcInsurance = "";
        public static string LowerOfCostOfAppraisal = "";
        public static string TotalMiInSectionFPrepaids = "";
        public static string TotalMiInSectionGEscrow = "";
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
        public static string IsInsEscrowed = "";
        public static string IsTaxEscrowed = "";
        public static string IsPmiEscrowed = "";
        public static string FrequencyOfPayment	=	"";
        public static string EscrowCalculationStartPeriodDate	= "";
        public static string CushionMonthsForInsurance	=	"";
        public static string CushionMonthsForTax	= "";
        public static string CushionMonthsForPmi	= "";
        public static string EscrowInstallmentInputsNumber	= "";
        public static string DateForEscrowInsurance	=	"";
        public static string InsuranceInstallmentAmount	=	"";
        public static string EscrowTaxCalculationsInputsNumberFR	= "";
        public static string EscrowTaxCalculationsInputsDateFR	= "";
        public static string EscrowTaxCalculationsInputsTaxInstallmentAmountFR	= "";
        public static string EscrowTaxCalculationsInputsNumberSR = "";
        public static string EscrowTaxCalculationsInputsDateSR = "";
        public static string EscrowTaxCalculationsInputsTaxInstallmentAmountSR = "";
        public static string EscrowInputForPmiCalculationEscrowPmiDate	=	"";
        public static string EscrowInputForPmiCalculationEscrowPmiAmount	=	"";

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
        public static string VariancePmi = "";
        public static string VarianceTotalPeriodPayment = "";
        public static string VarianceDropOffYearsForPmi = "";
        public static string VariancePeriodEscrowPayment = "";
        public static string VarianceFinanceCharge = "";
        public static string VariancePrepaidCharges = "";
        public static string VarianceAmountFinanced = "";
        public static string VarianceApr = "";
        public static string VarianceTip = "";
        public static string VarianceIn5Years = "";
        public static string VarianceIn5YearsPrincipal = "";
        public static string VarianceBalloonAmount = "";
        public static string VarianceEscrowPropertyOverOneYear = "";
        public static string VarianceNonEscrowPropertyOverOneYear = "";
        public static string VarianceInitialEscrowPayment = "";
        public static string VarianceTotalOfPayments = "";



        #endregion

        public void GetVariableNameAndSetValues(int row, int col, string stringValue, string sheetName)
        {

            #region Prepaid Charges

            if (sheetName == "PrepaidCharges")
            {
                if (col == 3 ) FhaVaUsdaUpfrontPmiFree = stringValue;
                if (col == 4 ) FloodFee = stringValue;
                if (col == 5 ) InspectionFee = stringValue;
                if (col == 6 ) LoanOriginationFee = stringValue;
                if (col == 7 ) OtherFees = stringValue;
                if (col == 8 ) PmiEscrowed = stringValue;
                if (col == 9 ) PrepaidDailyInterest = stringValue;
                if (col == 10) TaxServicing = stringValue;
                if (col == 11) TitleClosingFee = stringValue;
                if (col == 12) TitleClosingProtectionLetter = stringValue;
                if (col == 13) TitleCourierFee = stringValue;
                if (col == 14) TitleDrawFee = stringValue;
                if (col == 15) TitleWireFee = stringValue;
                if (col == 16) UnderWriting = stringValue;
                if (col == 17) PrepaidCustomName = stringValue;
                if (col == 18) PrepaidCustomValue = stringValue;
                if (col == 19) TotalMiInSectionFPrepaids = stringValue;
                if (col == 20) TotalMiInSectionGEscrow = stringValue;
            }

            #endregion


            //#region Loan Estimate

            //if (sheetName == "LoanEstimate")
            //{
            //    if (col == 2) CalculationMethod = stringValue;
            //    if (col == 3) LoanType = stringValue;
            //    if (col == 4) FrequencyOfPayments = stringValue;
            //    if (col == 5) LoanTerm = stringValue;
            //    if (col == 6) AdvanceType = stringValue;
            //    if (col == 7) RepaymentTermType = stringValue;
            //    if (col == 8) FrequencyOfPmtValue = stringValue;
            //    if (col == 9) LoanTermValue = stringValue;
            //    if (col == 10) LoanAmount = stringValue;
            //    if (col == 11) RateOfInterest = stringValue;
            //    if (col == 12) DateOfLoan = stringValue;
            //    if (col == 13) DateInterestBeginToAccrue = stringValue;
            //    if (col == 14) DateOfFirstPayment = stringValue;
            //    if (col == 15) PeriodPayment = stringValue;
            //    if (col == 16) LoanCosts = stringValue;
            //    //if (col == 17) FinalBalloonPayment = stringValue;
            //    if (col == 18) OddDaysInterestCollected = stringValue;
            //    if (col == 19) LoanDetailsEstimatedEscrow = stringValue;
            //    if (col == 20) DiscLosedIn5Years = stringValue;
            //    if (col == 21) DiscLosedIn5YearsPrincipal = stringValue;
            //    if (col == 22) DisclosedApr = stringValue;
            //    if (col == 23) DisclosedTip = stringValue;
            //    if (col == 24) In5Years = stringValue;
            //    if (col == 25) In5YearsPrincipal = stringValue;
            //    if (col == 26) Apr = stringValue;
            //    if (col == 27) Tip = stringValue;
            //}

            //#endregion


            //#region Closing Disclosure

            //if (sheetName == "ClosingDisclosure")
            //{
            //    if (col == 2) CalculationMethod = stringValue;
            //    if (col == 3) LoanType = stringValue;
            //    if (col == 4) FrequencyOfPayments = stringValue;
            //    if (col == 5) LoanTerm = stringValue;
            //    if (col == 6) AdvanceType = stringValue;
            //    if (col == 7) RepaymentTermType = stringValue;
            //    if (col == 8) FrequencyOfPmtValue = stringValue;
            //    if (col == 9) LoanTermValue = stringValue;
            //    if (col == 10) LoanAmount = stringValue;
            //    if (col == 11) RateOfInterest = stringValue;
            //    if (col == 12) DateOfLoan = stringValue;
            //    if (col == 13) DateInterestBeginToAccrue = stringValue;
            //    if (col == 14) DateOfFirstPayment = stringValue;
            //    if (col == 15) PeriodPayment = stringValue;
            //    if (col == 16) LoanCosts = stringValue;
            //    if (col == 17) OddDaysInterestCollected = stringValue;
            //    if (col == 18) MonthlyPrincipalAndInterest = stringValue;
            //    if (col == 19) MonthlyPmi = stringValue;
            //    if (col == 20) TotalMonhtlyPayment = stringValue;
            //    if (col == 21) PmiTerminationDate = stringValue;
            //    if (col == 22) PmiCancelDate = stringValue;
            //    if (col == 23) DisclosedFinalBalloonPayment = stringValue;
            //    if (col == 24) DisclosedTotalOfPayment = stringValue;
            //    if (col == 25) PrincipalAndInt = stringValue;
            //    if (col == 26) Pmi = stringValue;
            //    if (col == 27) DropOffYearsForPmi = stringValue;
            //    if (col == 28) TotalPeriodPayment = stringValue;
            //    if (col == 29) Apr = stringValue;
            //    if (col == 30) BalloonAmount = stringValue;
            //    if (col == 31) TotalOfPayments = stringValue;
            //    if (col == 32) FinanceCharge = stringValue;
            //    if (col == 33) PrepaidCharges = stringValue;
            //    if (col == 34) AmountFinanced = stringValue;
            //    if (col == 35) Tip = stringValue;
            //    if (col == 36) EscrowPropertyOverOneYear = stringValue;
            //    if (col == 37) InitialEscrowPayment = stringValue;
            //    if (col == 38) NonEscrowPropertyOverOneYear = stringValue;
            //    if (col == 39) PeriodEscrowPayment = stringValue;    
            //}              
                           
            //#endregion            //#region Closing Disclosure

            //if (sheetName == "ClosingDisclosure")
            //{
            //    if (col == 2) CalculationMethod = stringValue;
            //    if (col == 3) LoanType = stringValue;
            //    if (col == 4) FrequencyOfPayments = stringValue;
            //    if (col == 5) LoanTerm = stringValue;
            //    if (col == 6) AdvanceType = stringValue;
            //    if (col == 7) RepaymentTermType = stringValue;
            //    if (col == 8) FrequencyOfPmtValue = stringValue;
            //    if (col == 9) LoanTermValue = stringValue;
            //    if (col == 10) LoanAmount = stringValue;
            //    if (col == 11) RateOfInterest = stringValue;
            //    if (col == 12) DateOfLoan = stringValue;
            //    if (col == 13) DateInterestBeginToAccrue = stringValue;
            //    if (col == 14) DateOfFirstPayment = stringValue;
            //    if (col == 15) PeriodPayment = stringValue;
            //    if (col == 16) LoanCosts = stringValue;
            //    if (col == 17) OddDaysInterestCollected = stringValue;
            //    if (col == 18) MonthlyPrincipalAndInterest = stringValue;
            //    if (col == 19) MonthlyPmi = stringValue;
            //    if (col == 20) TotalMonhtlyPayment = stringValue;
            //    if (col == 21) PmiTerminationDate = stringValue;
            //    if (col == 22) PmiCancelDate = stringValue;
            //    if (col == 23) DisclosedFinalBalloonPayment = stringValue;
            //    if (col == 24) DisclosedTotalOfPayment = stringValue;
            //    if (col == 25) PrincipalAndInt = stringValue;
            //    if (col == 26) Pmi = stringValue;
            //    if (col == 27) DropOffYearsForPmi = stringValue;
            //    if (col == 28) TotalPeriodPayment = stringValue;
            //    if (col == 29) Apr = stringValue;
            //    if (col == 30) BalloonAmount = stringValue;
            //    if (col == 31) TotalOfPayments = stringValue;
            //    if (col == 32) FinanceCharge = stringValue;
            //    if (col == 33) PrepaidCharges = stringValue;
            //    if (col == 34) AmountFinanced = stringValue;
            //    if (col == 35) Tip = stringValue;
            //    if (col == 36) EscrowPropertyOverOneYear = stringValue;
            //    if (col == 37) InitialEscrowPayment = stringValue;
            //    if (col == 38) NonEscrowPropertyOverOneYear = stringValue;
            //    if (col == 39) PeriodEscrowPayment = stringValue;    
            //}              
                           
            //#endregion


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


            //#region Escrow

            //if (sheetName == "Escrow")
            //{              
            //    if (col == 2) IsInsEscrowed = stringValue;
            //    if (col == 3) IsTaxEscrowed = stringValue;
            //    if (col == 4) IsPmiEscrowed = stringValue;
            //    if (col == 5) CushionMonthsForInsurance = stringValue;
            //    if (col == 6) CushionMonthsForTax = stringValue;
            //    if (col == 7) EscrowInstallmentInputsNumber = stringValue;
            //    if (col == 8) DateForEscrowInsurance = stringValue;
            //    if (col == 9) InsuranceInstallmentAmount = stringValue;
            //    if (col == 10) EscrowTaxCalculationsInputsNumberFR = stringValue;
            //    if (col == 11) EscrowTaxCalculationsInputsDateFR = stringValue;
            //    if (col == 12) EscrowTaxCalculationsInputsTaxInstallmentAmountFR = stringValue;
            //    if (col == 13) EscrowTaxCalculationsInputsNumberSR = stringValue;
            //    if (col == 14) EscrowTaxCalculationsInputsDateSR = stringValue;
            //    if (col == 15) EscrowTaxCalculationsInputsTaxInstallmentAmountSR = stringValue;
            //    if (col == 16) EscrowPropertyOverOneYear = stringValue;
            //    if (col == 17) NonEscrowPropertyOverOneYear = stringValue;
            //    if (col == 18) InitialEscrowPayment = stringValue;
            //    if (col == 19) MonthlyEscrowPayment = stringValue;
            //    if (col == 20) DisclosedEscrowPropertyOverOneYear = stringValue;
            //    if (col == 21) DisclosedNonEscrowPropertyOverOneYear = stringValue;
            //    if (col == 22) DisclosedInitialEscrowPayment = stringValue;
            //    if (col == 23) DisclosedMonthlyEscrowPayment = stringValue;
            //    if (col == 24) DisclosedEstimatedEscrow = stringValue;
            //    if (col == 25) InsuranceInfoAdjustmentBalance = stringValue;
            //    if (col == 26) InsuranceInfoMinimumAmount = stringValue;
            //    if (col == 27) InsuranceInfoCushionAmount = stringValue;
            //    if (col == 28) InsuranceTotalInfoPeriodInsuranceAmount = stringValue;
            //    if (col == 29) InsuranceTotalInfoInputInsuranceAmount = stringValue;
            //    if (col == 30) TaxInfoAdjustmentBalance = stringValue;
            //    if (col == 31) TaxInfoMinimumAmount = stringValue;
            //    if (col == 32) TaxInfoCushionAmounts = stringValue;
            //    if (col == 33) TaxTotalInfoPeriodTaxAmount = stringValue;
            //    if (col == 34) TaxTotalInfoInputTaxAmount = stringValue;
            //    if (col == 35) PmiInfoAdjustmentBalance = stringValue;
            //    if (col == 36) PmiInfoMinimumAmount = stringValue;
            //    if (col == 37) PmInfoCushionAmount = stringValue;
            //    if (col == 38) PmiTotalInfoPeriodOmiAmount = stringValue;
            //    if (col == 39) PmiTotalInfoInputTaxAmount = stringValue;
            //    if (col == 40) AggregateInfoAdjustmentBalance = stringValue;
            //    if (col == 41) AggregateInfoMinimumAmount = stringValue;
            //    if (col == 42) AggregateInfoCushionAmount = stringValue;
            //    if (col == 43) AggregateTotalInfoAgregatePayment = stringValue;
            //    if (col == 44) AggregateTotalInfoAggregateDeposit = stringValue;
            //    if (col == 45) EscrowPropertyOverOneYear = stringValue;
            //    if (col == 46) NonEscrowPropertyOverOneYear = stringValue;
            //    if (col == 47) InitialEscrowPayment = stringValue;
            //    if (col == 48) PeriodEscrowPayment = stringValue;
            //}

            //#endregion


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
                if (col == 12) BaseLoanAmount = stringValue;
                if (col == 13) UpfrontLoanFactor = stringValue;
                if (col == 14) RateOfInterest = stringValue;
                if (col == 15) UpfrontMip = stringValue;
                if (col == 16) UpfrontMipFinanced = stringValue;
                if (col == 17) DateOfLoan = stringValue;
                if (col == 18) DateInterestBeginToAccrue = stringValue;
                if (col == 19) DateOfFirstPayment = stringValue;
                if (col == 20) PeriodPayment = stringValue;
                if (col == 21) LoanCosts = stringValue;
                if (col == 22) OddDaysInterestCollected = stringValue;
                if (col == 23) MonthlyPrincipalAndInterest = stringValue;
                if (col == 24) MonthlyPmi = stringValue;
                if (col == 26) TotalPeiodicPayment = stringValue;
                if (col == 27) PmiTerminationDate = stringValue;
                if (col == 28) PmiCancelDate = stringValue;
                if (col == 29) DisclosedFinalBalloonPayment = stringValue;
                if (col == 30) DisclosedTotalOfPayment = stringValue;
                if (col == 31) DisclosedFinanceCharge = stringValue;
                if (col == 32) DisclosedPrepaidCharge = stringValue;
                if (col == 33) DisclosedAmountFinanced = stringValue;
                if (col == 34) DiscLosedIn5Years = stringValue;
                if (col == 35) DiscLosedIn5YearsPrincipal = stringValue;
                if (col == 36) DisclosedApr = stringValue;
                if (col == 37) DisclosedTip = stringValue;
                if (col == 38) IsInsEscrowed = stringValue;
                if (col == 39) IsTaxEscrowed = stringValue;
                if (col == 40) IsPmiEscrowed = stringValue;
                if (col == 41) CushionMonthsForInsurance = stringValue;
                if (col == 42) CushionMonthsForTax = stringValue;
                if (col == 43) EscrowInstallmentInputsNumber = stringValue;
                if (col == 44) DateForEscrowInsurance = stringValue;
                if (col == 45) InsuranceInstallmentAmount = stringValue;
                if (col == 46) EscrowTaxCalculationsInputsNumberFR = stringValue;
                if (col == 47) EscrowTaxCalculationsInputsDateFR = stringValue;
                if (col == 48) EscrowTaxCalculationsInputsTaxInstallmentAmountFR = stringValue;
                if (col == 49) EscrowTaxCalculationsInputsNumberSR = stringValue;
                if (col == 50) EscrowTaxCalculationsInputsDateSR = stringValue;
                if (col == 51) EscrowTaxCalculationsInputsTaxInstallmentAmountSR = stringValue;
                if (col == 52) EscrowPropertyOverOneYear = stringValue;
                if (col == 53) NonEscrowPropertyOverOneYear = stringValue;
                if (col == 54) InitialEscrowPayment = stringValue;
                if (col == 55) MonthlyEscrowPayment = stringValue;
                if (col == 56) DisclosedEscrowPropertyOverOneYear = stringValue;
                if (col == 57) DisclosedNonEscrowPropertyOverOneYear = stringValue;
                if (col == 58) DisclosedInitialEscrowPayment = stringValue;
                if (col == 59) DisclosedMonthlyEscrowPayment = stringValue;
                if (col == 60) DisclosedEstimatedEscrow = stringValue;
                if (col == 61) PrincipalAndInt = stringValue;
                if (col == 62) Pmi = stringValue;
                if (col == 63) DropOffYearsForPmi = stringValue;
                if (col == 64) TotalPeriodPayment = stringValue;
                if (col == 65) Apr = stringValue;
                if (col == 66) BalloonAmount = stringValue;
                if (col == 67) TotalOfPayments = stringValue;
                if (col == 68) FinanceCharge = stringValue;
                if (col == 69) PrepaidCharges = stringValue;
                if (col == 70) AmountFinanced = stringValue;
                if (col == 71) Tip = stringValue;
                if (col == 72) EscrowPropertyOverOneYear = stringValue;
                if (col == 73) InitialEscrowPayment = stringValue;
                if (col == 74) NonEscrowPropertyOverOneYear = stringValue;
                if (col == 75) PeriodEscrowPayment = stringValue;
                if (col == 76) In5Years = stringValue;
                if (col == 77) In5YearsPrincipal = stringValue;
                if (col == 78) VariancePrincipalAndInt = stringValue;
                if (col == 79) VariancePmi = stringValue;
                if (col == 80) VarianceDropOffYearsForPmi = stringValue;
                if (col == 81) VarianceTotalPeriodPayment = stringValue;
                if (col == 82) VarianceApr = stringValue;
                if (col == 83) VarianceBalloonAmount = stringValue;
                if (col == 84) VarianceTotalOfPayments = stringValue;
                if (col == 85) VarianceFinanceCharge = stringValue;
                if (col == 86) VariancePrepaidCharges = stringValue;
                if (col == 87) VarianceAmountFinanced = stringValue;
                if (col == 88) VarianceTip = stringValue;
                if (col == 89) VarianceEscrowPropertyOverOneYear = stringValue;
                if (col == 90) VarianceInitialEscrowPayment = stringValue;
                if (col == 91) VarianceNonEscrowPropertyOverOneYear = stringValue;
                if (col == 92) VariancePeriodEscrowPayment = stringValue;
                if (col == 93) VarianceIn5Years = stringValue;
                if (col == 94) VarianceIn5YearsPrincipal = stringValue;

                #endregion
            }
        }
    }
}