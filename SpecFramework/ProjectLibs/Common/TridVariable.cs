using System.Collections.Generic;
using TechTalk.SpecRun.Helper;
using TRID.ActionClasses;
using TRID.CommonUtils;

namespace TRID.ProjectLibs.Common
{
    public class TridVariable
    {
        #region Assiging Variables 

        public static string ScenarioNo = "";
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
        public static string OddDaysInterestCollected = "";
        public static string LoanDetailsEstimatedEscrow = "";
        public static string DisclosedMonthlyPrincipalAndInterest = "";
        public static string DisclosedMonthlyPmi = "";
        public static string DisclosedTotalPeiodicPayment = "";
        public static string DisclosedPmiTerminationDate = "";
        public static string DisclosedPmiCancelDate = "";
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
        public static string AprWin = "";
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
        public static string OriginationChargePoints = "";
        public static string OriginationChargeOther1 = "";
        public static string OriginationChargeOther2 = "";
        public static string Flood = "";
        public static string FHAUSDA= "";
        public static string TaxServicing= "";
        public static string UpfrontPMIVAGuarantee= "";
        public static string SectionBOther1= "";
        public static string SectionBOther2= "";
        public static string TitleClosingProtectionLetter= "";
        public static string TitleClosingSettlement= "";
        public static string TitleCourierOverNight= "";
        public static string TitleWire= "";
        public static string TitleOther1= "";
        public static string TitleOther2= "";
        public static string SectionCOther1= "";
        public static string SectionCOther2 = "";
        public static string PrepaidDailyInterest= "";
        public static string TotalMiInSectionFPrepaids= "";
        public static string TotalMiInSectionGEscrow= "";
        public static string LoanCostsSumABC= "";
        public static string PrepaidCustomFieldsCustomName= "";
        public static string PrepaidCustomFieldsCustomValue= ""; 
        public static string DisclosedFinanceCharge = "";
        public static string DisclosedPrepaidCharge = "";
        public static string DisclosedAmountFinanced ="";
        public static string LoanIdNumber = "";
        public static string BorrowersNames = "";
        public static string PreparedBy = "";
        public static string NameOfLender = "";
        public static string OriginalCreditor = "";
        public static string LoanSecruredBy = "";
        public static string Export = "";
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
        public static string DateOfFirstMonthlyPmiDisbursement = "";
        public static string InsuranceCostNumber	= "";
        public static string DateInsurancePaidDisbursed	=	"";
        public static string InsuranceAmount	=	"";
        public static string TaxCostNumberFR	= "";
        public static string TaxCostDateFR	= "";
        public static string TaxCostInstallmentAmountFR	= "";
        public static string TaxCostNumberSR = "";
        public static string TaxCostDateSR = "";
        public static string TaxCostInstallmentAmountSR = "";
        public static string OtherCost1Number = "";
        public static string OtherCost1Date = "";
        public static string OtherCost1Amount = "";
        public static string OtherCost2Number = "";
        public static string OtherCost2Date = "";
        public static string OtherCost2Amount = "";
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
        public static List<string> PaymentStreamNo = new List<string>();
        public static List<string> PaymentScheduleNumberOfPayments = new List<string>();
        public static List<string> PaymentAmount = new List<string>();
        public static List<string> MonthlyPayment = new List<string>();
        public static List<string> MonthlyPmi = new List<string>();
        public static List<string> InsEscrowedAmount = new List<string>();
        public static List<string> TaxEscrowedAmount = new List<string>();
        public static string InsInitialDeposit = "";
        public static string InsPeriodDeposit = "";
        public static string InsLowBalance = "";
        public static string InsCushion = "";
        public static string InsTotalAnnualDisbursed = "";
        public static string TaxInitialDeposit = "";
        public static string TaxPeriodDeposit = "";
        public static string TaxLowBalance = "";
        public static string TaxCushion = "";
        public static string TaxTotalAnnualDisbursed = "";
        public static string PmiInitialDeposit = "";
        public static string PmiPeriodDeposit = "";
        public static string PmiLowBalance = "";
        public static string PmiCushion = "";
        public static string PmiTotalAnnualDisbursed = "";
        public static string Other1InitialDeposit = "";
        public static string Other1PeriodDeposit = "";
        public static string Other1LowBalance = "";
        public static string Other1Cushion = "";
        public static string Other1TotalAnnualDisbursed = "";
        public static string Other2InitialDeposit = "";
        public static string Other2PeriodDeposit = "";
        public static string Other2LowBalance = "";
        public static string Other2Cushion = "";
        public static string Other2TotalAnnualDisbursed = "";
        public static string AggregateInitialDeposit = "";
        public static string AggregatePeriodDeposit = "";
        public static string AggregateLowBalance = "";
        public static string AggregateCushion = "";
        public static string AggregateTotalAnnualDisbursed = "";


