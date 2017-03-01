using System;
using TRID.CommonUtils;
using TRID.Config;
using TRID.GlobalParam;

namespace TRID.TestClasses
{
    class LaunchTridApplication
    {
        public void GetTridApplication(string url)
        {
            ObjectRepo.Config = new AppConfigReader();
            ObjectRepo.SetDriver = new DriverSetup();
            ObjectRepo.Driver = ObjectRepo.SetDriver.InitDriver(ObjectRepo.Driver, ObjectRepo.Config);
            ObjectRepo.Driver.Url = url;
            ObjectRepo.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));
        }
    }
}
