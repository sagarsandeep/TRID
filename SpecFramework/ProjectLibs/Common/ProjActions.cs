using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using TRID.ActionClasses;
using TRID.CommonUtils;
using TRID.ProjectLibs.UI;

namespace TRID.ProjectLibs.Common
{
    class ProjActions
    {

        public static void AddPrepaidChargesDefaultValues()
        {
            var fhaVaUsdaUpfrontPmiFree = TridVariable.FhaVaUsdaUpfrontPmiFree;
            UIActions.Clear(UIElements.PcFhaVaUsdaUpfrontPmiFree);
            UIActions.GiveInput(UIElements.PcFhaVaUsdaUpfrontPmiFree, fhaVaUsdaUpfrontPmiFree);

            var floodFee = TridVariable.FloodFee;
            UIActions.Clear(UIElements.PcFloodFee);
            UIActions.GiveInput(UIElements.PcFloodFee, floodFee);

            var inspectionFee = TridVariable.InspectionFee;
            UIActions.Clear(UIElements.PcInspectionFee);
            UIActions.GiveInput(UIElements.PcInspectionFee, inspectionFee);

            var loanOriginationFee = TridVariable.LoanOriginationFee;
            UIActions.Clear(UIElements.PcLoanOriginationFee);
            UIActions.GiveInput(UIElements.PcLoanOriginationFee, loanOriginationFee);

            var otherFees = TridVariable.OtherFees;
            UIActions.Clear(UIElements.PcOtherFees);
            UIActions.GiveInput(UIElements.PcOtherFees, otherFees);

            var pmiEscrowed = TridVariable.PmiEscrowed;
            UIActions.Clear(UIElements.PcPmiEscrowed);
            UIActions.GiveInput(UIElements.PcPmiEscrowed, pmiEscrowed);

            var prepaidDailyInterest = TridVariable.PrepaidDailyInterest;
            UIActions.Clear(UIElements.PcPrepaidDailyInterest);
            UIActions.GiveInput(UIElements.PcPrepaidDailyInterest, prepaidDailyInterest);

            var taxServicing = TridVariable.TaxServicing;
            UIActions.Clear(UIElements.PcTaxServicing);
            UIActions.GiveInput(UIElements.PcTaxServicing, taxServicing);

            var titleClosingFee = TridVariable.TitleClosingFee;
            UIActions.Clear(UIElements.PcTitleClosingFee);
            UIActions.GiveInput(UIElements.PcTitleClosingFee, titleClosingFee);

            var titleClosingProtectionLetter = TridVariable.TitleClosingProtectionLetter;
            UIActions.Clear(UIElements.PcTitleClosingProtectionLetter);
            UIActions.GiveInput(UIElements.PcTitleClosingProtectionLetter, titleClosingProtectionLetter);

            var titleCourierFee = TridVariable.TitleCourierFee;
            UIActions.Clear(UIElements.PcTitleCourierFee);
            UIActions.GiveInput(UIElements.PcTitleCourierFee, titleCourierFee);

            var titleDrawFee = TridVariable.TitleDrawFee;
            UIActions.Clear(UIElements.PcTitleDrawFee);
            UIActions.GiveInput(UIElements.PcTitleDrawFee, titleDrawFee);

            var titleWireFee = TridVariable.TitleWireFee;
            UIActions.Clear(UIElements.PcTitleWireFee);
            UIActions.GiveInput(UIElements.PcTitleWireFee, titleWireFee);

            var underWriting = TridVariable.UnderWriting;
            UIActions.Clear(UIElements.PcUnderWriting);
            UIActions.GiveInput(UIElements.PcUnderWriting, underWriting);       
        }

        //readonly GetExcelData _getData = new GetExcelData();
        public static double GetNumericValueFromString(string inputString)
        {
            var result = Regex.Replace(inputString, @"[^0-9\.]+", "");
            return Convert.ToDouble(result);
        }

