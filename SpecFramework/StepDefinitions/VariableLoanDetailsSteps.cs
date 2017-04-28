using System;
using System.Threading;
using TechTalk.SpecFlow;
using TRID.ActionClasses;
using TRID.CommonUtils;
using TRID.ProjectLibs.Common;
using TRID.TestClasses;

namespace TRID.StepDefinitions
{
    [Binding]
    public class VariableLoanDetailsSteps : TridTest
    {
        readonly GetExcelData _getData = new GetExcelData();

        [Given(@"user have variable loan data from excel sheet (.*) for the scenario (.*)")]
        public void GivenUserHaveVariableLoanDataFromExcelSheetForTheScenario(string sheetName, int scenarioNo)
        {
            _getData.GetExcelValues(scenarioNo, sheetName);
        }

        [When(@"user navigate to Variable Loan Details Page")]
        public void WhenUserNavigateToVariableLoanDetailsPage()
        {
            UIActions.Click(VariableAmortizationLink);
            Thread.Sleep(5000);
        }
        
        [When(@"user enters input values for Variable Loan Details Page")]
        public void WhenUserEntersInputValuesForVariableLoanDetailsPage()
        {
            var loanAmount = TridVariable.LoanAmount;
            UIActions.Clear(LoanAmount);
            UIActions.GiveInput(LoanAmount, loanAmount);

            var rateOfInterest = TridVariable.RateOfInterest;
            UIActions.Clear(RateOfInterest);
            UIActions.GiveInput(RateOfInterest, rateOfInterest);

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
}
