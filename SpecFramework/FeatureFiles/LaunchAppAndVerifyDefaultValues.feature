Feature: LaunchAppAndVerifyDefaultValues
 #The user opens the app and the app has default values

@TestDefaultValues
Scenario Outline: Launch TRID App and verify default values for Prepaid Charges Page
Given user enters Trid Application url in browser
	And user gets default values from Excel sheet <sheetName> for scenario <scenarioNo>
When TRID Application launches
Then default page should be Prepaid Charges Page
	And all the input and custom fields should have zero values
	And Disclosed Values of Finance Charge, Prepaid Charge and Amount Financed are set to default values
Examples: 
	| scenarioNo | sheetName      |
	| 1          | PrepaidCharges |



@TestDefaultValues
Scenario Outline: Launch TRID App and verify default values for Mortgage Insurance Page
Given user enters Trid Application url in browser
	And user gets default values from Excel sheet <sheetName> for scenario <scenarioNo>
When user navigate to Mortgage Insurance Page
Then PMI rates Grid should be empty
	And lower of cost or Appraisal should have default value
Examples: 
	| scenarioNo | sheetName1        |
	| 1          | MortgageInsurance |



@TestDefaultValues
Scenario Outline: Launch TRID App and verify default values for Loan Estimate Page
Given user enters Trid Application url in browser
	And user gets default values from Excel sheet <sheetName> for scenario <scenarioNo>
When user navigate to Loan Estimate Page
	And user selects Calculation Method in Loan Estimate Page
	And user selects loan type in Loan Estimate Page 
	And user selects Frequency of Payments in Loan Estimate Page 
	And user selects Loan Term in Loan Estimate Page 
	And user selects Repayment Term Type in Loan Estimate Page
	And Enter Loan detail input values for computation for Loan Estimate page
	And Enter Disclosed input values for Loan Estimate Page
Examples: 
	| scenarioNo | sheetName    |
	| 1          | LoanEstimate |



@TestDefaultValues
Scenario Outline: Launch TRID App and verify default values for Export Page
Given user enters Trid Application url in browser
	And user gets default values from Excel sheet <sheetName> for scenario <scenarioNo>
When user navigate to Export Page
Then all the input values should have default values
	And click on Test button on Export Page
	And click on Export to pdf button on Export Page
	And file gets downloaded with <DownloadedFileName>
Examples: 
	| scenarioNo | sheetName | DownloadedFileName        |
	| 1          | Export    | Wipfli-TridCalculator.pdf |