        public static DateTime GetDatePart(By element)
        {
            var datePart = UIActions.GetText(element).Split(':')[1];
            return Convert.ToDateTime(Convert.ToDateTime(datePart).ToString("M/d/yyyy"));
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
            var pmiRatesGridRowsCount = UIActions.Count(UIElements.MiPmiRatesGridRowsCount);

            if (pmiRatesGridRowsCount == 0)
            {
                var firstAddNumber = TridVariable.FirstAddNumber;
                UIActions.Clear(UIElements.MiAddNumber);
                UIActions.GiveInput(UIElements.MiAddNumber, firstAddNumber);

                var firstAddBeginPeriod = TridVariable.FirstAddBeginPeriod;
                UIActions.Clear(UIElements.MiAddBeginPeriod);
                UIActions.GiveInput(UIElements.MiAddBeginPeriod, firstAddBeginPeriod);

                var firstAddEndPeriod = TridVariable.FirstAddEndPeriod;
                UIActions.Clear(UIElements.MiAddEndPeriod);
                UIActions.GiveInput(UIElements.MiAddEndPeriod, firstAddEndPeriod);

                var firstAddPmiRate = TridVariable.FirstAddPmiRate;
                UIActions.Clear(UIElements.MiAddPmiRate);
                UIActions.GiveInput(UIElements.MiAddPmiRate, firstAddPmiRate);

                UIActions.Click(UIElements.MiAddButton);
                Thread.Sleep(5000);

                var secondAddNumber = TridVariable.SecondAddNumber;
                UIActions.Clear(UIElements.MiAddNumber);
                UIActions.GiveInput(UIElements.MiAddNumber, secondAddNumber);

                var secondAddBeginPeriod = TridVariable.SecondAddBeginPeriod;
                UIActions.Clear(UIElements.MiAddBeginPeriod);
                UIActions.GiveInput(UIElements.MiAddBeginPeriod, secondAddBeginPeriod);

                var secondAddEndPeriod = TridVariable.SecondAddEndPeriod;
                UIActions.Clear(UIElements.MiAddEndPeriod);
                UIActions.GiveInput(UIElements.MiAddEndPeriod, secondAddEndPeriod);

                var secondAddPmiRate = TridVariable.SecondAddPmiRate;
                UIActions.Clear(UIElements.MiAddPmiRate);
                UIActions.GiveInput(UIElements.MiAddPmiRate, secondAddPmiRate);

                UIActions.Click(UIElements.MiAddButton);
                Thread.Sleep(5000);

                var thirdAddNumber = TridVariable.ThirdAddNumber;
                UIActions.Clear(UIElements.MiAddNumber);
                UIActions.GiveInput(UIElements.MiAddNumber, thirdAddNumber);

                var thirdAddBeginPeriod = TridVariable.ThirdAddBeginPeriod;
                UIActions.Clear(UIElements.MiAddBeginPeriod);
                UIActions.GiveInput(UIElements.MiAddBeginPeriod, thirdAddBeginPeriod);

                var thirdAddEndPeriod = TridVariable.ThirdAddEndPeriod;
                UIActions.Clear(UIElements.MiAddEndPeriod);
                UIActions.GiveInput(UIElements.MiAddEndPeriod, thirdAddEndPeriod);

                var thirdAddPmiRate = TridVariable.ThirdAddPmiRate;
                UIActions.Clear(UIElements.MiAddPmiRate);
                UIActions.GiveInput(UIElements.MiAddPmiRate, thirdAddPmiRate);

                UIActions.Click(UIElements.MiAddButton);
                Thread.Sleep(5000);

                UIActions.Click(UIElements.MiTestButton);
                Thread.Sleep(5000);
            }
            else
            {
                PmiRatesGridValidation();
                UIActions.Click(UIElements.MiTestButton);
                Thread.Sleep(5000);
            }
        }

