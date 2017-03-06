Feature: LaunchAppAndVerifyDefaultValues
 #The user opens the app and the app has default values

@TestDefaultValues
Scenario Outline: Launch TRID App and verify default values for Prepaid Charges Page
Given user enters Trid Application <url> in browser
	And user gets default values from Excel sheet <sheetName>
When TRID Application launches
Then default page should be Prepaid Charges Page
	And all the input and custom fields should have zero values
	And Disclosed Values of Finance Charge, Prepaid Charge and Amount Financed are set to default values
Examples: 
	| url                                                                                                    | sheetName      |
	| httP://thrive-app.azurewebsites.net/Index_Dev.html?tKey=EB535076-2140-4106-8CAE-B230F6E2D082&aKey=TRID | PrepaidCharges |



@TestDefaultValues
Scenario Outline: Launch TRID App and verify default values for Mortgage Insurance Page
Given user enters Trid Application <url> in browser
	And user gets default values from Excel sheet <sheetName>
When user navigate to Mortgage Insurance Page
Then PMI rates Grid should be empty
	And lower of cost or Appraisal should have default value
Examples: 
	| url                                                                                                    | sheetName         |
	| httP://thrive-app.azurewebsites.net/Index_Dev.html?tKey=EB535076-2140-4106-8CAE-B230F6E2D082&aKey=TRID | MortgageInsurance |



@TestDefaultValues
Scenario Outline: Launch TRID App and verify default values for Loan Estimate Page
Given user enters Trid Application <url> in browser
	And user gets default values from Excel sheet <sheetName>
When user navigate to Loan Estimate Page
Then calculation Method should have default value
	And Loan Type should have default value
	And Frequency of Payments should have default value
	And Loan Term should have default value
	And Repayment Term Type should have default value
	And Date of Loan, Date of Interest begins to accure and Date of First Payment should have default value
	And Disclosed values should have default values
Examples: 
	| url                                                                                                    | sheetName    |
	| httP://thrive-app.azurewebsites.net/Index_Dev.html?tKey=EB535076-2140-4106-8CAE-B230F6E2D082&aKey=TRID | LoanEstimate |



@TestDefaultValues
Scenario Outline: Launch TRID App and verify default values for Export Page
Given user enters Trid Application <url> in browser
	And user gets default values from Excel sheet <sheetName>
When user navigate to Export Page
Then all the input values should have default values
	And click on Test button on Export Page
	And click on Export to pdf button on Export Page
	And file gets downloaded with <DownloadedFileName>
Examples: 
	| url                                                                                                    | sheetName | DownloadedFileName        |
	| httP://thrive-app.azurewebsites.net/Index_Dev.html?tKey=EB535076-2140-4106-8CAE-B230F6E2D082&aKey=TRID | Export    | Wipfli-TridCalculator.pdf |