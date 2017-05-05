using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecRun.Helper;
using TRID.ActionClasses;
using TRID.CommonUtils;
using TRID.ProjectLibs.UI;

namespace TRID.ProjectLibs.Common
{
    class ProjActions : TridHeaderUiElements
    {

        public static void AddPrepaidChargesDefaultValues()
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

        public static string GetDate(string variable)
        {
            string date = "null";
            if (variable.IsNotNullOrEmpty())
            {
                date = DateTime.FromOADate(Convert.ToDouble(variable)).ToString("M/d/yyyy");
            }
            return date;
        }

        public static void AddPmiRateValues()
        {
            var pmiRatesGridRowsCount = UIActions.Count(PmiRatesGridRowsCount);

            if (pmiRatesGridRowsCount == 0)
            {
                var firstAddNumber = TridVariable.FirstAddNumber;
                UIActions.Clear(AddNumber);
                UIActions.GiveInput(AddNumber, firstAddNumber);

                var firstAddBeginPeriod = TridVariable.FirstAddBeginPeriod;
                UIActions.Clear(AddBeginPeriod);
                UIActions.GiveInput(AddBeginPeriod, firstAddBeginPeriod);

                var firstAddEndPeriod = TridVariable.FirstAddEndPeriod;
                UIActions.Clear(AddEndPeriod);
                UIActions.GiveInput(AddEndPeriod, firstAddEndPeriod);

                var firstAddPmiRate = TridVariable.FirstAddPmiRate;
                UIActions.Clear(AddPmiRate);
                UIActions.GiveInput(AddPmiRate, firstAddPmiRate);

                UIActions.Click(AddButton);
                Thread.Sleep(5000);

                var secondAddNumber = TridVariable.SecondAddNumber;
                UIActions.Clear(AddNumber);
                UIActions.GiveInput(AddNumber, secondAddNumber);

                var secondAddBeginPeriod = TridVariable.SecondAddBeginPeriod;
                UIActions.Clear(AddBeginPeriod);
                UIActions.GiveInput(AddBeginPeriod, secondAddBeginPeriod);

                var secondAddEndPeriod = TridVariable.SecondAddEndPeriod;
                UIActions.Clear(AddEndPeriod);
                UIActions.GiveInput(AddEndPeriod, secondAddEndPeriod);

                var secondAddPmiRate = TridVariable.SecondAddPmiRate;
                UIActions.Clear(AddPmiRate);
                UIActions.GiveInput(AddPmiRate, secondAddPmiRate);

                UIActions.Click(AddButton);
                Thread.Sleep(5000);

                var thirdAddNumber = TridVariable.ThirdAddNumber;
                UIActions.Clear(AddNumber);
                UIActions.GiveInput(AddNumber, thirdAddNumber);

                var thirdAddBeginPeriod = TridVariable.ThirdAddBeginPeriod;
                UIActions.Clear(AddBeginPeriod);
                UIActions.GiveInput(AddBeginPeriod, thirdAddBeginPeriod);

                var thirdAddEndPeriod = TridVariable.ThirdAddEndPeriod;
                UIActions.Clear(AddEndPeriod);
                UIActions.GiveInput(AddEndPeriod, thirdAddEndPeriod);

                var thirdAddPmiRate = TridVariable.ThirdAddPmiRate;
                UIActions.Clear(AddPmiRate);
                UIActions.GiveInput(AddPmiRate, thirdAddPmiRate);

                UIActions.Click(AddButton);
                Thread.Sleep(5000);
            }
            else
            {
                PmiRatesGridValidation();
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
            var pmiRatesGridRowsCount = UIActions.Count(PmiRatesGridRowsCount);
            var numberOfPaymentArray = new[] { TridVariable.FirstAddBeginPeriod, TridVariable.SecondAddBeginPeriod, TridVariable.ThirdAddBeginPeriod };

            Thread.Sleep(3000);
            Assert.AreEqual(3, pmiRatesGridRowsCount, "PMI Rates Grid entries are not as expected");

            for (var row = 1; row <= pmiRatesGridRowsCount; row++)
            {
                var pmiRatesBeginPeriod =
                    UIActions.GetText(
                        By.XPath("//section[@id='MortgageGrid']//tbody/tr[" + row + "]/td[2]//span"));
                Thread.Sleep(3000);
                Assert.True(numberOfPaymentArray.Contains(pmiRatesBeginPeriod), "PMI Rates Begin Period values are not as expected");
                Thread.Sleep(3000);
            }
        }

        public static void PmiRatesGridEmptyValidation()
        {
            var isRowExists = false;
            try
            {
                UIActions.Count(PmiRatesGridRowsCount);
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
            var prepaidChargeGridRowCount = UIActions.Count(PrepaidChargeGridCount);
            Assert.AreEqual(1, prepaidChargeGridRowCount, "Prepaid Charge Grid entries are not as expected");

            var prepaidCustomName = TridVariable.PrepaidCustomName;
            var actualPrepaidCustomName = UIActions.GetText(PrepaidChargeGridCustomName);
            Assert.AreEqual(prepaidCustomName, actualPrepaidCustomName, "Prepaid Charge Custom Name is not as expected");


            var prepaidCustomValue = TridVariable.PrepaidCustomValue;
            var actualPrepaidCustomValue = UIActions.GetText(PrepaidChargeGridCustomValue);
            Assert.AreEqual(prepaidCustomValue, actualPrepaidCustomValue,
                "Prepaid Charge Custom Value is not as expected");
        }

        public static void PrepaidChargesGridEmptyValidation()
        {
            var isRowExists = false;
            try
            {
                UIActions.GetText(PrepaidChargeGridCount);
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

