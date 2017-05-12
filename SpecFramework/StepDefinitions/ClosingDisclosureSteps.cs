using System;
using System.Configuration;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TRID.ActionClasses;
using TRID.CommonUtils;
using TRID.ProjectLibs.Common;
using TRID.TestClasses;


namespace TRID.StepDefinitions
{
    [Binding]
    public class ClosingDisclosureSteps : TridTest
    {
        private static string Url => ConfigurationManager.AppSettings["url"];
        readonly GetExcelData _getData = new GetExcelData();
        public static bool TestCaseStatus = true;

        #region Given

        [Given(@"user is at TRID application homepage")]
        public void GivenUserIsAtTridApplicationHomepage()
        {
            UIActions.WindowMaximize();
            UIActions.GoToUrl(Url + "?tKey=EB535076-2140-4106-8CAE-B230F6E2D082&aKey=TRID");
            Thread.Sleep(5000);
            UIActions.WebDriverWait(SnlStartNewLoanText, 60);

            UIActions.Click(SnlResetButton);
            Thread.Sleep(5000);
        }
       
        [Given(@"user have all the input values from Excel sheet (.*) for scenario (.*)")]
        public void GivenUserHaveAllTheInputValuesFromExcelSheetForScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }

        [Given(@"user have closing disclosure data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHaveClosingDisclosureDataFromExcelSheetForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }

        [Given(@"user have Mortgage Insurance data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHaveMortgageInsuranceDataFromExcelSheetForTheScenarioMortgageInsurance(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }

        [Given(@"user have variable loan data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHaveVariableLoanDataFromExcelSheetForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }

        [Given(@"user have Prepaid Charges data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHavePrepaidChargesDataFromExcelSheetPrepaidChargesForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }


        [Given(@"user navigate to Loan Estimate Page")]
        public void GivenUserNavigateToLoanEstimatePage()
        {
            UIActions.Click(LoanEstimateLink);
            UIActions.WebDriverWait(LoanDetailsText, 60);
        }

        [Given(@"PMI Rates Grid is empty")]
        public void GivenPmiRatesGridIsEmpty()
        {
            ProjActions.PmiRatesGridEmptyValidation();
        }


        #endregion


        #region When

        [When(@"user navigate to Loan Inputs Page")]
        public void WhenUserNavigateToLoanInputsPage()
        {
            UIActions.Click(LoanInputsLink);
            Thread.Sleep(5000);

            UIActions.WebDriverWait(LoanDetailsText, 60);
        }

        [When(@"user navigate to Amortization Page")]
        public void WhenUserNavigateToAmortizationPage()
        {
            UIActions.Click(AmortizationLink);
            Thread.Sleep(5000);

            UIActions.WebDriverWait(AmortizationPaymentScheduleText, 60);
        }



        [When(@"user navigate to Closing Disclosure Page")]
        public void GivenUserNavigateToClosingClosingDisclosurePage()
        {
            UIActions.Click(ClosingDisclosureLink);
            UIActions.WebDriverWait(LoanDetailsText, 60);
        }

        [When(@"user selects Calculation Method")]
        public void WhenUserSelectsCalculationMethodInClosingDisclosurePage()
        {
            LoanDetailsRadioButtonVariable();
            UIActions.Click(CalculationMethod);         
        }

        [When(@"user selects loan type")]
        public void WhenUserSelectsLoanTypeInClosingDisclosurePage()
        {
            LoanDetailsRadioButtonVariable();
            UIActions.Click(LoanType);

            if (CalculationMethod.Equals("Variable"))
            {
                var firstTermChange = TridVariable.FirstTermChange;
                UIActions.Clear(FirstTermChange);
                UIActions.GiveInput(FirstTermChange, firstTermChange);

                var subsequentTermChange = TridVariable.SubsequentTermChange;
                UIActions.Clear(SubsequentTermChange);
                UIActions.GiveInput(SubsequentTermChange, subsequentTermChange);

                var dnRateCapFirstAdjustment = TridVariable.DnRateCapFirstAdjustment;
                UIActions.Clear(DnRateCapFirstAdjustment);
                UIActions.GiveInput(DnRateCapFirstAdjustment, dnRateCapFirstAdjustment);

                var dnRateCapsubsequentAdjustment = TridVariable.DnRateCapsubsequentAdjustment;
                UIActions.Clear(DnRateCapSubseqAdjustment);
                UIActions.GiveInput(DnRateCapSubseqAdjustment, dnRateCapsubsequentAdjustment);

                var upRateCapFirstAdjustment = TridVariable.UpRateCapFirstAdjustment;
                UIActions.Clear(UpRateCapFirstAdjustment);
                UIActions.GiveInput(UpRateCapFirstAdjustment, upRateCapFirstAdjustment);

                var upRateCapsubsequentAdjustment = TridVariable.UpRateCapsubsequentAdjustment;
                UIActions.Clear(UpRateCapSubseqAdjustment);
                UIActions.GiveInput(UpRateCapSubseqAdjustment, upRateCapsubsequentAdjustment);

                var floorRate = TridVariable.FloorRate;
                UIActions.Clear(FloorRate);
                UIActions.GiveInput(FloorRate, floorRate);

                var maxRateEver = TridVariable.MaxRateEver;
                UIActions.Clear(MaxRateEver);
                UIActions.GiveInput(MaxRateEver, maxRateEver);

                var index = TridVariable.Index;
                UIActions.Clear(Index);
                UIActions.GiveInput(Index, index);

                var margin = TridVariable.Margin;
                UIActions.Clear(Margin);
                UIActions.GiveInput(Margin, margin);

                var indexRate = TridVariable.RoundingFactor;
                UIActions.Clear(Index);
                UIActions.GiveInput(Index, indexRate);
            }
        }

        [When(@"user selects Frequency of Payments")]
        public void WhenUserSelectsFrequencyOfPaymentsInClosingDisclosurePage()
        {
            LoanDetailsRadioButtonVariable();
            UIActions.Click(FrequencyOfPayments);
        }

        [When(@"user selects Loan Term")]
        public void WhenUserSelectsLoanTermInClosingDisclosurePage()
        {
            LoanDetailsRadioButtonVariable();
            UIActions.Click(LoanTerm);
        }

        [When(@"user selects Repayment Term Type")]
        public void WhenUserSelectsRepaymentTermTypeInClosingDisclosurePage()
        {
            LoanDetailsRadioButtonVariable();
            UIActions.Click(RepaymentTermType);
        }

        [When(@"Enter Loan detail input values for computation")]
        public void WhenEnterLoanDetailInputValuesForComputationforClosingDisclosurepage()
        {
            var frequencyOfPmtValue = TridVariable.FrequencyOfPmtValue;
            UIActions.Clear(FreqOfPmtValue);
            UIActions.GiveInput(FreqOfPmtValue, frequencyOfPmtValue);

            var loanTermValue = TridVariable.LoanTermValue;
            UIActions.Clear(LoanTermValue);
            UIActions.GiveInput(LoanTermValue, loanTermValue);

            var loanAmount = TridVariable.LoanAmount;
            UIActions.Clear(LoanAmount);
            UIActions.GiveInput(LoanAmount, loanAmount);

            var rateOfInterest = TridVariable.RateOfInterest;
            UIActions.Clear(RateOfInterest);
            UIActions.GiveInput(RateOfInterest, rateOfInterest);

            var dateOfLoan = ProjActions.GetDate(TridVariable.DateOfLoan);
            UIActions.Clear(DateOfLoan);
            UIActions.GiveInput(DateOfLoan, dateOfLoan);

            var dateOfInterestBegins = ProjActions.GetDate(TridVariable.DateInterestBeginToAccrue);
            UIActions.Clear(DateOfInterestBegins);
            UIActions.GiveInput(DateOfInterestBegins, dateOfInterestBegins);

            var dateOfFirstPayment = ProjActions.GetDate(TridVariable.DateOfFirstPayment);
            UIActions.Clear(DateOfFirstPayment);
            UIActions.GiveInput(DateOfFirstPayment, dateOfFirstPayment);

            var periodPayment = TridVariable.PeriodPayment;
            UIActions.Clear(PeriodPayment);
            UIActions.GiveInput(PeriodPayment, periodPayment);

            var loanCostsForDisclosure = TridVariable.LoanCosts;
            UIActions.Clear(LoanCostsForDisclosure);
            UIActions.GiveInput(LoanCostsForDisclosure, loanCostsForDisclosure);

            UIActions.Click(OddDaysClick);
            UIActions.Click(OddDaysSelect);
        }

        [When(@"user enters all input values for Prepaid Charges")]
        public void WhenUserEntersAllInputValuesForPrepaidCharges()
        {
            var fhaVaUsdaUpfrontPmiFree = TridVariable.FhaVaUsdaUpfrontPmiFree;
            UIActions.Clear(FhaVaUsdaUpfrontPmiFree);
            UIActions.GiveInput(FhaVaUsdaUpfrontPmiFree, fhaVaUsdaUpfrontPmiFree);

            var floodFee = TridVariable.FloodFee;
            UIActions.Clear(FloodFee);
            UIActions.GiveInput(FloodFee, floodFee);

            var inspectionFee = TridVariable.InspectionFee;
            UIActions.Clear(InspectionFee);
            UIActions.GiveInput(InspectionFee, inspectionFee);

            var loanOriginationFee = TridVariable.LoanOriginationFee;
            UIActions.Clear(LoanOriginationFee);
            UIActions.GiveInput(LoanOriginationFee, loanOriginationFee);

            var otherFees = TridVariable.OtherFees;
            UIActions.Clear(OtherFees);
            UIActions.GiveInput(OtherFees, otherFees);

            var pmiEscrowed = TridVariable.PmiEscrowed;
            UIActions.Clear(PmiEscrowed);
            UIActions.GiveInput(PmiEscrowed, pmiEscrowed);

            var prepaidDailyInterest = TridVariable.PrepaidDailyInterest;
            UIActions.Clear(PrepaidDailyInterest);
            UIActions.GiveInput(PrepaidDailyInterest, prepaidDailyInterest);

            var taxServicing = TridVariable.TaxServicing;
            UIActions.Clear(TaxServicing);
            UIActions.GiveInput(TaxServicing, taxServicing);

            var titleClosingFee = TridVariable.TitleClosingFee;
            UIActions.Clear(TitleClosingFee);
            UIActions.GiveInput(TitleClosingFee, titleClosingFee);

            var titleClosingProtectionLetter = TridVariable.TitleClosingProtectionLetter;
            UIActions.Clear(TitleClosingProtectionLetter);
            UIActions.GiveInput(TitleClosingProtectionLetter, titleClosingProtectionLetter);

            var titleCourierFee = TridVariable.TitleCourierFee;
            UIActions.Clear(TitleCourierFee);
            UIActions.GiveInput(TitleCourierFee, titleCourierFee);

            var titleDrawFee = TridVariable.TitleDrawFee;
            UIActions.Clear(TitleDrawFee);
            UIActions.GiveInput(TitleDrawFee, titleDrawFee);

            var titleWireFee = TridVariable.TitleWireFee;
            UIActions.Clear(TitleWireFee);
            UIActions.GiveInput(TitleWireFee, titleWireFee);

            var underWriting = TridVariable.UnderWriting;
            UIActions.Clear(UnderWriting);
            UIActions.GiveInput(UnderWriting, underWriting);
        }

        [When(@"user enters pmi rate values")]
        public void WhenUserEntersPmiRateValues()
        {
            ProjActions.AddPmiRateValues();
            Thread.Sleep(3000);
            ProjActions.PmiRatesGridValidation();
        }

        [When(@"user enters other pmi input values")]
        public void WhenUserEntersOtherPmiInputValues()
        {
            var numberOfPrdsOfAdvcInsurance = TridVariable.NumberOfPrdsOfAdvcInsurance;
            UIActions.Clear(NumberOfPeriodsofAdvanceInsCollected);
            UIActions.GiveInput(NumberOfPeriodsofAdvanceInsCollected, numberOfPrdsOfAdvcInsurance);

            var lowerOfCostOfAppraisal = TridVariable.LowerOfCostOfAppraisal;
            UIActions.Clear(LowerOfCostOrAppraisal);
            UIActions.GiveInput(LowerOfCostOrAppraisal, lowerOfCostOfAppraisal);

            var totalMiInSectionFPrepaids = TridVariable.TotalMiInSectionFPrepaids;
            UIActions.Clear(TotalMiInSectionFPrepaids);
            UIActions.GiveInput(TotalMiInSectionFPrepaids, totalMiInSectionFPrepaids);

            var totalMiInSectionGEscrow = TridVariable.TotalMiInSectionGEscrow;
            UIActions.Clear(TotalMiInSectionGEscrow);
            UIActions.GiveInput(TotalMiInSectionGEscrow, totalMiInSectionGEscrow);
        }

        [When(@"Enter Disclosed input values for Closing Disclosure page")]
        public void WhenEnterDisclosedInputValuesForClosingDisclosurePage()
        {
            var monthlyPrincipalAndInterest = TridVariable.MonthlyPrincipalAndInterest;
            UIActions.Clear(DisclosedMonthlyPrincipalandInterest);
            UIActions.GiveInput(DisclosedMonthlyPrincipalandInterest, monthlyPrincipalAndInterest);

            var monthlyPmi = TridVariable.MonthlyPmi;
            UIActions.Clear(DisclosedMonthlyPmi);
            UIActions.GiveInput(DisclosedMonthlyPmi, monthlyPmi);

            var totalMonhtlyPayment = TridVariable.TotalPeiodicPayment;
            UIActions.Clear(DisclosedTotalPeriodicPayment);
            UIActions.GiveInput(DisclosedTotalPeriodicPayment, totalMonhtlyPayment);

            var pmiTerminationDate = ProjActions.GetDate(TridVariable.PmiTerminationDate);
            UIActions.Clear(DisclosedPmiTerminalDate);
            UIActions.GiveInput(DisclosedPmiTerminalDate, pmiTerminationDate);

            var pmiCancelDate = ProjActions.GetDate(TridVariable.PmiCancelDate);
            UIActions.Clear(DisclosedPmiCancelDate);
            UIActions.GiveInput(DisclosedPmiCancelDate, pmiCancelDate);

            var disclosedFinalBalloonPayment = TridVariable.DisclosedFinalBalloonPayment;
            UIActions.Clear(DisclosedFinalBalloonPayment);
            UIActions.GiveInput(DisclosedFinalBalloonPayment, disclosedFinalBalloonPayment);

            var disclosedTotalOfPayment = TridVariable.DisclosedTotalOfPayment;
            UIActions.Clear(DisclosedTotalOfPayment);
            UIActions.GiveInput(DisclosedTotalOfPayment, disclosedTotalOfPayment);
        }


        [When(@"click on Loan Details TEST on Closing Disclosure page")]
        public void WhenClickOnLoanDetailsTestOnClosingDisclosurePage()
        {
            Thread.Sleep(3000);
            UIActions.Click(LoanEstimateLink);
            Thread.Sleep(3000);
            //UIActions.WebDriverWait(LoanDetailsText, 60);

            //UIActions.Click(ClosingDisclosureLink);
            //Thread.Sleep(3000);
            //UIActions.WebDriverWait(LoanDetailsText, 60);
        }


        [When(@"click on Disclosure TEST on Closing Disclosure page")]
        public void WhenClickOnDisclosureTestOnClosingDisclosurePage()
        {
            //UIActions.Click(DisclosedTest);
        }


        [When(@"click on Loan Details TEST on Loan Estimate Page")]
        public void WhenClickOnLoanDetailsTestOnLoanEstimatePage()
        {
            Thread.Sleep(3000);
            UIActions.Click(ClosingDisclosureLink);
        //    Thread.Sleep(3000);
        //    UIActions.WebDriverWait(LoanDetailsText, 60);


        //    UIActions.Click(LoanEstimateLink);
        //    Thread.Sleep(3000);
        //    UIActions.WebDriverWait(LoanDetailsText, 60);

        //    UIActions.Click(LoanDetailsTest);
        //    Thread.Sleep(5000);
        }

        [When(@"click on Disclosure TEST on Loan Estimate Page")]
        public void WhenClickOnDisclosureTestOnLoanEstimatePage()
        {
            //UIActions.Click(DisclosedTest);
        }

        [When(@"user navigates to Disclosure Inputs Page")]
        public void WhenUserNavigatesToDisclosureInputsPage()
        {
            UIActions.Click(DisclosureInputsLink);
            Thread.Sleep(5000);
            UIActions.WebDriverWait(DisclosedValuesText, 60);
        }

        [When(@"user enters disclosed input values for closing disclousre section")]
        public void WhenUserEntersDisclosedInputValuesForClosingDisclousreSection()
        {
            var monthlyPrincipalAndInterest = TridVariable.MonthlyPrincipalAndInterest;
            UIActions.Clear(DisclosedMonthlyPrincipalandInterest);
            UIActions.GiveInput(DisclosedMonthlyPrincipalandInterest, monthlyPrincipalAndInterest);

            var monthlyPmi = TridVariable.MonthlyPmi;
            UIActions.Clear(DisclosedMonthlyPmi);
            UIActions.GiveInput(DisclosedMonthlyPmi, monthlyPmi);

            var totalMonhtlyPayment = TridVariable.TotalPeiodicPayment;
            UIActions.Clear(DisclosedTotalPeriodicPayment);
            UIActions.GiveInput(DisclosedTotalPeriodicPayment, totalMonhtlyPayment);

            var pmiTerminationDate = ProjActions.GetDate(TridVariable.PmiTerminationDate);
            UIActions.Clear(DisclosedPmiTerminalDate);
            UIActions.GiveInput(DisclosedPmiTerminalDate, pmiTerminationDate);

            var pmiCancelDate = ProjActions.GetDate(TridVariable.PmiCancelDate);
            UIActions.Clear(DisclosedPmiCancelDate);
            UIActions.GiveInput(DisclosedPmiCancelDate, pmiCancelDate);

            var disclosedFinalBalloonPayment = TridVariable.DisclosedFinalBalloonPayment;
            UIActions.Clear(DisclosedFinalBalloonPayment);
            UIActions.GiveInput(DisclosedFinalBalloonPayment, disclosedFinalBalloonPayment);

            var disclosedTotalOfPayment = TridVariable.DisclosedTotalOfPayment;
            UIActions.Clear(DisclosedTotalOfPayment);
            UIActions.GiveInput(DisclosedTotalOfPayment, disclosedTotalOfPayment);
        }

        [When(@"user enters disclsoed input values for Loan Estimate")]
        public void WhenUserEntersDisclsoedInputValuesForLoanEstimate()
        {
            var in5Years = TridVariable.DiscLosedIn5Years;
            UIActions.Clear(DisclosedIn5Years);
            UIActions.GiveInput(DisclosedIn5Years, in5Years);

            var in5YearsPrincipal = TridVariable.DiscLosedIn5YearsPrincipal;
            UIActions.Clear(DisclosedIn5YearsPrincipal);
            UIActions.GiveInput(DisclosedIn5YearsPrincipal, in5YearsPrincipal);

            var apr = TridVariable.DisclosedApr;
            UIActions.Clear(DisclosedApr);
            UIActions.GiveInput(DisclosedApr, apr);

            var tip = TridVariable.DisclosedTip;
            UIActions.Clear(DisclosedTip);
            UIActions.GiveInput(DisclosedTip, tip);
        }

        [When(@"user enters disclosed input values for Prepaid Charges")]
        public void WhenUserEntersDisclosedInputValuesForPrepaidCharges()
        {
            UIActions.Clear(DisclosedFinanceCharge);
            UIActions.GiveInput(DisclosedFinanceCharge, TridVariable.DisclosedFinanceCharge);

            UIActions.Clear(DisclosedPrepaidCharge);
            UIActions.GiveInput(DisclosedPrepaidCharge, TridVariable.DisclosedPrepaidCharge);

            UIActions.Clear(DisclosedAmountFinanced);
            UIActions.GiveInput(DisclosedAmountFinanced, TridVariable.DisclosedAmountFinanced);
        }

        [When(@"user navigates to Closing Disclosure Cards Page")]
        public void WhenUserNavigatesToClosingDisclosureCardsPage()
        {
            UIActions.Click(ClosingDisclosureLink);
            Thread.Sleep(5000);
            UIActions.WebDriverWait(MonthlyPrincipalAndInterestText, 60);
        }

        [When(@"user navigates to Loan Estimate Cards Page")]
        public void WhenUserNavigatesToLoanEstimateCardsPage()
        {
            UIActions.Click(LoanEstimateLink);
            Thread.Sleep(5000);
            UIActions.WebDriverWait(LoanEstimateIn5YearsText, 60);
        }




        #endregion


        #region Then


        [Then(@"updated/computed Principal and Interest value should display on Closing Disclosure")]
        public void ThenUpdatedComputedPrincipalAndInterestValueShouldDisplayOnClosingDisclosure()
        {
            try
            {
                var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(PiComputedValue)), 2);

            var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.PrincipalAndInt), 2);
            Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
            Console.WriteLine("ActualComputedValue :" + actualCValue);
            Console.WriteLine("============================================================");

            var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PiDisclosureValue));

            Console.WriteLine("===========================================================");
            Console.WriteLine("DisclosedValue :" + actualDValue);
            Console.WriteLine("============================================================");

            var expectedVValue = Convert.ToDouble(TridVariable.VariancePrincipalAndInt);
            var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PiVarianceValue));

            Assert.AreEqual(actualVValue, expectedVValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedVarianceValue :" + actualVValue);
            Console.WriteLine("ActualVarianceValue :" + expectedVValue);
            Console.WriteLine("============================================================");
        }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
            }
}

[Then(@"updated/computed pmi value should display on Closing Disclosure")]
        public void ThenUpdatedComputedPmiValueShouldDisplayOnClosingDisclosure()
{
    try
    {
        var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(PmiComputedValue)),2);

