Feature: PrepaidChargesValidation
# Recalculate Prepaid Charges

@PrepaidCharges
Scenario Outline: Enter input values for Flood Fee, Loan Origination Fee, Prepaid Daily Interest, closing Fee, closing protection letter
Given user opens TRID application
	And user have test data from excel sheet <sheetName> for the scenario <scenarioNo>
When user enters input value for Flood Fee
	And user enters input value for Loan Origination Fee
	And user enters input value for Prepaid Daily Interest
	And user enters input value for Title - Closing Fee
	And user enters input value for Title - Closing protection letter
	And click on Prepaid Charges Test Button
	And user is at loan estimate page
	And user enters Loan Amount <loanAmount>
	And user is at Prepaid Charges Page
Then Prepaid Charges should recalculate and update with expected computed value
	And Amount Fianced should recalculate and update with expected computed value

Examples: 
	| scenarioNo | loanAmount | sheetName      |
	| 2          | 230000     | PrepaidCharges |


@PrepaidCharges
Scenario Outline: Enter input values for prepaid custom fields 
Given user opens TRID application
	And user have test data from excel sheet <sheetName> for the scenario <scenarioNo>
When user enters input value for Flood Fee
	And user enters input value for Loan Origination Fee
	And user enters input value for Prepaid Daily Interest
	And user enters input value for Title - Closing Fee
	And user enters input value for Title - Closing protection letter
	And user enters input value for prepaid custom fields
	And click on Prepaid Charges Test Button
	And user is at loan estimate page
	And user enters Loan Amount <loanAmount>
	And user is at Prepaid Charges Page
Then Prepaid Charges should recalculate and update with expected computed value
	Then Amount Fianced should recalculate and should be reduced with previous value
Examples: 
	| scenarioNo | loanAmount | sheetName      |
	| 3          | 230000     | PrepaidCharges |
