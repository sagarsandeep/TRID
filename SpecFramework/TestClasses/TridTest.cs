using System;
using System.Configuration;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using TRID.ActionClasses;
using TRID.CommonUtils;
using TRID.Config;
using TRID.GlobalParam;
using TRID.ProjectLibs.UI;

namespace TRID.TestClasses
{
  public  class TridTest : UIElements
  {
      private static string Url => ConfigurationManager.AppSettings["url"];
        public TridTest()
        {
            ObjectRepo.Config = new AppConfigReader();
            ObjectRepo.SetDriver = new DriverSetup();
            ObjectRepo.Driver = ObjectRepo.SetDriver.InitDriver(ObjectRepo.Driver, ObjectRepo.Config);
            ObjectRepo.Wait = new WebDriverWait(ObjectRepo.Driver, TimeSpan.FromSeconds(30));
            UIActions.WindowMaximize();
            UIActions.GoToUrl(Url + "?tKey=EB535076-2140-4106-8CAE-B230F6E2D082&aKey=TRID");
            Thread.Sleep(10000);
        }
    }
}
