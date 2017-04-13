using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using TRID.GlobalParam;

namespace TRID.ActionClasses
{
    public class UIActions
    {
        public static void GoToUrl(string url)
        {
            ObjectRepo.Driver.Navigate().GoToUrl(url);
        }

        public static void WindowMaximize()
        {
            ObjectRepo.Driver.Manage().Window.Maximize();
        }

        public static void Clear(By element)
        {
            ObjectRepo.Driver.FindElement(element).Clear();
        }

        public static void Click(By element)
        {
            ObjectRepo.Driver.FindElement(element).Click();
        }

        public static void GiveInput(By element, string input)
        {
            ObjectRepo.Driver.FindElement(element).SendKeys(input);
        }
        public static string GetText(By element)
        {
            return ObjectRepo.Driver.FindElement(element).Text;
        }

        public static int Count(By element)
        {
            return ObjectRepo.Driver.FindElements(element).Count;
        }

        public static string GetTitle()
        {
            return ObjectRepo.Driver.Title;
        }

        public static void ImplicitlyWait(int timeoutInSeconds)
        {
            ObjectRepo.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(timeoutInSeconds));
        }

        public static void WebDriverWait(By element, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
               new WebDriverWait(ObjectRepo.Driver, TimeSpan.FromSeconds(timeoutInSeconds)).Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(element));
        }


        static Actions _actions = new Actions(ObjectRepo.Driver);
        public static void MouseHoverOver(By element)
        {
            var webElement = ObjectRepo.Driver.FindElement(element);
            _actions.MoveToElement(webElement).Perform();
        }

        public static void Quit()
        {
            ObjectRepo.Driver.Quit();
        }

    }
}
