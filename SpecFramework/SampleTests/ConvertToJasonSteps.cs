using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using TechTalk.SpecFlow;
using TRID.ProjectLibs.Common;

namespace TRID.SampleTests
{
    [Binding]
    public class ConvertToJasonSteps : TridVariable
    {
        public class data
        {
            public int Id { get; set; }
            public int SSN { get; set; }
            public string Message { get; set; }

        }
        [Then(@"convert Excel values into json format")]
        public void ThenConvertExcelValuesIntoJsonFormat()
        {
            List<TridVariable> data = new List<TridVariable>();
            data.Add(new TridVariable()
            {
            //CalculationMethod = stringValue;
            //LoanType = stringValue;
            //FrequencyOfPayments = stringValue;
            //LoanTerm = stringValue;
            //AdvanceType = stringValue;
        });
            string json = JsonConvert.SerializeObject(data.ToArray());

            //write string to file
            System.IO.File.WriteAllText(@"D:\path.txt", json);
        }
    }
}
