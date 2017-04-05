Feature: LoanEstimateValidation
# Recalculating Amortization schedule

@LoanEstimate
Scenario Outline: Chooses Final Balloon payment resetting Prepaid charges
Given user opens TRID application with Prepaid Charges as homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have Loan Estimate data from excel sheet <leSheetName> for the scenario <leScenarioNo>
	And all the input and custom fields have zero values
When user navigates to Loan Estimate Page
	And select repayment type as Regular P and I - Final Balloon Payment
	And user enters input value for Loan Amount
	#And user enters input value for Final Balloon Payment
	And Click on Test button under loan details
Then Amortization Schedule should recalculate and last row balance should be zero
Examples: 
	| pcScenarioNo | pcSheetName    | leScenarioNo | leSheetName  |
	| 1            | PrepaidCharges | 2            | LoanEstimate |


@LoanEstimate
Scenario Outline: Chooses Multiple Of Months as Payment Frequency
Given user opens TRID application with Prepaid Charges as homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have Loan Estimate data from excel sheet <leSheetName> for the scenario <leScenarioNo>
	And all the input and custom fields have zero values
When user navigates to Loan Estimate Page
	And select Frequency of Payment as Multiple of Months
	And user enters input value under frequency of Pmt Value
	And select repayment type as Regular P and I - Final Balloon Payment
	And user enters the input value for Period Payment
	And user enters input value for Loan Amount
	And Click on Test button under loan details
Then Payment Date should be of two month period
	And Amortization Schedule should recalculate and last row balance should be zero
Examples: 
	| pcScenarioNo | pcSheetName    | leScenarioNo | leSheetName  |
	| 1            | PrepaidCharges | 3            | LoanEstimate |


@LoanEstimate
Scenario Outline: Chooses Bi-Weekly as Frequency Of Payments
Given user opens TRID application with Prepaid Charges as homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have Loan Estimate data from excel sheet <leSheetName> for the scenario <leScenarioNo>
	And all the input and custom fields have zero values
When user navigates to Loan Estimate Page
	And select Frequency of Payment as Bi-Weekly
	And frequency of Pmt Value should be empty
	And user enters the input value for Period Payment
	And user enters input value for Loan Amount
	And Click on Test button under loan details
Then Payment Date should be increment of 14 days
	And Payment Schedule should recalculate 780 number of payments
Examples: 
	| pcScenarioNo | pcSheetName    | leScenarioNo | leSheetName  |
	| 1            | PrepaidCharges | 4            | LoanEstimate |


@LoanEstimate
Scenario Outline: Chooses Semi Monthly as Frequency of Payments
Given user opens TRID application with Prepaid Charges as homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have Loan Estimate data from excel sheet <leSheetName> for the scenario <leScenarioNo>
	And all the input and custom fields have zero values
When user navigates to Loan Estimate Page
	And select Frequency of Payment as semi Monthly
	And frequency of Pmt Value should be empty
	And user enters the input value for Period Payment
	And user enters input value for Loan Amount
	And Click on Test button under loan details
Then Payment Date should be on 1st and 16th of every month
	And Payment Schedule should recalculate 720 number of payments
Examples: 
	| pcScenarioNo | pcSheetName    | leScenarioNo | leSheetName  |
	| 1            | PrepaidCharges | 5            | LoanEstimate |


@LoanEstimate
Scenario Outline: Chooses Actual Over 365 as Calculation Method
Given user opens TRID application with Prepaid Charges as homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have Loan Estimate data from excel sheet <leSheetName> for the scenario <leScenarioNo>
	And all the input and custom fields have zero values
When user navigates to Loan Estimate Page
	And select Calculation Method as Actual Over 365
	And select Frequency of Payment as Monthly
	And frequency of Pmt Value should be empty
	And user enters input value for Loan Amount
	And user enters input value for Date of loan
	And user enters input value for Date Interest Begins to Accrue
	And user enters input value for Date of first Payment
	And user enters the input value for Period Payment
	And Click on Test button under loan details
Then Amortization schedule should be calculated as expected for Feb 2017
Examples: 
	| pcScenarioNo | pcSheetName    | leScenarioNo | leSheetName  |
	| 1            | PrepaidCharges | 6            | LoanEstimate |


@LoanEstimate
Scenario Outline: Chooses Actual Over 365 And Leap Years as Calculation Method
Given user opens TRID application with Prepaid Charges as homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have Loan Estimate data from excel sheet <leSheetName> for the scenario <leScenarioNo>
	And all the input and custom fields for prepaid charges have zero values
When user navigates to Loan Estimate Page
	And select Calculation Method as Actual Over 365 And Leap Years
	And select Frequency of Payment as Monthly
	And frequency of Pmt Value should be empty
	And user enters input value for Loan Amount
	And user enters input value for Date of loan
	And user enters input value for Date Interest Begins to Accrue
	And user enters input value for Date of first Payment
	And user enters the input value for Period Payment
	And Click on Test button under loan details
Then Amortization schedule should recaulcuate for Feb 2017
Examples: 
	| pcScenarioNo | pcSheetName    | leScenarioNo | leSheetName  |
	| 1            | PrepaidCharges | 7            | LoanEstimate |

#============================================================================================================================ 
#======================================= Loan Estimate with No Prepaid, No PMI =========================================
#============================================================================================================================ 

@LoanDetails
Scenario Outline: Validating Loan Details on Loan Estimate Page
Given user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have Loan Estimate data from excel sheet <leSheetName> for the scenario <leScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
	And user is at Mortgage Insurance Page
	And PMI Rates Grid is empty
When user navigate to Loan Estimate Page
	And user selects Calculation Method in Loan Estimate Page
	And user selects loan type in Loan Estimate Page 
	And user selects Frequency of Payments in Loan Estimate Page 
	And user selects Loan Term in Loan Estimate Page 
	And user selects Repayment Term Type in Loan Estimate Page
	And Enter Loan detail input values for computation for Loan Estimate page
	And Enter Disclosed input values for Loan Estimate Page
	And click on Loan Details TEST on Loan Estimate Page
	And click on Disclosure TEST on Loan Estimate Page
Then updated/computed in 5 Years value should display on Loan Estimate
	And updated/computed in 5 Years principal value should display on Loan Estimate
	And updated/computed APR value should display on Loan Estimate
	And updated/computed TIP value should display on Loan Estimate
Examples: 
	| pcScenarioNo | pcSheetName    | leScenarioNo | leSheetName  |
	| 1            | PrepaidCharges | 7            | LoanEstimate |