        #endregion

        public void GetVariableNameAndSetValues(int row, int col, string stringValue, string sheetName)
        {

            #region Prepaid Charges

            if (sheetName == "PrepaidCharges")
            {
                if (col == 4) OriginationChargePoints = stringValue;
                if (col == 5) OriginationChargeOther1 = stringValue;
                if (col == 6) OriginationChargeOther2 = stringValue;
                if (col == 7) Flood = stringValue;
                if (col == 8) FHAUSDA= stringValue;
                if (col == 9) TaxServicing= stringValue;
                if (col == 10) UpfrontPMIVAGuarantee= stringValue;
                if (col == 11) SectionBOther1= stringValue;
                if (col == 12) SectionBOther2= stringValue;
                if (col == 13) TitleClosingProtectionLetter= stringValue;
                if (col == 14) TitleClosingSettlement= stringValue;
                if (col == 15) TitleCourierOverNight= stringValue;
                if (col == 16) TitleWire= stringValue;
                if (col == 17) TitleOther1= stringValue;
                if (col == 18) TitleOther2= stringValue;
                if (col == 19) SectionCOther1= stringValue;
                if (col == 20) SectionCOther2 = stringValue;
                if (col == 21) PrepaidDailyInterest= stringValue;
                if (col == 22) TotalMiInSectionFPrepaids= stringValue;
                if (col == 23) TotalMiInSectionGEscrow= stringValue;
                if (col == 24) LoanCostsSumABC= stringValue;
                if (col == 25) PrepaidCustomFieldsCustomName= stringValue;
                if (col == 26) PrepaidCustomFieldsCustomValue= stringValue;              
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
                if (col == 7) LoanSecruredBy = stringValue;
                if (col == 8) Export = stringValue;
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

            #region Escrow

            if (sheetName == "PaymentSchedule")
            {
                if (col == 2)
                {
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        PaymentStreamNo.Add(rowValue);
                }

                if (col == 3)
                {
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        PaymentScheduleNumberOfPayments.Add(rowValue);
                }
                if (col == 4)
                {
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        PaymentAmount.Add(rowValue);
                }
                if (col == 5)
                {
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        MonthlyPayment.Add(rowValue);
                }
                if (col == 6)
                {
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        MonthlyPmi.Add(rowValue);
                }
                if (col == 7)
                {
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        InsEscrowedAmount.Add(rowValue);
                }
                if (col == 8)
                {
                    var splitString = stringValue.Split(',');
                    foreach (string rowValue in splitString)
                        TaxEscrowedAmount.Add(rowValue);
                }
            }

            #endregion

            #region Tim Closing Disclosure Scenarios

            if (sheetName == "ClosingDisclosure")
            {
                if (col == 1) ScenarioNo = stringValue;
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
                if (col == 22) OddDaysInterestCollected = stringValue;
                if (col == 23) DisclosedMonthlyPrincipalAndInterest = stringValue;
                if (col == 24) DisclosedMonthlyPmi = stringValue;
                if (col == 26) DisclosedTotalPeiodicPayment = stringValue;
                if (col == 27) DisclosedPmiTerminationDate = stringValue;
                if (col == 28) DisclosedPmiCancelDate = stringValue;
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
                if (col == 40) IsOther1Escrowed = stringValue;
                if (col == 41) IsOther2Escrowed = stringValue;
                if (col == 42) CushionMonthsForInsurance = stringValue;
                if (col == 43) CushionMonthsForTax = stringValue;
                if (col == 44) CushionMonthsForOther1 = stringValue;
                if (col == 45) CushionMonthsForOther2 = stringValue;
                if (col == 46) DateOfFirstMonthlyPmiDisbursement = stringValue;
                if (col == 47) InsuranceCostNumber = stringValue;
                if (col == 48) DateInsurancePaidDisbursed = stringValue;
                if (col == 49) InsuranceAmount = stringValue;
                if (col == 50) TaxCostNumberFR = stringValue;
                if (col == 51) TaxCostDateFR = stringValue;
                if (col == 52) TaxCostInstallmentAmountFR = stringValue;
                if (col == 53) TaxCostNumberSR = stringValue;
                if (col == 54) TaxCostDateSR = stringValue;
                if (col == 55) TaxCostInstallmentAmountSR = stringValue;
                if (col == 56) OtherCost1Number = stringValue;
                if (col == 57) OtherCost1Date = stringValue;
                if (col == 58) OtherCost1Amount = stringValue;
                if (col == 59) OtherCost2Number = stringValue;
                if (col == 60) OtherCost2Date = stringValue;
                if (col == 61) OtherCost2Amount = stringValue;
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
                if (col == 73) AprWin = stringValue;
                if (col == 74) BalloonAmount = stringValue;
                if (col == 75) TotalOfPayments = stringValue;
                if (col == 76) FinanceCharge = stringValue;
                if (col == 77) PrepaidCharges = stringValue;
                if (col == 78) AmountFinanced = stringValue;
                if (col == 79) Tip = stringValue;
                if (col == 80) EscrowPropertyOver1Year11Months = stringValue;
                if (col == 81) EscrowPropertyOver1Year12Months = stringValue;
                if (col == 82) InitialEscrowPayment = stringValue;
                if (col == 83) NonEscrowPropertyOverOneYear = stringValue;
                if (col == 84) EstimatedEscrow = stringValue;
                if (col == 85) EstimatedTaxesInsuranceAssessments = stringValue;
                if (col == 86) In5Years = stringValue;
                if (col == 87) In5YearsPrincipal = stringValue;
                if (col == 88) VariancePrincipalAndInt = stringValue;
                if (col == 89) VarianceMortgageInsurance = stringValue;
                if (col == 90) VarianceScheduledPmiTerminationDate = stringValue;
                if (col == 91) VarianceEstimatedTotalMonthlyPayment = stringValue;
                if (col == 92) VarianceApr = stringValue;
                if (col == 93) VarianceBalloonAmount = stringValue;
                if (col == 94) VarianceTotalOfPayments = stringValue;
                if (col == 95) VarianceFinanceCharge = stringValue;
                if (col == 96) VariancePrepaidCharges = stringValue;
                if (col == 97) VarianceAmountFinanced = stringValue;
                if (col == 98) VarianceTip = stringValue;
                if (col == 99) VarianceEscrowPropertyOver1Year11Months = stringValue;
                if (col == 100) VarianceEscrowPropertyOver1Year12Months = stringValue;
                if (col == 101) VarianceInitialEscrowPayment = stringValue;
                if (col == 102) VarianceNonEscrowPropertyOverOneYear = stringValue;
                if (col == 103) VarianceEstimatedEscrow = stringValue;
                if (col == 104) VarianceEstimatedTaxesInsuranceAssessments = stringValue;
                if (col == 105) VarianceIn5Years = stringValue;
                if (col == 106) VarianceIn5YearsPrincipal = stringValue;
            }

            #endregion

            #region Escrow Info

            if (sheetName == "EscrowInfo")
            {
                if (col == 2) InsInitialDeposit = stringValue;
                if (col == 3) InsPeriodDeposit = stringValue;
                if (col == 4) InsLowBalance = stringValue;
                if (col == 5) InsCushion = stringValue;
                if (col == 6) InsTotalAnnualDisbursed = stringValue;
                if (col == 7) TaxInitialDeposit = stringValue;
                if (col == 8) TaxPeriodDeposit = stringValue;
                if (col == 9) TaxLowBalance = stringValue;
                if (col == 10) TaxCushion = stringValue;
                if (col == 11) TaxTotalAnnualDisbursed = stringValue;
                if (col == 12) PmiInitialDeposit = stringValue;
                if (col == 13) PmiPeriodDeposit = stringValue;
                if (col == 14) PmiLowBalance = stringValue;
                if (col == 15) PmiCushion = stringValue;
                if (col == 16) PmiTotalAnnualDisbursed = stringValue;
                if (col == 17) Other1InitialDeposit = stringValue;
                if (col == 18) Other1PeriodDeposit = stringValue;
                if (col == 19) Other1LowBalance = stringValue;
                if (col == 20) Other1Cushion = stringValue;
                if (col == 21) Other1TotalAnnualDisbursed = stringValue;
                if (col == 22) Other2InitialDeposit = stringValue;
                if (col == 23) Other2PeriodDeposit = stringValue;
                if (col == 24) Other2LowBalance = stringValue;
                if (col == 25) Other2Cushion = stringValue;
                if (col == 26) Other2TotalAnnualDisbursed = stringValue;
                if (col == 27) AggregateInitialDeposit = stringValue;
                if (col == 28) AggregatePeriodDeposit = stringValue;
                if (col == 29) AggregateLowBalance = stringValue;
                if (col == 30) AggregateCushion = stringValue;
                if (col == 31) AggregateTotalAnnualDisbursed = stringValue;
            }

            #endregion


        }
    }
}