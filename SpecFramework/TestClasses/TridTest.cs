﻿using System;
using OpenQA.Selenium.Support.UI;
using TRID.CommonUtils;
using TRID.Config;
using TRID.GlobalParam;
using TRID.ProjectLibs.UI;

namespace TRID.TestClasses
{
  public  class TridTest : UIElements
    {
        public TridTest()
        {
            ObjectRepo.Config = new AppConfigReader();
            ObjectRepo.SetDriver = new DriverSetup();
            ObjectRepo.Driver = ObjectRepo.SetDriver.InitDriver(ObjectRepo.Driver, ObjectRepo.Config);
            ObjectRepo.Wait = new WebDriverWait(ObjectRepo.Driver, TimeSpan.FromSeconds(30));

        }
    }
}
