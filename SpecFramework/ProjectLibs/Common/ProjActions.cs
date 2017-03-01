using System;
using System.Text.RegularExpressions;
using System.Threading;
using TRID.ActionClasses;
using TRID.ProjectLibs.UI;

namespace TRID.ProjectLibs.Common
{
    class ProjActions : UIElements
    {


        public static void AddPrepaidChargesDefaultValues()
        {
            var fhaVaUsdaUpfrontPmiFree = TridVariable.FhaVaUsdaUpfrontPmiFree;
            UIActions.Clear(PcFhaVaUsdaUpfrontPmiFree);
            UIActions.GiveInput(PcFhaVaUsdaUpfrontPmiFree, fhaVaUsdaUpfrontPmiFree);

            var floodFee = TridVariable.FloodFee;
            UIActions.Clear(PcFloodFee);
            UIActions.GiveInput(PcFloodFee, floodFee);

            var inspectionFee = TridVariable.InspectionFee;
            UIActions.Clear(PcInspectionFee);
            UIActions.GiveInput(PcInspectionFee, inspectionFee);

            var loanOriginationFee = TridVariable.LoanOriginationFee;
            UIActions.Clear(PcLoanOriginationFee);
            UIActions.GiveInput(PcLoanOriginationFee, loanOriginationFee);

            var otherFees = TridVariable.OtherFees;
            UIActions.Clear(PcOtherFees);
            UIActions.GiveInput(PcOtherFees, otherFees);

            var pmiEscrowed = TridVariable.PmiEscrowed;
            UIActions.Clear(PcPmiEscrowed);
            UIActions.GiveInput(PcPmiEscrowed, pmiEscrowed);

            var prepaidDailyInterest = TridVariable.PrepaidDailyInterest;
            UIActions.Clear(PcPrepaidDailyInterest);
            UIActions.GiveInput(PcPrepaidDailyInterest, prepaidDailyInterest);

            var taxServicing = TridVariable.TaxServicing;
            UIActions.Clear(PcTaxServicing);
            UIActions.GiveInput(PcTaxServicing, taxServicing);

            var titleClosingFee = TridVariable.TitleClosingFee;
            UIActions.Clear(PcTitleClosingFee);
            UIActions.GiveInput(PcTitleClosingFee, titleClosingFee);

            var titleClosingProtectionLetter = TridVariable.TitleClosingProtectionLetter;
            UIActions.Clear(PcTitleClosingProtectionLetter);
            UIActions.GiveInput(PcTitleClosingProtectionLetter, titleClosingProtectionLetter);

            var titleCourierFee = TridVariable.TitleCourierFee;
            UIActions.Clear(PcTitleCourierFee);
            UIActions.GiveInput(PcTitleCourierFee, titleCourierFee);

            var titleDrawFee = TridVariable.TitleDrawFee;
            UIActions.Clear(PcTitleDrawFee);
            UIActions.GiveInput(PcTitleDrawFee, titleDrawFee);

            var titleWireFee = TridVariable.TitleWireFee;
            UIActions.Clear(PcTitleWireFee);
            UIActions.GiveInput(PcTitleWireFee, titleWireFee);

            var underWriting = TridVariable.UnderWriting;
            UIActions.Clear(PcUnderWriting);
            UIActions.GiveInput(PcUnderWriting, underWriting);       
        }

        //readonly GetExcelData _getData = new GetExcelData();
        public static double GetNumericValueFromString(string inputString)
        {
            var result = Regex.Replace(inputString, @"[^0-9\.]+", "");
            return Convert.ToDouble(result);
        }

        //public static void CardsDataValidation()
        //{
        //    var cValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPiComputedValue));

        //    var actualCValue = Convert.ToDouble(_getData.GetExcelCellValues("Scenario", 8, 27));
        //    Assert.AreEqual(actualCValue, cValue, "Computed value does not match as expected");

        //    var dValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPiDisclosureValue));
        //    var vValue = ProjActions.GetNumericValueFromString(UIActions.GetText(CdPiVarianceValue));

        //    var actualVarianceValue = Math.Abs(Math.Round(cValue - dValue, 2));

        //    Assert.AreEqual(vValue, actualVarianceValue, "Variance does not match as expected");
        //}


        public static void AddPmiRate()
        {
            var firstAddNumber = TridVariable.FirstAddNumber;
            UIActions.Clear(MiAddNumber);
            UIActions.GiveInput(MiAddNumber, firstAddNumber);

            var firstAddBeginPeriod = TridVariable.FirstAddBeginPeriod;
            UIActions.Clear(MiAddBeginPeriod);
            UIActions.GiveInput(MiAddBeginPeriod, firstAddBeginPeriod);

            var firstAddEndPeriod = TridVariable.FirstAddEndPeriod;
            UIActions.Clear(MiAddEndPeriod);
            UIActions.GiveInput(MiAddEndPeriod, firstAddEndPeriod);

            var firstAddPmiRate = TridVariable.FirstAddPmiRate;
            UIActions.Clear(MiAddPmiRate);
            UIActions.GiveInput(MiAddPmiRate, firstAddPmiRate);

            UIActions.Click(MiAddButton);
            Thread.Sleep(5000);

            var secondAddNumber = TridVariable.SecondAddNumber;
            UIActions.Clear(MiAddNumber);
            UIActions.GiveInput(MiAddNumber, secondAddNumber);

            var secondAddBeginPeriod = TridVariable.SecondAddBeginPeriod;
            UIActions.Clear(MiAddBeginPeriod);
            UIActions.GiveInput(MiAddBeginPeriod, secondAddBeginPeriod);

            var secondAddEndPeriod = TridVariable.SecondAddEndPeriod;
            UIActions.Clear(MiAddEndPeriod);
            UIActions.GiveInput(MiAddEndPeriod, secondAddEndPeriod);

            var secondAddPmiRate = TridVariable.SecondAddPmiRate;
            UIActions.Clear(MiAddPmiRate);
            UIActions.GiveInput(MiAddPmiRate, secondAddPmiRate);

            UIActions.Click(MiAddButton);
            Thread.Sleep(5000);

            var thirdAddNumber = TridVariable.ThirdAddNumber;
            UIActions.Clear(MiAddNumber);
            UIActions.GiveInput(MiAddNumber, thirdAddNumber);

            var thirdAddBeginPeriod = TridVariable.ThirdAddBeginPeriod;
            UIActions.Clear(MiAddBeginPeriod);
            UIActions.GiveInput(MiAddBeginPeriod, thirdAddBeginPeriod);

            var thirdAddEndPeriod = TridVariable.ThirdAddEndPeriod;
            UIActions.Clear(MiAddEndPeriod);
            UIActions.GiveInput(MiAddEndPeriod, thirdAddEndPeriod);

            var thirdAddPmiRate = TridVariable.ThirdAddPmiRate;
            UIActions.Clear(MiAddPmiRate);
            UIActions.GiveInput(MiAddPmiRate, thirdAddPmiRate);

            UIActions.Click(MiAddButton);
            Thread.Sleep(5000);
        }

       
    }
}
