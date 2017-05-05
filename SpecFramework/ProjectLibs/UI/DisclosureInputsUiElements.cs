﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TRID.ProjectLibs.UI
{
    public class DisclosureInputsUiElements : ClosingDisclosureCardsUiElements
    {       
        public static By DisclosedValuesText = By.XPath("//div[@id='DisclosureInput']/md-toolbar");

        //Closing Disclosure
        public static By DisclosedMonthlyPrincipalandInterest = By.XPath("//div[@title='Dscl Monthly Principal And Interest']//input");
        public static By DisclosedMonthlyPmi = By.XPath("//div[@title='Dscl Monthly PMI']//input");
        public static By DisclosedTotalPeriodicPayment = By.XPath("//div[@title='Dscl Total Periodic Payment ']//input");
        public static By DisclosedPmiTerminalDate = By.XPath("//div[@title='Dscl PMI Termination Date (78%)']//input");
        public static By DisclosedPmiCancelDate = By.XPath("//div[@title='Dscl PMI Cancel Date (80%)']//input");
        public static By DisclosedFinalBalloonPayment = By.XPath("//div[@title='Dscl Final Balloon Payment']//input");
        public static By DisclosedTotalOfPayment = By.XPath("//div[@title='Dscl Total Of Payment']//input");


        //Loan Estimate
        public static By DisclosedIn5Years = By.XPath("//div[@title='Dscl In 5 Years']//input");
        public static By DisclosedIn5YearsPrincipal = By.XPath("//div[@title='Dscl In 5 Years Principal']//input");
        public static By DisclosedApr = By.XPath("//div[@title='Dscl APR']//input");
        public static By DisclosedTip = By.XPath("//div[@title='Dscl Total Interest Percentage']//input");

        //Escrow
        public static By EscrowPropertyOverOneYear = By.XPath("//div[@title='Escrow Property Over One Year']//input");
        public static By NonEscrowPropertyOverOneYear = By.XPath("//div[@title='Non Escrow Property Over One Year']//input");
        public static By InitialEscrowPayment = By.XPath("//div[@title='Initial Escrow Payment']//input");
        //public static By MonthlyEscrowPayment = By.XPath("//div[@title='Monthly Escrow Payment']//input");
        public static By DisclosedEscrowPropertyOverOneYear = By.XPath("//div[@title='Dscl Escrow Property Over One Year']//input");
        public static By DisclosedNonEscrowPropertyOverOneYear = By.XPath("//div[@title='Dscl Non Escrow Property Over One Year']//input");
        public static By DisclosedInitialEscrowPayment = By.XPath("//div[@title='Dscl Initial Escrow Payment']//input");
        public static By DisclosedMonthlyEscrowPayment = By.XPath("//div[@title='Dscl Monthly Escrow Payment']//input");
        public static By DisclosedEstimatedEscrow = By.XPath("//div[@title=' Dscl Estimated Escrow']//input");


        //Prepaid Charges
        public static By DisclosedFinanceCharge = By.XPath("//div[@title='Dscl Finance Charge']//input");
        public static By DisclosedPrepaidCharge = By.XPath("//div[@title='Dscl Prepaid Charge']//input");
        public static By DisclosedAmountFinanced = By.XPath("//div[@title='Dscl Amount Financed']//input");
    }
}
