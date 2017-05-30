﻿using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecRun.Helper;
using TRID.ActionClasses;
using TRID.ProjectLibs.UI;

namespace TRID.ProjectLibs.Common
{
    class ProjActions : TridHeaderUiElements
    {

        public static double GetNumericValueFromString(string inputString)
        {
            var result = Regex.Replace(inputString, @"[^0-9\.-]+", "");
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
                date = variable.Equals("N/A") ? "N/A" : DateTime.FromOADate(Convert.ToDouble(variable)).ToString("M/d/yyyy");
            }
            return date;
        }

        public static void AddPmiRateValues()
        {
            var pmiRatesGridRowsCount = UIActions.Count(PmiRatesGridRowsCount);

            if (TridVariable.FirstAddNumber != "")
            {
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
                    Thread.Sleep(1000);

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
                    Thread.Sleep(1000);

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
                    Thread.Sleep(1000);
                }
                else
                {
                    PmiRatesGridValidation();
                }
            }
        }

        public static void PmiRatesGridValidation()
        {
            if (TridVariable.FirstAddNumber != "")
            {
                var pmiRatesGridRowsCount = UIActions.Count(PmiRatesGridRowsCount);
                var numberOfPaymentArray = new[]
                {
                    TridVariable.FirstAddBeginPeriod,
                    TridVariable.SecondAddBeginPeriod,
                    TridVariable.ThirdAddBeginPeriod
                };
                Assert.AreEqual(3, pmiRatesGridRowsCount, "PMI Rates Grid entries are not as expected");

                for (var row = 1; row <= pmiRatesGridRowsCount; row++)
                {
                    var pmiRatesBeginPeriod =
                        UIActions.GetText(
                            By.XPath("//section[@id='MortgageGrid']//tbody/tr[" + row + "]/td[2]//span"));
                    Assert.True(numberOfPaymentArray.Contains(pmiRatesBeginPeriod),
                        "PMI Rates Begin Period values are not as expected");
                }
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

            var prepaidCustomName = TridVariable.PrepaidCustomFieldsCustomName;
            var actualPrepaidCustomName = UIActions.GetText(PrepaidChargeGridCustomName);
            Assert.AreEqual(prepaidCustomName, actualPrepaidCustomName, "Prepaid Charge Custom Name is not as expected");


            var prepaidCustomValue = TridVariable.PrepaidCustomFieldsCustomValue;
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