            var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.Pmi),2);
            Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
            Console.WriteLine("ActualComputedValue :" + actualCValue);
            Console.WriteLine("============================================================");

            var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PmiDisclosureValue));

            Console.WriteLine("===========================================================");
            Console.WriteLine("DisclosedValue :" + actualDValue);
            Console.WriteLine("============================================================");

            var expectedVValue = Convert.ToDouble(TridVariable.VariancePmi);
            var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PmiVarianceValue));

            Assert.AreEqual(actualVValue, expectedVValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedVarianceValue :" + actualVValue);
            Console.WriteLine("ActualVarianceValue :" + expectedVValue);
            Console.WriteLine("============================================================");
        }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
            }
}

[Then(@"updated/computed Drop off years for PMI value should display on Closing Disclosure")]
        public void ThenUpdatedComputedDropOffYearsForPmiValueShouldDisplayOnClosingDisclosure()
{
        if (TridVariable.DropOffYearsForPmi.Equals("N/A"))
            {
                DropOffYearsForPmiNotApplicableValidation();
            }               
            else
            {
            try
            {
                var actualCValue = ProjActions.GetDatePart(DoyfpComputedValue);
                var expectedCValue = Convert.ToDateTime(ProjActions.GetDate(TridVariable.DropOffYearsForPmi));
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetDatePart(DoyfpDisclosureValue);

                Console.WriteLine("===========================================================");
                Console.WriteLine("DisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceDropOffYearsForPmi);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(DoyfpVarianceValue));

                Assert.AreEqual(actualVValue, expectedVValue, "Variance does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :" + actualVValue);
                Console.WriteLine("ActualVarianceValue :" + expectedVValue);
                Console.WriteLine("============================================================");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
            }
        }
    }

        public static void DropOffYearsForPmiNotApplicableValidation()
        {
            try
            {  
            var actualCValue = UIActions.GetText(DoyfpComputedValue);
            var expectedCValue = "(C): " + TridVariable.DropOffYearsForPmi;
            Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
            Console.WriteLine("ActualComputedValue :" + actualCValue);
            Console.WriteLine("============================================================");

            var actualDValue = UIActions.GetText(DoyfpDisclosureValue);

            Console.WriteLine("===========================================================");
            Console.WriteLine("DisclosedValue :" + actualDValue);
            Console.WriteLine("============================================================");

            var expectedVValue = "(V): N/A Days";
            var actualVValue = UIActions.GetText(DoyfpVarianceValue);

            Assert.AreEqual(actualVValue, expectedVValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedVarianceValue :" + actualVValue);
            Console.WriteLine("ActualVarianceValue :" + expectedVValue);
            Console.WriteLine("============================================================");
        }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
            }
}


[Then(@"updated/computed Total Period Payment value should display on Closing Disclosure")]
        public void ThenUpdatedComputedTotalPeriodPaymentValueShouldDisplayOnClosingDisclosure()
{
    try
    {
        var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(TppComputedValue)),2);

            var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.TotalPeriodPayment),2);
            Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
            Console.WriteLine("ActualComputedValue :" + actualCValue);
            Console.WriteLine("============================================================");

            var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TppDisclosureValue));

            Console.WriteLine("===========================================================");
            Console.WriteLine("DisclosedValue :" + actualDValue);
            Console.WriteLine("============================================================");

            var expectedVValue = Convert.ToDouble(TridVariable.VarianceTotalPeriodPayment);
            var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TppVarianceValue));

            Assert.AreEqual(actualVValue, expectedVValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedVarianceValue :" + actualVValue);
            Console.WriteLine("ActualVarianceValue :" + expectedVValue);
            Console.WriteLine("============================================================");
        }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
            }
}

