using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
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

        public static void PaymentScheduleValidation(int newInputValue)
        {
            var paymentScheduleGridRowCount = UIActions.Count(MiPaymtScheduleGridRowsCount);
            var numberOfPaymentArray = new[] {"35", "313"};
            var totalNumberOfpayments = 0;


            if (newInputValue == 131189 || newInputValue == 164860)
                Assert.AreEqual(3, paymentScheduleGridRowCount, "Payment Schedule Grid entries are not as expected");

            if (newInputValue == 131188)
                Assert.AreEqual(4, paymentScheduleGridRowCount, "Payment Schedule Grid entries are not as expected");

            if (newInputValue == 164861)
                Assert.AreEqual(2, paymentScheduleGridRowCount, "Payment Schedule Grid entries are not as expected");

            for (var row = 1; row <= paymentScheduleGridRowCount; row++)
            {
                var numberOfPaymentGridValues =
                    UIActions.GetText(
                        By.XPath("//section[@id='PaymentScheduleOutput']//tbody/tr[" + row + "]/td[2]//span"));
                Assert.False(numberOfPaymentArray.Contains(numberOfPaymentGridValues), "Number of Payment value does not recalculated");

                totalNumberOfpayments += Convert.ToInt32(numberOfPaymentGridValues);
            }
            Assert.AreEqual(360, totalNumberOfpayments, "Total number of payments value is not as expected");
        }

        public static void PmiRatesGridValidation()
        {
            var paymentScheduleGridRowCount = UIActions.Count(MiPmiRatesGridRowsCount);
            var numberOfPaymentArray = new[] { "1", "13", "121" };

            Assert.AreEqual(3, paymentScheduleGridRowCount, "PMI Rates Grid entries are not as expected");
            

            for (var row = 1; row <= paymentScheduleGridRowCount; row++)
            {
                var pmiRatesBeginPeriod =
                    UIActions.GetText(
                        By.XPath("//section[@id='MortgageGrid']//tbody/tr[" + row + "]/td[2]//span"));
                Assert.True(numberOfPaymentArray.Contains(pmiRatesBeginPeriod), "PMI Rates Begin Period values are not as expected");
            }
        }

        public static void PrepaidChargeGridValidation()
        {
            var prepaidChargeGridRowCount = UIActions.Count(PcPrepaidChargeGridCount);
            Assert.AreEqual(1, prepaidChargeGridRowCount, "Prepaid Charge Grid entries are not as expected");

            var prepaidCustomName = TridVariable.PrepaidCustomName;
            var actualPrepaidCustomName = UIActions.GetText(PcPrepaidChargeGridCustomName);
            Assert.AreEqual(prepaidCustomName, actualPrepaidCustomName, "Prepaid Charge Custom Name is not as expected");


            var prepaidCustomValue = TridVariable.PrepaidCustomValue;
            var actualPrepaidCustomValue = UIActions.GetText(PcPrepaidChargeGridCustomValue);
            Assert.AreEqual(prepaidCustomValue, actualPrepaidCustomValue,
                "Prepaid Charge Custom Value is not as expected");
        }
    }
}

