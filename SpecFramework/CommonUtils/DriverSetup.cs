using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Protractor;
using TRID.Config.enumfolder;
using TRID.Config.Interfaces;
using TRID.CustomExceptions;

namespace TRID.CommonUtils
{
    class DriverSetup
    {
        private IWebDriver GetFirefoxDriver()
        {

            FirefoxBinary binary = new FirefoxBinary(@"C:\Program Files (x86)\Mozilla Firefox\firefox.exe");
            var profile = new FirefoxProfile();
            IWebDriver driver = new FirefoxDriver(binary, profile);
            //IWebDriver driver = new FirefoxDriver();
            return driver;
        }
        private IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }
        private IWebDriver GetIEDriver()
        {
            IWebDriver driver = new InternetExplorerDriver();
            return driver;
        }

        public IWebDriver InitDriver(IWebDriver driver, Iconfig config)
        {
            switch (config.GetBrowser())
            {
                case BrowserType.Firefox:
                    driver = GetFirefoxDriver();
                    break;

                case BrowserType.Chrome:
                    driver = GetChromeDriver();
                    break;

                case BrowserType.IExplorer:
                    driver = GetIEDriver();
                    break;

                default:
                    throw new NoDriverFound("Driver not found : " + config.GetBrowser());
            }
            return driver;
        }

    }
}