[Then(@"updated/computed Prepaid Charges value should display on Closing Disclosure")]
        public void ThenUpdatedComputedPrepaidChargesValueShouldDisplayOnClosingDisclosure()
{
    try
    {
        var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(PcComputedValue)), 2);

            var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.PrepaidCharges), 2);
            Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
            Console.WriteLine("ActualComputedValue :" + actualCValue);
            Console.WriteLine("============================================================");

            var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PcDisclosureValue));

            Console.WriteLine("===========================================================");
            Console.WriteLine("DisclosedValue :" + actualDValue);
            Console.WriteLine("============================================================");

            var expectedVValue = Convert.ToDouble(TridVariable.VariancePrepaidCharges);
            var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PcVarianceValue));

            Assert.AreEqual(actualVValue, expectedVValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedVarianceValue :" + actualVValue);
            Console.WriteLine("ActualVarianceValue :" + expectedVValue);
            Console.WriteLine("============================================================");
        }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
            }
}

[Then(@"updated/computed Amount Financed value should display on Closing Disclosure")]
        public void ThenUpdatedComputedAmountFinancedValueShouldDisplayOnClosingDisclosure()
{
    try
    {
        var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AfComputedValue)), 2);

            var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.AmountFinanced), 2);
            Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
            Console.WriteLine("ActualComputedValue :" + actualCValue);
            Console.WriteLine("============================================================");

            var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(AfDisclosureValue));

            Console.WriteLine("===========================================================");
            Console.WriteLine("DisclosedValue :" + actualDValue);
            Console.WriteLine("============================================================");

            var expectedVValue = Convert.ToDouble(TridVariable.VarianceAmountFinanced);
            var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(AfVarianceValue));

            Assert.AreEqual(actualVValue, expectedVValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedVarianceValue :" + actualVValue);
            Console.WriteLine("ActualVarianceValue :" + expectedVValue);
            Console.WriteLine("============================================================");
        }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
            }
}

