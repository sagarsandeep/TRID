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

        #region Given

        //[Given(@"user is at Prepaid Charges page")]
        //public void GivenUserIsAtPrepaidChargesPage()
        //{
        //    Thread.Sleep(3000);
        //    UIActions.Click(LoanDetailsText);
        //    //UIActions.WebDriverWait(PrepaidChargesText, 60);
        //}


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

        [Given(@"user navigate to Loan Estimate Page")]
        public void GivenUserNavigateToLoanEstimatePage()
        {
            UIActions.Click(LoanEstimateLink);
            UIActions.WebDriverWait(LoanDetailsText, 60);
        }

        [Given(@"user is at Mortgage Insurance Page")]
        public void GivenUserIsAtMortgageInsurancePage()
        {
            //UIActions.Click(MortgageInsuranceLink);
            //UIActions.WebDriverWait(MortgageInsuranceLink, 60);
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

        [When(@"Enter Disclosed input values for Closing Disclosure page")]
        public void WhenEnterDisclosedInputValuesForClosingDisclosurePage()
        {
            var monthlyPrincipalAndInterest = TridVariable.MonthlyPrincipalAndInterest;
            UIActions.Clear(DisclosedMonthlyPrincipalandInterest);
            UIActions.GiveInput(DisclosedMonthlyPrincipalandInterest, monthlyPrincipalAndInterest);

            var monthlyPmi = TridVariable.MonthlyPmi;
            UIActions.Clear(DisclosedMonthlyPmi);
            UIActions.GiveInput(DisclosedMonthlyPmi, monthlyPmi);

            var totalMonhtlyPayment = TridVariable.TotalMonhtlyPayment;
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

            var totalMonhtlyPayment = TridVariable.TotalMonhtlyPayment;
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



        #endregion


        #region Then


        [Then(@"updated/computed Principal and Interest value should display on Closing Disclosure")]
        public void ThenUpdatedComputedPrincipalAndInterestValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(PiComputedValue)), 2);

            var expectedValue = Math.Round(Convert.ToDouble(TridVariable.PrincipalAndInt), 2);
            Assert.AreEqual(expectedValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PiDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PiVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed pmi value should display on Closing Disclosure")]
        public void ThenUpdatedComputedPmiValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(PmiComputedValue)),2);

            var expectedValue = Math.Round(Convert.ToDouble(TridVariable.Pmi),2);
            Assert.AreEqual(expectedValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PmiDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PmiVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed Drop off years for PMI value should display on Closing Disclosure")]
        public void ThenUpdatedComputedDropOffYearsForPmiValueShouldDisplayOnClosingDisclosure()
        {          
            var cValue = ProjActions.GetDatePart(DoyfpComputedValue);
            
            var expectedValue = Convert.ToDateTime(ProjActions.GetDate(TridVariable.DropOffYearsForPmi));
            Assert.AreEqual(expectedValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetDatePart(DoyfpDisclosureValue);
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(DoyfpVarianceValue));

            var actualVarianceValue = (cValue - dValue).TotalDays;

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }


        [Then(@"updated/computed Total Period Payment value should display on Closing Disclosure")]
        public void ThenUpdatedComputedTotalPeriodPaymentValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(TppComputedValue)),2);

            var expectedValue = Math.Round(Convert.ToDouble(TridVariable.TotalPeriodPayment),2);
            Assert.AreEqual(expectedValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TppDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TppVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed Prepaid Charges value should display on Closing Disclosure")]
        public void ThenUpdatedComputedPrepaidChargesValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(PcComputedValue)), 2);

            var expectedValue = Math.Round(Convert.ToDouble(TridVariable.PrepaidCharges), 2);
            Assert.AreEqual(expectedValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PcDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PcVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed Amount Financed value should display on Closing Disclosure")]
        public void ThenUpdatedComputedAmountFinancedValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AfComputedValue)), 2);

            var expectedValue = Math.Round(Convert.ToDouble(TridVariable.AmountFinanced), 2);
            Assert.AreEqual(expectedValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(AfDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(AfVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed Escrow Property Costs over one year value should display on Closing Disclosure")]
        public void ThenUpdatedComputedEscrowPropertyCostsOverOneYearValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(EpcooyComputedValue)), 2);

            var expectedValue = Math.Round(Convert.ToDouble(TridVariable.EscrowPropertyOverOneYear), 2);
            Assert.AreEqual(expectedValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(EpcooyDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(EpcooyVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }


        [Then(@"updated/computed APR value should display on Closing Disclosure")]
        public void ThenUpdatedComputedAprValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(AprComputedValue)), 3);

            var expectedValue = Math.Round(Convert.ToDouble(TridVariable.Apr), 2);
            Assert.AreEqual(expectedValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(AprDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(AprVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 3));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed Balloon Amount value should display on Closing Disclosure")]
        public void ThenUpdatedComputedBalloonAmountValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(BaComputedValue)), 2);

            var expectedValue = Math.Round(Convert.ToDouble(TridVariable.BalloonAmount), 2);
            Assert.AreEqual(expectedValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(BaDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(BaVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed Total of Payments value should display on Closing Disclosure")]
        public void ThenUpdatedComputedTotalOfPaymentsValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(TopComputedValue)), 2);

            var expectedValue = Math.Round(Convert.ToDouble(TridVariable.TotalOfPayments), 2);
            Assert.AreEqual(expectedValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TopDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TopVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed Finance Charge value should display on Closing Disclosure")]
        public void ThenUpdatedComputedFinanceChargeValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(FcComputedValue)), 2);

            var expectedValue = Math.Round(Convert.ToDouble(TridVariable.FinanceCharge), 2);
            Assert.AreEqual(expectedValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(FcDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(FcVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed TIP value should display on Closing Disclosure")]
        public void ThenUpdatedComputedTipValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(TipComputedValue)), 2);

            var expectedValue = Math.Round(Convert.ToDouble(TridVariable.Tip), 2);
            Assert.AreEqual(expectedValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TipDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(TipVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed Initial Escrow Payment value should display on Closing Disclosure")]
        public void ThenUpdatedComputedInitialEscrowPaymentValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(IepComputedValue)), 2);

            var expectedValue = Math.Round(Convert.ToDouble(TridVariable.InitialEscrowPayment), 2);
            Assert.AreEqual(expectedValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(IepDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(IepVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }


        [Then(@"updated/computed Non Escrow Property Costs over one year value should display on Closing Disclosure")]
        public void ThenUpdatedComputedNonEscrowPropertyCostsOverOneYearValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(NepcooyComputedValue)), 2);

            var expectedValue = Math.Round(Convert.ToDouble(TridVariable.NonEscrowPropertyOverOneYear), 2);
            Assert.AreEqual(expectedValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(NepcooyDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(NepcooyVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        [Then(@"updated/computed Period Escrow Payment value should display on Closing Disclosure")]
        public void ThenUpdatedComputedPeriodEscrowPaymentValueShouldDisplayOnClosingDisclosure()
        {
            var cValue = Math.Round(ProjActions.GetNumericValueFromString(UIActions.GetText(PepComputedValue)), 2);

            var expectedValue = Math.Round(Convert.ToDouble(TridVariable.Tip), 2);
            Assert.AreEqual(expectedValue, cValue, "Computed value does not match as expected");

            var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PepDisclosureValue));
            var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(PepVarianceValue));

            var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

            Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");

            Console.WriteLine("===========================================================");
            Console.WriteLine("Expected :" + vValue);
            Console.WriteLine("Actual :" + actualVarianceValue);
            Console.WriteLine("=========================PASSED===========================");
        }

        #endregion

        [AfterTestRun]
        public static void TearDown()
        {
            UIActions.Quit();
        }
    }
}
