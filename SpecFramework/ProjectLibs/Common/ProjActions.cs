using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecRun.Helper;
using TRID.ActionClasses;
using TRID.ProjectLibs.UI;

namespace TRID.ProjectLibs.Common
{
    class ProjActions : TridHeaderUiElements
    {
        private static string UploadFilePath => ConfigurationManager.AppSettings["UploadFilePath"];
        public static StringBuilder CsvFile = new StringBuilder();
        public static string CsvFilePath => ConfigurationManager.AppSettings["CsvFilePath"];

        public static void CreateCsvCardsHeaderFile()
        {
            string csvHeaderFilePath = CsvFilePath + _getSheetName + "CardsHeader.csv";

            if (File.Exists(csvHeaderFilePath))
                File.Delete(csvHeaderFilePath);

            if (_getSheetName == "ClosingDisclosure")
            {              
                CsvFile.AppendLine(
                        "Scenario#,PrincipalAndInt,MortgageInsurance,ScheduledPMITerminationDate,EstimatedTotalMonthlyPayment," +
                        "APR,APRWIN,Balloon Amount,TotalOfPayments,FinanceCharge,PrepaidCharges,AmountFinanced,TIP," +
                        "EscrowPropertyOverOneYear11Months,EscrowPropertyOverOneYear12Months,InitialEscrowPymt," +
                        "NonEscrowPropertyOverOneYear,EstimatedEscrow,EstimatedTaxesInsuranceAssessments," +
                        "In 5 years,In 5 Years Principal");
            }

            if (_getSheetName == "PaymentSchedule")
            {
                CsvFile.AppendLine(
                        "Scenario#,PaymentStreamNo,NumberOfPayments,PaymentAmount,MonthlyPayment,MonthlyPMI,InsEscrowedAmount,TaxEscrowedAmt,EscrowOther1,EscrowOther2");
            }

            if (_getSheetName == "EscrowInfo")
            {
                CsvFile.AppendLine(
                        "Scenario#,InsPeriodDeposit,TaxPeriodDeposit,PmiPeriodDeposit,PmiLowBalance,PmiCushion,PmiTotalAnnualDisbursed,Other1InitialDeposit" +
                        ",Other1PeriodDeposit, Other1LowBalance, Other1Cushion, Other1TotalAnnualDisbursed, Other2InitialDeposit, Other2PeriodDeposit, " +
                        "Other2LowBalance, Other2Cushion, Other2TotalAnnualDisbursed, AggregateInitialDeposit, AggregatePeriodDeposit, AggregateLowBalance, AggregateCushion, AggregateTotalAnnualDisbursed");
            }

            File.AppendAllText(csvHeaderFilePath, CsvFile.ToString());         
        }

        public static void CreateCsvFile(string newColumnValue)
        {
            string csvScenarioFilePath = CsvFilePath + _getSheetName + "_"+ TridVariable.ScenarioNo + ".csv";
            if (File.Exists(csvScenarioFilePath))
            {
                List<string> lines = File.ReadAllLines(csvScenarioFilePath).ToList();
                lines[0] += "," + newColumnValue;
                File.WriteAllLines(csvScenarioFilePath, lines);
            }
            else
            {
                string firstValues = $"{TridVariable.ScenarioNo},{newColumnValue}";
                CsvFile.Append(firstValues);
                File.WriteAllText(csvScenarioFilePath, CsvFile.ToString());
            }
        }

        public static void UploadJsonFile()
        {
            UIActions.Click(BrowseButton);
            Thread.Sleep(500);
            SendKeys.SendWait(UploadFilePath + TridVariable.ScenarioNo +".json");
            Thread.Sleep(500);
            SendKeys.SendWait(@"{Enter}");
            Thread.Sleep(500);
            UIActions.Click(UploadButton);
        }

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
                    Thread.Sleep(250);
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
                    Thread.Sleep(500);

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
                    Thread.Sleep(500);

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
                    Thread.Sleep(500);
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


        public static void AddPrepaidCustomValues()
        {
            if (TridVariable.PrepaidCustomFieldsCustomName != "")
            {
                if (TridVariable.PrepaidCustomFieldsCustomName != "0")
                {
                    UIActions.Clear(PrepaidChargeGridCustomName);
                    UIActions.GiveInput(PrepaidChargeGridCustomName, TridVariable.PrepaidCustomFieldsCustomName);

                    UIActions.Clear(PrepaidChargeGridCustomValue);
                    UIActions.GiveInput(PrepaidChargeGridCustomValue, TridVariable.PrepaidCustomFieldsCustomValue);

                    UIActions.Click(CustomFieldAddButton);
                }
            }
            else
                PrepaidChargeGridValidation();
        }

        public static void PrepaidChargeGridValidation()
        {

            if (TridVariable.PrepaidCustomFieldsCustomName != "")
                if (TridVariable.PrepaidCustomFieldsCustomName != "0")
                {
                    var prepaidChargeGridRowCount = UIActions.Count(PrepaidChargeCustomGridCount);
                    Assert.AreEqual(1, prepaidChargeGridRowCount,
                        "Prepaid Charge Custom Grid entries are not as expected");

                    var prepaidCustomName = TridVariable.PrepaidCustomFieldsCustomName;
                    var actualPrepaidCustomName = UIActions.GetText(PrepaidChargeGridCustomName);
                    Assert.AreEqual(prepaidCustomName, actualPrepaidCustomName,
                        "Prepaid Charge Custom Name is not as expected");

                    var prepaidCustomValue = TridVariable.PrepaidCustomFieldsCustomValue;
                    var actualPrepaidCustomValue = UIActions.GetText(PrepaidChargeGridCustomValue);
                    Assert.AreEqual(prepaidCustomValue, actualPrepaidCustomValue,
                        "Prepaid Charge Custom Value is not as expected");
                }
        }

        public static void PrepaidChargesGridEmptyValidation()
        {
            var isRowExists = false;
            try
            {
                UIActions.GetText(PrepaidChargeCustomGridCount);
                isRowExists = true;
            }
            catch (Exception)
            {
                // ignored
            }
            if (isRowExists)
                throw new Exception("Prepaid Charges Custom Grid is not empty");
        }

        private static string _getSheetName;
        public static void GetSheetName(string sheetName)
        {
            //if (sheetName == "ClosingDisclosure") { var closingDisclosureSheetName = sheetName;}
            //if (sheetName == "PaymentSchedule") { var paymentScheduleeSheetName = sheetName;}
            //if (sheetName == "EscrowInfo") { var escrowInfoSheetName = sheetName;}

            _getSheetName = sheetName;
        }
    }
}