[Then(@"updated/computed Escrow Property Costs over one year value should display on Closing Disclosure")]
        public void ThenUpdatedComputedEscrowPropertyCostsOverOneYearValueShouldDisplayOnClosingDisclosure()
{
    try
    {
        var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(EpcooyComputedValue)), 2);

            var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.EscrowPropertyOverOneYear), 2);
            Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
            Console.WriteLine("ActualComputedValue :" + actualCValue);
            Console.WriteLine("============================================================");

            var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(EpcooyDisclosureValue));

            Console.WriteLine("===========================================================");
            Console.WriteLine("DisclosedValue :" + actualDValue);
            Console.WriteLine("============================================================");

            var expectedVValue = Convert.ToDouble(TridVariable.VarianceEscrowPropertyOverOneYear);
            var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(EpcooyVarianceValue));

            Assert.AreEqual(actualVValue, expectedVValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedVarianceValue :" + actualVValue);
            Console.WriteLine("ActualVarianceValue :" + expectedVValue);
            Console.WriteLine("============================================================");
        }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
            }
}


[Then(@"updated/computed APR value should display on Closing Disclosure")]
        public void ThenUpdatedComputedAprValueShouldDisplayOnClosingDisclosure()
{
    try
    {
        var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AprComputedValue)), 3);

            var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.Apr), 3);
            Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
            Console.WriteLine("ActualComputedValue :" + actualCValue);
            Console.WriteLine("============================================================");

            var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(AprDisclosureValue));

            Console.WriteLine("===========================================================");
            Console.WriteLine("DisclosedValue :" + actualDValue);
            Console.WriteLine("============================================================");

            var expectedVValue = Convert.ToDouble(TridVariable.VarianceApr);
            var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(AprVarianceValue));

            Assert.AreEqual(actualVValue, expectedVValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedVarianceValue :" + actualVValue);
            Console.WriteLine("ActualVarianceValue :" + expectedVValue);
            Console.WriteLine("============================================================");
        }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
            }
}

