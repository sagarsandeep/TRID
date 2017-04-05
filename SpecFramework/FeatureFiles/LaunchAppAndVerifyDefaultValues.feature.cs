﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TRID.FeatureFiles
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("LaunchAppAndVerifyDefaultValues", SourceFile="FeatureFiles\\LaunchAppAndVerifyDefaultValues.feature", SourceLine=0)]
    public partial class LaunchAppAndVerifyDefaultValuesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "LaunchAppAndVerifyDefaultValues.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "LaunchAppAndVerifyDefaultValues", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void LaunchTRIDAppAndVerifyDefaultValuesForPrepaidChargesPage(string scenarioNo, string sheetName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TestDefaultValues"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Launch TRID App and verify default values for Prepaid Charges Page", @__tags);
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
testRunner.Given("user enters Trid Application url in browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.And(string.Format("user gets default values from Excel sheet {0} for scenario {1}", sheetName, scenarioNo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
testRunner.When("TRID Application launches", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
testRunner.Then("default page should be Prepaid Charges Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 10
 testRunner.And("all the input and custom fields should have zero values", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("Disclosed Values of Finance Charge, Prepaid Charge and Amount Financed are set to" +
                    " default values", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Launch TRID App and verify default values for Prepaid Charges Page, 1", new string[] {
                "TestDefaultValues"}, SourceLine=13)]
        public virtual void LaunchTRIDAppAndVerifyDefaultValuesForPrepaidChargesPage_1()
        {
            this.LaunchTRIDAppAndVerifyDefaultValuesForPrepaidChargesPage("1", "PrepaidCharges", ((string[])(null)));
#line hidden
        }
        
        public virtual void LaunchTRIDAppAndVerifyDefaultValuesForMortgageInsurancePage(string scenarioNo, string sheetName1, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TestDefaultValues"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Launch TRID App and verify default values for Mortgage Insurance Page", @__tags);
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
testRunner.Given("user enters Trid Application url in browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
 testRunner.And(string.Format("user gets default values from Excel sheet <sheetName> for scenario {0}", scenarioNo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
testRunner.When("user navigate to Mortgage Insurance Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
testRunner.Then("PMI rates Grid should be empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.And("lower of cost or Appraisal should have default value", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Launch TRID App and verify default values for Mortgage Insurance Page, 1", new string[] {
                "TestDefaultValues"}, SourceLine=26)]
        public virtual void LaunchTRIDAppAndVerifyDefaultValuesForMortgageInsurancePage_1()
        {
            this.LaunchTRIDAppAndVerifyDefaultValuesForMortgageInsurancePage("1", "MortgageInsurance", ((string[])(null)));
#line hidden
        }
        
        public virtual void LaunchTRIDAppAndVerifyDefaultValuesForLoanEstimatePage(string scenarioNo, string sheetName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TestDefaultValues"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Launch TRID App and verify default values for Loan Estimate Page", @__tags);
#line 32
this.ScenarioSetup(scenarioInfo);
#line 33
testRunner.Given("user enters Trid Application url in browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
 testRunner.And(string.Format("user gets default values from Excel sheet {0} for scenario {1}", sheetName, scenarioNo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
testRunner.When("user navigate to Loan Estimate Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.And("user selects Calculation Method in Loan Estimate Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("user selects loan type in Loan Estimate Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("user selects Frequency of Payments in Loan Estimate Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("user selects Loan Term in Loan Estimate Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("user selects Repayment Term Type in Loan Estimate Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("Enter Loan detail input values for computation for Loan Estimate page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("Enter Disclosed input values for Loan Estimate Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Launch TRID App and verify default values for Loan Estimate Page, 1", new string[] {
                "TestDefaultValues"}, SourceLine=44)]
        public virtual void LaunchTRIDAppAndVerifyDefaultValuesForLoanEstimatePage_1()
        {
            this.LaunchTRIDAppAndVerifyDefaultValuesForLoanEstimatePage("1", "LoanEstimate", ((string[])(null)));
#line hidden
        }
        
        public virtual void LaunchTRIDAppAndVerifyDefaultValuesForExportPage(string scenarioNo, string sheetName, string downloadedFileName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TestDefaultValues"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Launch TRID App and verify default values for Export Page", @__tags);
#line 50
this.ScenarioSetup(scenarioInfo);
#line 51
testRunner.Given("user enters Trid Application url in browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 52
 testRunner.And(string.Format("user gets default values from Excel sheet {0} for scenario {1}", sheetName, scenarioNo), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
testRunner.When("user navigate to Export Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
testRunner.Then("all the input values should have default values", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
 testRunner.And("click on Test button on Export Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.And("click on Export to pdf button on Export Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.And(string.Format("file gets downloaded with {0}", downloadedFileName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Launch TRID App and verify default values for Export Page, 1", new string[] {
                "TestDefaultValues"}, SourceLine=59)]
        public virtual void LaunchTRIDAppAndVerifyDefaultValuesForExportPage_1()
        {
            this.LaunchTRIDAppAndVerifyDefaultValuesForExportPage("1", "Export", "Wipfli-TridCalculator.pdf", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
