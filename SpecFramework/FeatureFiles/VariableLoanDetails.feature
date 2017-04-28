Feature: VariableLoanDetails
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Variable Loan DetailsGiven user is at TRID application homepage
	And user have Prepaid Charges data from excel sheet <pcSheetName> for the scenario <pcScenarioNo>
	And user have closing disclosure data from excel sheet <cdSheetName> for the scenario <cdScenarioNo>
	And user have Mortgage Insurance data from excel sheet <miSheetName> for the scenario <miScenarioNo>
	And user have Escrow data from excel sheet <eSheetName> for the scenario <eScenarioNo>
	And user is at Prepaid Charges page
	And all the input and custom fields for prepaid charges have zero values
When user navigate to Mortgage Insurance Page
	And user enters pmi rate values
	And user navigate to Closing Disclosure Page
	And user selects Calculation Method in Closing Disclosure Page
	And user selects loan type in Closing Disclosure Page 
	And user navigate to Variable Loan Details Page
	And user enters input values for Variable Loan Details Page