[Then(@"updated/computed Balloon Amount value should display on Closing Disclosure")]
        public void ThenUpdatedComputedBalloonAmountValueShouldDisplayOnClosingDisclosure()
{
    try
    {
        var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(BaComputedValue)), 2);

            var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.BalloonAmount), 2);
            Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
            Console.WriteLine("ActualComputedValue :" + actualCValue);
            Console.WriteLine("============================================================");

            var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(BaDisclosureValue));

            Console.WriteLine("===========================================================");
            Console.WriteLine("DisclosedValue :" + actualDValue);
            Console.WriteLine("============================================================");

            var expectedVValue = Convert.ToDouble(TridVariable.VarianceBalloonAmount);
            var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(BaVarianceValue));

            Assert.AreEqual(actualVValue, expectedVValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedVarianceValue :" + actualVValue);
            Console.WriteLine("ActualVarianceValue :" + expectedVValue);
            Console.WriteLine("============================================================");
        }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
            }
}

[Then(@"updated/computed Total of Payments value should display on Closing Disclosure")]
        public void ThenUpdatedComputedTotalOfPaymentsValueShouldDisplayOnClosingDisclosure()
{
    try
    {
        var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(TopComputedValue)), 2);

            var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.TotalOfPayments), 2);
            Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
            Console.WriteLine("ActualComputedValue :" + actualCValue);
            Console.WriteLine("============================================================");

            var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TopDisclosureValue));

            Console.WriteLine("===========================================================");
            Console.WriteLine("DisclosedValue :" + actualDValue);
            Console.WriteLine("============================================================");

            var expectedVValue = Convert.ToDouble(TridVariable.VarianceTotalOfPayments);
            var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TopVarianceValue));

            Assert.AreEqual(actualVValue, expectedVValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedVarianceValue :" + actualVValue);
            Console.WriteLine("ActualVarianceValue :" + expectedVValue);
            Console.WriteLine("============================================================");
        }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
            }
}