        //public static void PaymentScheduleValidation(int newInputValue)
        //{
        //    var paymentScheduleGridRowCount = UIActions.Count(MiPaymtScheduleGridRowsCount);
        //    var numberOfPaymentArray = new[] {"35", "313"};
        //    var totalNumberOfpayments = 0;


        //    if (newInputValue == 131189 || newInputValue == 164860)
        //        Assert.AreEqual(3, paymentScheduleGridRowCount, "Payment Schedule Grid entries are not as expected");

        //    if (newInputValue == 131188)
        //        Assert.AreEqual(4, paymentScheduleGridRowCount, "Payment Schedule Grid entries are not as expected");

        //    if (newInputValue == 164861)
        //        Assert.AreEqual(2, paymentScheduleGridRowCount, "Payment Schedule Grid entries are not as expected");

        //    for (var row = 1; row <= paymentScheduleGridRowCount; row++)
        //    {
        //        var numberOfPaymentGridValues =
        //            UIActions.GetText(
        //                By.XPath("//section[@id='PaymentScheduleOutput']//tbody/tr[" + row + "]/td[2]//span"));
        //        Assert.False(numberOfPaymentArray.Contains(numberOfPaymentGridValues), "Number of Payment value does not recalculated");

        //        totalNumberOfpayments += Convert.ToInt32(numberOfPaymentGridValues);
        //    }
        //    Assert.AreEqual(360, totalNumberOfpayments, "Total number of payments value is not as expected");
        //}

        public static void PmiRatesGridValidation()
        {
            var pmiRatesGridRowsCount = UIActions.Count(UIElements.MiPmiRatesGridRowsCount);
            var numberOfPaymentArray = new[] { "1", "13", "121" };

            Assert.AreEqual(3, pmiRatesGridRowsCount, "PMI Rates Grid entries are not as expected");

            for (var row = 1; row <= pmiRatesGridRowsCount; row++)
            {
                var pmiRatesBeginPeriod =
                    UIActions.GetText(
                        By.XPath("//section[@id='MortgageGrid']//tbody/tr[" + row + "]/td[2]//span"));
                Assert.True(numberOfPaymentArray.Contains(pmiRatesBeginPeriod), "PMI Rates Begin Period values are not as expected");
            }
        }

        public static void PmiRatesGridEmptyValidation()
        {
            var isRowExists = false;
            try
            {
                UIActions.Count(UIElements.MiPmiRatesGridRowsCount);
                isRowExists = true;
            }
            catch (Exception)
            {
                // ignored
            }
            if (isRowExists)
                throw new Exception("PMI Grid is not empty");
            
        }

        public static void PrepaidChargeGridValidation()
        {
            var prepaidChargeGridRowCount = UIActions.Count(UIElements.PcPrepaidChargeGridCount);
            Assert.AreEqual(1, prepaidChargeGridRowCount, "Prepaid Charge Grid entries are not as expected");

            var prepaidCustomName = TridVariable.PrepaidCustomName;
            var actualPrepaidCustomName = UIActions.GetText(UIElements.PcPrepaidChargeGridCustomName);
            Assert.AreEqual(prepaidCustomName, actualPrepaidCustomName, "Prepaid Charge Custom Name is not as expected");


            var prepaidCustomValue = TridVariable.PrepaidCustomValue;
            var actualPrepaidCustomValue = UIActions.GetText(UIElements.PcPrepaidChargeGridCustomValue);
            Assert.AreEqual(prepaidCustomValue, actualPrepaidCustomValue,
                "Prepaid Charge Custom Value is not as expected");
        }

        public static void PrepaidChargesGridEmptyValidation()
        {
            var isRowExists = false;
            try
            {
                UIActions.GetText(UIElements.PcPrepaidChargeGridCount);
                isRowExists = true;
            }
            catch (Exception)
            {
                // ignored
            }
            if (isRowExists)
                throw new Exception("Prepaid Charges Grid is not empty");
        }
    }
}

