Feature: ClosingDisclosure

@LoanDetails
Scenario Outline: Validating Loan Details on Closing Disclosure page
Given user is at TRID application homepage with <url>
	And user navigate to Closing Disclosure Page
	And user have all the input values from Excel sheet <SheetName>
When Calculation Method is 30 Over 360
	And loan type is fixed
	And Frequency of Payments is Monthly
	And Loan Term is Months
	And Repayment Term Type is Regular P And I - Whole Term 
	And Enter Loan detail input values for computation
	And click on Loan Details TEST on Closing Disclosure page
	And click on Disclosure TEST on Closing Disclosure page
Then Updated Principal and Interest value should display
	And Updated Prepaid Charges should display
	#And Updated Finance Charge should display
	#And updated APR value should display
	And Updated Amount Financed should display
	#And Updated TIP value should display
	Examples: 
	| url                                                                                                    | SheetName         |
	| httP://thrive-app.azurewebsites.net/Index_Dev.html?tKey=EB535076-2140-4106-8CAE-B230F6E2D082&aKey=TRID | ClosingDisclosure |



@LoanDetails
Scenario Outline: Validating Loan Details on Loan Estimate Page
Given user is at TRID application homepage with <url>
	And user navigate to Loan Estimate Page
	And user have all the input values from Excel sheet <SheetName>
When Calculation Method is 30 Over 360
	And loan type is fixed
	And Frequency of Payments is Monthly
	And Loan Term is Months
	And Repayment Term Type is Regular P And I - Whole Term 
	And Enter Loan detail input values for computation
	And click on Loan Details TEST on Loan Estimate Page
	And click on Disclosure TEST on Loan Estimate Page
Then Updated in 5 Years value should display
	Then Updated in 5 Years principal should display
	And updated APR value should display
	And Updated TIP value should display
	Examples: 
	| url                                                                                                    | SheetName    |
	| httP://thrive-app.azurewebsites.net/Index_Dev.html?tKey=EB535076-2140-4106-8CAE-B230F6E2D082&aKey=TRID | LoanEstimate |


@LoanDetails
Scenario Outline: Validating PMI on Mortgage Insruance page
Given user is at TRID application homepage with <url>
	And user navigate to Mortgage Insruance page
	And user have all the input values from Excel sheet <SheetName>
When Add Pmi Rate
Then Updated PMI value should display
	And updated Total Period Payment should display
	And updated APR value should display
	And Updated Amount Financed should display
	Examples: 
	| url                                                                                                    | SheetName         |
	| httP://thrive-app.azurewebsites.net/Index_Dev.html?tKey=EB535076-2140-4106-8CAE-B230F6E2D082&aKey=TRID | MortgageInsurance |