[Then(@"updated/computed Finance Charge value should display on Closing Disclosure")]
        public void ThenUpdatedComputedFinanceChargeValueShouldDisplayOnClosingDisclosure()
{
    try
    {
        var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(FcComputedValue)), 2);

            var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.FinanceCharge), 2);
            Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
            Console.WriteLine("ActualComputedValue :" + actualCValue);
            Console.WriteLine("============================================================");

            var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(FcDisclosureValue));

            Console.WriteLine("===========================================================");
            Console.WriteLine("DisclosedValue :" + actualDValue);
            Console.WriteLine("============================================================");

            var expectedVValue = Convert.ToDouble(TridVariable.VarianceFinanceCharge);
            var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(FcVarianceValue));

            Assert.AreEqual(actualVValue, expectedVValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedVarianceValue :" + actualVValue);
            Console.WriteLine("ActualVarianceValue :" + expectedVValue);
            Console.WriteLine("============================================================");
        }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
            }
}

[Then(@"updated/computed TIP value should display on Closing Disclosure")]
        public void ThenUpdatedComputedTipValueShouldDisplayOnClosingDisclosure()
{
    try
    {
        var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(TipComputedValue)), 2);

            var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.Tip), 2);
            Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
            Console.WriteLine("ActualComputedValue :" + actualCValue);
            Console.WriteLine("============================================================");

            var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TipDisclosureValue));

            Console.WriteLine("===========================================================");
            Console.WriteLine("DisclosedValue :" + actualDValue);
            Console.WriteLine("============================================================");

            var expectedVValue = Convert.ToDouble(TridVariable.VarianceTip);
            var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TipVarianceValue));

            Assert.AreEqual(actualVValue, expectedVValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedVarianceValue :" + actualVValue);
            Console.WriteLine("ActualVarianceValue :" + expectedVValue);
            Console.WriteLine("============================================================");
        }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
            }
}

[Then(@"updated/computed Initial Escrow Payment value should display on Closing Disclosure")]
        public void ThenUpdatedComputedInitialEscrowPaymentValueShouldDisplayOnClosingDisclosure()
{
    try
    {
        var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(IepComputedValue)), 2);

            var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.InitialEscrowPayment), 2);
            Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
            Console.WriteLine("ActualComputedValue :" + actualCValue);
            Console.WriteLine("============================================================");

            var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(IepDisclosureValue));

            Console.WriteLine("===========================================================");
            Console.WriteLine("DisclosedValue :" + actualDValue);
            Console.WriteLine("============================================================");

            var expectedVValue = Convert.ToDouble(TridVariable.VarianceInitialEscrowPayment);
            var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(IepVarianceValue));

            Assert.AreEqual(actualVValue, expectedVValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedVarianceValue :" + actualVValue);
            Console.WriteLine("ActualVarianceValue :" + expectedVValue);
            Console.WriteLine("============================================================");
        }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
            }
}


[Then(@"updated/computed Non Escrow Property Costs over one year value should display on Closing Disclosure")]
        public void ThenUpdatedComputedNonEscrowPropertyCostsOverOneYearValueShouldDisplayOnClosingDisclosure()
{
    try
    {
        var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(NepcooyComputedValue)), 2);

            var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.NonEscrowPropertyOverOneYear), 2);
            Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
            Console.WriteLine("ActualComputedValue :" + actualCValue);
            Console.WriteLine("============================================================");

            var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(NepcooyDisclosureValue));

            Console.WriteLine("===========================================================");
            Console.WriteLine("DisclosedValue :" + actualDValue);
            Console.WriteLine("============================================================");

            var expectedVValue = Convert.ToDouble(TridVariable.VarianceNonEscrowPropertyOverOneYear);
            var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(NepcooyVarianceValue));

            Assert.AreEqual(actualVValue, expectedVValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedVarianceValue :" + actualVValue);
            Console.WriteLine("ActualVarianceValue :" + expectedVValue);
            Console.WriteLine("============================================================");
        }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
            }
}

[Then(@"updated/computed Period Escrow Payment value should display on Closing Disclosure")]
        public void ThenUpdatedComputedPeriodEscrowPaymentValueShouldDisplayOnClosingDisclosure()
{
    try
    {
        var actualCValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(PepComputedValue)), 2);

            var expectedCValue = Math.Round(Convert.ToDouble(TridVariable.PeriodEscrowPayment), 2);
            Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
            Console.WriteLine("ActualComputedValue :" + actualCValue);
            Console.WriteLine("============================================================");

            var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PepDisclosureValue));

            Console.WriteLine("===========================================================");
            Console.WriteLine("DisclosedValue :" + actualDValue);
            Console.WriteLine("============================================================");

            var expectedVValue = Convert.ToDouble(TridVariable.VariancePeriodEscrowPayment);
            var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PepVarianceValue));

            Assert.AreEqual(actualVValue, expectedVValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedVarianceValue :" + actualVValue);
            Console.WriteLine("ActualVarianceValue :" + expectedVValue);
            Console.WriteLine("============================================================");
        }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
            }
}

[Then(@"updated/computed in 5 Years value should display on Loan Estimate")]
        public void ThenUpdatedComputedIn5YearsValueShouldDisplayOnLoanEstimate()
        {
            try
            {
                var actualCValue = ProjActions.GetNumericValueFromString(UIActions.GetText(I5YComputedValue));

            var expectedCValue = Convert.ToDouble(TridVariable.In5Years);
            Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
            Console.WriteLine("ActualComputedValue :" + actualCValue);
            Console.WriteLine("============================================================");

            var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(I5YDisclosureValue));

            Console.WriteLine("===========================================================");
            Console.WriteLine("DisclosedValue :" + actualDValue);
            Console.WriteLine("============================================================");

            var expectedVValue = Convert.ToDouble(TridVariable.VarianceIn5Years);
            var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(I5YVarianceValue));

            Assert.AreEqual(actualVValue, expectedVValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("ExpectedVarianceValue :" + actualVValue);
            Console.WriteLine("ActualVarianceValue :" + expectedVValue);
            Console.WriteLine("============================================================");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
            }
        }

        [Then(@"updated/computed in 5 Years principal value should display on Loan Estimate")]
        public void ThenUpdatedComputedIn5YearsPrincipalValueShouldDisplayOnLoanEstimate()
        {
            try
            {  
                var actualCValue = ProjActions.GetNumericValueFromString(UIActions.GetText(I5YpComputedValue));

                var expectedCValue = Convert.ToDouble(TridVariable.In5YearsPrincipal);
                Assert.AreEqual(expectedCValue, actualCValue, "Computed value does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedComputedValue :" + expectedCValue);
                Console.WriteLine("ActualComputedValue :" + actualCValue);
                Console.WriteLine("============================================================");

                var actualDValue = ProjActions.GetNumericValueFromString(UIActions.GetText(I5YpDisclosureValue));

                Console.WriteLine("===========================================================");
                Console.WriteLine("DisclosedValue :" + actualDValue);
                Console.WriteLine("============================================================");

                var expectedVValue = Convert.ToDouble(TridVariable.VarianceIn5YearsPrincipal);
                var actualVValue = ProjActions.GetNumericValueFromString(UIActions.GetText(I5YpVarianceValue));

                Assert.AreEqual(actualVValue, expectedVValue, "Variance does not match as expected");

                Console.WriteLine("===========================================================");
                Console.WriteLine("ExpectedVarianceValue :" + actualVValue);
                Console.WriteLine("ActualVarianceValue :" + expectedVValue);
                Console.WriteLine("============================================================");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                TestCaseStatus = false;
            }
        }

        #endregion

        //[AfterScenario]
        //public static void TridTestCaseStatus()
        //{
        //    if (!TestCaseStatus)
        //    {
        //        throw new Exception("Test Case failed");
        //    }
        //    UIActions.Quit();
        //}

        [AfterTestRun]
        public static void TearDown()
        {
            UIActions.Quit();
            if (!TestCaseStatus)
            {
                throw new Exception("Test Case failed");
            }
        }
    }
}
